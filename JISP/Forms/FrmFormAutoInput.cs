using JISP.Classes;
using JISP.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JISP.Forms
{
    public partial class FrmFormAutoInput : Form
    {
        public FrmFormAutoInput()
        {
            InitializeComponent();
        }

        private void FrmFormAutoInput_Load(object sender, EventArgs e)
        {
            try
            {
                numDelay.Value = int.Parse(AppData.LoadSett(string.Join(":", Name, numDelay.Name), "1000"));
                bsFormAutoFills.DataSource = AppData.Ds;
                dgvFAFs.SelectionMode = dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                ttPrikaziKursor.SetToolTip(chkPrikaziKursor, "Prikazivanje kursora na zadatoj poziciji za Klik stavke u fazi čekanja (ne snimanja ili puštanja).");
                this.FormStandardSettings();
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;

        public void DoMouseClick()
        {
            uint x = (uint)Cursor.Position.X;
            uint y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, x, y, 0, 0);
        }

        private Point ptCursor;
        private int cntCursorSamePos = 0;
        /// <summary>Da li je izvrsena prva stavka pri pustanju rutine.</summary>
        private bool izvrsenaPrvaStavka = false;

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
                            var faf = dgvFAFs.CurrDataRow<Ds.FormAutoFillsRow>();
                            AppData.Ds.FAF_Items.AddFAF_ItemsRow
                                (AkcijaTip.Klik.ToString(), pos.X + ", " + pos.Y, "", faf);
                            cntCursorSamePos = 0;
                        }
                    }
                    else
                        cntCursorSamePos = 0;
                    ptCursor = pos;
                }
                if (tekuciProces == Proces.Pustanje)
                {
                    // izvrsavanje tekuce akcije
                    izvrsenaPrvaStavka = true;
                    var item = dgvItems.CurrDataRow<Ds.FAF_ItemsRow>();
                    if (item.ItemType == AkcijaTip.Tekst.ToString())
                        SendKeys.Send(item.Content);
                    if (item.ItemType == AkcijaTip.Klik.ToString())
                        NamestiKursor(item, true);

                    // prelazak na sledecu ili prvu (na kraju)
                    if (bsFAFItems.Position == bsFAFItems.Count - 1)
                    {
                        PromenaPustanje();
                        bsFAFItems.MoveFirst();
                    }
                    else
                        bsFAFItems.MoveNext();
                }
            }
            catch (Exception ex)
            {
                if (tekuciProces == Proces.Pustanje) PromenaPustanje(); else PromenaSnimanje();
                tekuciProces = Proces.Cekanje;
                Utils.ShowMbox(ex, $"Proces {tekuciProces} je naišao na problem");
            }
        }

        private void NamestiKursor(Ds.FAF_ItemsRow item, bool uradiKlik)
        {
            if (item.ItemType != AkcijaTip.Klik.ToString())
                return;
            var koordinate = item.Content.Split(new char[] { ',' });
            if (koordinate.Length != 2)
                throw new Exception("Tacka na ekranu na koju treba kliknuti mora da sadrži 2 koordinate.");

            if (int.TryParse(koordinate[0], out int x) && int.TryParse(koordinate[1], out int y))
            {
                Cursor.Position = new Point(x, y);
                if (uradiKlik)
                    DoMouseClick();
            }
            else
                throw new Exception("Koordinate tačke na ekranu na koju treba kliknuti moraju biti zadate u formatu \"100, 200\".");
        }

        private enum AkcijaTip
        {
            Klik,
            Tekst
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
        }

        private void BtnPustanjeStartStop_Click(object sender, EventArgs e)
        {
            var idx = bsFAFItems.Position;
            if (pustanje == ProcesKomanda.Stop ||
                (idx == 0 || Utils.ShowMboxYesNo($"Selektovana stavka je {idx + 1} po redu. Da li ste sigurni da želite da pokrenete rutinu od te stavke?"
                , "Pokretanje rutine (početna pozicija)") == DialogResult.Yes))
                PromenaPustanje();
        }

        private void DgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && !dgvItems.SelectedRows[0].IsNewRow)
                try
                {
                    var item = dgvItems.CurrDataRow<Ds.FAF_ItemsRow>();
                    if (item.ItemType == AkcijaTip.Klik.ToString())
                        NamestiKursor(item, false);
                }
                catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private void BtnObrisiStavku_Click(object sender, EventArgs e)
        {
            try
            {
                if (Utils.ShowMboxYesNo("Da li ste sigurni da želite da obrišete selektovane stavke?", "Brisanje stavki")
                    == DialogResult.Yes)
                {
                    var indices = new List<int>();
                    foreach (DataGridViewRow row in dgvItems.SelectedRows)
                        if (!row.IsNewRow)
                            indices.Add(row.Index);
                    foreach (var idx in indices)
                        bsFAFItems.RemoveAt(idx);
                }
            }
            catch (Exception ex) { Utils.ShowMbox(ex, Text); }
        }

        private void BtnPomeriStavkuNagore_Click(object sender, EventArgs e)
        {
            var idxRow = bsFAFItems.Position;
            if (idxRow == 0)
                return;
            if (dgvItems.SelectedRows.Count != 1 || dgvItems.SelectedRows[0].IsNewRow)
                return;
            for (int i = 0; i <= 2; i++)
                ZameniVrednostiCelija(i, -1);
            bsFAFItems.MovePrevious();
        }

        private void ZameniVrednostiCelija(int idxCol, int deltaRow)
        {
            var idxRow = bsFAFItems.Position;
            var s = dgvItems.Rows[idxRow + deltaRow].Cells[idxCol].Value;
            dgvItems.Rows[idxRow + deltaRow].Cells[idxCol].Value = dgvItems.Rows[idxRow].Cells[idxCol].Value;
            dgvItems.Rows[idxRow].Cells[idxCol].Value = s;
        }

        private void BtnPomeriStavkuNadole_Click(object sender, EventArgs e)
        {
            if (bsFAFItems.Position == bsFAFItems.Count - 1)
                return;
            if (dgvItems.SelectedRows.Count != 1 || dgvItems.SelectedRows[0].IsNewRow)
                return;
            for (int i = 0; i <= 2; i++)
                ZameniVrednostiCelija(i, +1);
            bsFAFItems.MoveNext();
        }

        private void DgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (tekuciProces != Proces.Cekanje || dgvItems.CurrentRow == null || !chkPrikaziKursor.Checked)
                return;
            var item = dgvItems.CurrDataRow<Ds.FAF_ItemsRow>();
            if (item.ItemType == AkcijaTip.Klik.ToString())
                NamestiKursor(item, false);
        }

        private void NumDelay_ValueChanged(object sender, EventArgs e)
        {
            AppData.SaveSett(string.Join(":", Name, numDelay.Name), numDelay.Value.ToString());
        }
    }
}
