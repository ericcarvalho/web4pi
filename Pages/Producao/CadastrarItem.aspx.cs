using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web4pi.Classes.Producao;
using Web4pi.Persistencia.Producao;

public partial class Pages_Producao_CadastrarItem : System.Web.UI.Page
{
    private object myModal;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSalvar_Click(object sender, EventArgs e)
    {
        Item item = new Item();
        item.Nome = txtNome.Text;
        item.Categoria = ddlCategoria.Text;
        //ver como a imagem será inserida (LINK)
        item.Imagem = null;

        ItemBD bd = new ItemBD();
        if (bd.Insert(item))
        {
            myModal = "Cadastrado";
        }
        else
        {
            lblMensagem.Text = "Item não salvo!";
        }
    }
}