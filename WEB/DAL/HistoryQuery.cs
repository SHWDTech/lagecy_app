using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using ESMonitor.DAL;

namespace ESMonitor.DAL
{
    public partial class HistoryQuery
    {
        public HistoryQuery()
        { }
        public DataSet GetSearchResualt(int selectControl,int devId, DateTime statetime, DateTime endtime) //获取增加条件的收索结果
        {
            SqlParameter[] parameters = { new SqlParameter("@selectControl", SqlDbType.Int) ,
                                          new SqlParameter("@devId", SqlDbType.Int) ,
                                          new SqlParameter("@statetime",SqlDbType.DateTime),
                                          new SqlParameter("@endtime ",SqlDbType.DateTime)
                                          };
            parameters[0].Value = selectControl;
            parameters[1].Value = devId;
            parameters[2].Value = statetime;
            parameters[3].Value = endtime;

            return DbHelperSQL.RunProcedure("T_SelectAverageData", parameters, "ds");

        }
        public DataSet GetSearchResualt1(int selectControl, int devId, DateTime statetime, DateTime endtime) //获取增加条件的收索结果
        {
            SqlParameter[] parameters = { new SqlParameter("@selectControl", SqlDbType.Int) ,
                                          new SqlParameter("@devId", SqlDbType.Int) ,
                                          new SqlParameter("@statetime",SqlDbType.DateTime),
                                          new SqlParameter("@endtime ",SqlDbType.DateTime)
                                          };
            parameters[0].Value = selectControl;
            parameters[1].Value = devId;
            parameters[2].Value = statetime;
            parameters[3].Value = endtime;

            return DbHelperSQL.RunProcedure("T_InsertTable", parameters, "ds");

        }

        public DataSet GetList(int selectControl, DateTime statetime, DateTime endtime, int indexKind, int country) 
        {
            SqlParameter[] parameters = { new SqlParameter("@selectControl", SqlDbType.Int,4) ,
                                          new SqlParameter("@statetime ", SqlDbType.DateTime) ,
                                          new SqlParameter("@endtime",SqlDbType.DateTime),
                                          new SqlParameter("@indexKind",SqlDbType.Int,4),
                                          new SqlParameter("@country", SqlDbType.Int,4), 
                                          };
            parameters[0].Value = selectControl;
            parameters[1].Value = statetime;
            parameters[2].Value = endtime;
            parameters[3].Value = indexKind;
            parameters[4].Value = country;
            return DbHelperSQL.RunProcedure("T_ProduceReport", parameters, "ds");
        }

        
        public DataSet GetAvgNoiseList(int statisType, string strWhere)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };
            
            string procedureName = "";
            switch (statisType)
            {
                case 1:
                    procedureName = "T_ESMin_GetAvgNoiseList";
                    break;
                case 2:
                    procedureName = "T_ESHour_GetAvgNoiseList";
                    break;
                default:
                    procedureName = "T_ESDay_GetAvgNoiseList";
                    break;
            }
            parameters[0].Value = strWhere;

