using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web4pi.Classes.Administrativo
{
    public class Pessoa
    {
        public int Id { get; set; }
        public int Tipo { get; set; }
        public int Ativo { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime DataCadastro { get; set; }


        public Pessoa()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}