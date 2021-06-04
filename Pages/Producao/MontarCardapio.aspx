<%@ Page Title="" Language="C#" MasterPageFile="~/Pages/Producao/ProprietarioPage.master" AutoEventWireup="true" CodeFile="MontarCardapio.aspx.cs" Inherits="Pages_Producao_MontarCardapio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
   <h3>Cardápio do dia</h3><asp:Label ID="lblMensagemErro" runat="server" BackColor="Red" ForeColor="White"></asp:Label>
    <div class="row">
        <div class="col-md-10 col-md-offset-1">
    <asp:gridview CssClass="table table-condensed table-hover table-responsive table-bordered" ID="gdvCardapio" runat="server" AutoGenerateColumns="False" OnRowCommand="gdvCardapio_RowCommand">
        <Columns>
           
            <asp:BoundField DataField="ITE_NOME" HeaderText="Nome" />
            <asp:BoundField DataField="ITE_DESCRICAO" HeaderText="Descrição" />
           
        <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="lbExcluir" runat="server" CommandName="retirar" CommandArgument='<%# Bind ("ite_id") %>'>Retirar</asp:LinkButton>
            </ItemTemplate>
            <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>
        </Columns>
        
    </asp:gridview>
        </div>
    </div>
 
    <h3>Itens de Cardápio</h3>
    
    <div class="row">
        <div class="col-md-10 col-md-offset-1">
    <asp:gridview CssClass="table table-condensed table-hover table-responsive table-bordered" ID="gdvItensCardapio" runat="server" AutoGenerateColumns="False" OnRowCommand="gdvItensCardapio_RowCommand">
        <Columns>
            <asp:BoundField DataField="ITE_NOME" HeaderText="Nome" />
            <asp:BoundField DataField="ITE_DESCRICAO" HeaderText="Descrição" />
            <asp:TemplateField>
            <ItemTemplate>
                <asp:LinkButton ID="lbAdicionar" runat="server" CommandName="adicionar" CommandArgument='<%# Bind ("ite_id") %>'>Adicionar</asp:LinkButton>
            </ItemTemplate>
            <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>
        </Columns>
    </asp:gridview>
        </div>
    </div>
</asp:Content>

