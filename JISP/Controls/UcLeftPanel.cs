using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Controls
{
    public partial class UcLeftPanel : UserControl
    {
        public UcLeftPanel()
        {
            InitializeComponent();

            expandedWidth = Width;
        }

        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Width of a right side show/hide bar."), Category("Layout")]
        public int RightWingWidth
        {
            get { return pnlRightWing.Width; }
            set { pnlRightWing.Width = value; }
        }

        private void PnlRightWing_MouseEnter(object sender, EventArgs e)
        {
            if (PanelWidthState == PanelWidthState.Expanded)
                pnlRightWing.BackColor = SystemColors.ControlDark;
        }

        private void PnlRightWing_MouseLeave(object sender, EventArgs e)
        {
            if (PanelWidthState == PanelWidthState.Expanded)
                pnlRightWing.BackColor = SystemColors.Control;
        }

        private int expandedWidth;

        public void Collapse()
        {

            expandedWidth = Width;
            Width = RightWingWidth;
            pnlRightWing.BackColor = SystemColors.ControlDark;
            panelWidthState = PanelWidthState.Collapsed;
        }

        public void Expand()
        {
            Width = expandedWidth;
            pnlRightWing.BackColor = SystemColors.Control;
            panelWidthState = PanelWidthState.Expanded;
        }

        private PanelWidthState panelWidthState = PanelWidthState.Expanded;
        /// <summary>Panel can be expanded or collapsed regarding its width.</summary>
        public PanelWidthState PanelWidthState
        {
            get { return panelWidthState; }
            set
            {
                if (panelWidthState != value)
                    TogglePanelWidthState();
            }
        }

        /// <summary>Change PanelWidthState: Collapsed <-> Expanded</summary>
        public void TogglePanelWidthState()
        {
            if (PanelWidthState == PanelWidthState.Expanded)
                Collapse();
            else
                Expand();
        }

        private void PnlRightWing_Click(object sender, EventArgs e)
        {
            TogglePanelWidthState();
        }
    }

    public enum PanelWidthState
    {
        Expanded, Collapsed
    }
}
