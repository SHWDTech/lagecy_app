
using System;
namespace ESMonitor.Model
{
	/// <summary>
	/// Devs:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Devs
	{
	    #region Model
		private int _id;
		private string _devcode;
		private int _statid;
		private DateTime _starttime;
		private DateTime _preendtime;
		private DateTime _endtime;
		private int _devstatus;
		private string _videourl;
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
		public string DevCode
		{
			set{ _devcode=value;}
			get{return _devcode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int StatId
		{
			set{ _statid=value;}
			get{return _statid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime StartTime
		{
			set{ _starttime=value;}
			get{return _starttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime PreEndTime
		{
			set{ _preendtime=value;}
			get{return _preendtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime EndTime
		{
			set{ _endtime=value;}
			get{return _endtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int DevStatus
		{
			set{ _devstatus=value;}
			get{return _devstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VideoUrl
		{
			set{ _videourl=value;}
			get{return _videourl;}
		}
		#endregion Model

	}
}

