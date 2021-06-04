using Web4pi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web4pi.Classes.Administrativo;

namespace Web4pi.Persistencia.Administrativo
{
    public class EnderecoBD
    {

        public bool Insert(Endereco endereco)
        {
            
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO TBL_ENDERECOS(END_CEP, END_CIDADE, END_ESTADO, END_TIPOLOGRADOURO, END_LOGRADOURO, END_BAIRRO, END_NUMERO, END_COMPLEMENTO) VALUES (?CEP, ?CIDADE, ?ESTADO, ?TIPOLOGRADOURO, ?LOGRADOURO, ?BAIRRO, ?NUMERO, ?COMPLEMENTO)";
            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?CEP", endereco.Cep));
            objCommand.Parameters.Add(Mapped.Parameter("?CIDADE", endereco.Cidade));
            objCommand.Parameters.Add(Mapped.Parameter("?ESTADO", endereco.Estado));
            objCommand.Parameters.Add(Mapped.Parameter("?TIPOLOGRADOURO", endereco.TipoLogradouro));
            objCommand.Parameters.Add(Mapped.Parameter("?LOGRADOURO", endereco.Logradouro));
            objCommand.Parameters.Add(Mapped.Parameter("?BAIRRO", endereco.Bairro));
            objCommand.Parameters.Add(Mapped.Parameter("?NUMERO", endereco.Numero));
            objCommand.Parameters.Add(Mapped.Parameter("?COMPLEMENTO", endereco.Complemento));
            
            
            

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }

        public Endereco SelectEndereco(int codigo)
        {
            Endereco endereco = null;

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;

            objConexao = Mapped.Connection();
            string sql = "SELECT * FROM TBL_ENDERECOS WHERE END_ID=?ID";
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?ID", codigo));

            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                endereco = new Endereco();
                endereco.Id = Convert.ToInt32(objDataReader["END_ID"]);
                endereco.TipoLogradouro = Convert.ToString(objDataReader["END_TIPOLOGRADOURO"]);
                endereco.Logradouro = Convert.ToString(objDataReader["END_LOGRADOURO"]);
                endereco.Numero = Convert.ToString(objDataReader["END_NUMERO"]);
                endereco.Bairro = Convert.ToString(objDataReader["END_BAIRRO"]);
                endereco.Complemento = Convert.ToString(objDataReader["END_COMPLEMENTO"]);
                endereco.Cep = Convert.ToString(objDataReader["END_CEP"]);
                endereco.Cep = Convert.ToString(objDataReader["END_CIDADE"]);
                endereco.Cep = Convert.ToString(objDataReader["END_ESTADO"]);
                
            }

            objDataReader.Close();
            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return endereco;
        }

        public int GetUltimoID(Endereco endereco)
        {

            int retorno = 0;

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;

            objConexao = Mapped.Connection();
            string sql = "SELECT * FROM TBL_ENDERECOS WHERE END_LOGRADOURO=?logradouro AND END_CEP=?cep";
            objCommand = Mapped.Command(sql, objConexao);
            objCommand.Parameters.Add(Mapped.Parameter("?logradouro", endereco.Logradouro));
            objCommand.Parameters.Add(Mapped.Parameter("?cep", endereco.Cep));

            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                Endereco end = new Endereco();
                end.Id = Convert.ToInt32(objDataReader["END_ID"]);
                retorno = end.Id;
            }

            objDataReader.Close();
            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return retorno;
        }


        public EnderecoBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}