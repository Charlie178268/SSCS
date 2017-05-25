<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="courseInfo.aspx.cs" Inherits="Web.Admin.courseInfo" %>
<%@ Register src="sidebar.ascx" tagname="sidebar" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:sidebar ID="sidebar1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="title">
        课程详细信息
    </div>
    <div class="c">

    </div>  
    <asp:DetailsView ID="DetailsView1" DataKeyNames="C_ID" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" Height="50px" Width="100%" OnItemInserted="DetailsView1_ItemInserted">
        <Fields>
            <asp:BoundField DataField="C_NO" HeaderText="课程编号" SortExpression="C_NO" >
            <HeaderStyle Width="100px" />
            </asp:BoundField>
            <asp:BoundField DataField="C_SCORE" HeaderText="学分" SortExpression="C_SCORE" />
            <asp:BoundField DataField="C_NAME" HeaderText="课程名" SortExpression="C_NAME" />
            <asp:BoundField DataField="C_GRADE" HeaderText="年级" SortExpression="C_GRADE" />
            <asp:BoundField DataField="C_TERM" HeaderText="学期" SortExpression="C_TERM" />
            <asp:BoundField DataField="C_DESCIPTION" HeaderText="课程描述" SortExpression="C_DESCIPTION" />
            <asp:CommandField ShowEditButton="True" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="SSCS.Model.COURSE" InsertMethod="Add" SelectMethod="GetModel" TypeName="SSCS.BLL.COURSE" UpdateMethod="Update">
        <SelectParameters>
            <asp:QueryStringParameter Name="C_ID" QueryStringField="id" Type="Decimal" />
        </SelectParameters>
    </asp:ObjectDataSource>
  
</asp:Content>
