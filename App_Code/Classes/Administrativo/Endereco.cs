using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web4pi.Classes.Administrativo
{
    public class Endereco
    {
        public int Id { get; set; }
        public string TipoLogradouro { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }




        public Endereco()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}