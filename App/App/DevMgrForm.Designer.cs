namespace ESMonApp
{
    partial class DevMgrForm
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
            this.infoList = new System.Windows.Forms.ListBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // infoList
            // 
            this.infoList.FormattingEnabled = true;
            this.infoList.ItemHeight = 12;
            this.infoList.Location = new System.Drawing.Point(12, 46);
            this.infoList.Name = "infoList";
            this.infoList.Size = new System.Drawing.Size(859, 520);
            this.infoList.TabIndex = 36;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(532, 4);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 34;
            this.clearBtn.Text = "清除信息";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Location = new System.Drawing.Point(431, 4);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(75, 23);
            this.stopBtn.TabIndex = 33;
            this.stopBtn.Text = "停止";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(334, 4);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(64, 23);
            this.startBtn.TabIndex = 29;
            this.startBtn.Text = "开始";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(258, 4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(52, 21);
            this.txtPort.TabIndex = 32;
            this.txtPort.TabStop = false;
            this.txtPort.Text = "9900";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 31;
            this.label2.Text = "监听端口：";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(69, 4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(103, 21);
            this.txtIP.TabIndex = 30;
            this.txtIP.TabStop = false;
            this.txtIP.Text = "192.168.0.100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 28;
            this.label1.Text = "服务器IP：";
            // 
            // DevMgrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 577);
            this.Controls.Add(this.infoList);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label1);
            this.Name = "DevMgrForm";
            this.Text = "中央控制管理平台";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox infoList;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;




    }
}