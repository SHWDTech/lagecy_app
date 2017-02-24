using System;
namespace ESMonitor.Model
{
	/// <summary>
	/// Modules:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Modules
	{
		public Modules()
		{}
		#region Model
		private int _id;
		private int _typeid;
		private string _name;
		private string _tag;
		private string _description;
		private string _url;
		private bool _disabled;
		private int _orders;
		private bool _ismenu;
		/// <summary>
		/// 模块ID
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 模块类型
		/// </summary>
		public int TypeId
		{
			set{ _typeid=value;}
			get{return _typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tag
		{
			set{ _tag=value;}
			get{return _tag;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string URL
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool Disabled
		{
			set{ _disabled=value;}
			get{return _disabled;}
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
		/// 是否显示在导航菜单中
		/// </summary>
		public bool IsMenu
		{
			set{ _ismenu=value;}
			get{return _ismenu;}
		}
		#endregion Model

	}
}

