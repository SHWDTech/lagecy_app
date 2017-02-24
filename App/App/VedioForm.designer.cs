using ESMonApp.Vedio;

namespace ESMonApp
{
    partial class VedioForm
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
            if (_mLRealHandle >= 0)
            {
                ChcNetSdk.NET_DVR_StopRealPlay(_mLRealHandle);
            }
            if (_mLUserId >= 0)
            {
                ChcNetSdk.NET_DVR_Logout(_mLUserId);
            }
            if (_mBInitSdk == true)
            {
                ChcNetSdk.NET_DVR_Cleanup();
            }

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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.RealPlayWnd = new System.Windows.Forms.PictureBox();
            this.listViewIPChannel = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnBMP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxView = new System.Windows.Forms.ComboBox();
            this.btnRecord = new System.Windows.Forms.Button();
            this.btnJPEG = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.TextBoxInfo = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "密码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "用户名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "设备端口";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "设备IP";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Location = new System.Drawing.Point(315, 58);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(112, 20);
            this.textBoxPassword.TabIndex = 23;
            this.textBoxPassword.Text = "12345";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(66, 58);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(141, 20);
            this.textBoxUserName.TabIndex = 22;
            this.textBoxUserName.Text = "admin";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(315, 20);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(112, 20);
            this.textBoxPort.TabIndex = 21;
            this.textBoxPort.Text = "8000";
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(66, 20);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(141, 20);
            this.textBoxIP.TabIndex = 20;
            this.textBoxIP.Text = "192.168.1.150";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(442, 20);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(78, 54);
            this.btnLogin.TabIndex = 19;
            this.btnLogin.Text = "登陆";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // RealPlayWnd
            // 
            this.RealPlayWnd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RealPlayWnd.Location = new System.Drawing.Point(165, 94);
            this.RealPlayWnd.Name = "RealPlayWnd";
            this.RealPlayWnd.Size = new System.Drawing.Size(442, 310);
            this.RealPlayWnd.TabIndex = 30;
            this.RealPlayWnd.TabStop = false;
            // 
            // listViewIPChannel
            // 
            this.listViewIPChannel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2});
            this.listViewIPChannel.FullRowSelect = true;
            this.listViewIPChannel.GridLines = true;
            this.listViewIPChannel.Location = new System.Drawing.Point(4, 94);
            this.listViewIPChannel.MultiSelect = false;
            this.listViewIPChannel.Name = "listViewIPChannel";
            this.listViewIPChannel.Size = new System.Drawing.Size(155, 248);
            this.listViewIPChannel.TabIndex = 32;
            this.listViewIPChannel.UseCompatibleStateImageBehavior = false;
            this.listViewIPChannel.View = System.Windows.Forms.View.Details;
            this.listViewIPChannel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewIPChannel_MouseClick);
            this.listViewIPChannel.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewIPChannel_ItemSelectionChanged);
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "通道";
            this.ColumnHeader1.Width = 78;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "状态";
            this.ColumnHeader2.Width = 90;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(161, 17);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 29);
            this.btnPreview.TabIndex = 33;
            this.btnPreview.Text = "预览";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnBMP
            // 
            this.btnBMP.Location = new System.Drawing.Point(258, 16);
            this.btnBMP.Name = "btnBMP";
            this.btnBMP.Size = new System.Drawing.Size(79, 29);
            this.btnBMP.TabIndex = 36;
            this.btnBMP.Text = "BMP抓图";
            this.btnBMP.UseVisualStyleBackColor = true;
            this.btnBMP.Click += new System.EventHandler(this.btnBMP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.comboBoxView);
            this.groupBox2.Controls.Add(this.btnRecord);
            this.groupBox2.Controls.Add(this.btnJPEG);
            this.groupBox2.Controls.Add(this.btnPreview);
            this.groupBox2.Controls.Add(this.btnBMP);
            this.groupBox2.Location = new System.Drawing.Point(4, 407);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 51);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 47;
            // 
            // comboBoxView
            // 
            this.comboBoxView.FormattingEnabled = true;
            this.comboBoxView.Items.AddRange(new object[] {
            "Direct:直接预览 ",
            "Callback:回调解码 "});
            this.comboBoxView.Location = new System.Drawing.Point(8, 20);
            this.comboBoxView.Name = "comboBoxView";
            this.comboBoxView.Size = new System.Drawing.Size(139, 21);
            this.comboBoxView.TabIndex = 46;
            // 
            // btnRecord
            // 
            this.btnRecord.Location = new System.Drawing.Point(507, 17);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(89, 27);
            this.btnRecord.TabIndex = 44;
            this.btnRecord.Text = "录像";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // btnJPEG
            // 
            this.btnJPEG.Location = new System.Drawing.Point(370, 15);
            this.btnJPEG.Name = "btnJPEG";
            this.btnJPEG.Size = new System.Drawing.Size(97, 28);
            this.btnJPEG.TabIndex = 42;
            this.btnJPEG.Text = "JPEG抓图";
            this.btnJPEG.UseVisualStyleBackColor = true;
            this.btnJPEG.Click += new System.EventHandler(this.btnJPEG_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxPassword);
            this.groupBox3.Controls.Add(this.btn_Exit);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBoxPort);
            this.groupBox3.Controls.Add(this.textBoxIP);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxUserName);
            this.groupBox3.Controls.Add(this.btnLogin);
            this.groupBox3.Location = new System.Drawing.Point(4, -2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(608, 91);
            this.groupBox3.TabIndex = 41;
            this.groupBox3.TabStop = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(533, 17);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(69, 57);
            this.btn_Exit.TabIndex = 42;
            this.btn_Exit.Text = "退出";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // TextBoxInfo
            // 
            this.TextBoxInfo.Location = new System.Drawing.Point(4, 464);
            this.TextBoxInfo.Multiline = true;
            this.TextBoxInfo.Name = "TextBoxInfo";
            this.TextBoxInfo.Size = new System.Drawing.Size(608, 97);
            this.TextBoxInfo.TabIndex = 43;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(4, 357);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 25);
            this.btnRefresh.TabIndex = 44;
            this.btnRefresh.Text = "刷新通道";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 564);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.TextBoxInfo);
            this.Controls.Add(this.listViewIPChannel);
            this.Controls.Add(this.RealPlayWnd);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox RealPlayWnd;
        private System.Windows.Forms.ListView listViewIPChannel;
        private System.Windows.Forms.ColumnHeader ColumnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnBMP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnJPEG;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox TextBoxInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxView;
        private System.Windows.Forms.Button btnRefresh;

    }
}

