<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Administrativo/ClientePage.master" AutoEventWireup="true" CodeFile="VisualizaCardapio.aspx.cs" Inherits="Pages_Producao_VisualizaCardapio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>Cardápio do dia</h3>
    <div class="row">
        <div class="col-md-3 col-md-offset-3">
            <asp:Label ID="lblMensagemErro" runat="server" BackColor="Red" ForeColor="White"></asp:Label>
    <asp:gridview CssClass="table table-condensed table-hover table-responsive table-bordered" ID="gdvCardapio" runat="server" AutoGenerateColumns="False" OnRowCommand="gdvCardapio_RowCommand">
        <Columns>
            <asp:ImageField DataImageUrlField="ITE_IMAGEM">
            </asp:ImageField>
            <asp:BoundField DataField="ITE_NOME"/>          
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="lbEnviar" runat="server" CommandName="enviar" CommandArgument='<%# Bind ("ite_id") %>'>    (+)    </asp:LinkButton>
            </ItemTemplate>
            <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>
        </Columns>       
    </asp:gridview>
        </div>
      
</div>
   
</asp:Content>

