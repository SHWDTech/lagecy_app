namespace ESMonApp
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDevMgr = new System.Windows.Forms.Button();
            this.btnVedioMgr = new System.Windows.Forms.Button();
            this.tabCtrlWin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabCtrlWin.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnVedioMgr);
            this.splitContainer1.Panel1.Controls.Add(this.btnDevMgr);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabCtrlWin);
            this.splitContainer1.Size = new System.Drawing.Size(737, 572);
            this.splitContainer1.SplitterDistance = 93;
            this.splitContainer1.SplitterWidth = 2;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnDevMgr
            // 
            this.btnDevMgr.Location = new System.Drawing.Point(3, 3);
            this.btnDevMgr.Name = "btnDevMgr";
            this.btnDevMgr.Size = new System.Drawing.Size(87, 36);
            this.btnDevMgr.TabIndex = 0;
            this.btnDevMgr.Text = "终端管理";
            this.btnDevMgr.UseVisualStyleBackColor = true;
            this.btnDevMgr.Click += new System.EventHandler(this.btnDevMgr_Click);
            // 
            // btnVedioMgr
            // 
            this.btnVedioMgr.Location = new System.Drawing.Point(3, 41);
            this.btnVedioMgr.Name = "btnVedioMgr";
            this.btnVedioMgr.Size = new System.Drawing.Size(87, 36);
            this.btnVedioMgr.TabIndex = 1;
            this.btnVedioMgr.Text = "视频监控";
            this.btnVedioMgr.UseVisualStyleBackColor = true;
            this.btnVedioMgr.Click += new System.EventHandler(this.btnVedioMgr_Click);
            // 
            // tabCtrlWin
            // 
            this.tabCtrlWin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabCtrlWin.Controls.Add(this.tabPage1);
            this.tabCtrlWin.Controls.Add(this.tabPage2);
            this.tabCtrlWin.Location = new System.Drawing.Point(1, 0);
            this.tabCtrlWin.Name = "tabCtrlWin";
            this.tabCtrlWin.Padding = new System.Drawing.Point(3, 3);
            this.tabCtrlWin.SelectedIndex = 0;
            this.tabCtrlWin.Size = new System.Drawing.Size(638, 572);
            this.tabCtrlWin.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(630, 546);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "终端管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(630, 546);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "视频监控";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 572);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabCtrlWin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDevMgr;
        private System.Windows.Forms.Button btnVedioMgr;
        private System.Windows.Forms.TabControl tabCtrlWin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}