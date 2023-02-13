using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextScrappy.Forms
{
    public partial class DemoForm_SpawnCMDLog : Form
    {
        public DemoForm_SpawnCMDLog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            socketHost_cmd1.SpawnNewConsole(textBox1.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            socketHost_cmd1.UpdateDetails();
        }
    }
}
