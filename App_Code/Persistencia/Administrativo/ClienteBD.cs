using Web4pi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web4pi.Classes.Administrativo;

namespace Web4pi.Persistencia.Administrativo
{
    public class ClienteBD
    {

        public bool Insert(Cliente cliente)
        {
           
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;

            string sql = "INSERT INTO TBL_PESSOAS(PES_TIPO, PES_ATIVO, PES_NOME, PES_SOBRENOME, PES_CPF, PES_DATANASCIMENTO, PES_TELEFONE, PES_EMAIL, PES_SENHA, PES_DATACADASTRO, END_ID) VALUES (?TIPO, ?ATIVO, ?NOME, ?SOBRENOME, ?CPF, ?DATANASCIMENTO, ?TELEFONE, ?EMAIL, ?SENHA, ?DATACADASTRO, ?ENDERECO)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?TIPO", 2));
            //para indicar se esta ativo ou nao esta sendo usando 0(inativo) 1(ativo)
            //ele cadastra o usuario com 1 que indica que o usuario esta ativo//
            objCommand.Parameters.Add(Mapped.Parameter("ATIVO", 1));
            objCommand.Parameters.Add(Mapped.Parameter("?NOME", cliente.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?SOBRENOME", cliente.Sobrenome));
            objCommand.Parameters.Add(Mapped.Parameter("?CPF", cliente.Cpf));
            objCommand.Parameters.Add(Mapped.Parameter("?DATANASCIMENTO", cliente.DataNascimento));
            objCommand.Parameters.Add(Mapped.Parameter("?TELEFONE", cliente.Telefone));
            objCommand.Parameters.Add(Mapped.Parameter("?EMAIL", cliente.Email));
            objCommand.Parameters.Add(Mapped.Parameter("?SENHA", cliente.Senha));
            objCommand.Parameters.Add(Mapped.Parameter("?DATACADASTRO", cliente.DataCadastro));
            objCommand.Parameters.Add(Mapped.Parameter("?ENDERECO", cliente.Endereco.Id));
            


            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }
        public Cliente ValidaUsuario(int Tipo, int Ativo, string Email, string Senha)
        {


            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;
            Cliente cliente = null;

            string sql = "SELECT PES_TIPO, PES_ATIVO, PES_EMAIL, PES_SENHA FROM TBL_PESSOAS WHERE PES_TIPO=?tipo AND PES_ATIVO=?ativo AND PES_EMAIL=?email and PES_SENHA=?senha";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?tipo", 2));
            objCommand.Parameters.Add(Mapped.Parameter("?ativo", 1));
            objCommand.Parameters.Add(Mapped.Parameter("?email", Email));
            objCommand.Parameters.Add(Mapped.Parameter("?senha", Senha));

            //EXECUTA COMANDO NO BD
            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {

                cliente = new Cliente();
                cliente.Email = Convert.ToString(objDataReader["PES_EMAIL"]);
                cliente.Senha = Convert.ToString(objDataReader["PES_SENHA"]);

            }
            objDataReader.Close();
            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return cliente;
        }

        public Cliente SelectCliente(int codigo)
        {
            Cliente cliente = null;

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;

            objConexao = Mapped.Connection();
            string sql = "SELECT * FROM TBL_PESSOAS WHERE PES_ID=?ID";
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?ID", codigo));

            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                cliente = new Cliente();
                cliente.Id = Convert.ToInt32(objDataReader["PES_ID"]);
                
            }

            objDataReader.Close();
            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return cliente;
        }

        public ClienteBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}