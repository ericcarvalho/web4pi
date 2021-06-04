<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CadastrarCliente.aspx.cs" Inherits="Pages_Administrativo_CadastrarCliente" %>

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
        <span class="mdl-layout-title"><a href="Restaurantes.aspx"><img src="../../Imagens/WEBFOODEXPRESS1.jpg" /></a></span>
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
        <span class="mdl-layout-title"><a href="Restaurantes.aspx"><img src="../../Imagens/WEBFOODEXPRESS1.jpg" /></a></span>
        <nav class="mdl-navigation">
        <a class="mdl-navigation__link" href="">Termos de uso</a>
        <a class="mdl-navigation__link" href="CadastrarRestaurantes.aspx">Cadastro de Restaurante</a>    
        </nav>
    </div>
  
    </div>
    <section id="corpo">
    <form id="form2" runat="server">
         <div class="row">
        <div class="form-group col-md-3 col-md-offset-2">
            <label for="txtNome">Nome</label>
            <asp:TextBox ID="txtNome" CssClass="form-control" runat="server"  Width="300px"></asp:TextBox>
            
            <label for="txtSobrenome">Sobrenome</label>
            <asp:TextBox ID="txtSobreNome" CssClass="form-control" runat="server"  Width="300px"></asp:TextBox>
            <label for="txtTelefone">Telefone</label>
            <asp:TextBox ID="txtTelefone" CssClass="form-control" runat="server" placeholder="(__)_____-___" Width="300px"></asp:TextBox>
            <label for="txtCpf">Cpf</label>
            <asp:TextBox ID="txtCpf" CssClass="form-control" runat="server" placeholder="___.___.___-__" Width="300px"></asp:TextBox>
            <label for="txtDataNascimento">Data de Nascimento</label>
            <asp:TextBox ID="txtDataNascimento" CssClass="form-control" runat="server" placeholder="dd/mm/aaaa" Width="300px"></asp:TextBox>    
            <label for="txtEmail">Email</label>
            <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" placeholder="seunome@provedor.com.br"  Width="300px"></asp:TextBox>
            <label for="txtSenha">Senha</label>
            <asp:TextBox ID="txtSenha" CssClass="form-control" runat="server" TextMode="Password" placeholder="********" Width="300px"></asp:TextBox>
            </div>
            <div class="form-group col-md-3 col-md-offset-0"> 
            <label for="txtCep">Cep</label>
            <asp:TextBox ID="txtCep" CssClass="form-control" runat="server" Width="300px"></asp:TextBox>
            
            <label for="txtCidade">Cidade</label>
            <asp:TextBox ID="txtCidade" CssClass="form-control" runat="server" Width="300px"></asp:TextBox>
            <label for="txtEstado">Estado</label>
            <asp:TextBox ID="txtEstado" CssClass="form-control" runat="server" Width="300px"></asp:TextBox>
            <label for="txtTipoLogradouro">Tipo Logradouro</label>
            <asp:TextBox ID="txtTipoLogradouro" CssClass="form-control" runat="server" Width="300px"></asp:TextBox>
            <label for="txtLogradouro">Logradouro</label>
            <asp:TextBox ID="txtLogradouro" CssClass="form-control" runat="server" Width="300px"></asp:TextBox>
            <label for="txtBairro">Bairro</label>
            <asp:TextBox ID="txtBairro" CssClass="form-control" runat="server" Width="300px"></asp:TextBox>
            <label for="txtComplemento">Complemento</label>
            <asp:TextBox ID="txtComplemento" CssClass="form-control" runat="server" Width="300px"></asp:TextBox>
            <label for="txtNumero">Número</label>
            <asp:TextBox ID="txtNumero" CssClass="form-control" runat="server" Width="300px"></asp:TextBox>         
        </div>
             <div class="col-md-0 col-md-offset-0" id="busca-cep"><asp:Button ID="btnBuscaCep" runat="server" Text="Busca Cep" OnClick="btnBuscaCep_Click" /></div>
        </div>
            
        <div class="row">           
            <div class="btn-group col-md-4 col-md-offset-4" id="botoes">
             <ul>
                <li><asp:Button ID="btnVoltar" CssClass="btn btn-danger btn-block" runat="server" Text="Voltar" OnClick="btnVoltar_Click" /></li>
                <li><asp:Button runat="server" cssClass="btn btn-primary btn-block" Text="Cadastrar" OnClick="btnCadastrar_Click" /></li>
                 <li><asp:Label ID="lblSucesso" runat="server"></asp:Label></li>
                 <li><asp:Label ID="lblErro" runat="server"></asp:Label></li>
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
