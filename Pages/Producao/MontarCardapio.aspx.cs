using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web4pi.Classes.Producao;
using Web4pi.Persistencia.Producao;

public partial class Pages_Producao_MontarCardapio : System.Web.UI.Page
{
    private void CarregaGrid()
    {
        ItemBD itemBD = new ItemBD();
        DataSet ds = itemBD.SelectAll();
        gdvItensCardapio.DataSource = ds.Tables[0].DefaultView;
        gdvItensCardapio.DataBind();
        
    }

    private void CarregaGrid2()
    {      

        CardapioBD cardBD = new CardapioBD();
        DataSet ds = cardBD.SelectAll();
        gdvCardapio.DataSource = ds.Tables[0].DefaultView;
        gdvCardapio.DataBind();


    }


    protected void Page_Load(object sender, EventArgs e)
    {
        CarregaGrid();
        CarregaGrid2();
    }

    protected void gdvItensCardapio_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        Cardapio car = new Cardapio();
        
        
        int idItem = 0;
        
        DateTime data = DateTime.Now;

            switch (e.CommandName)
            {
                case "adicionar":
                    idItem = Convert.ToInt32(e.CommandArgument);
                    CardapioBD carBD = new CardapioBD();

                    if (carBD.VerificarItemId(idItem) != null)
                    {
                        lblMensagemErro.Text = "Item " + idItem + " já existente no cardápio";
                    }
                    else
                    {
                        carBD.Insert(idItem, data);
                        lblMensagemErro.Text = "";
                        CarregaGrid();
                        CarregaGrid2();

                    }
                

                    break;
                default:
                    break;

            }
    }

    protected void gdvCardapio_RowCommand(object sender, GridViewCommandEventArgs e)
    {       
       Cardapio car = new Cardapio();
       int idCardapio = 0;
       switch(e.CommandName)
        {
            case "retirar":
                idCardapio = Convert.ToInt32(e.CommandArgument);
                CardapioBD carBD = new CardapioBD();
                carBD.Delete(idCardapio);
                lblMensagemErro.Text = "";
                CarregaGrid2();
                break;
            default:
                break;


        }
    }

}