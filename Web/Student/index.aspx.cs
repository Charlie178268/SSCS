using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Student
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /*判断是否登录了*/
            SSCS.Model.STUDENT stu = Session["user"] as SSCS.Model.STUDENT;
            if (stu == null)
            {
                Response.Write("<script>alert('您还未登录！请先登录'); location.href='../index.aspx'</script>");
            }
        }
    }
}