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

namespace TextScrappy.Forms
{
    public partial class Form_LilsCMDparty : Form
    {
        public Form_LilsCMDparty()
        {
            InitializeComponent();
            checkBox1.Checked = true;
        }

        private void cmdInterface1_Event_NewLineReturned11(object sender, string e)
        {
            richTextBox1.Text += e;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ProcWrapper_CMD wrapper = new();
            //WinShell_wrapper wrapper = new();
            wrapper.RunCMD_wait(textBox1.Text);
            var output = wrapper.stdOutBuffer.ToString();

            richTextBox1.Text += "\n\n";

            richTextBox1.Text += "> " + textBox1.Text + "\n\n";
            richTextBox1.Text += output;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                timer1.Start();
            else
                timer1.Stop();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            socketCtrl_Task_cmd1.RunCommand(textBox2.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            socketCtrl_Task_cmd1.CheckLog();
        }

        /*  CMD Copy-pasta

        ##########

        var p = new Process();
        p.StartInfo.FileName = "cmd.exe";
        p.StartInfo.Arguments = "/c mycmd.exe 2>&1";

        #

        var p = new Process();
        p.StartInfo.FileName = "cmd.exe";
        p.StartInfo.Arguments = @"/c dir \windows";
        p.StartInfo.CreateNoWindow = true;
        p.StartInfo.RedirectStandardError = true;
        p.StartInfo.RedirectStandardOutput = true;
        p.StartInfo.RedirectStandardInput = false;
        p.OutputDataReceived += (a, b) => Console.WriteLine(b.Data);
        p.ErrorDataReceived += (a, b) => Console.WriteLine(b.Data);
        p.Start();
        p.BeginErrorReadLine();
        p.BeginOutputReadLine();
        p.WaitForExit();

        ##########

        https://github.com/Tyrrrz/CliWrap

        #

        using CliWrap;
        using CliWrap.Buffered;

        var result = await Cli.Wrap("target.exe")
        .WithArguments("arguments")
        .ExecuteBufferedAsync();

        var stdout = result.StandardOutput;
        
        ##########

        */


    }
}
