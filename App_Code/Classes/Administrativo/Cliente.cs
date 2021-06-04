using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web4pi.Classes.Administrativo
{
    public class Cliente:Pessoa
    {

        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
       



        public Cliente()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}