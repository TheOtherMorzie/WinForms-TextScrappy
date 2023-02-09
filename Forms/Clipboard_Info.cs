using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFFT_Lib.src.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lil.Forms
{
    public partial class Clipboard_Info : Form
    {

        IDataObject? DataObject;

        public Clipboard_Info()
        {
            InitializeComponent();
        }


        private void Clipboard_Info_Load(object sender, EventArgs e)
        {

        }
    }
}
