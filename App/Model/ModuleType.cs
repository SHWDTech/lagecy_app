using System;
namespace ESMonitor.Model
{
	/// <summary>
	/// ModuleType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ModuleType
	{
	    #region Model
		private int _id;
		private string _name;
		private int _orders;
		private string _description;
		private int _superiorid;
		/// <summary>
		/// 模块分类ID
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 模块类型名称
		/// </summary>
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 排序
		/// </summary>
		public int Orders
		{
			set{ _orders=value;}
			get{return _orders;}
		}
		/// <summary>
		/// 说明
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 上级ID
		/// </summary>
		public int SuperiorId
		{
			set{ _superiorid=value;}
			get{return _superiorid;}
		}
		#endregion Model

	}
}

