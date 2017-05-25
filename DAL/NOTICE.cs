using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace SSCS.DAL
{
	/// <summary>
	/// 数据访问类:NOTICE
	/// </summary>
	public partial class NOTICE
	{
		public NOTICE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal N_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from NOTICE");
			strSql.Append(" where N_ID=:N_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":N_ID", OracleType.Number,22)			};
			parameters[0].Value = N_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SSCS.Model.NOTICE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into NOTICE(");
			strSql.Append("N_ID,N_TITLE,N_AUTHOR,N_CONTENT,N_DATE)");
			strSql.Append(" values (");
			strSql.Append(":N_ID,:N_TITLE,:N_AUTHOR,:N_CONTENT,:N_DATE)");
			OracleParameter[] parameters = {
					new OracleParameter(":N_ID", OracleType.Number,4),
					new OracleParameter(":N_TITLE", OracleType.VarChar,50),
					new OracleParameter(":N_AUTHOR", OracleType.VarChar,50),
					new OracleParameter(":N_CONTENT", OracleType.VarChar,1000),
					new OracleParameter(":N_DATE", OracleType.DateTime)};
			parameters[0].Value = model.N_ID;
			parameters[1].Value = model.N_TITLE;
			parameters[2].Value = model.N_AUTHOR;
			parameters[3].Value = model.N_CONTENT;
			parameters[4].Value = model.N_DATE;

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
		public bool Update(SSCS.Model.NOTICE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update NOTICE set ");
			strSql.Append("N_ID=:N_ID,");
			strSql.Append("N_TITLE=:N_TITLE,");
			strSql.Append("N_AUTHOR=:N_AUTHOR,");
			strSql.Append("N_CONTENT=:N_CONTENT,");
			strSql.Append("N_DATE=:N_DATE");
			strSql.Append(" where N_ID=:N_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":N_ID", OracleType.Number,4),
					new OracleParameter(":N_TITLE", OracleType.VarChar,50),
					new OracleParameter(":N_AUTHOR", OracleType.VarChar,50),
					new OracleParameter(":N_CONTENT", OracleType.VarChar,1000),
					new OracleParameter(":N_DATE", OracleType.DateTime)};
			parameters[0].Value = model.N_ID;
			parameters[1].Value = model.N_TITLE;
			parameters[2].Value = model.N_AUTHOR;
			parameters[3].Value = model.N_CONTENT;
			parameters[4].Value = model.N_DATE;

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
		public bool Delete(decimal N_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NOTICE ");
			strSql.Append(" where N_ID=:N_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":N_ID", OracleType.Number,22)			};
			parameters[0].Value = N_ID;

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
		public bool DeleteList(string N_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from NOTICE ");
			strSql.Append(" where N_ID in ("+N_IDlist + ")  ");
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
		public SSCS.Model.NOTICE GetModel(decimal N_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select N_ID,N_TITLE,N_AUTHOR,N_CONTENT,N_DATE from NOTICE ");
			strSql.Append(" where N_ID=:N_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":N_ID", OracleType.Number,22)			};
			parameters[0].Value = N_ID;

			SSCS.Model.NOTICE model=new SSCS.Model.NOTICE();
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
		public SSCS.Model.NOTICE DataRowToModel(DataRow row)
		{
			SSCS.Model.NOTICE model=new SSCS.Model.NOTICE();
			if (row != null)
			{
				if(row["N_ID"]!=null && row["N_ID"].ToString()!="")
				{
					model.N_ID=decimal.Parse(row["N_ID"].ToString());
				}
				if(row["N_TITLE"]!=null)
				{
					model.N_TITLE=row["N_TITLE"].ToString();
				}
				if(row["N_AUTHOR"]!=null)
				{
					model.N_AUTHOR=row["N_AUTHOR"].ToString();
				}
				if(row["N_CONTENT"]!=null)
				{
					model.N_CONTENT=row["N_CONTENT"].ToString();
				}
				if(row["N_DATE"]!=null && row["N_DATE"].ToString()!="")
				{
					model.N_DATE=DateTime.Parse(row["N_DATE"].ToString());
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
			strSql.Append("select N_ID,N_TITLE,N_AUTHOR,N_CONTENT,N_DATE ");
			strSql.Append(" FROM NOTICE ");
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
			strSql.Append("select count(1) FROM NOTICE ");
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
				strSql.Append("order by T.N_ID desc");
			}
			strSql.Append(")AS Row, T.*  from NOTICE T ");
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
			parameters[0].Value = "NOTICE";
			parameters[1].Value = "N_ID";
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

