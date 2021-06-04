using Web4pi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web4pi.Classes.Administrativo;

namespace Web4pi.Persistencia.Administrativo
{

    public class RestauranteBD
    {
        public bool Insert(Restaurante restaurante)
        {

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;

            string sql = "INSERT INTO TBL_PESSOAS(PES_TIPO, PES_ATIVO, PES_NOME, PES_NOMEEMPRESA, PES_CNPJ, PES_EMAIL, PES_SENHA, PES_DATACADASTRO) VALUES (?TIPO, ?ATIVO, ?NOME, ?NOMEEMPRESA, ?CNPJ, ?EMAIL, ?SENHA, ?DATACADASTRO)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?TIPO", 1));
            //para indicar se esta ativo ou nao esta sendo usando 0(inativo) 1(ativo)
            //ele cadastra o usuario com 1 que indica que o usuario esta ativo//
            objCommand.Parameters.Add(Mapped.Parameter("ATIVO", 1));
            objCommand.Parameters.Add(Mapped.Parameter("?NOME", restaurante.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?NOMEEMPRESA", restaurante.NomeEmpresa));
            objCommand.Parameters.Add(Mapped.Parameter("?CNPJ", restaurante.Cnpj));
            objCommand.Parameters.Add(Mapped.Parameter("?EMAIL", restaurante.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?SENHA", restaurante.Senha));
            objCommand.Parameters.Add(Mapped.Parameter("?DATACADASTRO", restaurante.DataCadastro));
            



            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }
        public Restaurante ValidaRestaurante (int Tipo, int Ativo, string Email, string Senha)
        {


            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            Restaurante restaurante = null;

            string sql = "SELECT PES_TIPO, PES_ATIVO, PES_EMAIL, PES_SENHA FROM TBL_PESSOAS WHERE PES_TIPO=?tipo AND PES_ATIVO=?ativo AND PES_EMAIL=?email AND PES_SENHA=?senha";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?tipo", 1));
            objCommand.Parameters.Add(Mapped.Parameter("?ativo", 1));
            objCommand.Parameters.Add(Mapped.Parameter("?email", Email));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", Senha));

            //EXECUTA COMANDO NO BD
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {

                restaurante = new Restaurante();
                restaurante.Email = Convert.ToString(objDataReader["PES_EMAIL"]);
                restaurante.Senha = Convert.ToString(objDataReader["PES_SENHA"]);

            }
            objDataReader.Close();
            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return restaurante;
        }

        public RestauranteBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}