            return DbHelperSQL.RunProcedure(procedureName, parameters, "ds");
        }

        public DataSet GetAvgCMPList(int statisType, string strWhere)
        {
            SqlParameter[] parameters = { 
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };
            parameters[0].Value = strWhere;
            
            string procedureName = "";
            switch (statisType)
            {
                case 1:
                    procedureName = "T_ESMin_GetAvgCMPList";
                    break;
                case 2:
                    procedureName = "T_ESHour_GetAvgCMPList";
                    break;
                default:
                    procedureName = "T_ESDay_GetAvgCMPList";
                    break;
            }

            return DbHelperSQL.RunProcedure(procedureName, parameters, "ds");
        }

        public DataSet GetAvgCMPOrderList(int statisType, string country, string strWhere)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Country", SqlDbType.VarChar,20),
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };

            parameters[0].Value = country;
            parameters[1].Value = strWhere;

            string procedureName = "";
            switch (statisType)
            {
                case 1:
                    procedureName = "T_ESMin_GetAvgCMPOrderList";
                    break;
                case 2:
                    procedureName = "T_ESHour_GetAvgCMPOrderList";
                    break;
                default:
                    procedureName = "T_ESDay_GetAvgCMPOrderList";
                    break;
            }

            return DbHelperSQL.RunProcedure(procedureName, parameters, "ds");
        }

        public DataSet GetAvgNoiseOrderList(int statisType, string country, string strWhere)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Country", SqlDbType.VarChar,20),
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };

            parameters[0].Value = country;
            parameters[1].Value = strWhere;

            string procedureName = "";
            switch (statisType)
            {
                case 1:
                    procedureName = "T_ESMin_GetAvgNoiseOrderList";
                    break;
                case 2:
                    procedureName = "T_ESHour_GetAvgNoiseOrderList";
                    break;
                default:
                    procedureName = "T_ESDay_GetAvgNoiseOrderList";
                    break;
            }

            return DbHelperSQL.RunProcedure(procedureName, parameters, "ds");
        }

        public DataSet GetAvgCMPStatList(int statisType, string country, string strWhere)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Country", SqlDbType.VarChar,20),
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };

            parameters[0].Value = country;
            parameters[1].Value = strWhere;

            string procedureName = "";
            switch (statisType)
            {
                case 1:
                    procedureName = "T_ESMin_GetAvgCMPStatList";
                    break;
                case 2:
                    procedureName = "T_ESHour_GetAvgCMPStatList";
                    break;
                default:
                    procedureName = "T_ESDay_GetAvgCMPStatList";
                    break;
            }

            return DbHelperSQL.RunProcedure(procedureName, parameters, "ds");
        }

        public DataSet GetAvgNoiseStatList(int statisType, string country, string strWhere)
        {
            SqlParameter[] parameters = {
                new SqlParameter("@Country", SqlDbType.VarChar,20),
                new SqlParameter("@strWhere", SqlDbType.VarChar,1000)
            };

            parameters[0].Value = country;
            parameters[1].Value = strWhere;

            string procedureName = "";
            switch (statisType)
            {
                case 1:
                    procedureName = "T_ESMin_GetAvgNoiseStatList";
                    break;
                case 2:
                    procedureName = "T_ESHour_GetAvgNoiseStatList";
                    break;
                default:
                    procedureName = "T_ESDay_GetAvgNoiseStatList";
                    break;
            }

            return DbHelperSQL.RunProcedure(procedureName, parameters, "ds");
        } 
    }


//    public partial class AlertManage
//    {
//        public AlertManage()
//        { }



//        public DataSet GetAllSearch(int FaultTypeForContol)//获取全部的单灯控制器的故障
//        {
//            SqlParameter[] parameters = { new SqlParameter("@FaultTypeForContol", SqlDbType.Int) };
//            parameters[0].Value = FaultTypeForContol;
//            return DbHelperSQL.RunProcedure("T_Fault_GetList", parameters, "ds");
//        }
//        public DataSet GetAlertByTypes(int catalog)//获取所有的故障类型
//        {
//            SqlParameter[] parameters = { new SqlParameter("@catalog", SqlDbType.Int) };
//            parameters[0].Value = catalog;
//            return DbHelperSQL.RunProcedure("T_Alert_GetTypes", parameters, "ds");
//        }

//        public DataSet GetSearchResualt(string strWhere, int PageSize, int PageIndex, int AlertTypeForContol) //获取增加条件的收索结果
//        {
//            SqlParameter[] parameters = { new SqlParameter("@strWhere", SqlDbType.VarChar, 1000) ,
//                                          new SqlParameter("@AlertTypeForContol",SqlDbType.Int),
//                                          new SqlParameter("@PageSize ",SqlDbType.Int),
//                                          new SqlParameter("@PageIndex",SqlDbType.Int)
//                                          };
//            parameters[0].Value = strWhere;
//            parameters[1].Value = AlertTypeForContol;
//            parameters[2].Value = PageSize;
//            parameters[3].Value = PageIndex;
//            return DbHelperSQL.RunProcedure("T_Alert_GetList", parameters, "ds");
//        }
//        public int GetRecordCount(string strWhere)
//        {
//            StringBuilder strSql = new StringBuilder();
//            strSql.Append(@"select  count(1)  from  T_LEDAlert T1 inner join T_LEDControls T2 on T1.LEDAddr=T2.Addr inner join T_AlertType  T3 on T1.AlertCatalog=T3.TypeId
//                   inner join T_LocalControls T4 on T1.LocalAddr=T4.Addr  inner join T_Nodes T5 on T1.AddressId=T5.Id ");
//            if (strWhere.Trim() != "")
//            {
//                strSql.Append(" where " + strWhere);
//            }
//            object obj = DbHelperSQL.GetSingle(strSql.ToString());
//            if (obj == null)
//            {
//                return 0;
//            }
//            else
//            {
//                return Convert.ToInt32(obj);
//            }
//        }
//    }
}
