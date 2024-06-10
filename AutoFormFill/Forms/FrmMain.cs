using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace AutoFormFill
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                AppData.LoadFromRegistry();
                txtDataFolder.Text = AppData.DataFolder;
                AppData.LoadDsData(ds);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Učitavanje podataka"); }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                AppData.SaveDataFolder(txtDataFolder.Text);
                AppData.SaveDsData(ds);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Čuvanje podataka"); }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public void DoMouseClick(string tip)
        {
            uint x = (uint)Cursor.Position.X;
            uint y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
            if (tip == AkcijaTip.DKlik.ToString())
            {
                Thread.Sleep(50);
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
            }
        }

        private Point ptCursor;
        private int cntCursorSamePos = 0;
        /// <summary>Da li je izvrsena prva stavka pri pustanju rutine.</summary>
        private bool izvrsenaPrvaStavka = false;

        /// <summary>Da li je tip akcije klik ili dupli klik.</summary>
        private static bool JeKlik(string tip)
            => tip == AkcijaTip.Klik.ToString() || tip == AkcijaTip.DKlik.ToString();

        private enum AkcijaTip
        {
            Tekst,
            Klik,
            DKlik,
            Pauza
        }

        private enum ProcesKomanda
        {
            Start,
            Stop
        }
        private ProcesKomanda snimanje = ProcesKomanda.Start;
        private ProcesKomanda pustanje = ProcesKomanda.Start;

        private enum Proces
        {
            Cekanje,
            Snimanje,
            Pustanje
        }
        private Proces tekuciProces = Proces.Cekanje;

        static Point StrToPoint(string content)
        {
            var koordinate = content.Split(new char[] { ',' });
            if (koordinate.Length != 2)
                throw new Exception("Tacka na ekranu na koju treba kliknuti mora da sadrži 2 koordinate.");

            if (int.TryParse(koordinate[0], out int x) && int.TryParse(koordinate[1], out int y))
                return new Point(x, y);
            else
                throw new Exception("Koordinate tačke na ekranu na koju treba kliknuti moraju biti zadate u formatu \"100, 200\".");
        }

        private void NamestiKursor(Ds.ActionsRow action, bool uradiKlik)
        {
            if (!JeKlik(action.Type))
                return;
            ptPoslednja = Cursor.Position = StrToPoint(action.Content);
            if (testCurrentPosition)
                ptCurrentPosition = ptPoslednja;
            if (uradiKlik)
                DoMouseClick(action.Type);
        }

        Point? ptPoslednja = null;

        /// <summary>Promena stanja snimanja: radi <-> ne radi.</summary>
        private void PromenaSnimanje()
        {
            tim.Interval = 1000;
            tim.Enabled = snimanje == ProcesKomanda.Start;
            snimanje = snimanje == ProcesKomanda.Start ? ProcesKomanda.Stop : ProcesKomanda.Start;
            tekuciProces = snimanje == ProcesKomanda.Start ? Proces.Cekanje : Proces.Snimanje;
            btnSnimanjeStartStop.Text = snimanje.ToString();
            btnSnimanjeStartStop.BackColor = snimanje == ProcesKomanda.Start ? SystemColors.Control : Color.Red;
        }

        /// <summary>Promena stanja pustanja: radi <-> ne radi.</summary>
        private void PromenaPustanje()
        {
            tim.Interval = (int)numDelay.Value;
            tim.Enabled = pustanje == ProcesKomanda.Start;
            pustanje = pustanje == ProcesKomanda.Start ? ProcesKomanda.Stop : ProcesKomanda.Start;
            tekuciProces = pustanje == ProcesKomanda.Start ? Proces.Cekanje : Proces.Pustanje;
            btnPustanjeStartStop.Text = pustanje.ToString();
            btnPustanjeStartStop.BackColor = pustanje == ProcesKomanda.Start ? SystemColors.Control : Color.Green;
            if (pustanje == ProcesKomanda.Start)
                izvrsenaPrvaStavka = false;
        }

        private void BtnSnimanjeStartStop_Click(object sender, EventArgs e)
        {
            PromenaSnimanje();
            ResetAdjPositions();
        }

        private void BtnPustanjeStartStop_Click(object sender, EventArgs e)
        {
            var idx = bsActions.Position;
            if (pustanje == ProcesKomanda.Stop ||
                idx == 0 ||
                MessageBox.Show($"Selektovana stavka je {idx + 1} po redu. Da li ste sigurni da želite da pokrenete rutinu od te stavke?"
                    , "Pokretanje rutine (početna pozicija)", MessageBoxButtons.YesNo) == DialogResult.Yes)
                PromenaPustanje();
            ResetAdjPositions();
        }

        Point? ptCurrentPosition = null;
        bool testCurrentPosition = false;
        Point? ptLastPosition = null;

        private void TimAdjustPositions_Tick(object sender, EventArgs e)
        {
            if (ptCurrentPosition.HasValue && testCurrentPosition)
            {
                var pos = Cursor.Position;
                if (pos != ptCurrentPosition.Value
                    && ptLastPosition.HasValue && pos == ptLastPosition)
                {
                    testCurrentPosition = false;
                    timAdjustPositions.Stop();
                    btnAdjPosOK.Enabled = true;
                }
                else
                {
                    if (Bounds.Contains(pos))
                    {
                        timAdjustPositions.Stop();
                        btnAdjPosOK.Enabled = false;
                        ResetAdjPositions();
                    }
                    else
                    {
                        txtAdjPosDX.Text = (pos.X - ptCurrentPosition.Value.X).ToString();
                        txtAdjPosDY.Text = (pos.Y - ptCurrentPosition.Value.Y).ToString();
                    }
                }
                ptLastPosition = pos;
            }
        }

        void ResetAdjPositions()
        {
            txtAdjPosDX.Text = txtAdjPosDY.Text = "";
            btnAdjPosOK.Enabled = false;
        }

        private void BtnAdjPosOK_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dgvActions.SelectedRows)
                {
                    var act = (row?.DataBoundItem as DataRowView)?.Row as Ds.ActionsRow;
                    if (act == null || !JeKlik(act.Type))
                        continue;
                    var pt = StrToPoint(act.Content);
                    var ptOffset = StrToPoint(txtAdjPosDX.Text + ", " + txtAdjPosDY.Text);
                    pt.Offset(ptOffset.X, ptOffset.Y);
                    act.Content = pt.X + ", " + pt.Y;
                }
                ResetAdjPositions();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Podešavanje pozicija tačaka za klikove"); }
        }

        private void DgvActions_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && !dgvActions.SelectedRows[0].IsNewRow)
                try
                {
                    var act = CurrentAction;
                    if (JeKlik(act.Type))
                    {
                        testCurrentPosition = true;
                        NamestiKursor(act, false);
                        timAdjustPositions.Start();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, Text); }
        }

        private void BtnObrisiStavku_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Da li ste sigurni da želite da obrišete selektovane stavke?"
                    , btnObrisiStavku.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var indices = new List<int>();
                    foreach (DataGridViewRow row in dgvActions.SelectedRows)
                        if (!row.IsNewRow)
                            indices.Add(row.Index);
                    foreach (var idx in indices)
                        bsActions.RemoveAt(idx);
                }
            }
            //catch (Exception ex) { Utils.ShowMbox(ex, Text); }
            catch (Exception ex) { MessageBox.Show(ex.Message, btnObrisiStavku.Text); }
        }

        private void ZameniVrednostiCelija(int idxCol, int deltaRow)
        {
            var idxRow = bsActions.Position;
            var s = dgvActions.Rows[idxRow + deltaRow].Cells[idxCol].Value;
            dgvActions.Rows[idxRow + deltaRow].Cells[idxCol].Value = dgvActions.Rows[idxRow].Cells[idxCol].Value;
            dgvActions.Rows[idxRow].Cells[idxCol].Value = s;
        }

        private void BtnPomeriStavkuNagore_Click(object sender, EventArgs e)
        {
            var idxRow = bsActions.Position;
            if (idxRow == 0)
                return;
            if (dgvActions.SelectedRows.Count != 1 || dgvActions.SelectedRows[0].IsNewRow)
                return;
            for (int i = 0; i <= 2; i++)
                ZameniVrednostiCelija(i, -1);
            bsActions.MovePrevious();
        }

        private void BtnPomeriStavkuNadole_Click(object sender, EventArgs e)
        {
            if (bsActions.Position == bsActions.Count - 1)
                return;
            if (dgvActions.SelectedRows.Count != 1 || dgvActions.SelectedRows[0].IsNewRow)
                return;
            for (int i = 0; i <= 2; i++)
                ZameniVrednostiCelija(i, +1);
            SledecaAkcija();
        }

        private void DgvActions_SelectionChanged(object sender, EventArgs e)
        {
            if (tekuciProces != Proces.Cekanje || dgvActions.CurrentRow == null || !chkPrikaziKursor.Checked)
                return;
            var act = CurrentAction;
            if (JeKlik(act.Type))
                NamestiKursor(act, false);
        }

        private void NumDelay_ValueChanged(object sender, EventArgs e)
        {
        }

        private void FrmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control || e.Alt) && e.KeyCode == Keys.P)
            {
                PromenaPustanje();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        const string msgKorPomerioKursor = "Korisnik je pomerio kursor.";

        private void Tim_Tick(object sender, EventArgs e)
        {
            var pos = Cursor.Position;
            // ako je kursor na ovoj formi - njegova pozicija nije vazna i donja logika se ne izvrsava
            if (Bounds.Contains(pos) && (tekuciProces == Proces.Snimanje || izvrsenaPrvaStavka))
                return;
            try
            {
                if (tekuciProces == Proces.Snimanje)
                {
                    if (pos == ptCursor)
                    {
                        cntCursorSamePos++;
                        if (cntCursorSamePos >= 2)
                        {
                            var routine = (dgvRoutines.CurrentRow?.DataBoundItem as DataRowView)?.Row as Ds.RoutinesRow
                                ?? throw new Exception("Nije definisana rutina za koju se snimaju ove akcije.");
                            ds.Actions.AddActionsRow(routine, AkcijaTip.Klik.ToString(), pos.X + ", " + pos.Y, "", true);
                            cntCursorSamePos = 0;
                        }
                    }
                    else
                        cntCursorSamePos = 0;
                    ptCursor = pos;
                }
                if (tekuciProces == Proces.Pustanje)
                {
                    if (ptPoslednja.HasValue)
                    {
                        var dx = Math.Abs(ptPoslednja.Value.X - Cursor.Position.X);
                        var dy = Math.Abs(ptPoslednja.Value.Y - Cursor.Position.Y);
                        var d = Math.Sqrt(dx * dx + dy * dy);
                        if (d > 15)
                        {
                            ptPoslednja = null;
                            throw new Exception(msgKorPomerioKursor);
                        }
                    }

                    // izvrsavanje tekuce akcije
                    izvrsenaPrvaStavka = true;

                    var act = CurrentAction;
                    if (act.Type == AkcijaTip.Tekst.ToString())
                        SendKeys.Send(act.Content);
                    if (JeKlik(act.Type))
                        NamestiKursor(act, true);
                    tim.Interval = (int)numDelay.Value
                        + (act.Type == AkcijaTip.Pauza.ToString() ? int.Parse(act.Content) : 0);

                    // prelazak na sledecu ili prvu (na kraju)
                    if (bsActions.Position == bsActions.Count - 1)
                    {
                        PromenaPustanje();
                        bsActions.MoveFirst();
                    }
                    else
                        SledecaAkcija();
                }
            }
            catch (Exception ex)
            {
                if (tekuciProces == Proces.Pustanje)
                    PromenaPustanje();
                else
                    PromenaSnimanje();
                tekuciProces = Proces.Cekanje;
                if (ex.Message != msgKorPomerioKursor)
                    MessageBox.Show(ex.Message, $"Proces {tekuciProces} je naišao na problem");
            }
        }

        void SledecaAkcija()
        {
            do
            {
                bsActions.MoveNext();
            }
            while (CurrentAction != null && !CurrentAction.Enabled && bsActions.Position < bsActions.Count - 1);
        }

        Ds.ActionsRow CurrentAction => (dgvActions.CurrentRow.DataBoundItem as DataRowView).Row as Ds.ActionsRow;

    }
}
