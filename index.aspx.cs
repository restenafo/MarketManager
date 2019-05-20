using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarketManager
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNlogin_Click(object sender, EventArgs e)
        {
            if (TXTusername.Text!="" && TXTpassword.Text!="")
            {
                if (TXTusername.Text=="SuperAdmin" && TXTpassword.Text=="SuperAdminPassword")
                {
                    bool utenteAutorizzato = true;
                    Session["loggato"] = true;
                    Session["administrator"] = true;
                    Session["username"] = "Amministratore";
                    Response.Redirect("landing.aspx");
                }
            }
        }
    }
}