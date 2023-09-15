using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Epicode_U4_W3_D5_Benchmark
{
    public class Articolo
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Quantita { get; set; }
        public string Foto { get; set; }

        
        public static List<Articolo> ArticoliList { get; set; } = new List<Articolo>();
        private static int GLOBAL_ID { get; set; } = 0;


        public Articolo(string nome, string descrizione, double prezzo, int quanita, string foto) 
        {
            GLOBAL_ID++;

            ID = GLOBAL_ID;
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Quantita = quanita;
            Foto = foto;
        }

        public static void aggiungiArticoli()
        {
            //Funzione di test solo per aggiungere qualche articolo ad apertura progetto
            ArticoliList.Add(new Articolo("NES", "Il Nintendo Entertainment System (NES), noto in Giappone con il nome di Famicom (ファミコン Famikon pronunciai?, fami(ly) com(puter)), è stata una console per videogiochi a 8-bit prodotta da Nintendo tra il 1983 e il 1995.", 100, 20, "NES-Console-Set.jpg"));
            ArticoliList.Add(new Articolo("SNES", "Il Super Nintendo Entertainment System (SNES), comunemente abbreviato in Super NES o Super Nintendo,[4][5][6] è una console per videogiochi a 16 bit sviluppata dalla giapponese Nintendo e commercializzata nel 1990 in Giappone e Corea del Sud,[7] nel 1991 in America del Nord, nel 1992 in Europa e Oceania e nel 1993 in America del Sud.", 200, 10, "Nintendo-Super-Famicom-Set-FL.jpg"));
            ArticoliList.Add(new Articolo("Nintendo 64", "Il Nintendo 64 (abbreviato N64) è una console per videogiochi da tavolo prodotta da Nintendo tra il 1996 e il 2002 e succeduta al Super Nintendo Entertainment System.", 300, 15, "N64-Console-Set.png"));
            ArticoliList.Add(new Articolo("Gamecube", "Il Nintendo GameCube (ニンテンドー ゲームキューブ Nintendō Gēmukyūbu?), anche noto come GameCube[11] (abbreviato come NGC[12] in Giappone o GCN[13] in Europa e Nord America), è una console prodotta da Nintendo. È stata una console di sesta generazione, assieme a Dreamcast, PlayStation 2 e Xbox.", 400, 20, "GameCube-Console-Set.png"));
            ArticoliList.Add(new Articolo("Wii", "Erede del Nintendo GameCube, i suoi 101,63 milioni di unità vendute l'hanno resa la console casalinga più popolare della settima generazione e la seconda di Nintendo, superata solo da Nintendo Switch. Wii è stato il principale concorrente di Xbox 360 di Microsoft e di PlayStation 3 di Sony.", 500, 5, "390px-Wii-console.jpg"));
            ArticoliList.Add(new Articolo("Wii U", "Wii U (ウィー・ユー Wī Yū?, pronunciato come i pronomi inglesi we [wiː] \"noi\" e you [juː] \"tu\" o \"voi\") è una console per videogiochi prodotta da Nintendo. É il successore di Wii pur non sostituendolo in alcuni paesi ed è stata la prima console da tavolo dell'ottava generazione ad essere immessa sul mercato.", 600, 1, "Wii_U_Console_and_Gamepad.png"));
        }
    }

    public class Carrello
    {
        public List<Articolo> Articoli { get; set; } = new List<Articolo>();
        public double Totale { get; set; } = 0;

        public void addArticolo(Articolo articolo)
        {
            Articolo.ArticoliList.Where(art => art.ID == articolo.ID).FirstOrDefault().Quantita--;
            Articoli.Add(articolo);
            Totale += articolo.Prezzo;
        }

        public void removeArticolo(int id)
        {
            //Prendo l'articolo e lo rimuovo dal carrello
            Articolo articolo = Articolo.ArticoliList.Where((art) => art.ID == id).FirstOrDefault();
            Totale -= articolo.Prezzo;
            Articoli.Remove(articolo);

            //Lo rendo di nuovo disponibile
            Articolo.ArticoliList.Where(art => art.ID == id).FirstOrDefault().Quantita++;
        }

        public void removeAllArticoli()
        {
            foreach (var articolo in Articoli)
                Articolo.ArticoliList.Where(art => art.ID == articolo.ID).FirstOrDefault().Quantita++;
            Articoli = new List<Articolo>();
            Totale = 0;
        }
    }
}