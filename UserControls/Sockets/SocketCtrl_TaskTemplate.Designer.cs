namespace TextScrappy.UserControls.Sockets
{
    partial class SocketCtrl_TaskTemplate
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
            this.richTextBoxTaskLog = new System.Windows.Forms.RichTextBox();
            this.textBoxTaskName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBoxTaskLog
            // 
            this.richTextBoxTaskLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxTaskLog.Location = new System.Drawing.Point(0, 23);
            this.richTextBoxTaskLog.Name = "richTextBoxTaskLog";
            this.richTextBoxTaskLog.Size = new System.Drawing.Size(516, 327);
            this.richTextBoxTaskLog.TabIndex = 3;
            this.richTextBoxTaskLog.Text = "";
            // 
            // textBoxTaskName
            // 
            this.textBoxTaskName.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTaskName.Location = new System.Drawing.Point(0, 0);
            this.textBoxTaskName.Name = "textBoxTaskName";
            this.textBoxTaskName.Size = new System.Drawing.Size(516, 23);
            this.textBoxTaskName.TabIndex = 2;
            // 
            // SocketCtrl_TaskTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBoxTaskLog);
            this.Controls.Add(this.textBoxTaskName);
            this.Name = "SocketCtrl_TaskTemplate";
            this.Size = new System.Drawing.Size(516, 350);
            this.Load += new System.EventHandler(this.SocketCtrl_TaskTemplate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBoxTaskLog;
        private TextBox textBoxTaskName;
    }
}
