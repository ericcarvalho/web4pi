using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace Web4pi.Persistencia.Producao
{

    public class PedidoBD
    {

        public bool Insert(Pedido pedido)
        {
            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;
            string sql = "INSERT INTO TBL_PEDIDO (PES_ID) VALUE (?CLIENTE)";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


            objCommand.Parameters.Add(Mapped.Parameter("?CLIENTE", pedido.Pessoa.Id));


            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }




        public PedidoBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}