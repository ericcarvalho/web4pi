using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web4pi.Classes.Producao;

namespace Web4pi.Persistencia.Producao
{
    public class MarmitexItens
    {
        public int Id { get; set; }
        public Cardapio Cardapio { get; set; }


        public MarmitexItens()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}