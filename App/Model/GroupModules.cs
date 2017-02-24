using System;
namespace ESMonitor.Model
{
	/// <summary>
	/// GroupModules:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class GroupModules
	{
	    #region Model
		private int _groupid;
		private int _moduleid;
		/// <summary>
		/// 
		/// </summary>
		public int GroupId
		{
			set{ _groupid=value;}
			get{return _groupid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ModuleId
		{
			set{ _moduleid=value;}
			get{return _moduleid;}
		}
		#endregion Model

	}
}

