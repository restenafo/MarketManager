using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MarketManager
{
    public partial class landing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if  ((bool)Session["loggato"])
            {
                if ((bool)Session["administrator"])
                {
                    LBLwelcome.Text="Benvenuto "+ (string)Session["username"]+"!";
                    BTNgestioneDipendenti.CssClass = "btn btn-lg btnColorOne pulsante visibile";
                    BTNgestioneContabile.CssClass = "btn btn-lg btnColorSeven pulsante visibile";
                    BTNgestioneCasse.CssClass = "btn btn-lg btnColorTwo pulsante visibile";
                    BTNgestioneArticoliInVendita.CssClass = "btn btn-lg btnColorSix pulsante visibile";
                    BTNgestioneScaffali.CssClass = "btn btn-lg btnColorFive pulsante visibile";
                    BTNgestioneMagazzino.CssClass = "btn btn-lg btnColorThree pulsante visibile";
                }
            }
        }

        protected void BTNgestioneDipendenti_Click(object sender, EventArgs e)
        {
            Response.Redirect("gestioneDipendenti.aspx");
        }
    }
}