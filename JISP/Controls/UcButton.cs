using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace JISP.Controls
{
    public partial class UcButton : Button
    {
        /// <summary>
        /// Dugme sa ToolTip-om (ako ToolTipText nije prazan)
        /// </summary>
        public UcButton()
        {
            InitializeComponent();

            SetToolTipIN();
        }

        private ToolTip tt;

        private string toolTipText;
        [Browsable(true), EditorBrowsable(EditorBrowsableState.Always)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Description("Text displayed on a tooltip for this button."), Category("Behavior")]
        public string ToolTipText
        {
            get { return toolTipText; }
            set {
                toolTipText = value;
                SetToolTipIN();
            }
        }

        /// <summary>Kreiranje ToolTip-a za dugme ako ToolTipText nije prazan.</summary>
        private void SetToolTipIN()
        {
            if (!string.IsNullOrEmpty(ToolTipText))
            {
                tt = new ToolTip();
                tt.SetToolTip(this, ToolTipText);
            }
        }
    }
}
