using System;
using System.Data;
using System.Text;
using System.Data.OracleClient;
using Maticsoft.DBUtility;//Please add references
namespace SSCS.DAL
{
	/// <summary>
	/// 数据访问类:STUDENT
	/// </summary>
	public partial class STUDENT
	{
		public STUDENT()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal S_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from STUDENT");
			strSql.Append(" where S_ID=:S_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":S_ID", OracleType.Number,22)			};
			parameters[0].Value = S_ID;

			return DbHelperOra.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SSCS.Model.STUDENT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into STUDENT(");
			strSql.Append("S_ID,S_NAME,S_NO,S_BIRTHDAY,S_SEX,S_CLASS,S_DEPARTMENT,S_MAJOR,S_GRADE,S_NOTE,S_RDATE,S_TYPE,S_MAXCOURSE,S_SELECTCOURSE,S_PASSWORD)");
			strSql.Append(" values (");
			strSql.Append(":S_ID,:S_NAME,:S_NO,:S_BIRTHDAY,:S_SEX,:S_CLASS,:S_DEPARTMENT,:S_MAJOR,:S_GRADE,:S_NOTE,:S_RDATE,:S_TYPE,:S_MAXCOURSE,:S_SELECTCOURSE,:S_PASSWORD)");
			OracleParameter[] parameters = {
					new OracleParameter(":S_ID", OracleType.Number,4),
					new OracleParameter(":S_NAME", OracleType.VarChar,50),
					new OracleParameter(":S_NO", OracleType.Char,10),
					new OracleParameter(":S_BIRTHDAY", OracleType.DateTime),
					new OracleParameter(":S_SEX", OracleType.Char,3),
					new OracleParameter(":S_CLASS", OracleType.Char,20),
					new OracleParameter(":S_DEPARTMENT", OracleType.VarChar,50),
					new OracleParameter(":S_MAJOR", OracleType.VarChar,50),
					new OracleParameter(":S_GRADE", OracleType.VarChar,20),
					new OracleParameter(":S_NOTE", OracleType.VarChar,300),
					new OracleParameter(":S_RDATE", OracleType.DateTime),
					new OracleParameter(":S_TYPE", OracleType.VarChar,20),
					new OracleParameter(":S_MAXCOURSE", OracleType.Number,4),
					new OracleParameter(":S_SELECTCOURSE", OracleType.Number,4),
					new OracleParameter(":S_PASSWORD", OracleType.VarChar,50)};
			parameters[0].Value = model.S_ID;
			parameters[1].Value = model.S_NAME;
			parameters[2].Value = model.S_NO;
			parameters[3].Value = model.S_BIRTHDAY;
			parameters[4].Value = model.S_SEX;
			parameters[5].Value = model.S_CLASS;
			parameters[6].Value = model.S_DEPARTMENT;
			parameters[7].Value = model.S_MAJOR;
			parameters[8].Value = model.S_GRADE;
			parameters[9].Value = model.S_NOTE;
			parameters[10].Value = model.S_RDATE;
			parameters[11].Value = model.S_TYPE;
			parameters[12].Value = model.S_MAXCOURSE;
			parameters[13].Value = model.S_SELECTCOURSE;
			parameters[14].Value = model.S_PASSWORD;

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
		public bool Update(SSCS.Model.STUDENT model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update STUDENT set ");
			strSql.Append("S_ID=:S_ID,");
			strSql.Append("S_NAME=:S_NAME,");
			strSql.Append("S_NO=:S_NO,");
			strSql.Append("S_BIRTHDAY=:S_BIRTHDAY,");
			strSql.Append("S_SEX=:S_SEX,");
			strSql.Append("S_CLASS=:S_CLASS,");
			strSql.Append("S_DEPARTMENT=:S_DEPARTMENT,");
			strSql.Append("S_MAJOR=:S_MAJOR,");
			strSql.Append("S_GRADE=:S_GRADE,");
			strSql.Append("S_NOTE=:S_NOTE,");
			strSql.Append("S_RDATE=:S_RDATE,");
			strSql.Append("S_TYPE=:S_TYPE,");
			strSql.Append("S_MAXCOURSE=:S_MAXCOURSE,");
			strSql.Append("S_SELECTCOURSE=:S_SELECTCOURSE,");
			strSql.Append("S_PASSWORD=:S_PASSWORD");
			strSql.Append(" where S_ID=:S_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":S_ID", OracleType.Number,4),
					new OracleParameter(":S_NAME", OracleType.VarChar,50),
					new OracleParameter(":S_NO", OracleType.Char,10),
					new OracleParameter(":S_BIRTHDAY", OracleType.DateTime),
					new OracleParameter(":S_SEX", OracleType.Char,3),
					new OracleParameter(":S_CLASS", OracleType.Char,20),
					new OracleParameter(":S_DEPARTMENT", OracleType.VarChar,50),
					new OracleParameter(":S_MAJOR", OracleType.VarChar,50),
					new OracleParameter(":S_GRADE", OracleType.VarChar,20),
					new OracleParameter(":S_NOTE", OracleType.VarChar,300),
					new OracleParameter(":S_RDATE", OracleType.DateTime),
					new OracleParameter(":S_TYPE", OracleType.VarChar,20),
					new OracleParameter(":S_MAXCOURSE", OracleType.Number,4),
					new OracleParameter(":S_SELECTCOURSE", OracleType.Number,4),
					new OracleParameter(":S_PASSWORD", OracleType.VarChar,50)};
			parameters[0].Value = model.S_ID;
			parameters[1].Value = model.S_NAME;
			parameters[2].Value = model.S_NO;
			parameters[3].Value = model.S_BIRTHDAY;
			parameters[4].Value = model.S_SEX;
			parameters[5].Value = model.S_CLASS;
			parameters[6].Value = model.S_DEPARTMENT;
			parameters[7].Value = model.S_MAJOR;
			parameters[8].Value = model.S_GRADE;
			parameters[9].Value = model.S_NOTE;
			parameters[10].Value = model.S_RDATE;
			parameters[11].Value = model.S_TYPE;
			parameters[12].Value = model.S_MAXCOURSE;
			parameters[13].Value = model.S_SELECTCOURSE;
			parameters[14].Value = model.S_PASSWORD;

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
		public bool Delete(decimal S_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STUDENT ");
			strSql.Append(" where S_ID=:S_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":S_ID", OracleType.Number,22)			};
			parameters[0].Value = S_ID;

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
		public bool DeleteList(string S_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from STUDENT ");
			strSql.Append(" where S_ID in ("+S_IDlist + ")  ");
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
		public SSCS.Model.STUDENT GetModel(decimal S_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select S_ID,S_NAME,S_NO,S_BIRTHDAY,S_SEX,S_CLASS,S_DEPARTMENT,S_MAJOR,S_GRADE,S_NOTE,S_RDATE,S_TYPE,S_MAXCOURSE,S_SELECTCOURSE,S_PASSWORD from STUDENT ");
			strSql.Append(" where S_ID=:S_ID ");
			OracleParameter[] parameters = {
					new OracleParameter(":S_ID", OracleType.Number,22)			};
			parameters[0].Value = S_ID;

			SSCS.Model.STUDENT model=new SSCS.Model.STUDENT();
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
		public SSCS.Model.STUDENT DataRowToModel(DataRow row)
		{
			SSCS.Model.STUDENT model=new SSCS.Model.STUDENT();
			if (row != null)
			{
				if(row["S_ID"]!=null && row["S_ID"].ToString()!="")
				{
					model.S_ID=decimal.Parse(row["S_ID"].ToString());
				}
				if(row["S_NAME"]!=null)
				{
					model.S_NAME=row["S_NAME"].ToString();
				}
				if(row["S_NO"]!=null)
				{
					model.S_NO=row["S_NO"].ToString();
				}
				if(row["S_BIRTHDAY"]!=null && row["S_BIRTHDAY"].ToString()!="")
				{
					model.S_BIRTHDAY=DateTime.Parse(row["S_BIRTHDAY"].ToString());
				}
				if(row["S_SEX"]!=null)
				{
					model.S_SEX=row["S_SEX"].ToString();
				}
				if(row["S_CLASS"]!=null)
				{
					model.S_CLASS=row["S_CLASS"].ToString();
				}
				if(row["S_DEPARTMENT"]!=null)
				{
					model.S_DEPARTMENT=row["S_DEPARTMENT"].ToString();
				}
				if(row["S_MAJOR"]!=null)
				{
					model.S_MAJOR=row["S_MAJOR"].ToString();
				}
				if(row["S_GRADE"]!=null)
				{
					model.S_GRADE=row["S_GRADE"].ToString();
				}
				if(row["S_NOTE"]!=null)
				{
					model.S_NOTE=row["S_NOTE"].ToString();
				}
				if(row["S_RDATE"]!=null && row["S_RDATE"].ToString()!="")
				{
					model.S_RDATE=DateTime.Parse(row["S_RDATE"].ToString());
				}
				if(row["S_TYPE"]!=null)
				{
					model.S_TYPE=row["S_TYPE"].ToString();
				}
				if(row["S_MAXCOURSE"]!=null && row["S_MAXCOURSE"].ToString()!="")
				{
					model.S_MAXCOURSE=decimal.Parse(row["S_MAXCOURSE"].ToString());
				}
				if(row["S_SELECTCOURSE"]!=null && row["S_SELECTCOURSE"].ToString()!="")
				{
					model.S_SELECTCOURSE=decimal.Parse(row["S_SELECTCOURSE"].ToString());
				}
				if(row["S_PASSWORD"]!=null)
				{
					model.S_PASSWORD=row["S_PASSWORD"].ToString();
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
			strSql.Append("select S_ID,S_NAME,S_NO,S_BIRTHDAY,S_SEX,S_CLASS,S_DEPARTMENT,S_MAJOR,S_GRADE,S_NOTE,S_RDATE,S_TYPE,S_MAXCOURSE,S_SELECTCOURSE,S_PASSWORD ");
			strSql.Append(" FROM STUDENT ");
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
			strSql.Append("select count(1) FROM STUDENT ");
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
				strSql.Append("order by T.S_ID desc");
			}
			strSql.Append(")AS Row, T.*  from STUDENT T ");
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
			parameters[0].Value = "STUDENT";
			parameters[1].Value = "S_ID";
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
        /// 通过登录名获取对象
        /// </summary>
        /// <param name="S_No"></param>
        /// <returns>student对象</returns>
        public SSCS.Model.STUDENT GetModel(string S_No)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select S_ID,S_NAME,S_NO,S_BIRTHDAY,S_SEX,S_CLASS,S_DEPARTMENT,S_MAJOR,S_GRADE,S_NOTE,S_RDATE,S_TYPE,S_MAXCOURSE,S_SELECTCOURSE,S_PASSWORD from STUDENT ");
            strSql.Append(" where S_NO=:S_No ");/*查询条件*/
            OracleParameter[] parameters = {
                    new OracleParameter(":S_No", OracleType.Char)         };
            parameters[0].Value = S_No;/*给参数:S_ID赋值*/

            /*把查询到的数据行转换成一个对象*/
            SSCS.Model.STUDENT model = new SSCS.Model.STUDENT();
            DataSet ds = DbHelperOra.Query(strSql.ToString(), parameters);/*调用Orace查询语句*/
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

