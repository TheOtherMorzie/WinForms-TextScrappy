using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDev.HtmlRenderer.WinForms;
using WFFT_Lib.src.UserControls;

namespace TextScrappy.UserControls
{
    public partial class UCtrl_ViewerHTML : UserControl
    {


        public UCtrl_ViewerHTML()
        {
            InitializeComponent();
        }

        private void UCtrl_ViewerHTML_Load(object sender, EventArgs e)
        {

        }


        public CradleGeneric CradleGeneric1 { get => cradleGeneric1; protected set => cradleGeneric1 = value; }
        public HtmlLabel HtmlLabel1 { get => htmlLabel1; protected set => htmlLabel1 = value; }
        public HtmlPanel HtmlPanel1 { get => htmlPanel1; protected set => htmlPanel1 = value; }


    }
}
