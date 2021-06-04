<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarRestaurantes.aspx.cs" Inherits="Pages_Administrativo_CadastrarRestaurantes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <title></title>
   

         <!-- Latest compiled and minified CSS -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">

        <!-- Optional theme -->
        <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap-theme.min.css">

        <!-- Latest compiled and minified JavaScript -->
        <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js"></script>

    <link href="../Style/BootStrap/css/bootstrap.min.css" rel="stylesheet" />

    <link rel="stylesheet" href="https://storage.googleapis.com/code.getmdl.io/1.0.4/material.indigo-pink.min.css">
    <script src="https://storage.googleapis.com/code.getmdl.io/1.0.4/material.min.js"></script>
    <link rel="stylesheet" href="https://fonts.googleapis.com/icon?family=Material+Icons">

    <link href="../Style/Css/estilo.css" rel="stylesheet" />
    
</head>
   
<body>
    
    <!-- Always shows a header, even in smaller screens. -->
    <div class="mdl-layout mdl-js-layout mdl-layout--fixed-header">
    <header class="mdl-layout__header" id="cabecalho">
        <div class="mdl-layout__header-row" >
        <!-- Title -->
        <span class="mdl-layout-title"><a href="Restaurantes.aspx"><img src="../../Imagens/WEBFOODEXPRESS1.jpg" /></a></span>
        <!-- Add spacer, to align navigation to the right -->
        <div class="mdl-layout-spacer"></div>
        <!-- Navigation. We hide it in small screens. -->
        <nav class="mdl-navigation mdl-layout--large-screen-only">
        <a class="mdl-navigation__link" href="">Termos de uso</a>
        <a class="mdl-navigation__link" href="Login.aspx">Entrar</a>
        </nav>
        </div>
    </header>

    <div class="mdl-layout__drawer">
        <span class="mdl-layout-title"><a href="Restaurantes.aspx"><img src="../../Imagens/WEBFOODEXPRESS1.jpg" /></a></span>
        <nav class="mdl-navigation">
        <a class="mdl-navigation__link" href="">Termos de uso</a>
        <a class="mdl-navigation__link" href="Login.aspx">Entrar</a>    
        </nav>
    </div>
  
    </div>

    <form id="form1" runat="server">
        <section id="corpo">
    <div class="row">
        <div class="form-group col-md-4 col-md-offset-1">
            <label for="txtNomeEmpresa">Nome da Empresa</label>
            <asp:TextBox ID="txtNomeEmpresa" CssClass="form-control" runat="server"></asp:TextBox>
            <label for="txtNome">Nome do Administrador</label>          
            <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"></asp:TextBox>
            <label for="txtCnpj">Cnpj</label>
            <asp:TextBox ID="txtCnpj" CssClass="form-control" runat="server"></asp:TextBox>           
            <label for="txtEmail">Email</label>
            <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server"></asp:TextBox>
            <label for="txtSenha">Senha</label>
            <asp:TextBox ID="txtSenha" CssClass="form-control" runat="server" TextMode="Password"></asp:TextBox>
        </div>
     </div>
            
    <div class="row">           
        <div class="btn-group col-md-4 col-md-offset-4" id="botoes">
             <ul>
                <li><asp:Button ID="btnVoltar" CssClass="btn btn-danger btn-block" runat="server" Text="Voltar" OnClick="btnVoltar_Click" /></li>
                <li><asp:Button runat="server" cssClass="btn btn-primary btn-block" Text="Cadastrar" OnClick="btnCadastrar_Click" /></li>
            </ul>        
        </div>
     </div>

</section>
</form>
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

