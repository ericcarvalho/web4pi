using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Pages_Administrativo_ClientePage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToBoolean(Session["autenticado"]) == false)
        {

            Response.Redirect("http://localhost:57527/Pages/Administrativo/Login.aspx");
            
        }
    }
    protected void lbSair1_Click(object sender, EventArgs e)
    {
        Session.Clear();
        Session.RemoveAll();
        Session.Abandon();
        Session["autenticado"] = false;
        Response.Redirect("http://localhost:57527/Pages/Administrativo/Login.aspx");
    }

  
}
