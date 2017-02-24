using System;
namespace ESMonitor.Model
{
	/// <summary>
	/// UserGroup:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class UserGroup
	{
		public UserGroup()
		{}
		#region Model
		private int _id;
		private string _name;
		private int _orders;
		private string _description;
		/// <summary>
		/// 用户组ID
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 用户分组名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Orders
		{
			set{ _orders=value;}
			get{return _orders;}
		}
		/// <summary>
		/// 用户分组描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		#endregion Model

	}
}

