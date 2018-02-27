<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Projeto_Restaurante_Comanda_Eletronica.Telas.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="../Content/bootstrap.min.css" rel="stylesheet" />
<link href="../CSS/Login.css" rel="stylesheet" />
    <title>Login</title>
    </head>
<body class="bodylogin" >
    <form  id="form1" class="form-login" runat="server">
        <img src = "Imagens/fundo.jpg" class = "imglogo" alt = "logo" id = "logo" />
        <div>Usuario</div>
            <asp:TextBox ID="TBusuario" runat="server" class="form-control" placeholder="Digite Seu Usuario"></asp:TextBox>
        <div>Senha</div>
            <asp:TextBox ID="TBsenha" runat="server" class="form-control" TextMode="Password" placeholder="Digite Sua Senha"></asp:TextBox>
        <div class="Botoes">
           <asp:Button ID="BTentrar" runat="server" Text="Entrar" class="btn btn-primary" OnClick="BTentrar_Click" Width="300px"/> 
        </div>
    </form>
</body>
</html>
