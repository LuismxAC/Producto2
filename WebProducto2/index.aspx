﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebProducto2.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Carniceria<br />
        <br />
        <br />
        <asp:Button ID="btn_registrar" runat="server" Text="Registrate" OnClick="btn_registrar_Click" />
        <br />
        <br />
        <br />
        <br />
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        publicidad de los productos<br />
        <br />
    
    </div>
    </form>
</body>
</html>
