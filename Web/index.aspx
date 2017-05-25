<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Web.index" %>
<%@ Register src="UserControl/sidebar.ascx" tagname="sidebar" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
              <uc1:sidebar ID="sidebar1" runat="server" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <div class="title">通知</div>
    <tr>
        <td>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:BoundField DataField="N_TITLE" HeaderText="标题" SortExpression="N_TITLE" >
                    <ItemStyle Width="100px" HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:BoundField DataField="N_AUTHOR" HeaderText="作者" SortExpression="N_AUTHOR" >
                    <ItemStyle Width="80px" HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>
                    <asp:BoundField DataField="N_CONTENT" HeaderText="内容" SortExpression="N_CONTENT" >
                    <ItemStyle Width="500px" HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>

                    <asp:BoundField DataField="N_DATE" HeaderText="时间" SortExpression="N_DATE" >

                    <HeaderStyle Width="100px" />
                    <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                    </asp:BoundField>

                  </Columns>
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetModelList" TypeName="SSCS.BLL.NOTICE">
                <SelectParameters>
                    <asp:Parameter DefaultValue=" " Name="strWhere" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </td>
    </tr>

</asp:Content>
