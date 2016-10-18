<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="try1.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 630px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         <asp:Panel ID="Вход" runat="server" GroupingText="Регистрация">
                <table>
                    <tr>
                        <td>Потребителско име : </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Не сте въвели потребителско име !" Font-Bold="True" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td>Парола : </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Не сте въвели парола !" Font-Bold="True" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td>Повторете паролата : </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Не сте въвели повторна парола !" Font-Bold="True" ControlToValidate="TextBox3" ForeColor="Red"></asp:RequiredFieldValidator></td>
                        
                    </tr>
                    <tr>
                        <td>Въведете таен въпрос : </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Не сте въвели таен въпрос !" Font-Bold="True" ControlToValidate="TextBox4" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td>Таен отговор : </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox5" runat="server" Width="404px"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Не сте въвели таен отговор !" Font-Bold="True" ControlToValidate="TextBox5" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td>Име : </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Не сте въвели име !" Font-Bold="True" ControlToValidate="TextBox6" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td>Фамилия : </td>
                        <td class="auto-style2">
                            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Не сте въвели фамилия !" Font-Bold="True" ControlToValidate="TextBox7" ForeColor="Red"></asp:RequiredFieldValidator></td>
                    </tr>
                    <tr>
                        <td>Пол : </td>
                        <td class="auto-style2" >
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style2" TabIndex="3" EnableViewState="True" CausesValidation="True" AppendDataBoundItems="True" InitialValue="">
                                <asp:ListItem>Моля,изберете пол</asp:ListItem>
                                <asp:ListItem>Мъж</asp:ListItem>
                                <asp:ListItem>Жена</asp:ListItem>
                            </asp:DropDownList><asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ErrorMessage="Не сте избрали пол !" Font-Bold="True" ControlToValidate="DropDownList1" ForeColor="Red" InitialValue="Моля,изберете пол"></asp:RequiredFieldValidator>
                            </td>
                    </tr>
                    <tr>
                        <td>Дата на раждане : </td>
                        <td class="auto-style2">
                            <asp:Calendar ID="Calendar1" runat="server" SelectedDate="<%# DateTime.Today %>" WeekendDayStyle-ForeColor="Black" WeekendDayStyle-BackColor="#66FFCC" SelectorStyle-BorderColor="Red" TodayDayStyle-BorderColor="Red" SelectedDayStyle-BorderColor="Red" SelectedDayStyle-ForeColor="Red" TodayDayStyle-ForeColor="Red"></asp:Calendar>
                        </td>
                    </tr>
                    <tr><td colspan="2" align="right";><asp:Button ID="Button1" runat="server" Text="Регистрация" /></td></tr>
                    
                </table>
            </asp:Panel>
    </div>
    </form>
</body>
</html>
