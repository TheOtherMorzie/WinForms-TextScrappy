using TheArtOfDev.HtmlRenderer.WinForms;
using WFFT_Lib.src.UserControls;

namespace TextScrappy.UserControls
{
    partial class UCtrl_ViewerHTML
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
            this.cradleGeneric1 = new WFFT_Lib.src.UserControls.CradleGeneric();
            this.htmlLabel1 = new TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel();
            this.htmlPanel1 = new TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel();
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
            this.splitContainer1.Panel1.Controls.Add(this.cradleGeneric1);
            this.splitContainer1.Panel1.Controls.Add(this.htmlLabel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.htmlPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(537, 628);
            this.splitContainer1.SplitterDistance = 118;
            this.splitContainer1.TabIndex = 0;
            // 
            // cradleGeneric1
            // 
            this.cradleGeneric1.Location = new System.Drawing.Point(4, 64);
            this.cradleGeneric1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cradleGeneric1.Name = "cradleGeneric1";
            this.cradleGeneric1.Size = new System.Drawing.Size(200, 51);
            this.cradleGeneric1.TabIndex = 1;
            this.cradleGeneric1.Target = null;
            // 
            // htmlLabel1
            // 
            this.htmlLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlLabel1.BaseStylesheet = null;
            this.htmlLabel1.Location = new System.Drawing.Point(3, 3);
            this.htmlLabel1.Name = "htmlLabel1";
            this.htmlLabel1.Size = new System.Drawing.Size(74, 20);
            this.htmlLabel1.TabIndex = 0;
            this.htmlLabel1.Text = "htmlLabel1";
            // 
            // htmlPanel1
            // 
            this.htmlPanel1.AutoScroll = true;
            this.htmlPanel1.AutoScrollMinSize = new System.Drawing.Size(537, 20);
            this.htmlPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel1.BaseStylesheet = null;
            this.htmlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlPanel1.Location = new System.Drawing.Point(0, 0);
            this.htmlPanel1.Name = "htmlPanel1";
            this.htmlPanel1.Size = new System.Drawing.Size(537, 506);
            this.htmlPanel1.TabIndex = 0;
            this.htmlPanel1.Text = "htmlPanel1";
            // 
            // UCtrl_ViewerHTML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UCtrl_ViewerHTML";
            this.Size = new System.Drawing.Size(537, 628);
            this.Load += new System.EventHandler(this.UCtrl_ViewerHTML_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private WFFT_Lib.src.UserControls.CradleGeneric cradleGeneric1;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlLabel htmlLabel1;
        private TheArtOfDev.HtmlRenderer.WinForms.HtmlPanel htmlPanel1;

    }
}
