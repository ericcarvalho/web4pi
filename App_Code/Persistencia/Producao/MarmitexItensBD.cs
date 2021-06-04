using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web4pi;

namespace Web4pi.Persistencia.Producao
{
    public class MarmitexItensBD
    {
        public bool Insert(int codigo)
        {

            System.Data.IDbConnection objConexao;
            System.Data.IDbCommand objCommand;

            string sql = "INSERT INTO TBL_MARMITEX_ITENS (CAR_ITE_ID, MAR_ID) VALUES (?CAR_ITE_ID,(Select MAX(mar_id) from tbl_marmitex))";

            objConexao = Mapped.Connection();
            objCommand = Mapped.Command(sql, objConexao);


           
            objCommand.Parameters.Add(Mapped.Parameter("?CAR_ITE_ID", codigo));


            objCommand.ExecuteNonQuery();
            objConexao.Close();
            objCommand.Dispose();
            objConexao.Dispose();

            return true;
        }

        public MarmitexItensBD()
        {
            //
            // TODO: Add constructor logic here
            //
        }
    }
}