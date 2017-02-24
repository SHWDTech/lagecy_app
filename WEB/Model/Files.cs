
using System;
namespace ESMonitor.Model
{
	/// <summary>
	/// Files:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Files
	{
		public Files()
		{}
		#region Model
		private int _id;
		private string _statcode;
		private DateTime? _captime;
		private int? _type;
		private string _filename;
		private string _path;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StatCode
		{
			set{ _statcode=value;}
			get{return _statcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CapTime
		{
			set{ _captime=value;}
			get{return _captime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Type
		{
			set{ _type=value;}
			get{return _type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FileName
		{
			set{ _filename=value;}
			get{return _filename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Path
		{
			set{ _path=value;}
			get{return _path;}
		}
		#endregion Model

	}
}

