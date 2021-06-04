using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web4pi.Classes.Administrativo;
using Web4pi.Persistencia.Administrativo;
using Web4pi.Persistencia.Producao;

public partial class Pages_Administrativo_StartPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void lkbFazerPedido_Click(object sender, EventArgs e)
    {
        /*
        Marmitex mar = new Marmitex();
        MarmitexBD marBD = new MarmitexBD();
        ClienteBD cliBD = new ClienteBD();
        Cliente cli = new Cliente();
        Pedido ped = new Pedido();
        PedidoBD pedBD = new PedidoBD();
               
        
        int quant = 1;
        // int cliente = Convert.ToInt32(Session["Cliente"]);
         cli.Id = cliBD.SelectCliente(Session["Cliente"]));

        ped.Pessoa.Id = cli.Id;

        pedBD.Insert(ped);

            mar.Quantidade = quant;

            marBD.Insert(quant);*/
            Response.Redirect("../Producao/VisualizaCardapio.aspx");
        

   
        

       
    }


}