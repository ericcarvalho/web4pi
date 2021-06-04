using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web4pi.Classes.Administrativo;
using Web4pi.Persistencia.Administrativo;

public partial class Pages_Administrativo_CadastrarRestaurantes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        Restaurante rest = new Restaurante();
        

        //usar classe cultureinfo que faz com que todas string jogada para variavel "PrimeiraLetra" tenha a primeira letra de cada palavra maiuscula
        //e em seguida as stopword tem um replace para minuscula 
        System.Globalization.CultureInfo PrimeiraLetra = System.Threading.Thread.CurrentThread.CurrentCulture;
        rest.Nome = txtNome.Text;
        rest.Nome = PrimeiraLetra.TextInfo.ToTitleCase(rest.Nome);
        rest.Nome = rest.Nome.Replace("De ", "de ").Replace("Da ", "da ").Replace("Das ", "das ").Replace("Dos ", "dos ");
        rest.Nome = txtNome.Text;
        rest.NomeEmpresa = txtNomeEmpresa.Text;
        rest.Cnpj = txtCnpj.Text;
        rest.Email = txtEmail.Text;

        //criptografar a senha no banco 
        rest.Senha = Crip.GetSHA256(txtSenha.Text);

        DateTime data = DateTime.Now;
        rest.DataCadastro = data;

        RestauranteBD restBD = new RestauranteBD();
        
        restBD.Insert(rest);



    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    
}