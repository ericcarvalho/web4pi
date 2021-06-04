

using Web4pi.Classes.Administrativo;
using Web4pi.Persistencia.Administrativo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class Pages_Administrativo_CadastrarCliente : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCadastrar_Click(object sender, EventArgs e)
    {
        Cliente cli = new Cliente();
        Endereco end = new Endereco();

        //usar classe cultureinfo que faz com que todas string jogada para variavel "PrimeiraLetra" tenha a primeira letra de cada palavra maiuscula
        //e em seguida as stopword tem um replace para minuscula 
        System.Globalization.CultureInfo PrimeiraLetra = System.Threading.Thread.CurrentThread.CurrentCulture;
        cli.Nome = txtNome.Text;
        cli.Nome = PrimeiraLetra.TextInfo.ToTitleCase(cli.Nome);
        cli.Nome = cli.Nome.Replace("De ", "de ").Replace("Da ", "da ").Replace("Das ", "das ").Replace("Dos ", "dos ");

        cli.Nome = txtNome.Text;
        cli.Sobrenome = txtSobreNome.Text;
        cli.Telefone = txtTelefone.Text;
        cli.Cpf = txtCpf.Text;
        cli.Email = txtEmail.Text;
        
        //criptografar a senha no banco 
        cli.Senha = Crip.GetSHA256(txtSenha.Text);
        cli.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);

        end.Logradouro = txtLogradouro.Text;
        end.TipoLogradouro = txtTipoLogradouro.Text;
        end.Bairro = txtBairro.Text;      
        end.Cep = txtCep.Text;
        end.Cidade = txtCidade.Text;
        end.Estado = txtEstado.Text;
        end.Numero = txtNumero.Text;
        end.Complemento = txtComplemento.Text;

        DateTime data = DateTime.Now;
        cli.DataCadastro = data;

        ClienteBD cliBD = new ClienteBD();
        EnderecoBD endBD = new EnderecoBD();

        //insert no endereco
        endBD.Insert(end);

        //recupera o PK do ultimo endereço cadastrado
        int codigoEndereco = endBD.GetUltimoID(end);
        //atribui o valor da FK para cli.endereco para dar insert na tabela
        cli.Endereco = endBD.SelectEndereco(codigoEndereco);

      if(cliBD.Insert(cli))
        {
            txtCidade.Text = string.Empty;
            txtComplemento.Text = string.Empty;
            txtCpf.Text = string.Empty;
            txtDataNascimento.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEstado.Text = string.Empty;
            txtCep.Text = string.Empty;
            txtBairro.Text = string.Empty;
            txtLogradouro.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtSenha.Text = string.Empty;
            txtSobreNome.Text = string.Empty;
            txtTelefone.Text = string.Empty;
            txtTipoLogradouro.Text = string.Empty;
            lblSucesso.Text = "Cadastro realizado com sucesso";
        }
        else
        {
            lblErro.Text = "Houve um problema ao cadastrar, contate o administrador do sistema!";
        }

        

    }

    protected void btnVoltar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
    }

    protected void btnBuscaCep_Click(object sender, EventArgs e)
    {
        string urlConsulta = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml";

        DataSet dsRetornaEndereco = new DataSet();

        dsRetornaEndereco.ReadXml(urlConsulta.Replace("@cep", txtCep.Text));

        string retorno = dsRetornaEndereco.Tables[0].Rows[0]["resultado"].ToString();

        if (retorno == "0")
        {
           //messageBox.Show("Cep inválido");
        }
        else
        {
            txtTipoLogradouro.Text = dsRetornaEndereco.Tables[0].Rows[0]["tipo_logradouro"].ToString();
            txtLogradouro.Text = dsRetornaEndereco.Tables[0].Rows[0]["logradouro"].ToString();
            txtCidade.Text = dsRetornaEndereco.Tables[0].Rows[0]["Cidade"].ToString();
            txtEstado.Text = dsRetornaEndereco.Tables[0].Rows[0]["uf"].ToString();
            txtBairro.Text = dsRetornaEndereco.Tables[0].Rows[0]["Bairro"].ToString();
            

        }
    }
}