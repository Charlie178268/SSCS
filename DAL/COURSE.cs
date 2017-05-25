using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace SSCS.DAL
{
	/// <summary>
	/// 数据访问类:COURSE
	/// </summary>
	public partial class COURSE
	{
		public COURSE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal C_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from COURSE");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleType.Number,22)			};
			parameters[0].Value = C_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SSCS.Model.COURSE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into COURSE(");
			strSql.Append("C_ID,C_NO,C_SCORE,C_NAME,C_GRADE,C_TERM,C_DESCIPTION)");
			strSql.Append(" values (");
			strSql.Append(":C_ID,:C_NO,:C_SCORE,:C_NAME,:C_GRADE,:C_TERM,:C_DESCIPTION)");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleType.Number,4),
					new OracleParameter(":C_NO", OracleType.Char,10),
					new OracleParameter(":C_SCORE", OracleType.Number,4),
					new OracleParameter(":C_NAME", OracleType.VarChar,50),
					new OracleParameter(":C_GRADE", OracleType.VarChar,20),
					new OracleParameter(":C_TERM", OracleType.VarChar,20),
					new OracleParameter(":C_DESCIPTION", OracleType.VarChar,800)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_NO;
			parameters[2].Value = model.C_SCORE;
			parameters[3].Value = model.C_NAME;
			parameters[4].Value = model.C_GRADE;
			parameters[5].Value = model.C_TERM;
			parameters[6].Value = model.C_DESCIPTION;

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
		public bool Update(SSCS.Model.COURSE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update COURSE set ");
			strSql.Append("C_ID=:C_ID,");
			strSql.Append("C_NO=:C_NO,");
			strSql.Append("C_SCORE=:C_SCORE,");
			strSql.Append("C_NAME=:C_NAME,");
			strSql.Append("C_GRADE=:C_GRADE,");
			strSql.Append("C_TERM=:C_TERM,");
			strSql.Append("C_DESCIPTION=:C_DESCIPTION");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleType.Number,4),
					new OracleParameter(":C_NO", OracleType.Char,10),
					new OracleParameter(":C_SCORE", OracleType.Number,4),
					new OracleParameter(":C_NAME", OracleType.VarChar,50),
					new OracleParameter(":C_GRADE", OracleType.VarChar,20),
					new OracleParameter(":C_TERM", OracleType.VarChar,20),
					new OracleParameter(":C_DESCIPTION", OracleType.VarChar,800)};
			parameters[0].Value = model.C_ID;
			parameters[1].Value = model.C_NO;
			parameters[2].Value = model.C_SCORE;
			parameters[3].Value = model.C_NAME;
			parameters[4].Value = model.C_GRADE;
			parameters[5].Value = model.C_TERM;
			parameters[6].Value = model.C_DESCIPTION;

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
		public bool Delete(decimal C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from COURSE ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleType.Number,22)			};
			parameters[0].Value = C_ID;

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
		public bool DeleteList(string C_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from COURSE ");
			strSql.Append(" where C_ID in ("+C_IDlist + ")  ");
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
		public SSCS.Model.COURSE GetModel(decimal C_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select C_ID,C_NO,C_SCORE,C_NAME,C_GRADE,C_TERM,C_DESCIPTION from COURSE ");
			strSql.Append(" where C_ID=:C_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":C_ID", OracleType.Number,22)			};
			parameters[0].Value = C_ID;

			SSCS.Model.COURSE model=new SSCS.Model.COURSE();
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
		public SSCS.Model.COURSE DataRowToModel(DataRow row)
		{
			SSCS.Model.COURSE model=new SSCS.Model.COURSE();
			if (row != null)
			{
				if(row["C_ID"]!=null && row["C_ID"].ToString()!="")
				{
					model.C_ID=decimal.Parse(row["C_ID"].ToString());
				}
				if(row["C_NO"]!=null)
				{
					model.C_NO=row["C_NO"].ToString();
				}
				if(row["C_SCORE"]!=null && row["C_SCORE"].ToString()!="")
				{
					model.C_SCORE=decimal.Parse(row["C_SCORE"].ToString());
				}
				if(row["C_NAME"]!=null)
				{
					model.C_NAME=row["C_NAME"].ToString();
				}
				if(row["C_GRADE"]!=null)
				{
					model.C_GRADE=row["C_GRADE"].ToString();
				}
				if(row["C_TERM"]!=null)
				{
					model.C_TERM=row["C_TERM"].ToString();
				}
				if(row["C_DESCIPTION"]!=null)
				{
					model.C_DESCIPTION=row["C_DESCIPTION"].ToString();
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
			strSql.Append("select C_ID,C_NO,C_SCORE,C_NAME,C_GRADE,C_TERM,C_DESCIPTION ");
			strSql.Append(" FROM COURSE ");
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
			strSql.Append("select count(1) FROM COURSE ");
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
				strSql.Append("order by T.C_ID desc");
			}
			strSql.Append(")AS Row, T.*  from COURSE T ");
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
			parameters[0].Value = "COURSE";
			parameters[1].Value = "C_ID";
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

