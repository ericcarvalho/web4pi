<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Pages_Administrativo_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <!--bootstrap-->
    <link href="../Style/BootStrap/css/bootstrap.min.css" rel="stylesheet" />
    <!--google-->
    <link rel="stylesheet" href="../Style/Google/mdl/material.min.css"/>
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons"/>
    <!--estilo-->
    <link href="../Style/Css/estilo.css" rel="stylesheet" />
</head>
    <!--bootstrap-->
    <script src="../Style/BootStrap/js/bootstrap.min.js"></script>
    <!--google-->
    <script src="../Style/Google/mdl/material.min.js"></script>
<body>

        <!-- Always shows a header, even in smaller screens. -->
    <div class="mdl-layout mdl-js-layout mdl-layout--fixed-header">
    <header class="mdl-layout__header" id="cabecalho">
        <div class="mdl-layout__header-row" >
        <!-- Title -->
        <span class="mdl-layout-title"><a href="Restaurantes.aspx"><img src="../../Imagens/WEBFOODEXPRESS4.jpg" /></a></span>
        <!-- Add spacer, to align navigation to the right -->
        <div class="mdl-layout-spacer"></div>
        <!-- Navigation. We hide it in small screens. -->
        <nav class="mdl-navigation mdl-layout--large-screen-only">
        <a class="mdl-navigation__link" href="">Termos de uso</a>
        <a class="mdl-navigation__link" href="CadastrarRestaurantes.aspx">Cadastro de Restaurante</a>
        </nav>
        </div>
    </header>

    <div class="mdl-layout__drawer">
        <span class="mdl-layout-title"><a href="Restaurantes.aspx"><img src="../../Imagens/WEBFOODEXPRESS4.jpg" /></a></span>
        <nav class="mdl-navigation">
        <a class="mdl-navigation__link" href="">Termos de uso</a>
        <a class="mdl-navigation__link" href="CadastrarRestaurantes.aspx">Cadastro de Restaurante</a>    
        </nav>
    </div>
  
    </div>
    
    <section id="login">
    <form id="form2" runat="server">
    <div class="row">
    <div class="form-group col-md-4 col-md-offset-1">
        <label for="txtEmail">Email</label>
        <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" width="400px"></asp:TextBox>       
        <label for="txtSenha">Senha</label>
        <asp:TextBox ID="txtSenha" CssClass="form-control" runat="server" TextMode="Password" width="400px"></asp:TextBox>               
    </div>
    </div>
    <div class="row">           
        <div class="btn-group col-md-4 col-md-offset-1" id="botoes-login">
        <ul>            
            <li><asp:Button ID="btnEntrar" runat="server" cssClass="btn btn-primary btn-block" OnClick="btnEntrar_Click" Text="Entrar" /></li>
            <li id="mensagem"><asp:Label ID="lblMensagemErro" runat="server" ForeColor="white"></asp:Label></li>
            <li id="mensagem"><asp:LinkButton ID="lkbCadastrar" runat="server" OnClick="lkbCadastrar_Click" ForeColor="White">Ainda não é cadastrado? Cadastre-se aqui</asp:LinkButton></li>    
        </ul>        
        </div>
    </div>
    </form>
    </section>
    <footer class="mdl-mega-footer" id="rodape">
    <div class="mdl-mega-footer__middle-section">
        <div class="mdl-mega-footer__drop-down-section">
        <input class="mdl-mega-footer__heading-checkbox" type="checkbox" checked>
        <h1 class="mdl-mega-footer__heading">Features</h1>
        <ul class="mdl-mega-footer__link-list">
            <li><a href="#">About</a></li>
            <li><a href="#">Terms</a></li>
            <li><a href="#">Partners</a></li>
            <li><a href="#">Updates</a></li>
        </ul>
        </div>
        <div class="mdl-mega-footer__drop-down-section">
        <input class="mdl-mega-footer__heading-checkbox" type="checkbox" checked>
        <h1 class="mdl-mega-footer__heading">Details</h1>
        <ul class="mdl-mega-footer__link-list">
            <li><a href="#">Specs</a></li>
            <li><a href="#">Tools</a></li>
            <li><a href="#">Resources</a></li>
        </ul>
        </div>
        <div class="mdl-mega-footer__drop-down-section">
        <input class="mdl-mega-footer__heading-checkbox" type="checkbox" checked>
        <h1 class="mdl-mega-footer__heading">Technology</h1>
        <ul class="mdl-mega-footer__link-list">
            <li><a href="#">How it works</a></li>
            <li><a href="#">Patterns</a></li>
            <li><a href="#">Usage</a></li>
            <li><a href="#">Products</a></li>
            <li><a href="#">Contracts</a></li>
        </ul>
     </div>
        <div class="mdl-mega-footer__drop-down-section">
        <input class="mdl-mega-footer__heading-checkbox" type="checkbox" checked>
        <h1 class="mdl-mega-footer__heading">FAQ</h1>
        <ul class="mdl-mega-footer__link-list">
          <li><a href="#">Questions</a></li>
          <li><a href="#">Answers</a></li>
          <li><a href="#">Contact us</a></li>
        </ul>
        </div>
    </div>
    <div class="mdl-mega-footer__bottom-section">
        <div class="mdl-logo">Title</div>
        <ul class="mdl-mega-footer__link-list">
        <li><a href="#">Help</a></li>
        <li><a href="#">Privacy & Terms</a></li>
        </ul>
    </div>
</footer>
  
</body>
</html>