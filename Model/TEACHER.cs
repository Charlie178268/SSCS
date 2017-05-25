using System;
namespace SSCS.Model
{
	/// <summary>
	/// TEACHER:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class TEACHER
	{
		public TEACHER()
		{}
		#region Model
		private decimal _t_id;
		private string _t_name;
		private string _t_no;
		private string _t_sex;
		private string _t_password;
		private string _t_title;
		private decimal _t_isadmin;
		private string _t_department;
		private string _t_major;
		/// <summary>
		/// 
		/// </summary>
		public decimal T_ID
		{
			set{ _t_id=value;}
			get{return _t_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string T_NAME
		{
			set{ _t_name=value;}
			get{return _t_name;}
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
		public string T_SEX
		{
			set{ _t_sex=value;}
			get{return _t_sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string T_PASSWORD
		{
			set{ _t_password=value;}
			get{return _t_password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string T_TITLE
		{
			set{ _t_title=value;}
			get{return _t_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal T_ISADMIN
		{
			set{ _t_isadmin=value;}
			get{return _t_isadmin;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string T_DEPARTMENT
		{
			set{ _t_department=value;}
			get{return _t_department;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string T_MAJOR
		{
			set{ _t_major=value;}
			get{return _t_major;}
		}
		#endregion Model

	}
}

