using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Web4pi;
using Web4pi.Classes.Producao;

namespace Web4pi.Persistencia.Producao
{
    public class ItemBD
    {

        public bool Insert(Item item)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO tbl_itens(ite_nome, ite_categoria, ite_imagem) VALUES (?nome, ?categoria, ?imagem)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

          
            objCommand.Parameters.Add(Mapped.Parameter("?nome", item.Nome));
            objCommand.Parameters.Add(Mapped.Parameter("?categoria", item.Categoria));
            objCommand.Parameters.Add(Mapped.Parameter("?imagem", item.Imagem));

            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }

        public DataSet SelectAll()
        {
            DataSet ds = new DataSet();

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataAdapter objDataAdapter;

            string sql = "SELECT * FROM TBL_ITENS";


            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);
            objDataAdapter = Mapped.Adapter(objCommand);
            objDataAdapter.Fill(ds);

            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();

            return ds;
        }
        public Item VerificarItemId(int codigo)
        {
            IDbConnection objConexao;
            IDbCommand objComando;
            IDataReader objReader;
            Item item = new Item();

            string sql = "SELECT ite_nome FROM tbl_itens WHERE ITE_ID =?ID";

            objConexao = Mapped.Connection();
            objComando = Mapped.Command(sql, objConexao);

            objComando.Parameters.Add(Mapped.Parameter("?ID", codigo));

            objReader = objComando.ExecuteReader();

            objConexao.Close();
            objConexao.Dispose();
            objComando.Dispose();

            return item;
        }


        public ItemBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}