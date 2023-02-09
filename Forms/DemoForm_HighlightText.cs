using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TextScrappy.Forms
{
    public partial class DemoForm_HighlightText : Form
    {
        public DemoForm_HighlightText()
        {
            InitializeComponent();
        }

        void ScrapeChars()
        {

            var text = richTextBox1.SelectedText;

            listView1.SuspendLayout();
            listView1.Items.Clear();

            if (text.Length > 0)
            {
                List<char> chars = new List<char>(text);

                for (int i = 0; i < chars.Count; i++)
                {
                    char c = chars[i];
                    int cint = (int)c;
                    string chex = cint.ToString("X");


                    var item = listView1.Items.Add(i.ToString());
                    item.SubItems.Add(c.ToString());
                    item.SubItems.Add(cint.ToString());
                    item.SubItems.Add(chex.ToString());
                }
            }
            listView1.ResumeLayout();
        }

        void ScrapeText()
        {
            var text = richTextBox2.SelectedText;
            richTextBox1.Text = text;
        }

        private void richTextBox2_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox2.SelectionLength > 0)
            {
                label4.Text = richTextBox2.SelectionLength.ToString();
            }
            else
            {
                label4.Text = "N/A";
            }
            ScrapeText();
        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionLength > 0)
            {
                label5.Text = richTextBox1.SelectionLength.ToString();
            }
            else
            {
                label5.Text = "N/A";
            }
            ScrapeChars();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            label3.Text = richTextBox2.Text.Length.ToString();
        }
    }
}
