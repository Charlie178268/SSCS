using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace SSCS.DAL
{
	/// <summary>
	/// 数据访问类:TEACHCOURSE
	/// </summary>
	public partial class TEACHCOURSE
	{
		public TEACHCOURSE()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal TC_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TEACHCOURSE");
			strSql.Append(" where TC_ID=:TC_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":TC_ID", OracleType.Number,22)			};
			parameters[0].Value = TC_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SSCS.Model.TEACHCOURSE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TEACHCOURSE(");
			strSql.Append("TC_ID,C_NO,T_NO,TC_MAXNUM,TC_SELECTNUM,TC_PLACE,TC_WEEK,TC_COURSENUM)");
			strSql.Append(" values (");
			strSql.Append(":TC_ID,:C_NO,:T_NO,:TC_MAXNUM,:TC_SELECTNUM,:TC_PLACE,:TC_WEEK,:TC_COURSENUM)");
			OracleParameter[] parameters = {
					new OracleParameter(":TC_ID", OracleType.Number,4),
					new OracleParameter(":C_NO", OracleType.Char,10),
					new OracleParameter(":T_NO", OracleType.Char,10),
					new OracleParameter(":TC_MAXNUM", OracleType.Number,4),
					new OracleParameter(":TC_SELECTNUM", OracleType.Number,4),
					new OracleParameter(":TC_PLACE", OracleType.VarChar,50),
					new OracleParameter(":TC_WEEK", OracleType.VarChar,20),
					new OracleParameter(":TC_COURSENUM", OracleType.VarChar,20)};
			parameters[0].Value = model.TC_ID;
			parameters[1].Value = model.C_NO;
			parameters[2].Value = model.T_NO;
			parameters[3].Value = model.TC_MAXNUM;
			parameters[4].Value = model.TC_SELECTNUM;
			parameters[5].Value = model.TC_PLACE;
			parameters[6].Value = model.TC_WEEK;
			parameters[7].Value = model.TC_COURSENUM;

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
		public bool Update(SSCS.Model.TEACHCOURSE model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TEACHCOURSE set ");
			strSql.Append("TC_ID=:TC_ID,");
			strSql.Append("C_NO=:C_NO,");
			strSql.Append("T_NO=:T_NO,");
			strSql.Append("TC_MAXNUM=:TC_MAXNUM,");
			strSql.Append("TC_SELECTNUM=:TC_SELECTNUM,");
			strSql.Append("TC_PLACE=:TC_PLACE,");
			strSql.Append("TC_WEEK=:TC_WEEK,");
			strSql.Append("TC_COURSENUM=:TC_COURSENUM");
			strSql.Append(" where TC_ID=:TC_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":TC_ID", OracleType.Number,4),
					new OracleParameter(":C_NO", OracleType.Char,10),
					new OracleParameter(":T_NO", OracleType.Char,10),
					new OracleParameter(":TC_MAXNUM", OracleType.Number,4),
					new OracleParameter(":TC_SELECTNUM", OracleType.Number,4),
					new OracleParameter(":TC_PLACE", OracleType.VarChar,50),
					new OracleParameter(":TC_WEEK", OracleType.VarChar,20),
					new OracleParameter(":TC_COURSENUM", OracleType.VarChar,20)};
			parameters[0].Value = model.TC_ID;
			parameters[1].Value = model.C_NO;
			parameters[2].Value = model.T_NO;
			parameters[3].Value = model.TC_MAXNUM;
			parameters[4].Value = model.TC_SELECTNUM;
			parameters[5].Value = model.TC_PLACE;
			parameters[6].Value = model.TC_WEEK;
			parameters[7].Value = model.TC_COURSENUM;

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
		public bool Delete(decimal TC_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TEACHCOURSE ");
			strSql.Append(" where TC_ID=:TC_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":TC_ID", OracleType.Number,22)			};
			parameters[0].Value = TC_ID;

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
		public bool DeleteList(string TC_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TEACHCOURSE ");
			strSql.Append(" where TC_ID in ("+TC_IDlist + ")  ");
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
		public SSCS.Model.TEACHCOURSE GetModel(decimal TC_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select TC_ID,C_NO,T_NO,TC_MAXNUM,TC_SELECTNUM,TC_PLACE,TC_WEEK,TC_COURSENUM from TEACHCOURSE ");
			strSql.Append(" where TC_ID=:TC_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":TC_ID", OracleType.Number,22)			};
			parameters[0].Value = TC_ID;

			SSCS.Model.TEACHCOURSE model=new SSCS.Model.TEACHCOURSE();
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
		public SSCS.Model.TEACHCOURSE DataRowToModel(DataRow row)
		{
			SSCS.Model.TEACHCOURSE model=new SSCS.Model.TEACHCOURSE();
			if (row != null)
			{
				if(row["TC_ID"]!=null && row["TC_ID"].ToString()!="")
				{
					model.TC_ID=decimal.Parse(row["TC_ID"].ToString());
				}
				if(row["C_NO"]!=null)
				{
					model.C_NO=row["C_NO"].ToString();
				}
				if(row["T_NO"]!=null)
				{
					model.T_NO=row["T_NO"].ToString();
				}
				if(row["TC_MAXNUM"]!=null && row["TC_MAXNUM"].ToString()!="")
				{
					model.TC_MAXNUM=decimal.Parse(row["TC_MAXNUM"].ToString());
				}
				if(row["TC_SELECTNUM"]!=null && row["TC_SELECTNUM"].ToString()!="")
				{
					model.TC_SELECTNUM=decimal.Parse(row["TC_SELECTNUM"].ToString());
				}
				if(row["TC_PLACE"]!=null)
				{
					model.TC_PLACE=row["TC_PLACE"].ToString();
				}
				if(row["TC_WEEK"]!=null)
				{
					model.TC_WEEK=row["TC_WEEK"].ToString();
				}
				if(row["TC_COURSENUM"]!=null)
				{
					model.TC_COURSENUM=row["TC_COURSENUM"].ToString();
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
			strSql.Append("select TC_ID,C_NO,T_NO,TC_MAXNUM,TC_SELECTNUM,TC_PLACE,TC_WEEK,TC_COURSENUM ");
			strSql.Append(" FROM TEACHCOURSE ");
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
			strSql.Append("select count(1) FROM TEACHCOURSE ");
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
				strSql.Append("order by T.TC_ID desc");
			}
			strSql.Append(")AS Row, T.*  from TEACHCOURSE T ");
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
			parameters[0].Value = "TEACHCOURSE";
			parameters[1].Value = "TC_ID";
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

