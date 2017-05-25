using System;
using System.Data;
using System.Collections.Generic;
using Maticsoft.Common;
using SSCS.Model;
namespace SSCS.BLL
{
	/// <summary>
	/// NOTICE
	/// </summary>
	public partial class NOTICE
	{
		private readonly SSCS.DAL.NOTICE dal=new SSCS.DAL.NOTICE();
		public NOTICE()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(decimal N_ID)
		{
			return dal.Exists(N_ID);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(SSCS.Model.NOTICE model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(SSCS.Model.NOTICE model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(decimal N_ID)
		{
			
			return dal.Delete(N_ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string N_IDlist )
		{
			return dal.DeleteList(N_IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public SSCS.Model.NOTICE GetModel(decimal N_ID)
		{
			
			return dal.GetModel(N_ID);
		}

		/// <summary>
		/// 得到一个对象实体，从缓存中
		/// </summary>
		public SSCS.Model.NOTICE GetModelByCache(decimal N_ID)
		{
			
			string CacheKey = "NOTICEModel-" + N_ID;
			object objModel = Maticsoft.Common.DataCache.GetCache(CacheKey);
			if (objModel == null)
			{
				try
				{
					objModel = dal.GetModel(N_ID);
					if (objModel != null)
					{
						int ModelCache = Maticsoft.Common.ConfigHelper.GetConfigInt("ModelCache");
						Maticsoft.Common.DataCache.SetCache(CacheKey, objModel, DateTime.Now.AddMinutes(ModelCache), TimeSpan.Zero);
					}
				}
				catch{}
			}
			return (SSCS.Model.NOTICE)objModel;
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
		public List<SSCS.Model.NOTICE> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<SSCS.Model.NOTICE> DataTableToList(DataTable dt)
		{
			List<SSCS.Model.NOTICE> modelList = new List<SSCS.Model.NOTICE>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				SSCS.Model.NOTICE model;
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

