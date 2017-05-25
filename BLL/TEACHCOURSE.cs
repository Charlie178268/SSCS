using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using SSCS.Model;
namespace SSCS.BLL
{
	/// <summary>
	/// TEACHCOURSE
	/// </summary>
	public partial class TEACHCOURSE
	{
		private readonly SSCS.DAL.TEACHCOURSE dal=new SSCS.DAL.TEACHCOURSE();
		public TEACHCOURSE()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal TC_ID)
		{
			return dal.Exists(TC_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SSCS.Model.TEACHCOURSE model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SSCS.Model.TEACHCOURSE model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal TC_ID)
		{
			
			return dal.Delete(TC_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string TC_IDlist )
		{
			return dal.DeleteList(TC_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SSCS.Model.TEACHCOURSE GetModel(decimal TC_ID)
		{
			
			return dal.GetModel(TC_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public SSCS.Model.TEACHCOURSE GetModelByCache(decimal TC_ID)
		{
			
			string CacheKey = "TEACHCOURSEModel-" + TC_ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(TC_ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (SSCS.Model.TEACHCOURSE)objModel;
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
		public List<SSCS.Model.TEACHCOURSE> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SSCS.Model.TEACHCOURSE> DataTableToList(DataTable dt)
		{
			List<SSCS.Model.TEACHCOURSE> modelList = new List<SSCS.Model.TEACHCOURSE>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				SSCS.Model.TEACHCOURSE model;
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

		#endregion  ExtensionMethod
	}
}

