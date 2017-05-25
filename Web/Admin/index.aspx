<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web.Admin.index" %>
<%@ Register src="sidebar.ascx" tagname="sidebar" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:sidebar ID="sidebar1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="title">
        课程管理
    </div>
    <div class="c">
        <a href="courseinfo.aspx">添加课程</a>
    </div>  
    <asp:GridView ID="GridView1" runat="server" DataKeyNames="C_ID" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="100%">
        <Columns>
            <asp:BoundField DataField="C_NO" HeaderText="编号" SortExpression="C_NO">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:HyperLinkField DataNavigateUrlFields="C_ID" DataNavigateUrlFormatString="courseInfo.aspx?id={0}" DataTextField="C_NAME" HeaderText="课程名">
            <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:HyperLinkField>
            <asp:BoundField DataField="C_SCORE" HeaderText="学分" SortExpression="C_SCORE">
                <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="C_GRADE" HeaderText="年级" SortExpression="C_GRADE" >
                <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
            <asp:BoundField DataField="C_TERM" HeaderText="学期" SortExpression="C_TERM" >
                <HeaderStyle HorizontalAlign="Center" />
            <ItemStyle HorizontalAlign="Center" />
            </asp:BoundField>
           
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:LinkButton ID="LinkButton1" OnClientClick="return confirm('确定删除记录吗?');" runat="server" CausesValidation="False" CommandName="Delete" Text="删除"></asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModelList" TypeName="SSCS.BLL.COURSE" DataObjectTypeName="SSCS.Model.COURSE" DeleteMethod="Delete">
        <SelectParameters>
            <asp:Parameter DefaultValue=" " Name="strWhere" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
    
</asp:Content>
