using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Web4pi.Classes.Producao;

namespace Web4pi.Persistencia.Producao
{
    public class MarmitexBD
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



       

        public bool Insert(int codigo4 )
        {

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;

            string sql = "INSERT INTO TBL_MARMITEX (MAR_QUANT, ped_id) VALUES (?QUANT,(Select MAX(ped_id) from tbl_pedido))";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?QUANT", codigo4));


            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }







        public int GetUltimoID(Marmitex marmitex)
        {
            int retorno = 0;

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            System.Data.IDataReader objDataReader;

            objConexao = Mapped.Connection();
            string sql = "SELECT * FROM TBL_MARMITEX WHERE MAR_ID=?ID";
            objCommand = Mapped.Command(sql, objConexao);

            objCommand.Parameters.Add(Mapped.Parameter("?id", marmitex.Id));

            objDataReader = objCommand.ExecuteReader();
            while (objDataReader.Read())
            {
                Marmitex mar = new Marmitex();
                mar.Id = Convert.ToInt32(objDataReader["MAR_ID"]);
                retorno = mar.Id;
            }

            objDataReader.Close();
            objConexao.Close();

            objCommand.Dispose();
            objConexao.Dispose();
            objDataReader.Dispose();

            return retorno;
        }


        public MarmitexBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}
