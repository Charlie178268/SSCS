<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="teacherList.aspx.cs" Inherits="Web.Admin.teacherList" %>
<%@ Register src="sidebar.ascx" tagname="sidebar" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:sidebar ID="sidebar1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="title">
        教师管理
    </div>
    <div class="c">
        <a href="teacherInfo.aspx">添加教师</a>
    </div>  
            <asp:GridView ID="GridView1" DataKeyNames="T_ID" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="100%" HorizontalAlign="Center">
                <Columns>
                    <asp:BoundField DataField="T_NO" HeaderText="编号" SortExpression="T_NO" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:HyperLinkField DataNavigateUrlFields="T_ID" DataNavigateUrlFormatString="teacherInfo.aspx?id={0}" DataTextField="T_NAME" HeaderText="姓名" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:HyperLinkField>
                    <asp:BoundField DataField="T_SEX" HeaderText="性别" SortExpression="T_SEX" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="T_TITLE" HeaderText="职称" SortExpression="T_TITLE" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="T_ISADMIN" HeaderText="是否是管理员" SortExpression="T_ISADMIN" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:BoundField DataField="T_DEPARTMENT" HeaderText="学院" SortExpression="T_DEPARTMENT" >
                   <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                     <asp:BoundField DataField="T_MAJOR" HeaderText="专业" SortExpression="T_MAJOR" >
                    <ItemStyle HorizontalAlign="Center" />
                    </asp:BoundField>
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" OnClientClick="return confirm('确定删除记录吗?');" runat="server" CausesValidation="False" CommandName="Delete" Text="删除"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="SSCS.Model.TEACHER" DeleteMethod="Delete" InsertMethod="Add" SelectMethod="GetModelList" TypeName="SSCS.BLL.TEACHER" UpdateMethod="Update">
                <SelectParameters>
                    <asp:Parameter DefaultValue=" " Name="strWhere" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
</asp:Content>
