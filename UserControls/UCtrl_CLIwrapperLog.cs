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

namespace TextScrappy.UserControls
{
    public partial class UCtrl_CLIwrapperLog : UserControl
    {
        public UCtrl_CLIwrapperLog()
        {
            InitializeComponent();
        }


        ProcWrapper_CMD wrapper = new();
        Task? cmdTask { get; set; }
        string log = "";


        [Category("Lil")]
        [Description("Description")]
        public bool HideDetailsPanel
        {
            get => splitContainer1.Panel1Collapsed;
            set => splitContainer1.Panel1Collapsed = value;
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            if (cmdTask == null)
            {
                cmdTask = wrapper.RunCMD(textBox1.Text);

                richTextBox1.Text += "\n\n";

                richTextBox1.Text += "> " + textBox1.Text + "\n\n";

                timer1.Start();
                log = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }


        private void UCtrl_CLIwrapperLog_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            richTextBox1.Text += "OnControlAdded: " + e.Control.Name;
            base.OnControlAdded(e);
        }

        protected override void OnControlRemoved(ControlEventArgs e)
        {
            richTextBox1.Text += "OnControlRemoved: " + e.Control.Name;
            base.OnControlRemoved(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            checkBox2.Checked = cmdTask != null;
            if (cmdTask != null)
            {


                checkBox2.Checked = cmdTask.IsCompletedSuccessfully;
                if (cmdTask.IsCompletedSuccessfully)
                {
                    timer1.Stop();
                    cmdTask = null;
                }

                var reader = wrapper.stdOutBuffer;
                string output = reader.ToString();
                if (output.Length > log.Length)
                {
                    string diff;
                    if (log.Length == 0)
                    {
                        diff = output;
                    }
                    else
                    {
                        diff = output.Replace(log, "");
                    }
                    log = output;
                    richTextBox1.Text += diff;
                }
            }
        }
    }
}
