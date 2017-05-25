<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sidebar.ascx.cs" Inherits="Web.Admin.sidebar" %>
<style>
    .bar .c ul {
        list-style-type: none;
        margin-left: 40px;
    }

        .bar .c ul li {
            margin-bottom: 10px;
        }
</style>
<div class="bar">
    <div class="title ">&nbsp;</div>
    <div class="c" style="margin-left:10px">
        <p>欢迎XXX登陆</p>
    </div>
</div>

<div class="bar">
    <div class="title ">系统功能</div>
    <div class="c">
        <ul>
            <li>
                <a href="Index.aspx">课程管理</a>
            </li>
            <li>
                <a href="StuManager.aspx">学生管理</a>
            </li>
            <li>
                <a href="teacherList.aspx">教师管理</a>
            </li>
            <li>
                <a href="teaching.aspx">安排课程</a>
            </li>
            <li>
                <a href="../exit.aspx">退&nbsp;&nbsp;&nbsp;&nbsp;出</a>
            </li>
        </ul>
    </div>
</div>