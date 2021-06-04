using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web4pi.Classes.Administrativo;
using Web4pi.Persistencia.Administrativo;

public partial class Pages_Administrativo_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtEmail.Focus();
    }

    protected void btnEntrar_Click(object sender, EventArgs e)
    {
        ClienteBD cliBD = new ClienteBD();
        RestauranteBD restBD = new RestauranteBD();

        // a senha vai estar cripitografada no banco, para nao precisar descripitografar, usamos esse metodo e a senha que o usuario digita para logar fica cripitografada e eh comparada as duas senhas cripitografadas
        string senha = Crip.GetSHA256(txtSenha.Text);

        Cliente cli = cliBD.ValidaUsuario (2, 1, txtEmail.Text, senha);
        Restaurante rest = restBD.ValidaRestaurante (1, 1, txtEmail.Text, senha);


        if (cli != null)
        {
            Session["Cliente"] = cli.Id;
            Session["autenticado"] = true;
            Response.Redirect("SelecionarRestaurantes.aspx");
        }
        else
        {
            lblMensagemErro.Text = "Email ou senha inválida";

        }

        if(rest != null)
        {
            Session["Restaurante"] = rest.Id;
            Session["autenticado"] = true;
            Response.Redirect("../Producao/MontarCardapio.aspx");
        }
    }

    protected void lkbCadastrar_Click(object sender, EventArgs e)
    {
        Session["autenticado"] = true;
        Response.Redirect("CadastrarCliente.aspx");

    }


}