using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace SSCS.DAL
{
	/// <summary>
	/// 数据访问类:TEACHER
	/// </summary>
	public partial class TEACHER
	{
		public TEACHER()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal T_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from TEACHER");
			strSql.Append(" where T_ID=:T_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":T_ID", OracleType.Number,22)			};
			parameters[0].Value = T_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SSCS.Model.TEACHER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into TEACHER(");
			strSql.Append("T_ID,T_NAME,T_NO,T_SEX,T_PASSWORD,T_TITLE,T_ISADMIN,T_DEPARTMENT,T_MAJOR)");
			strSql.Append(" values (");
			strSql.Append(":T_ID,:T_NAME,:T_NO,:T_SEX,:T_PASSWORD,:T_TITLE,:T_ISADMIN,:T_DEPARTMENT,:T_MAJOR)");
			OracleParameter[] parameters = {
					new OracleParameter(":T_ID", OracleType.Number,4),
					new OracleParameter(":T_NAME", OracleType.VarChar,30),
					new OracleParameter(":T_NO", OracleType.Char,10),
					new OracleParameter(":T_SEX", OracleType.Char,3),
					new OracleParameter(":T_PASSWORD", OracleType.VarChar,32),
					new OracleParameter(":T_TITLE", OracleType.VarChar,50),
					new OracleParameter(":T_ISADMIN", OracleType.Number,4),
					new OracleParameter(":T_DEPARTMENT", OracleType.VarChar,50),
					new OracleParameter(":T_MAJOR", OracleType.VarChar,50)};
			parameters[0].Value = model.T_ID;
			parameters[1].Value = model.T_NAME;
			parameters[2].Value = model.T_NO;
			parameters[3].Value = model.T_SEX;
			parameters[4].Value = model.T_PASSWORD;
			parameters[5].Value = model.T_TITLE;
			parameters[6].Value = model.T_ISADMIN;
			parameters[7].Value = model.T_DEPARTMENT;
			parameters[8].Value = model.T_MAJOR;

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
		public bool Update(SSCS.Model.TEACHER model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update TEACHER set ");
			strSql.Append("T_ID=:T_ID,");
			strSql.Append("T_NAME=:T_NAME,");
			strSql.Append("T_NO=:T_NO,");
			strSql.Append("T_SEX=:T_SEX,");
			strSql.Append("T_PASSWORD=:T_PASSWORD,");
			strSql.Append("T_TITLE=:T_TITLE,");
			strSql.Append("T_ISADMIN=:T_ISADMIN,");
			strSql.Append("T_DEPARTMENT=:T_DEPARTMENT,");
			strSql.Append("T_MAJOR=:T_MAJOR");
			strSql.Append(" where T_ID=:T_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":T_ID", OracleType.Number,4),
					new OracleParameter(":T_NAME", OracleType.VarChar,30),
					new OracleParameter(":T_NO", OracleType.Char,10),
					new OracleParameter(":T_SEX", OracleType.Char,3),
					new OracleParameter(":T_PASSWORD", OracleType.VarChar,32),
					new OracleParameter(":T_TITLE", OracleType.VarChar,50),
					new OracleParameter(":T_ISADMIN", OracleType.Number,4),
					new OracleParameter(":T_DEPARTMENT", OracleType.VarChar,50),
					new OracleParameter(":T_MAJOR", OracleType.VarChar,50)};
			parameters[0].Value = model.T_ID;
			parameters[1].Value = model.T_NAME;
			parameters[2].Value = model.T_NO;
			parameters[3].Value = model.T_SEX;
			parameters[4].Value = model.T_PASSWORD;
			parameters[5].Value = model.T_TITLE;
			parameters[6].Value = model.T_ISADMIN;
			parameters[7].Value = model.T_DEPARTMENT;
			parameters[8].Value = model.T_MAJOR;

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
		public bool Delete(decimal T_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TEACHER ");
			strSql.Append(" where T_ID=:T_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":T_ID", OracleType.Number,22)			};
			parameters[0].Value = T_ID;

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
		public bool DeleteList(string T_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from TEACHER ");
			strSql.Append(" where T_ID in ("+T_IDlist + ")  ");
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
		public SSCS.Model.TEACHER GetModel(decimal T_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select T_ID,T_NAME,T_NO,T_SEX,T_PASSWORD,T_TITLE,T_ISADMIN,T_DEPARTMENT,T_MAJOR from TEACHER ");
			strSql.Append(" where T_ID=:T_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":T_ID", OracleType.Number,22)			};
			parameters[0].Value = T_ID;

			SSCS.Model.TEACHER model=new SSCS.Model.TEACHER();
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
		public SSCS.Model.TEACHER DataRowToModel(DataRow row)
		{
			SSCS.Model.TEACHER model=new SSCS.Model.TEACHER();
			if (row != null)
			{
				if(row["T_ID"]!=null && row["T_ID"].ToString()!="")
				{
					model.T_ID=decimal.Parse(row["T_ID"].ToString());
				}
				if(row["T_NAME"]!=null)
				{
					model.T_NAME=row["T_NAME"].ToString();
				}
				if(row["T_NO"]!=null)
				{
					model.T_NO=row["T_NO"].ToString();
				}
				if(row["T_SEX"]!=null)
				{
					model.T_SEX=row["T_SEX"].ToString();
				}
				if(row["T_PASSWORD"]!=null)
				{
					model.T_PASSWORD=row["T_PASSWORD"].ToString();
				}
				if(row["T_TITLE"]!=null)
				{
					model.T_TITLE=row["T_TITLE"].ToString();
				}
				if(row["T_ISADMIN"]!=null && row["T_ISADMIN"].ToString()!="")
				{
					model.T_ISADMIN=decimal.Parse(row["T_ISADMIN"].ToString());
				}
				if(row["T_DEPARTMENT"]!=null)
				{
					model.T_DEPARTMENT=row["T_DEPARTMENT"].ToString();
				}
				if(row["T_MAJOR"]!=null)
				{
					model.T_MAJOR=row["T_MAJOR"].ToString();
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
			strSql.Append("select T_ID,T_NAME,T_NO,T_SEX,T_PASSWORD,T_TITLE,T_ISADMIN,T_DEPARTMENT,T_MAJOR ");
			strSql.Append(" FROM TEACHER ");
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
			strSql.Append("select count(1) FROM TEACHER ");
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
				strSql.Append("order by T.T_ID desc");
			}
			strSql.Append(")AS Row, T.*  from TEACHER T ");
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
			parameters[0].Value = "TEACHER";
			parameters[1].Value = "T_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        /// <summary>
        /// 通过登录名得到一个对象实体
        /// </summary>
        public SSCS.Model.TEACHER GetModel(string T_No)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select T_ID,T_NAME,T_NO,T_SEX,T_PASSWORD,T_TITLE,T_ISADMIN,T_DEPARTMENT,T_MAJOR from TEACHER ");
            strSql.Append(" where T_NO=:T_No ");
            OracleParameter[] parameters = {
                    new OracleParameter(":T_No", OracleType.Char)          };
            parameters[0].Value = T_No;

            SSCS.Model.TEACHER model = new SSCS.Model.TEACHER();
            DataSet ds = DbHelperOra.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        #endregion  ExtensionMethod
    }
}

