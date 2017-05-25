using System;
namespace SSCS.Model
{
	/// <summary>
	/// COURSE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class COURSE
	{
		public COURSE()
		{}
		#region Model
		private decimal _c_id;
		private string _c_no;
		private decimal _c_score;
		private string _c_name;
		private string _c_grade;
		private string _c_term;
		private string _c_desciption;
		/// <summary>
		/// 
		/// </summary>
		public decimal C_ID
		{
			set{ _c_id=value;}
			get{return _c_id;}
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
		public decimal C_SCORE
		{
			set{ _c_score=value;}
			get{return _c_score;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_NAME
		{
			set{ _c_name=value;}
			get{return _c_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_GRADE
		{
			set{ _c_grade=value;}
			get{return _c_grade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_TERM
		{
			set{ _c_term=value;}
			get{return _c_term;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string C_DESCIPTION
		{
			set{ _c_desciption=value;}
			get{return _c_desciption;}
		}
		#endregion Model

	}
}

