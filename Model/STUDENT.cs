using System;
namespace SSCS.Model
{
	/// <summary>
	/// STUDENT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class STUDENT
	{
		public STUDENT()
		{}
		#region Model
		private decimal _s_id;
		private string _s_name;
		private string _s_no;
		private DateTime _s_birthday;
		private string _s_sex;
		private string _s_class;
		private string _s_department;
		private string _s_major;
		private string _s_grade;
		private string _s_note;
		private DateTime _s_rdate;
		private string _s_type;
		private decimal _s_maxcourse;
		private decimal _s_selectcourse;
		private string _s_password;
		/// <summary>
		/// 
		/// </summary>
		public decimal S_ID
		{
			set{ _s_id=value;}
			get{return _s_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string S_NAME
		{
			set{ _s_name=value;}
			get{return _s_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string S_NO
		{
			set{ _s_no=value;}
			get{return _s_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime S_BIRTHDAY
		{
			set{ _s_birthday=value;}
			get{return _s_birthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string S_SEX
		{
			set{ _s_sex=value;}
			get{return _s_sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string S_CLASS
		{
			set{ _s_class=value;}
			get{return _s_class;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string S_DEPARTMENT
		{
			set{ _s_department=value;}
			get{return _s_department;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string S_MAJOR
		{
			set{ _s_major=value;}
			get{return _s_major;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string S_GRADE
		{
			set{ _s_grade=value;}
			get{return _s_grade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string S_NOTE
		{
			set{ _s_note=value;}
			get{return _s_note;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime S_RDATE
		{
			set{ _s_rdate=value;}
			get{return _s_rdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string S_TYPE
		{
			set{ _s_type=value;}
			get{return _s_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal S_MAXCOURSE
		{
			set{ _s_maxcourse=value;}
			get{return _s_maxcourse;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal S_SELECTCOURSE
		{
			set{ _s_selectcourse=value;}
			get{return _s_selectcourse;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string S_PASSWORD
		{
			set{ _s_password=value;}
			get{return _s_password;}
		}
		#endregion Model

	}
}

