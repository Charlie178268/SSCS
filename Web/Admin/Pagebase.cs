using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Admin
{
    public class Pagebase: System.Web.UI.Page
    {
        protected override void OnInitComplete(EventArgs e)
        {
            base.OnInitComplete(e);
            SSCS.Model.TEACHER teacher = Session["user"] as SSCS.Model.TEACHER;
            if (teacher == null)
            {
                Response.Write("<script>alert('请先登录!'); location.href='../index.aspx';</script>");
            } else if (teacher.T_ISADMIN == 0) {
                Response.Write("<script>alert('非管理员不能访问此页!'); location.href='../index.aspx';</script>");
            }
        }
    }
}