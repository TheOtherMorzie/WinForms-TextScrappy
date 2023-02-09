namespace TextScrappy.Forms
{
    partial class Form_ViewerSimpleHTML
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
            this.uCtrl_Viewerhtml1 = new TextScrappy.UserControls.UCtrl_ViewerHTML();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LBox_Console = new System.Windows.Forms.ListBox();
            this.uCtrl_RichTextEditor_html1 = new TextScrappy.UserControls.UCtrl_RichTextEditor_HTML();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uCtrl_Viewerhtml1
            // 
            this.uCtrl_Viewerhtml1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uCtrl_Viewerhtml1.Location = new System.Drawing.Point(1006, 12);
            this.uCtrl_Viewerhtml1.Name = "uCtrl_Viewerhtml1";
            this.uCtrl_Viewerhtml1.Size = new System.Drawing.Size(431, 731);
            this.uCtrl_Viewerhtml1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBox1.Location = new System.Drawing.Point(625, 157);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(375, 586);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(799, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(799, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "CLR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LBox_Console
            // 
            this.LBox_Console.FormattingEnabled = true;
            this.LBox_Console.ItemHeight = 15;
            this.LBox_Console.Location = new System.Drawing.Point(880, 12);
            this.LBox_Console.Name = "LBox_Console";
            this.LBox_Console.Size = new System.Drawing.Size(120, 139);
            this.LBox_Console.TabIndex = 4;
            // 
            // uCtrl_RichTextEditor_html1
            // 
            this.uCtrl_RichTextEditor_html1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uCtrl_RichTextEditor_html1.Location = new System.Drawing.Point(12, 12);
            this.uCtrl_RichTextEditor_html1.Name = "uCtrl_RichTextEditor_html1";
            this.uCtrl_RichTextEditor_html1.Size = new System.Drawing.Size(400, 731);
            this.uCtrl_RichTextEditor_html1.TabIndex = 5;
            this.uCtrl_RichTextEditor_html1.OnEvent_ExportHTML += new System.EventHandler<string>(this.uCtrl_RichTextEditor_html1_OnEvent_ExportHTML);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(718, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Sanatize";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(718, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "rm whiteSpace";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(418, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 679);
            this.listBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(855, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "😉";
            // 
            // Form_ViewerSimpleHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 755);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.uCtrl_RichTextEditor_html1);
            this.Controls.Add(this.LBox_Console);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.uCtrl_Viewerhtml1);
            this.Name = "Form_ViewerSimpleHTML";
            this.Text = "Form_ViewerSimpleHTML";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.UCtrl_ViewerHTML uCtrl_Viewerhtml1;
        private RichTextBox richTextBox1;
        private Button button1;
        private Button button2;
        private ListBox LBox_Console;
        private UserControls.UCtrl_RichTextEditor_HTML uCtrl_RichTextEditor_html1;
        private Button button3;
        private Button button4;
        private ListBox listBox1;
        private Label label1;
    }
}