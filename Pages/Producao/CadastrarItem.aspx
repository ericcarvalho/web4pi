<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Producao/ProprietarioPage.master" AutoEventWireup="true" CodeFile="CadastrarItem.aspx.cs" Inherits="Pages_Producao_CadastrarItem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
  
        <h3>Cadastro de Itens</h3>
        <div class="row">
        <div class="form-group col-md-4 col-md-offset-1">
        
        <label for="txtNome">Nome:</label>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
   
      
        <label for="ddlCategoria">Categoria:</label>
        <asp:DropDownList ID="ddlCategoria" runat="server">
            <asp:ListItem>Arroz</asp:ListItem>
            <asp:ListItem>Feijão</asp:ListItem>
            <asp:ListItem>Mistura</asp:ListItem>
            <asp:ListItem>Massa</asp:ListItem>
            <asp:ListItem>Guarnição</asp:ListItem>
            <asp:ListItem>Salada</asp:ListItem>
        </asp:DropDownList>
   
        <asp:Label ID="lblImagem" runat="server" Text="Inserir Imagem"></asp:Label>
   
        <!-- MODAL <button type="button" class="btn btn-info btn-lg" data-toggle="modal" data-target="#myModal">Open Modal</button> -->
        <asp:Button class="btn btn-success btn-lg" data-toggle="modal" data-target="#myModal" ID="btnSalvar" runat="server" Text="Cadastrar" OnClick="btnSalvar_Click" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button class="btn btn-danger btn-lg" ID="btnCancelar" runat="server" Text="Cancelar" />
    
        <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        <div class="container">

            <!-- Modal -->
            <div class="modal fade" id="myModal" role="dialog">
                <div class="modal-dialog">

                    <!-- Modal content-->
                    <div class="modal-content">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal">&times;</button>
                            <h4 class="modal-title">Item cadastrado !</h4>
                        </div>
                        <div class="modal-body">
                            <p>Item cadastrado com sucesso.</p>
                        </div>
                        <div class="modal-footer">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        </div>
                    </div>

                </div>
            </div>
            </div>
            </div>
         </div>
</asp:Content>

