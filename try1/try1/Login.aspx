<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="try1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        .auto-style1 {
            width: 724px;
        }
        .auto-style2 {
            width: 771px;
        }
        .auto-style3 {
            width: 761px;
        }
    </style>

</head>
<body>

    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Вход" runat="server" GroupingText="Вход">
                <table>
                    <tr>
                        <td>Потребителско име : </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>Парола : </td>
                        <td class="auto-style1">
                            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
                    </tr>
                    <tr><td colspan="2" align="right";><asp:Button ID="Button1" runat="server" Text="Вход" /></td></tr>
                    <tr><td colspan="2"><asp:Button ID="Button2" runat="server" Text="Забравена парола" OnClick="Button2_Click" /></td></tr>
                </table>
            </asp:Panel>
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Възстановяване на парола чрез мобилен телефон" OnCheckedChanged="CheckBox1_CheckedChanged" Visible="False" />
            <asp:Panel ID="Panel1" runat="server" GroupingText="Възстановяване на парола чрез таен въпрос" Visible="False">
                <table>
                    <tr>
                        <td>Таен въпрос : </td>
                        <td class="auto-style2">
                           </td>
                    </tr>
                    <tr>
                        <td>Таен отговор : </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox4" runat="server" Width="450px"></asp:TextBox></td>
                    </tr>
                    <tr><td colspan="2" align="right";><asp:Button ID="Button3" runat="server" Text="Виж парола" OnClick="Button3_Click" /></td></tr>
                    <tr>
                        <asp:PlaceHolder ID="PlaceHolder1" runat="server" Visible="False"><td>Вашата парола е : </td></asp:PlaceHolder>
                        </tr>                   
                </table>
            </asp:Panel>
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Възстановяване на парола чрез таен въпрос" OnCheckedChanged="CheckBox2_CheckedChanged" Visible="False" />
             <asp:Panel ID="Panel2" runat="server" GroupingText="Възстановяване на парола чрез мобилен телефон" Visible="False">
                <table>
                    <tr>
                        <td>Мобилен телефон : +359</td>
                        <td class="auto-style3">
                            <asp:TextBox ID="TextBox3" runat="server" Width="450px"></asp:TextBox></td>
                    </tr>
                    <tr><td colspan="2" align="right";><asp:Button ID="Button4" runat="server" Text="Виж парола" Width="107px" OnClick="Button4_Click" /></td></tr>
                    <tr>
                        <asp:PlaceHolder ID="PlaceHolder2" runat="server"><td>Вашата парола е : </td></asp:PlaceHolder>
                        </tr>                   
                </table>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
