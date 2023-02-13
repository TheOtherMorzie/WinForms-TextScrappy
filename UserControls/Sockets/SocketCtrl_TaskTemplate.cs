using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextScrappy.UserControls.Sockets
{
    public partial class SocketCtrl_TaskTemplate : UserControl
    {
        public SocketCtrl_TaskTemplate()
        {
            InitializeComponent();
        }

        public Task? TaskObject { get; set; }
        public string TaskLog 
        { 
            get => richTextBoxTaskLog.Text;
            set => richTextBoxTaskLog.Text = value;
        }

        private void SocketCtrl_TaskTemplate_Load(object sender, EventArgs e)
        {
            if (TaskObject == null)
            {
                textBoxTaskName.Text = string.Empty;
            }
            else
            {
                textBoxTaskName.Text = TaskObject.ToString();
            }
        }
    }
}
