using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Text;

namespace Web
{
    public partial class UserGroupAdd : System.Web.UI.Page
    {
        //private readonly ESMonitor.BLL.UserGroup UGBll = new ESMonitor.BLL.UserGroup();
        //ESMonitor.BLL.GroupModules GMBll = new ESMonitor.BLL.GroupModules();
        //Dictionary<int, byte> authDic = new Dictionary<int, byte>();
        public string zNodesStr = string.Empty;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitTree();
            }
        }

        //绑定组
        private void BindGroup()
        {
            //if (this.hdnLoadGroups.Value == "")
            //{
            //    ESMonitor.BLL.UserGroup bll = new ESMonitor.BLL.UserGroup();
            //    DataSet ds = bll.GetList("");
            //    this.ddlGroup.DataSource = ds;
            //    this.ddlGroup.DataTextField = "Name";
            //    this.ddlGroup.DataValueField = "Id";
            //    this.ddlGroup.DataBind();
            //    this.hdnLoadGroups.Value = "1";
            //}
        }

        #region ModelPanel
        private void InitTree()
        {
            StringBuilder sb = new StringBuilder();
            ESMonitor.BLL.ModuleType MTBll = new ESMonitor.BLL.ModuleType();
            DataTable dt = MTBll.GetAllList().Tables[0];
            
            sb.Append("[");
            foreach (DataRow dr in dt.Rows)
            {
                sb.Append("{");
                sb.AppendFormat("id:\"T{0}\",pId:\"T{1}\",name:\"{2}\",isParent:true", dr["Id"], dr["SuperiorId"], dr["Name"]);
                sb.Append("},");
            }
            
            
            dt.Clear();
            ESMonitor.BLL.Modules MBll = new ESMonitor.BLL.Modules();
            dt = MBll.GetList("Disabled=0").Tables[0];

            foreach (DataRow dr in dt.Rows)
            {
                sb.Append("{");
                sb.AppendFormat("id:\"M{0}\",pId:\"T{1}\",name:\"{2}\"", dr["Id"], dr["TypeId"], dr["Name"]);
                sb.Append("},");
            }
            
            if (sb.Length > 1)
            {
                sb = sb.Remove(sb.Length - 1, 1);
            }

            sb.Append("]");
            zNodesStr = sb.ToString();
            
            return;
        }
        //绑定模型对象
        //private void BindModuleTypes()
        //{
        //    ESMonitor.BLL.ModuleType bll = new ESMonitor.BLL.ModuleType();
        //    DataSet ds = bll.GetList("");
        //    this.ModuleTypeRepeater.DataSource = ds;
        //    this.ModuleTypeRepeater.DataBind();
        //}

        //private void BindGroupModuleList(string strWhere)
        //{
        //    ESMonitor.BLL.Modules MBll = new ESMonitor.BLL.Modules();
        //    DataSet ds = MBll.GetList(strWhere);
        //    this.ModuleRepeater.DataSource = ds;
        //    this.ModuleRepeater.DataBind();

        //    if (ds.Tables[0].Rows.Count > 0)
        //    {
        //        this.btn_AllSave.Visible = true;
        //    }
        //    else
        //    {
        //        this.btn_AllSave.Visible = false;
        //    }
        //}

        
        #endregion
        
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            //string tip = string.Empty;
            //string email = string.Empty;
            //string name = this.txtName.Text.Trim();
            //string description = this.txtDescription.Text.Trim();
            //int order = int.Parse(this.txtOrder.Text.Trim());
            
            //if (name != "" && description != "")
            //{
            //    if (!UGBll.Exists(name))
            //    {
            //        ESMonitor.Model.UserGroup model = new ESMonitor.Model.UserGroup();
            //        model.Name = name;
            //        model.Description = description;
            //        model.Orders = order;

            //        if (UGBll.Add(model) > 0)
            //        {
            //            tip = "成功添加分组！";
            //        }
            //        else
            //        {
            //            tip = "添加分组失败...";
            //        }
            //    }
            //    else
            //    {
            //        tip = "组名已使用";
            //    }
            //}
            //else
            //{
            //    tip = "组名、描述不能为空";
            //}


            //ClientScript.RegisterStartupScript(this.GetType(), "", "<script>window.parent.zAlert(\"" + tip + "\");</script>");


        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            this.txtName.Text = "";
            this.txtDescription.Text = "";
            this.txtOrder.Text = "";
        }
    }
}
