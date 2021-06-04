using Web4pi;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Web4pi.Classes.Producao;

namespace Web4pi.Persistencia.Producao
{
    public class CardapioBD
    {
        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;

            string sql = "SELECT tbl_cardapio.ITE_ID, tbl_itens.ITE_NOME, tbl_itens.ITE_DESCRICAO, tbl_itens.ITE_VALORITEM, tbl_itens.ITE_CATEGORIA, tbl_itens.ITE_IMAGEM FROM tbl_cardapio INNER JOIN tbl_itens on (tbl_cardapio.ITE_ID = tbl_itens.ITE_ID)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }

        public bool Delete(int codigo)
        {

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "DELETE FROM TBL_CARDAPIO WHERE ITE_ID=?ID";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?ID", codigo));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }

        public bool Insert(int codigo, DateTime data)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO TBL_CARDAPIO (ITE_ID, CAR_DATA) VALUES (?ID, ?DATA)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?ID", codigo));
            objCommand.Parameters.Add(Mapped.Parameter("?DATA", data));


            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }


        public Cardapio VerificarItemId(int codigo)
        {
            IDbConnection objConexao;
            IDbCommand objComando;
            IDataReader objReader;
            Cardapio cardapio = null;

            string sql = "SELECT * FROM TBL_CARDAPIO WHERE ITE_ID =?ID";

            objConexao = Mapped.Connection();
            objComando = Mapped.Command(sql, objConexao);

            objComando.Parameters.Add(Mapped.Parameter("?ID", codigo));

            objReader = objComando.ExecuteReader();
            while (objReader.Read())
            {
                cardapio = new Cardapio();
                
            }

            objConexao.Close();
            objConexao.Dispose();
            objComando.Dispose();

            return cardapio;
        }


        public CardapioBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}