<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ValidaDNI.aspx.cs" Inherits="Actividad_Integradora_7_Problema_2.ValidaDNI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Valida DNI<br />
            DNI:
            <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="btnEnviar" runat="server" OnClick="btnEnviar_Click" Text="Enviar" />
            <br />
            <asp:Label ID="lblResultado" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
