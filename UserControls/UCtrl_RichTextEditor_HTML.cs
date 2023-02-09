using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextScrappy.UserControls
{
    public partial class UCtrl_RichTextEditor_HTML : UserControl
    {
        public UCtrl_RichTextEditor_HTML()
        {
            InitializeComponent();
        }


        [Description("After text has been exported"), Category("Lil.Actions")]
        public event EventHandler<String>? OnEvent_ExportHTML;

        private void buttonExportHTML_Click(object sender, EventArgs e)
        {
            String html = richTextBox1.Text;
            cradleGeneric1.Target = html;
            OnEvent_ExportHTML?.Invoke(this, html);
        }

        private void buttonClearHTML_Click(object sender, EventArgs e)
        {
            cradleGeneric1.Target = null;
        }
    }
}
