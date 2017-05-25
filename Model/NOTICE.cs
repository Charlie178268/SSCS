using System;
namespace SSCS.Model
{
	/// <summary>
	/// NOTICE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NOTICE
	{
		public NOTICE()
		{}
		#region Model
		private decimal _n_id;
		private string _n_title;
		private string _n_author;
		private string _n_content;
		private DateTime _n_date;
		/// <summary>
		/// 
		/// </summary>
		public decimal N_ID
		{
			set{ _n_id=value;}
			get{return _n_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string N_TITLE
		{
			set{ _n_title=value;}
			get{return _n_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string N_AUTHOR
		{
			set{ _n_author=value;}
			get{return _n_author;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string N_CONTENT
		{
			set{ _n_content=value;}
			get{return _n_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime N_DATE
		{
			set{ _n_date=value;}
			get{return _n_date;}
		}
		#endregion Model

	}
}

