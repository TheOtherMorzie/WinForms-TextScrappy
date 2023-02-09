using AngleSharp.Common;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TextScrappy.UserControls
{
    public partial class UCtrl_ClipboardScanner : UserControl
    {

        // variables

        const string NoFormats = "N/A";
        IDataObject? clipBoardDataObject;
        List<string> formats = new();


        // config functions

        public UCtrl_ClipboardScanner()
        {
            InitializeComponent();
        }

        private void UCtrl_ClipboardScanner_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }


        // properties

        object? target;
        private RichTextBox? textBox;
        private ListBox? listBox_Formats;

        public object? Target
        {
            get => target;
            protected
            set => target = value;
        }

        string defaultText => "Owner: " + Name;
        public RichTextBox? TextBox
        {
            get
            {
                return textBox;
            }
            set
            {
                if (textBox != value)
                {
                    if (textBox != null) textBox.Text = "";
                    if (value != null) value.Text = defaultText;
                    textBox = value;
                }
            }
        }

        public ListBox? ListBox_Formats
        {
            get
            {
                return listBox_Formats;
            }

            set
            {
                if (listBox_Formats != value)
                {
                    if (listBox_Formats != null)
                    {
                        listBox_Formats.Items.Clear();
                    }
                    listBox_Formats = value;
                    if (listBox_Formats != null)
                    {
                        listBox_Formats.Items.Clear();
                        listBox_Formats.Items.Add(defaultText);
                    }
                }
            }
        }

        public object? ClipboardData_Formated
        {
            get;
            set;
        }

        public List<string> Formats
        {
            get => formats;
            set => formats = value;
        }

        public IDataObject? ClipBoardDataObject
        {
            get => clipBoardDataObject;
            set
            {
                if (value == null)
                {
                    ClearFormats();
                }
                else
                {
                    SetFormats(value.GetFormats());
                }
                clipBoardDataObject = value;
            }
        }

        public bool HasDataObject => clipBoardDataObject != null;
        public bool HasValidFormat => HasDataObject && ClipboardData_Formated != null;


        // events


        [Description("Description"), Category("Catagory")]
        public event EventHandler<string>? OnFormatSelected;

        void TestFire()
        {
            OnFormatSelected?.Invoke(this, "");
        }


        // custom functions

        void SetFormats(string[] strings)
        {

            comboBox1.SuspendLayout();
            List<string> list = new();
            if (strings.Length == 0)
            {
                list.Add(NoFormats);
            }
            else
            {
                list.AddRange(strings);
            }
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(list.ToArray());
            ListBox_Formats?.Items.Clear();
            ListBox_Formats?.Items.AddRange(list.ToArray());
            comboBox1.ResumeLayout();
        }

        void SetFormats(List<string> strings)
        {
            SetFormats(strings.ToArray());
        }

        void ClearFormats()
        {
            comboBox1.SuspendLayout();

            comboBox1.Items.Clear();
            comboBox1.Items.Add(NoFormats);
            ListBox_Formats?.Items.Clear();
            comboBox1.ResumeLayout();
        }

        void SelectFormat(int index)
        {
            if (ClipBoardDataObject == null) Target = null;
            else
            {
                if (index <= 0 || index >= formats.Count)
                    return;
                var data = ClipBoardDataObject.GetData(formats[index]);
                Target = data;
                ClipboardData_Formated = data;
                OnFormatSelected?.Invoke(this, comboBox1.Text);
            }
        }

        void SelectFormat(string format)
        {
            var data = ClipBoardDataObject?.GetData(format);
            Target = data;
            ClipboardData_Formated = data;
            OnFormatSelected?.Invoke(this, comboBox1.Text);
        }


        // Designer generated

        private void button1_Click(object sender, EventArgs e)
        {
            var data = Clipboard.GetDataObject();
            ClipBoardDataObject = data;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0) return;
            SelectFormat(comboBox1.SelectedIndex);
        }
    }
}
