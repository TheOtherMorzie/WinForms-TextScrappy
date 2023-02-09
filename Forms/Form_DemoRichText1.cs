using Lil.Toolkit;
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

namespace TextScrappy.Forms
{
    public partial class Form_DemoRichText1 : Form
    {
        public Form_DemoRichText1()
        {
            InitializeComponent();
        }
        private void ShowDialog_OpenFile()
        {
            openFileDialog1.InitialDirectory = MyDir.GetCurPath();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var file = openFileDialog1.OpenFile();

                String fileLocation = Path.GetDirectoryName(openFileDialog1.FileName);
                String filePath = fileLocation + "\\" + openFileDialog1.SafeFileName;

                String ext = Path.GetExtension(filePath);
                switch (ext)
                {
                    case ".txt":
                        LoadFile(filePath);
                        break;

                    default:
                        //Runtime_LilOrg.I.Log("warn", "Invalid file type: " + ext);
                        break;
                }
            }
        }
        private void LoadFile(String path)
        {
            string text = File.ReadAllText(path);
            richTextBox1.Text = text;
        }

        void ScrapeChars()
        {

            var text = richTextBox1.SelectedText;

            List<char> chars = new List<char>(text);
            listView1.Items.Clear();

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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDialog_OpenFile();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            ScrapeChars();
        }
    }
}
