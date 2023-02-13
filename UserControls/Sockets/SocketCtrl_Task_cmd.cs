using Lil.Toolkit;
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
    public partial class SocketCtrl_Task_cmd : UserControl
    {
        public SocketCtrl_Task_cmd()
        {
            InitializeComponent();
            Stream = new(wrapper.stdOutBuffer);
        }

        ProcWrapper_CMD wrapper = new();
        StringStream Stream;

        [Category("Lil")]
        [Description("Description")]
        public Task? TaskObject { get; set; }

        [Category("Lil")]
        [Description("Description")]
        public string TaskLog
        {
            get => richTextBoxTaskLog.Text;
            protected
            set => richTextBoxTaskLog.Text = value;
        }



        [Category("Lil")]
        [Description("Description")]
        public bool HideDetailsPanel
        {
            get => splitContainer1.Panel1Collapsed;
            set => splitContainer1.Panel1Collapsed = value;
        }

        private void SocketCtrl_Task_cmd_Load(object sender, EventArgs e)
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

        public void RunCommand(string command)
        {
            textBoxTaskName.Text = command;
            TaskObject = wrapper.RunCMD(command);
        }

        public void CheckLog()
        {
            if (Stream.Avaliable()>0)
            {
                richTextBoxTaskLog.SuspendLayout();
                while (Stream.Avaliable() > 0)
                {
                    richTextBoxTaskLog.Text += Stream.Read();
                }
                richTextBoxTaskLog.ResumeLayout();
            }
        }
    }
}
