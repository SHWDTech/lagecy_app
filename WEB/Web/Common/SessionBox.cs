using System;
using System.Collections.Generic;
using System.Collections;

namespace Web
{
    /// <summary>
    /// 用于读、写、删除、比较Session中的用户信息。
    /// </summary>
    [Serializable]
    public class SessionBox
    {
        private SessionBox(){}

        #region 用户Session操作

        /// <summary>
        /// 检测User Session是否存在
        /// </summary>
        /// <returns></returns>
        public static bool CheckUserSession()
        {
            object o = System.Web.HttpContext.Current.Session["USER"];
            if (o == null)
                return false;
            else
                return true;

        }

        /// <summary>
        /// 登记User Session
        /// </summary>
        /// <param name="userinfo"></param>
        public static void CreateUserSession(UserSession userinfo)
        {
            System.Web.HttpContext.Current.Session["USER"] = userinfo;
        }

        /// <summary>
        /// 获取User Session
        /// </summary>
        /// <returns></returns>
        public static UserSession GetUserSession()
        {
            object o = System.Web.HttpContext.Current.Session["USER"];
            if (o == null) throw new ExceptionSession("读取UserSession失败。");
            else return (o as UserSession);
        }

        /// <summary>
        /// 移除User Session
        /// </summary>
        public static void RemoveUserSession()
        {
            object o = System.Web.HttpContext.Current.Session["USER"];
            if (o != null) System.Web.HttpContext.Current.Session.Remove("User");
        }

        #endregion
    }
}
