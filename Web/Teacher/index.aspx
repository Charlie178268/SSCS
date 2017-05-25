<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web.Teacher.index" %>
<%@ Register src="sidebar.ascx" tagname="sidebar" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:sidebar ID="sidebar1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="title">
        老师信息
    </div>
    <div class="c"></div>

    <asp:DetailsView ID="DetailsView1" DataKeyNames="T_ID" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" Height="50px" Width="100%">
        <Fields>
            <asp:BoundField DataField="T_NAME" HeaderText="姓名" SortExpression="T_NAME" />
            <asp:BoundField DataField="T_NO" HeaderText="编号" SortExpression="T_NO" />
            <asp:BoundField DataField="T_SEX" HeaderText="性别" SortExpression="T_SEX" />
            <asp:BoundField DataField="T_TITLE" HeaderText="职称" SortExpression="T_TITLE" />
            <asp:BoundField DataField="T_ISADMIN" HeaderText="是否是管理员" SortExpression="T_ISADMIN" />
            <asp:BoundField DataField="T_DEPARTMENT" HeaderText="学院" SortExpression="T_DEPARTMENT" />
            <asp:BoundField DataField="T_MAJOR" HeaderText="专业" SortExpression="T_MAJOR" />
        </Fields>
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModel" TypeName="SSCS.BLL.TEACHER">
        <SelectParameters>
            <asp:QueryStringParameter Name="T_ID" QueryStringField="id" Type="Decimal" />
        </SelectParameters>
    </asp:ObjectDataSource>


</asp:Content>
