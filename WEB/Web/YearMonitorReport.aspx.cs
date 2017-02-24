using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ESMonitor.BLL;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace Web
{
    public partial class YearMonitorReport : Page
    {
        private readonly HistoryQuery _bll = new HistoryQuery();
        public string ReturnValue = "";
        public string XAxisCategories = "";
        private int _cityId;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblAvgShow.Visible = false;
            if (!IsPostBack)
            {
                DdlSelectYearBind();
                DdlPolutionKindBind();
            }
        }
        public void DdlSelectYearBind()
        {
            ddlSelectYear.Items.Add(new ListItem("2015", "2015"));
            ddlSelectYear.Items.Add(new ListItem("2016", "2016"));
            ddlSelectYear.Items.Add(new ListItem("2017", "2017"));
            ddlSelectYear.Items.Add(new ListItem("2018", "2018"));
            ddlSelectYear.Items.Add(new ListItem("2019", "2019"));
            ddlSelectYear.Items.Add(new ListItem("2020", "2020"));
            ddlSelectYear.Items.Add(new ListItem("2021", "2021"));
            ddlSelectYear.Items.Add(new ListItem("2022", "2022"));
            ddlSelectYear.Items.Add(new ListItem("2023", "2023"));
            ddlSelectYear.Items.Add(new ListItem("2024", "2024"));
        }

        public void DdlPolutionKindBind()
        {
            ddlPolutionKind.Items.Add(new ListItem("颗粒物", "1"));
            ddlPolutionKind.Items.Add(new ListItem("噪音", "2"));
            ddlPolutionKind.Items.Add(new ListItem("PM2.5", "3"));
            ddlPolutionKind.Items.Add(new ListItem("PM10", "4"));    
        }
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            _cityId = int.Parse(hiddencityId.Value.Trim());
            string strYear = ddlSelectYear.SelectedValue;
            string strDate = strYear + "-" + "01";
            DateTime startTime = DateTime.Parse(strDate);
            DateTime endTime = startTime.AddYears(1);
            int indexKind = Convert.ToInt16(ddlPolutionKind.SelectedValue);

            DataSet reportDs = _bll.GetList(1, startTime, endTime, indexKind, _cityId);
            if (indexKind == 1)
            {
                foreach (DataRow drRow in reportDs.Tables[0].Rows)
                {
                    drRow["IndexAVG"] = string.Format("{0:F}", (double)drRow["IndexAVG"] / 1000.0);
                    drRow["IndexMAX"] = string.Format("{0:F}", (double)drRow["IndexMAX"] / 1000.0);
                    drRow["IndexMIN"] = string.Format("{0:F}", (double)drRow["IndexMIN"] / 1000.0);
                }
            }
            else
            {
                foreach (DataRow drRow in reportDs.Tables[0].Rows)
                {
                    drRow["IndexAVG"] = string.Format("{0:F}", (double)drRow["IndexAVG"]);
                    drRow["IndexMAX"] = string.Format("{0:F}", (double)drRow["IndexMAX"]);
                    drRow["IndexMIN"] = string.Format("{0:F}", (double)drRow["IndexMIN"]);
                }
            }

            DataSet avgDs = _bll.GetList(2, startTime, endTime, indexKind, _cityId);

            gvReportShow.DataSource = reportDs;
            gvReportShow.DataBind();
            DataTable reportDt = reportDs.Tables[0];

            DataTable avarageDt = avgDs.Tables[0];

            if (reportDt.Rows.Count > 0)
            {
                if (indexKind == 1)
                {
                    StringBuilder strBuilderReturnValue = new StringBuilder();
                    strBuilderReturnValue.Append("[");
                    strBuilderReturnValue.Append("{name: '颗粒物浓度',data: [");

                    for (int i = 0; i < reportDt.Rows.Count; i++)
                    {
                        string strName = reportDt.Rows[i]["IndexAVG"].ToString();
                        strBuilderReturnValue.Append(strName);
                        strBuilderReturnValue.Append(",");
                    }
                    strBuilderReturnValue.Remove(strBuilderReturnValue.ToString().LastIndexOf(','), 1);
                    strBuilderReturnValue.Append("]}]");
                    ReturnValue = strBuilderReturnValue.ToString();


                    StringBuilder strBuilderxAxisCategories = new StringBuilder();
                    strBuilderxAxisCategories.Append("[");
                    for (int i = 0; i < reportDt.Rows.Count; i++)
                    {
                        string strName = reportDt.Rows[i]["StatName"].ToString();
                        strBuilderxAxisCategories.Append("'");
                        strBuilderxAxisCategories.Append(strName);
                        strBuilderxAxisCategories.Append("'");
                        strBuilderxAxisCategories.Append(",");
                    }
                    strBuilderxAxisCategories.Remove(strBuilderxAxisCategories.ToString().LastIndexOf(','), 1);
                    strBuilderxAxisCategories.Append("]");
                    XAxisCategories = strBuilderxAxisCategories.ToString();


                    lblAvgShow.Text = ddlSelectYear.SelectedItem.Value + "年" + "颗粒物平均浓度为：" + String.Format("{0:N1}", float.Parse(avarageDt.Rows[0]["IndexAVG"].ToString()) / 1000.0);
                    lblAvgShow.Visible = true;
                }


                if (indexKind == 2)
                {
                    StringBuilder strBuilderReturnValue = new StringBuilder();
                    strBuilderReturnValue.Append("[");
                    strBuilderReturnValue.Append("{name: '噪音大小',data: [");

                    for (int i = 0; i < reportDt.Rows.Count; i++)
                    {
                        string strName = reportDt.Rows[i]["IndexAVG"].ToString();
                        strBuilderReturnValue.Append(strName);
                        strBuilderReturnValue.Append(",");
                    }
                    strBuilderReturnValue.Remove(strBuilderReturnValue.ToString().LastIndexOf(','), 1);
                    strBuilderReturnValue.Append("]}]");
                    ReturnValue = strBuilderReturnValue.ToString();


                    StringBuilder strBuilderxAxisCategories = new StringBuilder();
                    strBuilderxAxisCategories.Append("[");
                    for (int i = 0; i < reportDt.Rows.Count; i++)
                    {
                        string strName = reportDt.Rows[i]["StatName"].ToString();
                        strBuilderxAxisCategories.Append("'");
                        strBuilderxAxisCategories.Append(strName);
                        strBuilderxAxisCategories.Append("'");
                        strBuilderxAxisCategories.Append(",");
                    }
                    strBuilderxAxisCategories.Remove(strBuilderxAxisCategories.ToString().LastIndexOf(','), 1);
                    strBuilderxAxisCategories.Append("]");
                    XAxisCategories = strBuilderxAxisCategories.ToString();

                    lblAvgShow.Text = ddlSelectYear.SelectedItem.Value + "年" + "噪音平均大小为：" + String.Format("{0:N1}", float.Parse(avarageDt.Rows[0]["IndexAVG"].ToString()));
                    lblAvgShow.Visible = true;
                }

                if (indexKind == 3)
                {
                    StringBuilder strBuilderReturnValue = new StringBuilder();
                    strBuilderReturnValue.Append("[");
                    strBuilderReturnValue.Append("{name: 'PM2.5',data: [");

                    for (int i = 0; i < reportDt.Rows.Count; i++)
                    {
                        string strName = reportDt.Rows[i]["IndexAVG"].ToString();
                        strBuilderReturnValue.Append(strName);
                        strBuilderReturnValue.Append(",");
                    }
                    strBuilderReturnValue.Remove(strBuilderReturnValue.ToString().LastIndexOf(','), 1);
                    strBuilderReturnValue.Append("]}]");
                    ReturnValue = strBuilderReturnValue.ToString();


                    StringBuilder strBuilderxAxisCategories = new StringBuilder();
                    strBuilderxAxisCategories.Append("[");
                    for (int i = 0; i < reportDt.Rows.Count; i++)
                    {
                        string strName = reportDt.Rows[i]["StatName"].ToString();
                        strBuilderxAxisCategories.Append("'");
                        strBuilderxAxisCategories.Append(strName);
                        strBuilderxAxisCategories.Append("'");
                        strBuilderxAxisCategories.Append(",");
                    }
                    strBuilderxAxisCategories.Remove(strBuilderxAxisCategories.ToString().LastIndexOf(','), 1);
                    strBuilderxAxisCategories.Append("]");
                    XAxisCategories = strBuilderxAxisCategories.ToString();


                    lblAvgShow.Text = ddlSelectYear.SelectedItem.Value + "年" + "PM2.5平均浓度为：" + String.Format("{0:N1}", float.Parse(avarageDt.Rows[0]["IndexAVG"].ToString()) / 1000.0);
                    lblAvgShow.Visible = true;
                }

                if (indexKind == 4)
                {
                    StringBuilder strBuilderReturnValue = new StringBuilder();
                    strBuilderReturnValue.Append("[");
                    strBuilderReturnValue.Append("{name: 'PM10',data: [");

                    for (int i = 0; i < reportDt.Rows.Count; i++)
                    {
                        string strName = reportDt.Rows[i]["IndexAVG"].ToString();
                        strBuilderReturnValue.Append(strName);
                        strBuilderReturnValue.Append(",");
                    }
                    strBuilderReturnValue.Remove(strBuilderReturnValue.ToString().LastIndexOf(','), 1);
                    strBuilderReturnValue.Append("]}]");
                    ReturnValue = strBuilderReturnValue.ToString();


                    StringBuilder strBuilderxAxisCategories = new StringBuilder();
                    strBuilderxAxisCategories.Append("[");
                    for (int i = 0; i < reportDt.Rows.Count; i++)
                    {
                        string strName = reportDt.Rows[i]["StatName"].ToString();
                        strBuilderxAxisCategories.Append("'");
                        strBuilderxAxisCategories.Append(strName);
                        strBuilderxAxisCategories.Append("'");
                        strBuilderxAxisCategories.Append(",");
                    }
                    strBuilderxAxisCategories.Remove(strBuilderxAxisCategories.ToString().LastIndexOf(','), 1);
                    strBuilderxAxisCategories.Append("]");
                    XAxisCategories = strBuilderxAxisCategories.ToString();


                    lblAvgShow.Text = ddlSelectYear.SelectedItem.Value + "年" + "PM10平均浓度为：" + String.Format("{0:N1}", float.Parse(avarageDt.Rows[0]["IndexAVG"].ToString()) / 1000.0);
                    lblAvgShow.Visible = true;
                }
                lblShowError.Visible = false;
            }
            else
            {
                lblShowError.Text = "此阶时间段内无数据";
                lblShowError.Visible = true;
            }
        }

        protected void btnOutPutExcel_Click(object sender, EventArgs e)
        {
            _cityId = int.Parse(hiddencityId.Value.Trim());
            string strYear = ddlSelectYear.SelectedValue;
            string strDate = strYear + "-" + "01";
            DateTime startTime = DateTime.Parse(strDate);
            DateTime endTime = startTime.AddYears(1);
            int indexKind = Convert.ToInt16(ddlPolutionKind.SelectedValue);

            DataSet reportDs = _bll.GetList(1, startTime, endTime, indexKind, _cityId);
            DataTable dt = reportDs.Tables[0];

            string filename = "";
            if (indexKind == 1)
            {
                dt.Columns.Remove("Column1");
                dt.Columns[0].ColumnName = "工程名称";
                dt.Columns[1].ColumnName = "平均值(mg/m³)";
                dt.Columns[2].ColumnName = "最小值(mg/m³)";
                dt.Columns[3].ColumnName = "最大值(mg/m³)";
                dt.Columns[4].ColumnName = "有效天数";
                foreach (DataRow drRow in reportDs.Tables[0].Rows)
                {
                    drRow["平均值(mg/m³)"] = string.Format("{0:F}", (double)drRow["平均值(mg/m³)"] / 1000.0);
                    drRow["最小值(mg/m³)"] = string.Format("{0:F}", (double)drRow["最小值(mg/m³)"] / 1000.0);
                    drRow["最大值(mg/m³)"] = string.Format("{0:F}", (double)drRow["最大值(mg/m³)"] / 1000.0);
                }
                filename = string.Format("{0}年颗粒物浓度统计报表.xlsx", strYear);
            }
            else if (indexKind == 2)
            {
                dt.Columns.Remove("Column1");
                dt.Columns[0].ColumnName = "工程名称";
                dt.Columns[1].ColumnName = "平均值(dB)";
                dt.Columns[2].ColumnName = "最小值(dB)";
                dt.Columns[3].ColumnName = "最大值(dB)";
                dt.Columns[4].ColumnName = "有效天数";
                foreach (DataRow drRow in reportDs.Tables[0].Rows)
                {
                    drRow["平均值(dB)"] = string.Format("{0:F}", drRow["平均值(dB)"]);
                    drRow["最小值(dB)"] = string.Format("{0:F}", drRow["最小值(dB)"]);
                    drRow["最大值(dB)"] = string.Format("{0:F}", drRow["最大值(dB)"]);
                }
                filename = string.Format("{0}年噪音值统计报表.xlsx", strYear);
            }
            else if (indexKind == 3)
            {
                dt.Columns.Remove("Column1");
                dt.Columns[0].ColumnName = "工程名称";
                dt.Columns[1].ColumnName = "平均值(mg/m³)";
                dt.Columns[2].ColumnName = "最小值(mg/m³)";
                dt.Columns[3].ColumnName = "最大值(mg/m³)";
                dt.Columns[4].ColumnName = "有效天数";
                foreach (DataRow drRow in reportDs.Tables[0].Rows)
                {
                    drRow["平均值(mg/m³)"] = string.Format("{0:F}", (double)drRow["平均值(mg/m³)"] / 1000.0);
                    drRow["最小值(mg/m³)"] = string.Format("{0:F}", (double)drRow["最小值(mg/m³)"] / 1000.0);
                    drRow["最大值(mg/m³)"] = string.Format("{0:F}", (double)drRow["最大值(mg/m³)"] / 1000.0);
                }
                filename = string.Format("{0}年PM2.5浓度统计报表.xlsx", strYear);
            }
            else if (indexKind == 4)
            {
                dt.Columns.Remove("Column1");
                dt.Columns[0].ColumnName = "工程名称";
                dt.Columns[1].ColumnName = "平均值(mg/m³)";
                dt.Columns[2].ColumnName = "最小值(mg/m³)";
                dt.Columns[3].ColumnName = "最大值(mg/m³)";
                dt.Columns[4].ColumnName = "有效天数";
                foreach (DataRow drRow in reportDs.Tables[0].Rows)
                {
                    drRow["平均值(mg/m³)"] = string.Format("{0:F}", (double)drRow["平均值(mg/m³)"] / 1000.0);
                    drRow["最小值(mg/m³)"] = string.Format("{0:F}", (double)drRow["最小值(mg/m³)"] / 1000.0);
                    drRow["最大值(mg/m³)"] = string.Format("{0:F}", (double)drRow["最大值(mg/m³)"] / 1000.0);
                }
                filename = string.Format("{0}年PM10浓度统计报表.xlsx", strYear);
            }
            DumpExcel(dt, filename);
        }
        private void DumpExcel(DataTable tbl, string filename)
        {
            using (ExcelPackage pck = new ExcelPackage())
            {
                ExcelWorksheet ws = pck.Workbook.Worksheets.Add("年度统计报表");

                ws.Cells["A1"].LoadFromDataTable(tbl, true);

                using (ExcelRange rng = ws.Cells["A1:E1"])
                {
                    rng.Style.Font.Bold = true;
                    rng.Style.Fill.PatternType = ExcelFillStyle.Solid;
                    rng.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(107, 105, 107));
                    rng.Style.Font.Color.SetColor(Color.White);
                }

                ws.Column(1).Width = 35.0;
                ws.Column(2).Width = 12.0;
                ws.Column(3).Width = 12.0;
                ws.Column(4).Width = 12.0;
                Response.Clear();
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                if (Request.UserAgent != null && Request.UserAgent.Contains("IE"))
                {
                    Response.AppendHeader("content-disposition",
                        "attachment;  filename=" + HttpUtility.UrlEncode(filename, Encoding.UTF8));
                }
                else
                {
                    Response.AppendHeader("content-disposition", "attachment;  filename=" + filename);
                }
                Response.BinaryWrite(pck.GetAsByteArray());
                Response.End();
            }
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
        }
    }
}