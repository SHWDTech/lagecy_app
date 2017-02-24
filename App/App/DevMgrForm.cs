using System;
using System.Windows.Forms;
using System.Net;
using System.Configuration;


namespace ESMonApp
{
    public partial class DevMgrForm : Form
    {
        public DevMgrForm()
        {
            InitializeComponent();
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtIP.Text = ConfigurationManager.AppSettings["server"];
            txtPort.Text = ConfigurationManager.AppSettings["serverPort"];
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            
            var ip = txtIP.Text;
            var port = int.Parse(txtPort.Text);

            var listenPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            var flag = Program.AsyncSocketSvr.Start(listenPoint);
            
            if (flag)
            {
                startBtn.Enabled = false;
                stopBtn.Enabled = true;
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            var flag = Program.AsyncSocketSvr.Stop();

            if (flag)
            {
                startBtn.Enabled = true;
                stopBtn.Enabled = false;
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            infoList.Items.Clear();
        }

        public void UpdateList(string str)
        {

        }

        public void SetListBox(string str)
        {
            if (infoList.Items.Count > 1000)
            {
                infoList.Items.RemoveAt(0);
            }
            
            infoList.Items.Add(str);
        }
    }
}
