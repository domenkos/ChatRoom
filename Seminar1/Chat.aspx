<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="Seminar1.Chat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chat</title>
    <style type="text/css">
        .auto-style1 {
            width: 401px;
        }
        .auto-style2 {
            height: 3px;
        }
    </style>
    </head>
<body>
    <form id="form1" runat="server">
        <table>
            <tr>
                <td class="auto-style1">
                    <asp:Label ID="CurrentUser" runat="server" Text=" Prijavljeni ste kot:"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="Logout" runat="server" Text="Odjava" style="margin-left: 12px" Width="180px" OnClick="Logout_Click" />
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:ListBox ID="Messages" runat="server" Height="326px" Width="387px" OnSelectedIndexChanged="Messages_SelectedIndexChanged"></asp:ListBox></td>
                <td>
                    <asp:ListBox ID="Users" runat="server" Height="326px" Width="215px" OnSelectedIndexChanged="Users_SelectedIndexChanged"></asp:ListBox></td>
            </tr>
            <tr>
                
                <td class="auto-style2">
                    Vnos sporocil
                </td>
                <td class="auto-style2">
                    <asp:Button ID="Refresh" runat="server" Text="Osvezi" style="margin-left: 12px" Width="190px" Height="36px" OnClick="Refresh_Click" />

                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:TextBox ID="Message" runat="server" Width="375px" Height="31px" OnTextChanged="Message_TextChanged"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Send" runat="server" Text="Poslji" style="margin-left: 12px" Width="190px" Height="35px" OnClick="Send_Click" />
                </td>
            </tr>

        </table>
    </form>
</body>
</html>
