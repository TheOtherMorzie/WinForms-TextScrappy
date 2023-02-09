using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextScrappy.src
{
    public class MyClipboardDataObject
    {

        IDataObject? clipBoardDataObject;

        public object? ClipboardData_Formated
        {
            get;
            set;
        }


        [Description("Description"), Category("Catagory")]
        public event EventHandler<IDataObject?>? OnDataChanged;


        IDataObject? data;


        public IDataObject? Data
        {
            get => data;
            set
            {
                if (data != value)
                {
                    data = value;
                    OnDataChanged?.Invoke(this, data);
                }
            }
        }

        public bool CanConvertTo(string type)
        {
            if (Data == null) return false;
            return Data.GetDataPresent(type);
        }

        public List<string> GetFormats()
        {
            if (data == null)
            {
                return new();
            }
            return Data.GetFormats().ToList();
        }


        public bool HasDataObject => Data != null;

        public void LoadFromClipboard()
        {
            Data = Clipboard.GetDataObject();
        }

        public static MyClipboardDataObject NewFromClipboard()
        {
            MyClipboardDataObject dataObject = new();
            dataObject.LoadFromClipboard();
            return dataObject;
        }

    }
}
