<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OperacionesCliente.aspx.cs" Inherits="WebProducto2.OperacionesCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Operaciones de tabla cliente<br />
        <br />
        Id_Cliente: <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Nombre:
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        Apellido Paterno:
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        Apellido Materno:
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        Celular:
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <br />
        <br />
        correo: <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Insertar Cliente" Width="254px" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:TextBox ID="TextBox7" runat="server" Width="544px"></asp:TextBox>
    </form>
</body>
</html>
