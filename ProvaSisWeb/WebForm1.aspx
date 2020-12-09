<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ProvaSisWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Aeolithan</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet1.css" />
     <script type="text/javascript" language="javascript">
        function ConfirmLogoff()
        {
          if (confirm("Deseja mesmo sair?")==true)
            return true;
          else
            return false;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Image ID="Image1" runat="server" ImageUrl="source.gif" style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 100%; width: 100%" />
        <asp:Image ID="Image2" runat="server" ImageUrl="aec.png" style="z-index: 1; left: 31%; top: 1%; position: absolute; height: 160px; width: 756px" />
        <asp:Button ID="Button1" CssClass ="fade" runat="server" style="z-index: 1; left: 45%; top: 39%; position: absolute; height: 50px; width: 200px" Text="Logon"  OnClick="Button1_Click"/>
        <asp:Button ID="Button2" CssClass ="fade" runat="server" style="z-index: 1; left: 45%; top: 46%; position: absolute; height: 50px; width: 200px" Text="Cadastro" OnClick="Button2_Click"/>
        <asp:Button ID="Button3" CssClass ="fade" runat="server" style="z-index: 1; left: 45%; top: 53%; position: absolute; height: 50px; width: 200px" Text="Consulta" OnClick="Button3_Click"/>
        <asp:Button ID="Button4" CssClass ="fade" runat="server" style="z-index: 1; left: 45%; top: 60%; position: absolute; height: 50px; width: 200px" Text="Exclusão" OnClick="Button4_Click"/>
        <asp:Button ID="Button5" CssClass ="fade" runat="server" style="z-index: 1; left: 45%; top: 67%; position: absolute; height: 50px; width: 200px" Text="Alteração" OnClick="Button5_Click"/>
        <asp:Button ID="Button6" CssClass ="fade" runat="server" style="z-index: 1; left: 45%; top: 74%; position: absolute; height: 50px; width: 200px" Text="Logoff" OnClick="Button6_Click"/>
        <asp:Button ID="Button7" CssClass ="fade" runat="server" style="z-index: 1; left: 0px; top: 0px; position: absolute; height: 80px; width: 400px" Text="Logoff" Visible ="false"/>
    </form>
</body>
</html>
