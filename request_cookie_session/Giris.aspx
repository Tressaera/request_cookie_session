<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="request_cookie_session.Giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Kullanıcı Adı:<asp:TextBox ID="kuladi" runat="server"></asp:TextBox>
            <br />
            Şifre:<asp:TextBox ID="sifre" runat="server" TextMode="Password"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Giriş Yap" />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Güvenli Çıkış</asp:LinkButton>
        </div>
    </form>
</body>
</html>
