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
    public partial class Form_CharInspector___CURSED : Form
    {
        public Form_CharInspector___CURSED()
        {
            InitializeComponent();
        }

        void ScrapeChars()
        {

            var text = contents.SelectedText;

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

        private void LoadFile(String path)
        {
            string text = File.ReadAllText(path);
            contents.Text = text;
        }
        private void LoadFile(MyDir dir) => LoadFile(dir.Path);

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

        private void contents_TextChanged(object sender, EventArgs e)
        {
            label3.Text = contents.Text.Length.ToString();
        }

        private void contents_SelectionChanged(object sender, EventArgs e)
        {
            if (contents.SelectionLength > 0)
            {
                label4.Text = contents.SelectionLength.ToString();
                ScrapeChars();
            }
            else
            {
                label4.Text = "N/A";
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDialog_OpenFile();
        }
    }
}
