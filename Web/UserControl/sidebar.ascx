<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="sidebar.ascx.cs" Inherits="Web.UserControl.sidebar" %>
<div class="bar notice">
                <div class="title ">公告</div>
                <div class="c">
                    <p>第一次登陆请尽快修改密码，默认密码是123456</p></div>
            </div>
            
            <div class="bar login">
                <div class="title">登陆</div>
                <div class="c">
                    <table>
                        <tr>
                            <td style="width:500px">类&nbsp;&nbsp;型：</td>
                            <td style="width:80%">
                                <asp:DropDownList class="input" ID="ddlType" runat="server">
                                    <asp:ListItem Value="1">学生</asp:ListItem>
                                    <asp:ListItem Value="2">老师</asp:ListItem>
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>账&nbsp;&nbsp;号：</td>
                            <td>
                                <asp:TextBox ID="txtNo" class="input" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>密&nbsp;&nbsp;码：</td>
                            <td>
                                <asp:TextBox ID="txtPwd" TextMode="Password" class="input" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td>验证码：</td>
                            <td>
                                <asp:TextBox ID="txtCode" style="width:40px; vertical-align:middle" runat="server"></asp:TextBox>&nbsp
                                <img id="Imagetestcode" title="看不清？点我" style="cursor:pointer; vertical-align:middle; height:22px; width:50px" src="../ValidateCode.ashx" onclick="changeTestCode()"/>
                            </td>
                            </td>
                        </tr>
                        <tr>
                     
                            <td colspan="2" align="center">
                                <asp:Button ID="btnLogin" runat="server" Text="登陆" OnClick="btnLogin_Click" />
                                <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
<script>
function changeTestCode() {
        //改变验证码，一定要在地址后面加随机数，不然浏览器会以为是同一个地址而不请求服务器，直接在缓存里加载
    document.getElementById('Imagetestcode').src = '../ValidateCode.ashx?_=' + Math.random();
}
</script>