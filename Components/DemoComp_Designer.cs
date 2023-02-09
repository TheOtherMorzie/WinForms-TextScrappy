using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.DataFormats;
using TextScrappy.src;
using CsvHelper.Configuration.Attributes;

namespace TextScrappy.Components
{
    public partial class DemoComp_Designer : Component
    {
        public DemoComp_Designer()
        {
            InitializeComponent();
        }

        public DemoComp_Designer(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }



        const string NoFormats = "N/A";
        IDataObject? clipBoardDataObject;
        List<string> formats = new();


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
                    //ClearFormats();
                }
                else
                {
                    //SetFormats(value.GetFormats());
                }
                clipBoardDataObject = value;
            }
        }

        public bool HasDataObject => clipBoardDataObject != null;
        public bool HasValidFormat => HasDataObject && ClipboardData_Formated != null;



        [
            Name("Hide Details"),
            Category("Lil"),
            Description("Hides the details Panel"),
            ]
        public bool HideDetails
        {
            get;
            set;
        }



        [Description("Description"), Category("Catagory")]
        public event EventHandler<String>? Event_NewString;



        public void TestFire()
        {
            Event_NewString?.Invoke(this, "");

            //if (EventItemSelected != null)
            //    EventItemSelected(this, null);
        }




        [Description("Description"), Category("Category")]
        public String DummyText = "text";



        // length

        int pathPartCount = 4;

        [Description("Description"), Category("Category")]
        public int PathPartCount
        {
            get => pathPartCount;
            set
            {
                if (value > MaxPathLength)
                {
                    pathPartCount = MaxPathLength;
                    return;
                }
                if (value < 0)
                {
                    pathPartCount = 0;
                    return;
                }
                pathPartCount = value;
            }
        }

        [Description("Description"), Category("Category")]
        public int MaxPathLength
        {
            get => pathPartCount;
            set => pathPartCount = value;
        }

        [Description("Description"), Category("Category")]
        public bool Path_Small
        {
            get => pathPartCount < 4;
        }

        [Description("Description"), Category("Category")]
        public bool Path_Large
        {
            get => pathPartCount > 2;
        }

        public int demoRangeVal = 4;

        [Description("Description"), Category("Category")]
        public int DemoRangeVal
        {
            get => pathPartCount;
            set => pathPartCount = value;
        }

        [Description("Description"), Category("Category")]
        public bool DemoRangeMax
        {
            get => pathPartCount < 4;
        }

        [Description("Description"), Category("Category")]
        public bool DemoRangeMin
        {
            get => pathPartCount > 2;
        }



    }
}
