namespace TextScrappy.UserControls
{
    partial class UCtrl_ClipboardInspector
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCtrl_ClipboardInspector));
            this.uCtrl_ClipboardScanner1 = new TextScrappy.UserControls.UCtrl_ClipboardScanner();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // uCtrl_ClipboardScanner1
            // 
            this.uCtrl_ClipboardScanner1.ClipboardData_Formated = null;
            this.uCtrl_ClipboardScanner1.ClipBoardDataObject = null;
            this.uCtrl_ClipboardScanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uCtrl_ClipboardScanner1.Formats = ((System.Collections.Generic.List<string>)(resources.GetObject("uCtrl_ClipboardScanner1.Formats")));
            this.uCtrl_ClipboardScanner1.Location = new System.Drawing.Point(0, 0);
            this.uCtrl_ClipboardScanner1.MaximumSize = new System.Drawing.Size(0, 29);
            this.uCtrl_ClipboardScanner1.MinimumSize = new System.Drawing.Size(150, 29);
            this.uCtrl_ClipboardScanner1.Name = "uCtrl_ClipboardScanner1";
            this.uCtrl_ClipboardScanner1.Size = new System.Drawing.Size(312, 29);
            this.uCtrl_ClipboardScanner1.TabIndex = 0;
            this.uCtrl_ClipboardScanner1.OnFormatSelected += new System.EventHandler<string>(this.uCtrl_ClipboardScanner1_OnFormatSelected);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 29);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(312, 272);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // UCtrl_ClipboardInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.uCtrl_ClipboardScanner1);
            this.Name = "UCtrl_ClipboardInspector";
            this.Size = new System.Drawing.Size(312, 301);
            this.ResumeLayout(false);

        }

        #endregion

        private UCtrl_ClipboardScanner uCtrl_ClipboardScanner1;
        private RichTextBox richTextBox1;
    }
}
