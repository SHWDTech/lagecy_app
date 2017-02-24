/**************************************
* 作用：系统Session处理
**************************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Web;

namespace Web
{
    /// <summary>
    /// 储存在Session中的已登录会员的基本信息。
    /// </summary>
    [Serializable]
    public class UserSession
    {
        public int UserId;
        public string UserName;
        public int RoleId;
        public string CountryId;
        
        /// <summary>
        /// 初始化用户登录Session
        /// </summary>
        /// <param name="_userId">用户ID</param>
        /// <param name="_username">用户名</param>
        /// <param name="_roleid">角色ID</param>
        /// <param name="authDic">管辖区县</param>
        public UserSession(int _userId, string _username, int _roleid, string _countryId)
        {
            this.UserId = _userId;
            this.UserName = _username;
            this.RoleId = _roleid;
            this.CountryId = _countryId;
        }
    }
}
