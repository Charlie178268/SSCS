<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web.Student.index" %>
<%@ Register src="sidebar.ascx" tagname="sidebar" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:sidebar ID="sidebar1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
     <div class="title">
        学生信息
    </div>
    <div class="c">
        
    </div>  
            <asp:DetailsView ID="DetailsView1" runat="server" Height="50px" Width="100%" AutoGenerateRows="False" DataSourceID="ObjectDataSource1">
                <Fields>
                    <asp:BoundField DataField="S_NAME" HeaderText="姓名" SortExpression="S_NAME" />
                    <asp:BoundField DataField="S_NO" HeaderText="编号" SortExpression="S_NO" />
                    <asp:BoundField DataField="S_BIRTHDAY" HeaderText="生日" SortExpression="S_BIRTHDAY" />
                    <asp:BoundField DataField="S_SEX" HeaderText="性别" SortExpression="S_SEX" />
                    <asp:BoundField DataField="S_CLASS" HeaderText="班级" SortExpression="S_CLASS" />
                    <asp:BoundField DataField="S_DEPARTMENT" HeaderText="学院" SortExpression="S_DEPARTMENT" />
                    <asp:BoundField DataField="S_MAJOR" HeaderText="专业" SortExpression="S_MAJOR" />
                    <asp:BoundField DataField="S_GRADE" HeaderText="年级" SortExpression="S_GRADE" />
                    <asp:BoundField DataField="S_RDATE" HeaderText="入学日期" SortExpression="S_RDATE" />
                    <asp:BoundField DataField="S_TYPE" HeaderText="类别" SortExpression="S_TYPE" />
                    <asp:BoundField DataField="S_MAXCOURSE" HeaderText="最大选课数" SortExpression="S_MAXCOURSE" />
                    <asp:BoundField DataField="S_SELECTCOURSE" HeaderText="已选课数" SortExpression="S_SELECTCOURSE" />
                    <asp:BoundField DataField="S_NOTE" HeaderText="备注" SortExpression="S_NOTE" />
                    
                </Fields>
            </asp:DetailsView>
     <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModel" TypeName="SSCS.BLL.STUDENT">
         <SelectParameters>
             <asp:QueryStringParameter Name="S_ID" QueryStringField="id" Type="Decimal" />
         </SelectParameters>
     </asp:ObjectDataSource>

</asp:Content>
