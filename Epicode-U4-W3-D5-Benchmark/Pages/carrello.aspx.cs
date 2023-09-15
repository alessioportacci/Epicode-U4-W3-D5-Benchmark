using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicode_U4_W3_D5_Benchmark.Pages
{
    public partial class carrello : System.Web.UI.Page
    {
        Carrello Shopping = new Carrello();

        protected void Page_Load(object sender, EventArgs e)
        {
            Shopping = (Carrello)Session["Carrello"];

            RepeaterCarrello.DataSource = Shopping.Articoli;
            RepeaterCarrello.DataBind();

            Totale.InnerText = String.Concat("Totale: ", Shopping.Totale.ToString(), "€");
        }

        protected void Rimuovi_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = Int32.Parse(btn.CommandArgument.ToString());
            Shopping.removeArticolo(id);
            Response.Redirect(Page.Request.Url.ToString(), true);
        }

        protected void SvuotaCarrello_Click(object sender, EventArgs e)
        {
            Shopping.removeAllArticoli();
            Response.Redirect(Page.Request.Url.ToString(), true);
        }
    }
}