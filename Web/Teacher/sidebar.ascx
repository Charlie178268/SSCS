<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sidebar.ascx.cs" Inherits="Web.Teacher.sidebar" %>
<style>
    .bar .c ul {
        list-style-type: none;
        margin-left: 48px;
    }

        .bar .c ul li {
            margin-bottom: 10px;
        }
</style>
<div class="bar">
    <div class="title ">&nbsp;</div>
    <div class="c">
        <p>欢迎XXX登陆</p>
    </div>
</div>

<div class="bar">
    <div class="title ">系统功能</div>
    <div class="c">
        <ul>
            <li>
                <a href="index.aspx">个人信息</a>
            </li>
            <li>
                <a href="score.aspx">录入成绩</a>
            </li>
            <li>
                <a href="TimeTable.aspx">课&nbsp;程&nbsp;表</a>
            </li>
            <li>
                <a href="../exit.aspx">退&nbsp;&nbsp;&nbsp;&nbsp;出</a>
            </li>
        </ul>
    </div>
</div>
