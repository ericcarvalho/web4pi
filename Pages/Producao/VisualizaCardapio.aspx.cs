using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web4pi.Classes.Producao;
using Web4pi.Persistencia.Producao;

public partial class Pages_Producao_VisualizaCardapio : System.Web.UI.Page
{
    

    private void CarregaGrid()
    {
        CardapioBD carBD = new CardapioBD();
        DataSet ds = carBD.SelectAll();
        gdvCardapio.DataSource = ds.Tables[0].DefaultView;
        gdvCardapio.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {         
            CarregaGrid();



    }
    protected void gdvCardapio_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        
        MarmitexItens marIt = new MarmitexItens();
        MarmitexItensBD marItBD = new MarmitexItensBD();

        Marmitex mar = new Marmitex();
        MarmitexBD marBD = new MarmitexBD();



        switch (e.CommandName)
            {
                case "enviar":

                int itemId = 0;
                itemId = Convert.ToInt32(e.CommandArgument);
                marItBD.Insert(itemId);
                //tem que dar update na tabela marmitex

                CarregaGrid();



                    break;
                default:
                    break;




            }
       
    }



    protected void btnFinalizar_Click(object sender, EventArgs e)
    {
        
    }
}


