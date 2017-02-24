
using System;
namespace ESMonitor.Model
{
	/// <summary>
	/// Stats:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Stats
	{
		#region Model
		private int _id;
		private string _statcode;
		private string _statname;
		private string _chargeman;
		private string _telepone;
		private double _longitude;
		private double _latitude;
		private string _department;
		private string _address;
		private string _country;
		private string _street;
		private double _square;
		private DateTime _prostarttime;
		private int _stage;
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
		public string StatName
		{
			set{ _statname=value;}
			get{return _statname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ChargeMan
		{
			set{ _chargeman=value;}
			get{return _chargeman;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Telepone
		{
			set{ _telepone=value;}
			get{return _telepone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double Longitude
		{
			set{ _longitude=value;}
			get{return _longitude;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double Latitude
		{
			set { _latitude = value; }
			get { return _latitude; }
		}
		
		/// <summary>
		/// 
		/// </summary>
		public string Department
		{
			set{ _department=value;}
			get{return _department;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Country
		{
			set{ _country=value;}
			get{return _country;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Street
		{
			set{ _street=value;}
			get{return _street;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double Square
		{
			set{ _square=value;}
			get{return _square;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ProStartTime
		{
			set{ _prostarttime=value;}
			get{return _prostarttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Stage
		{
			set{ _stage=value;}
			get{return _stage;}
		}
		#endregion Model

	}
}

