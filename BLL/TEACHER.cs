using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using SSCS.Model;
namespace SSCS.BLL
{
	/// <summary>
	/// TEACHER
	/// </summary>
	public partial class TEACHER
	{
		private readonly SSCS.DAL.TEACHER dal=new SSCS.DAL.TEACHER();
		public TEACHER()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal T_ID)
		{
			return dal.Exists(T_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SSCS.Model.TEACHER model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SSCS.Model.TEACHER model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal T_ID)
		{
			
			return dal.Delete(T_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string T_IDlist )
		{
			return dal.DeleteList(T_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SSCS.Model.TEACHER GetModel(decimal T_ID)
		{
			
			return dal.GetModel(T_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public SSCS.Model.TEACHER GetModelByCache(decimal T_ID)
		{
			
			string CacheKey = "TEACHERModel-" + T_ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(T_ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (SSCS.Model.TEACHER)objModel;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SSCS.Model.TEACHER> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SSCS.Model.TEACHER> DataTableToList(DataTable dt)
		{
			List<SSCS.Model.TEACHER> modelList = new List<SSCS.Model.TEACHER>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				SSCS.Model.TEACHER model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  BasicMethod
        #region  ExtensionMethod
        /*判断是否登录成功，参数：登录名、密码、登录结果信息、学生对象*/
        public bool Login(string no, string pwd, out string msg, out Model.TEACHER teacher)
        {
            bool r = false;
            teacher = dal.GetModel(no);
            if (teacher == null)
            {
                msg = "用户名不存在";
            }
            else
            {
                if (teacher.T_PASSWORD == pwd)
                {
                    r = true;
                    msg = "登录成功";
                }
                else
                {
                    msg = "密码错误";
                }
            }
            return r;
        }
        /// <summary>
        /// 根据数据对象删除一条数据
        /// </summary>
        public bool Delete(Model.TEACHER obj)
        {
            return dal.Delete(obj.T_ID);
        }
        #endregion  ExtensionMethod
    }
}

