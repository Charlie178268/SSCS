<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="teacherInfo.aspx.cs" Inherits="Web.Admin.teacherInfo" %>
<%@ Register src="sidebar.ascx" tagname="sidebar" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:sidebar ID="sidebar1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="title">
        教师详细信息
        <asp:DetailsView ID="DetailsView1" DataKeyNames="T_ID" runat="server" AutoGenerateRows="False" DataSourceID="ObjectDataSource1" Height="50px" Width="100%" OnItemInserted="DetailsView1_ItemInserted" OnItemInserting="DetailsView1_ItemInserting" OnItemUpdating="DetailsView1_ItemUpdating">
        <Fields>
            <asp:BoundField DataField="T_NAME" HeaderText="姓名" SortExpression="T_NAME" >
            <HeaderStyle Width="20%" />
            </asp:BoundField>
            <asp:BoundField DataField="T_NO" HeaderText="编号" SortExpression="T_NO" />
            <asp:TemplateField HeaderText="性别" SortExpression="T_SEX">
                <EditItemTemplate>
                    <asp:RadioButton runat="server" GroupName="sex" ID="RadioButton1" text="男"></asp:RadioButton>                                    
                    <asp:RadioButton runat="server" GroupName="sex" ID="RadioButton2" text="女"></asp:RadioButton>
                </EditItemTemplate>
                <InsertItemTemplate>
                    <asp:RadioButton runat="server" GroupName="sex" ID="rdomale" text="男"></asp:RadioButton>                                    
                    <asp:RadioButton runat="server" GroupName="sex" ID="rdofemale" text="女"></asp:RadioButton>
                </InsertItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("T_SEX") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:BoundField DataField="T_TITLE" HeaderText="职称" SortExpression="T_TITLE" />
            <asp:BoundField DataField="T_ISADMIN" HeaderText="是否是管理员" SortExpression="T_ISADMIN" />
            <asp:BoundField DataField="T_DEPARTMENT" HeaderText="学院" SortExpression="T_DEPARTMENT" />
            <asp:BoundField DataField="T_MAJOR" HeaderText="专业" SortExpression="T_MAJOR" />
            <asp:CommandField ShowInsertButton="True" />
            <asp:BoundField DataField="T_ID" SortExpression="T_ID" Visible="False" />
            <asp:BoundField DataField="T_PASSWORD" SortExpression="T_PASSWORD" Visible="False" />
        </Fields>
    </asp:DetailsView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModel" TypeName="SSCS.BLL.TEACHER" DataObjectTypeName="SSCS.Model.TEACHER" InsertMethod="Add" UpdateMethod="Update">
        <SelectParameters>
            <asp:QueryStringParameter Name="T_ID" QueryStringField="id" Type="Decimal" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
    </div>
    <div class="c">
     </div>

</asp:Content>
