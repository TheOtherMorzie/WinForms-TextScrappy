namespace Lil.Forms
{
    partial class Clipboard_Info
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clipboard_Info));
            this.uCtrl_ClipboardScanner1 = new TextScrappy.UserControls.UCtrl_ClipboardScanner();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.myClipboardComponent1 = new TextScrappy.Components.MyClipboardComponent(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uCtrl_ClipboardScanner1
            // 
            this.uCtrl_ClipboardScanner1.ClipboardData_Formated = null;
            this.uCtrl_ClipboardScanner1.ClipBoardDataObject = null;
            this.uCtrl_ClipboardScanner1.Formats = ((System.Collections.Generic.List<string>)(resources.GetObject("uCtrl_ClipboardScanner1.Formats")));
            this.uCtrl_ClipboardScanner1.ListBox_Formats = this.listBox1;
            this.uCtrl_ClipboardScanner1.Location = new System.Drawing.Point(12, 12);
            this.uCtrl_ClipboardScanner1.MaximumSize = new System.Drawing.Size(0, 29);
            this.uCtrl_ClipboardScanner1.MinimumSize = new System.Drawing.Size(150, 29);
            this.uCtrl_ClipboardScanner1.Name = "uCtrl_ClipboardScanner1";
            this.uCtrl_ClipboardScanner1.Size = new System.Drawing.Size(218, 29);
            this.uCtrl_ClipboardScanner1.TabIndex = 8;
            this.uCtrl_ClipboardScanner1.TextBox = this.richTextBox1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(236, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(570, 609);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Owner: UCtrl_ClipboardScanner";
            // 
            // myClipboardComponent1
            // 
            this.myClipboardComponent1.ClipboardData_Formated = null;
            this.myClipboardComponent1.ClipBoardDataObject = null;
            this.myClipboardComponent1.Formats = ((System.Collections.Generic.List<string>)(resources.GetObject("myClipboardComponent1.Formats")));
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Items.AddRange(new object[] {
            "Owner: UCtrl_ClipboardScanner"});
            this.listBox1.Location = new System.Drawing.Point(12, 47);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(218, 379);
            this.listBox1.TabIndex = 10;
            // 
            // Clipboard_Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 707);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.uCtrl_ClipboardScanner1);
            this.Name = "Clipboard_Info";
            this.Text = "Clipboard_Info";
            this.Load += new System.EventHandler(this.Clipboard_Info_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private TextScrappy.UserControls.UCtrl_ClipboardScanner uCtrl_ClipboardScanner1;
        private RichTextBox richTextBox1;
        private TextScrappy.Components.MyClipboardComponent myClipboardComponent1;
        private ListBox listBox1;
    }
}