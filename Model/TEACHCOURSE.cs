using System;
namespace SSCS.Model
{
	/// <summary>
	/// TEACHCOURSE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEACHCOURSE
	{
		public TEACHCOURSE()
		{}
		#region Model
		private decimal _tc_id;
		private string _c_no;
		private string _t_no;
		private decimal _tc_maxnum;
		private decimal _tc_selectnum;
		private string _tc_place;
		private string _tc_week;
		private string _tc_coursenum;
		/// <summary>
		/// 
		/// </summary>
		public decimal TC_ID
		{
			set{ _tc_id=value;}
			get{return _tc_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_NO
		{
			set{ _c_no=value;}
			get{return _c_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string T_NO
		{
			set{ _t_no=value;}
			get{return _t_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal TC_MAXNUM
		{
			set{ _tc_maxnum=value;}
			get{return _tc_maxnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal TC_SELECTNUM
		{
			set{ _tc_selectnum=value;}
			get{return _tc_selectnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TC_PLACE
		{
			set{ _tc_place=value;}
			get{return _tc_place;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TC_WEEK
		{
			set{ _tc_week=value;}
			get{return _tc_week;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TC_COURSENUM
		{
			set{ _tc_coursenum=value;}
			get{return _tc_coursenum;}
		}
		#endregion Model

	}
}

