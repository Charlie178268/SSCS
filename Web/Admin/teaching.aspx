<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="teaching.aspx.cs" Inherits="Web.Admin.teaching" %>
<%@ Register src="../UserControl/sidebar.ascx" tagname="sidebar" tagprefix="uc1" %>
<%@ Register src="sidebar.ascx" tagname="sidebar" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc2:sidebar ID="sidebar" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="title">
        教师排课
    </div>
    <div class="c">
        教师:&nbsp;&nbsp;<asp:dropdownlist ID="ddlTeacher" runat="server" DataSourceID="ObjectDataSource1" DataTextField="T_NAME" DataValueField="T_ID"></asp:dropdownlist>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModelList" TypeName="SSCS.BLL.TEACHER">
            <SelectParameters>
                <asp:Parameter DefaultValue=" " Name="strWhere" Type="String" />
            </SelectParameters>
    </asp:ObjectDataSource>
        &nbsp;&nbsp;课程:&nbsp;&nbsp;<asp:dropdownlist ID="ddlCourse" runat="server" DataSourceID="ObjectDataSource2" DataTextField="C_NAME" DataValueField="C_ID"></asp:dropdownlist>
        <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetModelList" TypeName="SSCS.BLL.COURSE">
            <SelectParameters>
                <asp:Parameter DefaultValue=" " Name="strWhere" Type="String" />
            </SelectParameters>
    </asp:ObjectDataSource>
        &nbsp;&nbsp;星期:&nbsp;&nbsp;<asp:dropdownlist ID="ddlWeek" runat="server">
            <asp:ListItem>星期一</asp:ListItem>
            <asp:ListItem>星期二</asp:ListItem>
            <asp:ListItem>星期三</asp:ListItem>
            <asp:ListItem>星期四</asp:ListItem>
            <asp:ListItem>星期五</asp:ListItem>
            <asp:ListItem>星期六</asp:ListItem>
            <asp:ListItem>星期日</asp:ListItem>
    </asp:dropdownlist>
        &nbsp;&nbsp;节次:&nbsp;&nbsp;<asp:dropdownlist ID="ddlPeriod" runat="server">
            <asp:ListItem>上午第一二节</asp:ListItem>
            <asp:ListItem>上午第三四节</asp:ListItem>
            <asp:ListItem>下午第一二节</asp:ListItem>
            <asp:ListItem>下午第三四节</asp:ListItem>
            <asp:ListItem>晚上一二三节</asp:ListItem>
          
           </asp:dropdownlist>
        <br/>
        最大选课人数:&nbsp;&nbsp;<asp:textbox ID="txtNum" Width="40" runat="server"></asp:textbox>
        上课地点:&nbsp;&nbsp;<asp:textbox ID="txtPlace" Width="40" runat="server"></asp:textbox>
    </div>
      
    <asp:Button ID="setCourseBtn" runat="server" Text="排课" />

      
</asp:Content>
