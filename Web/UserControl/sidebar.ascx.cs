using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.UserControl
{
    public partial class sidebar : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        /// <summary>
        /// 登录按钮的响应事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            /*判断类型，1是学生，2是老师*/
            string type = ddlType.SelectedValue;
            string no = txtNo.Text.Trim();
            string pwd = txtPwd.Text.Trim();
            string code = txtCode.Text.Trim();
            string msg;/*保存登录信息*/
            /*判断验证码是否正确*/
            /*Session过20分钟会自动失效，所以要判断是否为空*/
            if (Session["code"] != null && code.ToLower() == Session["code"].ToString().ToLower())
            {
                lblMsg.Text = "";
                /*清掉code*/
                Session.Remove("code");
                pwd = Common.GetMd5(pwd);
                if (type == "1")/*学生登录*/
                {
                    /*判断用户名密码是否正确*/
                    SSCS.BLL.STUDENT sbll = new SSCS.BLL.STUDENT();
                    SSCS.Model.STUDENT stu = new SSCS.Model.STUDENT();
                    lblMsg.Text = "学生登录";
                    if (sbll.Login(no, pwd, out msg, out stu))
                    {
                        lblMsg.Text = stu.S_NO.ToString();
                        /*保存登录信息*/
                        Session["user"] = stu;
                        SSCS.Model.STUDENT stud = Session["user"] as SSCS.Model.STUDENT;
                        /*跳转到学生首页*/
                        Response.Redirect("Student/index.aspx?id="+stud.S_ID);
                    }
                }else if (type == "2")/*老师登录*/
                {
                    
                    SSCS.BLL.TEACHER tbll = new SSCS.BLL.TEACHER();
                    SSCS.Model.TEACHER teacher = new SSCS.Model.TEACHER();
                    if (tbll.Login(no, pwd, out msg, out teacher))
                    {
                        Session["user"] = teacher;
                        if (teacher.T_ISADMIN == 0)
                        {
                            /*跳到老师界面*/
                            SSCS.Model.TEACHER tea = Session["user"] as SSCS.Model.TEACHER;
                            Response.Redirect("Teacher/index.aspx?id="+tea.T_ID);
                        }
                        else
                        {
                            /*跳到管理员界面*/
                            Response.Redirect("Admin/index.aspx");
                        }
                    }
                    
                        lblMsg.Text = msg;
                   }
            }
            else
            {
                lblMsg.Text = "验证码错误！";
            }
        }
    }
}