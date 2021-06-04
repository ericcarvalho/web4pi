using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Web4pi.Persistencia.Producao;

public partial class Pages_Producao_ListarItem : System.Web.UI.Page
{
    private void Carrega()
    {
        ItemBD bd = new ItemBD();
        DataSet ds = bd.SelectAll();
        GridViewItem.DataSource = ds.Tables[0].DefaultView;
        GridViewItem.DataBind();
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        Carrega();
    }

    protected void GridViewItem_RowCommand(object sender, GridViewCommandEventArgs e)
    {

    }
}