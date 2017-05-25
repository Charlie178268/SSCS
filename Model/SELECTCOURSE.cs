using System;
namespace SSCS.Model
{
	/// <summary>
	/// SELECTCOURSE:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SELECTCOURSE
	{
		public SELECTCOURSE()
		{}
		#region Model
		private decimal _sc_id;
		private decimal _s_no;
		private decimal _c_no;
		/// <summary>
		/// 
		/// </summary>
		public decimal SC_ID
		{
			set{ _sc_id=value;}
			get{return _sc_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal S_NO
		{
			set{ _s_no=value;}
			get{return _s_no;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal C_NO
		{
			set{ _c_no=value;}
			get{return _c_no;}
		}
		#endregion Model

	}
}

