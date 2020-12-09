<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="ProvaSisWeb.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Aeolithan</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
    <link rel="stylesheet" type="text/css" href="StyleSheet2.css" />
</head>
<body>
    <form id="form1" runat="server">
           <asp:Image ID="Image1" runat="server" ImageUrl="source.gif" style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 100%; width: 100%" />
           <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 42%; top: 39%; position: absolute" Height="40px" Width="300px" MaxLength="10">usuário</asp:TextBox>
           <asp:Button ID="Button2" CssClass ="fade" runat="server" style="z-index: 1; left: 45%; top: 46%; position: absolute; height: 50px; width: 200px" Text="Consultar"  OnClick="Button1_Click"/>
           <asp:Button ID="Button3" CssClass ="fade" runat="server" style="z-index: 1; left: 45%; top: 53%; position: absolute; height: 50px; width: 200px" Text="Voltar" OnClick="Button2_Click"/>
           <asp:ListBox ID="ListBox1" runat="server" style="z-index: 1; left: 37%; top: 10%; position: absolute; height: 250px; width: 500px" Visible="False"></asp:ListBox>
    </form>
</body>
</html>
