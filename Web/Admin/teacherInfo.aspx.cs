using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Admin
{
    public partial class teacherInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string mode = Request.QueryString["id"];
            if (string.IsNullOrEmpty(mode))
            {
                DetailsView1.DefaultMode = DetailsViewMode.Insert;
            }
        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            Response.Redirect("teacherList.aspx");
        }

        protected void DetailsView1_ItemInserting(object sender, DetailsViewInsertEventArgs e)
        {
            CheckBox chk = (CheckBox)DetailsView1.FindControl("rdoMale");
            e.Values["T_Sex"] = chk.Checked ? "男" : "女";
            e.Values["T_PASSWORD"] = Common.GetMd5("123456");/*默认密码123456*/
        }

        protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
        {
            /*更新数据，报错，先注释*/
            //CheckBox chk = (CheckBox)DetailsView1.FindControl("rdoMale");
            //e.NewValues[0] = chk.Checked ? "男" : "女";
            //e.NewValues[1] = Common.GetMd5("123456");/*默认密码123456*/
        }
    }
}