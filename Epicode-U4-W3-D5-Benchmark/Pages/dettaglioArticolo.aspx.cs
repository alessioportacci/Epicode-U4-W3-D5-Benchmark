using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Epicode_U4_W3_D5_Benchmark.Pages
{
    public partial class dettaglioArticolo : System.Web.UI.Page
    {
        protected Articolo Articolo = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            try 
            {
                int urlID = Int32.Parse(Request.QueryString["ID"]);
                Articolo = Articolo.ArticoliList.Where(articolo => articolo.ID == urlID).FirstOrDefault();
                riempiCampi();            
            }
            catch
            {
                Response.Redirect("default.aspx");
            }

        }


        private void riempiCampi()
        {
            Immagine.Src = string.Concat("../Content/imgs/", Articolo.Foto);

            Nome.InnerText = String.Concat(Articolo.Nome, " - ", Articolo.Prezzo, "€");
            Descrizione.InnerText = Articolo.Descrizione;
            Rimaste.InnerText = String.Concat(Articolo.Quantita, " unità rimaste");

            if (Articolo.Quantita == 0)
                Aggiungi.Enabled = false;
        }

        protected void Aggiungi_Click(object sender, EventArgs e)
        {
            Carrello carrello = (Carrello)Session["Carrello"];
            carrello.addArticolo(Articolo);
            Session["Carrello"] = carrello;
            Aggiunto.InnerText = "Aggiunto al carrello";
            Response.Redirect(Page.Request.Url.ToString(), true);

        }


    }
}