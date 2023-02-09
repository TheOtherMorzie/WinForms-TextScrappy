
using Lil.Toolkit;
using System.Windows.Forms;
using TextFileEditor.src.Toolkit;
//using WFFT_Lib.Toolkit;

namespace TextFileEditor
{
    public partial class FormEditor_txt : Form
    {
        private MyDir m_dir;
        private FileStream? fs = null;

        private bool HasFile
        {
            get
            {
                return fs != null;
            }
        }

        public FormEditor_txt()
        {
            m_dir = new MyDir();
            InitializeComponent();
        }

        public FormEditor_txt(MyDir dir)
        {
            m_dir = dir;
            InitializeComponent();
            applicationHandler1.AddForm(this);
            CheckProgress();
        }

        void CheckProgress()
        {
            //toolStripTextBox1.Text = 
            //    (S_RTime.I.AppContext == null ?
            //    "AppC: [null]" :
            //    "AppC.n=" + S_RTime.I.AppContext.forms.Count.ToString());
            //if (S_RTime.I.AppContext != null) toolStripProgressBar1.Value = 1;

        }

        public void UpdateDetails()
        {
        }

        public void UpdateControls()
        {
        }

        private void Import(MyDir dir)
        {
        }

        private void Export()
        {
            saveFileDialog1.InitialDirectory = m_dir.Path ?? MyDir.GetCurPath();
            saveFileDialog1.ShowDialog();
            var name = saveFileDialog1.FileName;
            try
            {
                var f = saveFileDialog1.OpenFile() as FileStream;
                var p = Path.GetDirectoryName(saveFileDialog1.FileName);
                //Runtime_LilOrg.I.GetCatcher().Yell("File: " + name + ", " + p ?? "[null]");
            }
            catch (IOException e)
            {
                //Runtime_LilOrg.I.GetCatcher().Yell("File error: " + e.Message);
            }
        }

        private void LoadFile(String path)
        {
            string text = File.ReadAllText(path);
            contents.Text = text;
            UpdateDetails();

            /* Todo
             * - clean up UI
             * - Store file location
             * - FileSystemWatcher
             * - Save file
             *
             *
             */
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

        private void chapters_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void contents_TextChanged(object sender, EventArgs e)
        {
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDialog_OpenFile();
        }

        private void fileExplorerererererToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new FExplorer().Show();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Export();
        }

        private void contents_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            CheckProgress();
        }

        private void newEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEditor_txt f = new();
            S_RTime.I.AppContext.ShowForm(f);
        }
    }
}