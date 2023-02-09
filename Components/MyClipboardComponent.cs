using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.DataFormats;
using WFFT_Lib.src.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace TextScrappy.Components
{
    public partial class MyClipboardComponent : Component
    {


        // variables

        const string NoFormats = "N/A";
        IDataObject? clipBoardDataObject;
        List<string> formats = new();


        public MyClipboardComponent()
        {
            InitializeComponent();
        }

        public MyClipboardComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        // paste to clipboard

        // copy from clipboard


        // properties

        object? target;
        public object? Target
        {
            get => target;
            protected
            set => target = value;
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



        // custom functions

        void SetFormats(string[] strings)
        {

            //comboBox1.SuspendLayout();
            //comboBox1.Items.Clear();
            //if (strings.Length == 0)
            //{
            //    comboBox1.Items.Add(NoFormats);
            //}
            //else
            //{
            //    comboBox1.Items.AddRange(strings);
            //}
            //comboBox1.ResumeLayout();
        }

        void SetFormats(List<string> strings)
        {
            SetFormats(strings.ToArray());
        }

        void ClearFormats()
        {
            //comboBox1.SuspendLayout();
            //comboBox1.Items.Clear();
            //comboBox1.Items.Add(NoFormats);
            //comboBox1.ResumeLayout();
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
            }
        }

        void SelectFormat(string format)
        {
            var data = ClipBoardDataObject?.GetData(format);
            Target = data;
            ClipboardData_Formated = data;
        }

        void ScanClipboard()
        {
            var data = Clipboard.GetDataObject();
            ClipBoardDataObject = data;
        }





    }
}
