namespace TextScrappy.Forms
{
    partial class Form_LilsCMDparty
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmdInterface1 = new WFFT_Lib.src.UserControls.CMDInterface();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.socketCtrl_Task_cmd1 = new TextScrappy.UserControls.Sockets.SocketCtrl_Task_cmd();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.uCtrl_clIwrapperLog1 = new TextScrappy.UserControls.UCtrl_CLIwrapperLog();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cmdInterface1);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox1);
            this.splitContainer1.Panel1.Controls.Add(this.socketCtrl_Task_cmd1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.uCtrl_clIwrapperLog1);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1325, 1061);
            this.splitContainer1.SplitterDistance = 743;
            this.splitContainer1.TabIndex = 0;
            // 
            // cmdInterface1
            // 
            this.cmdInterface1.Location = new System.Drawing.Point(13, 316);
            this.cmdInterface1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdInterface1.Name = "cmdInterface1";
            this.cmdInterface1.Size = new System.Drawing.Size(810, 394);
            this.cmdInterface1.TabIndex = 18;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(821, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 19);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "IsYourTimerRunning?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // socketCtrl_Task_cmd1
            // 
            this.socketCtrl_Task_cmd1.Location = new System.Drawing.Point(429, 41);
            this.socketCtrl_Task_cmd1.Name = "socketCtrl_Task_cmd1";
            this.socketCtrl_Task_cmd1.Size = new System.Drawing.Size(394, 269);
            this.socketCtrl_Task_cmd1.TabIndex = 16;
            this.socketCtrl_Task_cmd1.TaskObject = null;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(510, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(305, 23);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "echo \"HelloWorld!\"";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(429, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // uCtrl_clIwrapperLog1
            // 
            this.uCtrl_clIwrapperLog1.HideDetailsPanel = false;
            this.uCtrl_clIwrapperLog1.Location = new System.Drawing.Point(12, 12);
            this.uCtrl_clIwrapperLog1.Name = "uCtrl_clIwrapperLog1";
            this.uCtrl_clIwrapperLog1.Size = new System.Drawing.Size(411, 298);
            this.uCtrl_clIwrapperLog1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(1176, 716);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1109, 716);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Run";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(12, 716);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1091, 23);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "echo \"HelloWorld!\"";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(1238, 716);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "clr console";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1325, 314);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_LilsCMDparty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 1061);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form_LilsCMDparty";
            this.Text = "Form_LilsCMDparty";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button button3;
        private Button button2;
        private TextBox textBox1;
        private Button button1;
        private RichTextBox richTextBox1;
        private UserControls.UCtrl_CLIwrapperLog uCtrl_clIwrapperLog1;
        private TextBox textBox2;
        private Button button4;
        private UserControls.Sockets.SocketCtrl_Task_cmd socketCtrl_Task_cmd1;
        private CheckBox checkBox1;
        private System.Windows.Forms.Timer timer1;
        private WFFT_Lib.src.UserControls.CMDInterface cmdInterface1;
    }
}