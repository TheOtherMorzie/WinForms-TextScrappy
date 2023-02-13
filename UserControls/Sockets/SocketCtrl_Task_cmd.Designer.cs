namespace TextScrappy.UserControls.Sockets
{
    partial class SocketCtrl_Task_cmd
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
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.richTextBoxTaskLog = new System.Windows.Forms.RichTextBox();
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
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTaskName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxTaskLog);
            this.splitContainer1.Size = new System.Drawing.Size(394, 269);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTaskName.Location = new System.Drawing.Point(0, 0);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.ReadOnly = true;
            this.textBoxTaskName.Size = new System.Drawing.Size(394, 23);
            this.textBoxTaskName.TabIndex = 2;
            // 
            // richTextBoxTaskLog
            // 
            this.richTextBoxTaskLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxTaskLog.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxTaskLog.Name = "richTextBoxTaskLog";
            this.richTextBoxTaskLog.Size = new System.Drawing.Size(394, 240);
            this.richTextBoxTaskLog.TabIndex = 3;
            this.richTextBoxTaskLog.Text = "1\n2\n3\n4\n5\n6\n7\n8\n9\n0";
            // 
            // SocketCtrl_Task_cmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "SocketCtrl_Task_cmd";
            this.Size = new System.Drawing.Size(394, 269);
            this.Load += new System.EventHandler(this.SocketCtrl_Task_cmd_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox textBoxTaskName;
        private RichTextBox richTextBoxTaskLog;
    }
}
