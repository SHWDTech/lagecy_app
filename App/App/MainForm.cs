using System;
using System.Windows.Forms;

namespace ESMonApp
{
    public partial class MainForm : Form
    {
        private VedioForm _vedioWin;
        private DevMgrForm _devMgrWin;
        public MainForm()
        {
            InitializeComponent();
            
            InitTabCtrlWin();
        }

        private void InitTabCtrlWin()
        {
            _vedioWin = new VedioForm();
            _devMgrWin = new DevMgrForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            //设置为非顶级窗体
            //设置窗体为非边框样式
            //设置样式是否填充整个panel
            tabPage1.Controls.Add(_devMgrWin);		//添加窗体
            _devMgrWin.Show();

            _vedioWin.TopLevel = false;	  //设置为非顶级窗体
            _vedioWin.FormBorderStyle = FormBorderStyle.None; //设置窗体为非边框样式
            _vedioWin.Dock = DockStyle.Fill;				  //设置样式是否填充整个panel
            tabPage2.Controls.Add(_vedioWin);		//添加窗体
            _vedioWin.Show();

            Program.OutputLog.SetOutputForm(_devMgrWin);	
        }
        
        
        private void btnDevMgr_Click(object sender, EventArgs e)
        {
            SetTabPage(0);
        }

        private void btnVedioMgr_Click(object sender, EventArgs e)
        {
            SetTabPage(1);
        }

        private void SetTabPage(int curPageIndex)
        {
            if (tabCtrlWin != null && curPageIndex != tabCtrlWin.SelectedIndex)
            {
                tabCtrlWin.SelectedIndex = curPageIndex;
            }
        }
    }
}
