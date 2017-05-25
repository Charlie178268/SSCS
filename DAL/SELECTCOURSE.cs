using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace SSCS.DAL
{
	/// <summary>
	/// 数据访问类:SELECTCOURSE
	/// </summary>
	public partial class SELECTCOURSE
	{
		public SELECTCOURSE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal SC_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SELECTCOURSE");
			strSql.Append(" where SC_ID=:SC_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":SC_ID", OracleType.Number,22)			};
			parameters[0].Value = SC_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SSCS.Model.SELECTCOURSE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SELECTCOURSE(");
			strSql.Append("SC_ID,S_NO,C_NO)");
			strSql.Append(" values (");
			strSql.Append(":SC_ID,:S_NO,:C_NO)");
			OracleParameter[] parameters = {
					new OracleParameter(":SC_ID", OracleType.Number,4),
					new OracleParameter(":S_NO", OracleType.Number,4),
					new OracleParameter(":C_NO", OracleType.Number,4)};
			parameters[0].Value = model.SC_ID;
			parameters[1].Value = model.S_NO;
			parameters[2].Value = model.C_NO;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SSCS.Model.SELECTCOURSE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SELECTCOURSE set ");
			strSql.Append("SC_ID=:SC_ID,");
			strSql.Append("S_NO=:S_NO,");
			strSql.Append("C_NO=:C_NO");
			strSql.Append(" where SC_ID=:SC_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":SC_ID", OracleType.Number,4),
					new OracleParameter(":S_NO", OracleType.Number,4),
					new OracleParameter(":C_NO", OracleType.Number,4)};
			parameters[0].Value = model.SC_ID;
			parameters[1].Value = model.S_NO;
			parameters[2].Value = model.C_NO;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal SC_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SELECTCOURSE ");
			strSql.Append(" where SC_ID=:SC_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":SC_ID", OracleType.Number,22)			};
			parameters[0].Value = SC_ID;

			int rows=DbHelperOra.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string SC_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SELECTCOURSE ");
			strSql.Append(" where SC_ID in ("+SC_IDlist + ")  ");
			int rows=DbHelperOra.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SSCS.Model.SELECTCOURSE GetModel(decimal SC_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SC_ID,S_NO,C_NO from SELECTCOURSE ");
			strSql.Append(" where SC_ID=:SC_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":SC_ID", OracleType.Number,22)			};
			parameters[0].Value = SC_ID;

			SSCS.Model.SELECTCOURSE model=new SSCS.Model.SELECTCOURSE();
			DataSet ds=DbHelperOra.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SSCS.Model.SELECTCOURSE DataRowToModel(DataRow row)
		{
			SSCS.Model.SELECTCOURSE model=new SSCS.Model.SELECTCOURSE();
			if (row != null)
			{
				if(row["SC_ID"]!=null && row["SC_ID"].ToString()!="")
				{
					model.SC_ID=decimal.Parse(row["SC_ID"].ToString());
				}
				if(row["S_NO"]!=null && row["S_NO"].ToString()!="")
				{
					model.S_NO=decimal.Parse(row["S_NO"].ToString());
				}
				if(row["C_NO"]!=null && row["C_NO"].ToString()!="")
				{
					model.C_NO=decimal.Parse(row["C_NO"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select SC_ID,S_NO,C_NO ");
			strSql.Append(" FROM SELECTCOURSE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOra.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM SELECTCOURSE ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.SC_ID desc");
			}
			strSql.Append(")AS Row, T.*  from SELECTCOURSE T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperOra.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			OracleParameter[] parameters = {
					new OracleParameter(":tblName", OracleType.VarChar, 255),
					new OracleParameter(":fldName", OracleType.VarChar, 255),
					new OracleParameter(":PageSize", OracleType.Number),
					new OracleParameter(":PageIndex", OracleType.Number),
					new OracleParameter(":IsReCount", OracleType.Clob),
					new OracleParameter(":OrderType", OracleType.Clob),
					new OracleParameter(":strWhere", OracleType.VarChar,1000),
					};
			parameters[0].Value = "SELECTCOURSE";
			parameters[1].Value = "SC_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

