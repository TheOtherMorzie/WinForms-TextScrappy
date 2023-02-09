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
    public partial class DemoForm_clipboard1 : Form
    {
        IDataObject? DataObject;
        public DemoForm_clipboard1()
        {
            InitializeComponent();
        }

        private void DemoForm_clipboard1_Load(object sender, EventArgs e)
        {

        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {

            // Takes the selected text from a text box and puts it on the clipboard.
            if (richTextBox1.SelectedText != "")
                Clipboard.SetDataObject(richTextBox1.SelectedText);
            else
                richTextBox1.Text = "No text selected in textBox1";
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            // Declares an IDataObject to hold the data returned from the clipboard.
            // Retrieves the data from the clipboard.
            IDataObject iData = Clipboard.GetDataObject();
            DataObject = iData;
            cradleGeneric1.Target = DataObject;

            if (iData != null)
            {
                var formats = iData.GetFormats();
                listBox1.Items.Clear();
                listBox1.Items.AddRange(formats);
            }

            // Determines whether the data is in a format you can use.
            if (iData.GetDataPresent(DataFormats.Text))
            {
                // Yes it is, so display it in a text box.
                richTextBox2.Text = (String)iData.GetData(DataFormats.Text);
            }
            else
            {
                // No it is not.
                richTextBox2.Text = "Could not retrieve data off the clipboard.";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DataObject == null) richTextBox3.Text = "[No DataObject]";
            else
            {
                if (listBox1.SelectedIndex <= 0 || listBox1.SelectedIndex > listBox1.Items.Count) richTextBox3.Text = "[Invalid Index:" + listBox1.SelectedIndex + "]";
                else
                {
                    // Determines whether the data is in a format you can use.
                    if (DataObject.GetDataPresent(listBox1.SelectedItem.ToString()))
                    {
                        // Yes it is, so display it in a text box.
                        object? data = DataObject.GetData(listBox1.SelectedItem.ToString());
                        if (data == null) richTextBox3.Text = "[null data]";
                        else
                        {
                            richTextBox3.Text = data.ToString();
                        }
                    }
                    else
                    {
                        // No it is not.
                        richTextBox2.Text = "Could not convert data from clipboard.";
                    }
                }
            }
        }
    }
}
