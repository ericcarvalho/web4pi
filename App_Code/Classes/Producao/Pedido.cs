using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web4pi.Classes.Administrativo;
using Web4pi.Persistencia.Producao;

public class Pedido
{

    public int Id { get; set; }
    public double ValorTotal { get; set; }
    public DateTime DataPedido { get; set; }
    public Pessoa Pessoa { get; set; }
    public PedidoStatus PedidoStatus { get; set; }
    public Pagamento Pagamento { get; set; }




    public Pedido()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}