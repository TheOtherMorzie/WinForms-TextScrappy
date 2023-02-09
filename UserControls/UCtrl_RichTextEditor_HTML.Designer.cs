namespace TextScrappy.UserControls
{
    partial class UCtrl_RichTextEditor_HTML
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cradleGeneric1 = new WFFT_Lib.src.UserControls.CradleGeneric();
            this.buttonExportHTML = new System.Windows.Forms.Button();
            this.buttonClearHTML = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonClearHTML);
            this.splitContainer1.Panel1.Controls.Add(this.buttonExportHTML);
            this.splitContainer1.Panel1.Controls.Add(this.cradleGeneric1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(400, 600);
            this.splitContainer1.SplitterDistance = 86;
            this.splitContainer1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(400, 510);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // cradleGeneric1
            // 
            this.cradleGeneric1.Location = new System.Drawing.Point(240, 3);
            this.cradleGeneric1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cradleGeneric1.Name = "cradleGeneric1";
            this.cradleGeneric1.Size = new System.Drawing.Size(156, 51);
            this.cradleGeneric1.TabIndex = 0;
            this.cradleGeneric1.Target = null;
            // 
            // buttonExportHTML
            // 
            this.buttonExportHTML.Location = new System.Drawing.Point(240, 60);
            this.buttonExportHTML.Name = "buttonExportHTML";
            this.buttonExportHTML.Size = new System.Drawing.Size(75, 23);
            this.buttonExportHTML.TabIndex = 1;
            this.buttonExportHTML.Text = "Export";
            this.buttonExportHTML.UseVisualStyleBackColor = true;
            this.buttonExportHTML.Click += new System.EventHandler(this.buttonExportHTML_Click);
            // 
            // buttonClearHTML
            // 
            this.buttonClearHTML.Location = new System.Drawing.Point(321, 60);
            this.buttonClearHTML.Name = "buttonClearHTML";
            this.buttonClearHTML.Size = new System.Drawing.Size(75, 23);
            this.buttonClearHTML.TabIndex = 2;
            this.buttonClearHTML.Text = "Clear";
            this.buttonClearHTML.UseVisualStyleBackColor = true;
            this.buttonClearHTML.Click += new System.EventHandler(this.buttonClearHTML_Click);
            // 
            // UCtrl_RichTextEditor_HTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCtrl_RichTextEditor_HTML";
            this.Size = new System.Drawing.Size(400, 600);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private RichTextBox richTextBox1;
        private Button buttonClearHTML;
        private Button buttonExportHTML;
        private WFFT_Lib.src.UserControls.CradleGeneric cradleGeneric1;
    }
}
