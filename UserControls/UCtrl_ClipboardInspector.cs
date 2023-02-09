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
    public partial class UCtrl_ClipboardInspector : UserControl
    {
        public UCtrl_ClipboardInspector()
        {
            InitializeComponent();
        }

        private void uCtrl_ClipboardScanner1_OnFormatSelected(object sender, string e)
        {
            var data = uCtrl_ClipboardScanner1.ClipBoardDataObject;
            if (data == null)
            {
                richTextBox1.Text = "No Data";
                return;
            }
            var fdata = data.GetData(e);
            if (fdata == null)
            {
                richTextBox1.Text = "Ivalid Format: " + e;
                return;
            }

            if (e == "Rich Text Format")
            {
                richTextBox1.Rtf = (string)fdata;
            }
            else
            {
                richTextBox1.Text = fdata.ToString();
            }
        }
    }
}
