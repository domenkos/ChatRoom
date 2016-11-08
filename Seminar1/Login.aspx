<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Seminar1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p style="margin-left: 40px">
            NoDB - Prijava</p>
        <p style="margin-left: 40px">
            Uporabniško ime:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Username" runat="server" OnTextChanged="Username_TextChanged"></asp:TextBox>
        </p>
        <p style="margin-left: 40px">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Geslo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="Password" runat="server" OnTextChanged="Password_TextChanged" TextMode="Password"></asp:TextBox>
        </p>
        <p style="margin-left: 160px">
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="LoginBtn" runat="server" Text="Prijava" Width="132px" OnClick="LoginBtn_Click" />
          
        </p>
        <p style="margin-left: 160px">
            <asp:Label ID="error" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
