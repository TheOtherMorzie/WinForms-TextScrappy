using Ganss.Xss;
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
    public partial class Form_ViewerSimpleHTML : Form
    {
        HtmlSanitizer sanitizer = new();
        public Form_ViewerSimpleHTML()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uCtrl_Viewerhtml1.HtmlPanel1.Text = richTextBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uCtrl_Viewerhtml1.HtmlPanel1.Text = "";
        }

        private void uCtrl_RichTextEditor_html1_OnEvent_ExportHTML(object sender, string e)
        {
            richTextBox1.Text = e;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            var result = sanitizer.Sanitize(richTextBox1.Text);
            richTextBox1.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String text = richTextBox1.Text;
            List<String> lines = new();
            var result = text.Split(new[] { '\r', '\n' }, StringSplitOptions.TrimEntries);
            String textNew = "";
            foreach (var line in result)
            {
                if (line.Length > 0)
                {
                    textNew += line + '\n';
                    lines.Add(line + '\n');
                }
            }
            listBox1.Items.Clear();
            listBox1.Items.AddRange(lines.ToArray());
            richTextBox1.Text = textNew;
        }
    }
}
