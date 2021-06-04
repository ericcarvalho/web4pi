using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web4pi.Classes.Administrativo
{
    public class Restaurante:Pessoa
    {
        
        public string NomeEmpresa { get; set; }
        public string Cnpj { get; set; }
        public DateTime DataRegistro { get; set; }
        public int RestauranteStatus { get; set; }


        public Restaurante()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}