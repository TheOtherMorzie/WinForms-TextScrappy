namespace TextScrappy.Forms
{
    partial class DemoForm_clipboard1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.cradleGeneric1 = new WFFT_Lib.src.UserControls.CradleGeneric();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.buttonPaste = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.uCtrl_ClipboardInspector1 = new TextScrappy.UserControls.UCtrl_ClipboardInspector();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(190, 163);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(208, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(190, 163);
            this.richTextBox2.TabIndex = 8;
            this.richTextBox2.Text = "";
            // 
            // cradleGeneric1
            // 
            this.cradleGeneric1.CradleName = "Object Cradle";
            this.cradleGeneric1.Location = new System.Drawing.Point(12, 533);
            this.cradleGeneric1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cradleGeneric1.MaximumSize = new System.Drawing.Size(0, 50);
            this.cradleGeneric1.MinimumSize = new System.Drawing.Size(100, 50);
            this.cradleGeneric1.Name = "cradleGeneric1";
            this.cradleGeneric1.Size = new System.Drawing.Size(160, 50);
            this.cradleGeneric1.TabIndex = 13;
            this.cradleGeneric1.Target = null;
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(12, 181);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(75, 23);
            this.buttonCopy.TabIndex = 9;
            this.buttonCopy.Text = "Clip <<";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(208, 223);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(287, 304);
            this.richTextBox3.TabIndex = 12;
            this.richTextBox3.Text = "";
            // 
            // buttonPaste
            // 
            this.buttonPaste.Location = new System.Drawing.Point(208, 181);
            this.buttonPaste.Name = "buttonPaste";
            this.buttonPaste.Size = new System.Drawing.Size(75, 23);
            this.buttonPaste.TabIndex = 10;
            this.buttonPaste.Text = "Clip >>";
            this.buttonPaste.UseVisualStyleBackColor = true;
            this.buttonPaste.Click += new System.EventHandler(this.buttonPaste_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 223);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(190, 304);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // uCtrl_ClipboardInspector1
            // 
            this.uCtrl_ClipboardInspector1.Location = new System.Drawing.Point(501, 12);
            this.uCtrl_ClipboardInspector1.Name = "uCtrl_ClipboardInspector1";
            this.uCtrl_ClipboardInspector1.Size = new System.Drawing.Size(561, 654);
            this.uCtrl_ClipboardInspector1.TabIndex = 14;
            // 
            // DemoForm_clipboard1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 678);
            this.Controls.Add(this.uCtrl_ClipboardInspector1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.cradleGeneric1);
            this.Controls.Add(this.buttonCopy);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.buttonPaste);
            this.Controls.Add(this.listBox1);
            this.Name = "DemoForm_clipboard1";
            this.Text = "DemoForm_clipboard1";
            this.Load += new System.EventHandler(this.DemoForm_clipboard1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private WFFT_Lib.src.UserControls.CradleGeneric cradleGeneric1;
        private Button buttonCopy;
        private RichTextBox richTextBox3;
        private Button buttonPaste;
        private ListBox listBox1;
        private UserControls.UCtrl_ClipboardInspector uCtrl_ClipboardInspector1;
    }
}