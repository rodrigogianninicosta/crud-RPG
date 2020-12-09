<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="ProvaSisWeb.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Aeolithan</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
    <link rel="stylesheet" type="text/css" href="StyleSheet3.css" />
</head>
<body>
    <form id="form1" runat="server">
          <asp:Image ID="Image1" runat="server" ImageUrl="source.gif" style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 100%; width: 100%" />
          <asp:Image ID="Image2" runat="server" ImageUrl="selec.png" style="z-index: 1; left: 31%; top: 1%; position: absolute; height: 90px; width: 756px" />
          <asp:Button ID="Butt1" CssClass ="fade" runat="server" style="z-index: 1; left: 410px; top: 185px; position: absolute; height: 420px; width: 240px"  OnClick="Button1_Click" />
          <asp:Button ID="Butt2" CssClass ="fade" runat="server" style="z-index: 1; left: 710px; top: 185px; position: absolute; height: 420px; width: 240px"  OnClick="Button2_Click" />
          <asp:Button ID="Butt3" CssClass ="fade" runat="server" style="z-index: 1; left: 1010px; top: 185px; position: absolute; height: 420px; width: 240px" OnClick="Button3_Click" />
          <asp:Button ID="Butt4" CssClass ="fade" runat="server" style="z-index: 1; left: 1310px; top: 185px; position: absolute; height: 420px; width: 240px" OnClick="Button4_Click" />
          <asp:Button ID="Button2" CssClass ="fade" runat="server" style="z-index: 1; left: 45%; top: 67%; position: absolute; height: 50px; width: 200px" Text="Voltar" OnClick="Button_Click"/>
          <asp:Image ID="Image3" runat="server" ImageUrl="mino.gif" style="z-index: 1; left: 22%; top: 260px; position: absolute; height: 200px; width: 200px" />
          <asp:Image ID="Image4" runat="server" ImageUrl="lich.gif" style="z-index: 1; left: 36%; top: 260px; position: absolute; height: 200px; width: 280px" />
          <asp:Image ID="Image5" runat="server" ImageUrl="sam.gif" style="z-index: 1; left: 51%; top: 260px; position: absolute; height: 200px; width: 280px" />
          <asp:Image ID="Image6" runat="server" ImageUrl="mu.gif" style="z-index: 1; left: 68%; top: 260px; position: absolute; height: 200px; width: 250px" />
    </form>
</body>
</html>
