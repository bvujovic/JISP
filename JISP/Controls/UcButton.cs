using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
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
            set
            {
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

        /// <summary>Ovu metodu bi trebalo zvati kod Click async poziva - Text postaje ..., rad sa izuzecima.</summary>
        /// <example>await btnUcitajObracunZarada.RunAsync(async () => { });</example>
        /// <see cref="https://stackoverflow.com/questions/33941583/converting-action-method-call-to-async-action-method-call"/>
        /// <seealso cref="https://stackoverflow.com/questions/20593501/the-await-operator-can-only-be-used-within-an-async-lambda-expression"/>
        public async Task RunAsync(Func<Task> func)
        {
            var originalText = Text;
            Text = "...";
            try
            {
                await func();
            }
            catch (Exception ex) { Classes.Utils.ShowMbox(ex, originalText); }
            Text = originalText;
        }
    }
}
