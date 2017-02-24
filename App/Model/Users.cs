using System;
namespace ESMonitor.Model
{
	/// <summary>
	/// Users:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Users
	{
	    #region Model
		private int _userid;
		private string _username;
		private string _pwd;
		private string _mobile;
		private string _email;
		private int? _status=0;
		private DateTime _regtime= DateTime.Now;
		private int _roleid;
		private DateTime? _lasttime;
		private DateTime? _nowtime;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int UserId
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Pwd
		{
			set{ _pwd=value;}
			get{return _pwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mobile
		{
			set{ _mobile=value;}
			get{return _mobile;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime RegTime
		{
			set{ _regtime=value;}
			get{return _regtime;}
		}
		/// <summary>
		/// 角色Id
		/// </summary>
		public int RoleId
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LastTime
		{
			set{ _lasttime=value;}
			get{return _lasttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? NowTime
		{
			set{ _nowtime=value;}
			get{return _nowtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ReMark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

