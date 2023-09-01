using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    internal static class ContributiSoftware
    {
        public static List<Contribuente> TuttiContribuenti = new List<Contribuente>();

        public static void ContribuenteMenu()
        {
            Console.WriteLine("*---- Menù programma contribuente ----*");
            Console.WriteLine("1 - Crea un nuovo contribuente");
            Console.WriteLine("2 - Visualizza tutti i contribuenti analizzati");
            byte chose = 0;
            try
            {
                chose = Byte.Parse(Console.ReadLine());
            }
            catch (Exception ex) { Console.WriteLine($"Errore {ex.Message}"); }

            switch (chose)
            {
                case 1:
                    CreaContribuente();
                    break;

                case 2:
                    ShowAll();
                    break;

                default: Console.WriteLine("scelta errata"); ContribuenteMenu(); break;
            }
        }

        private static void CreaContribuente()
        {
            Console.WriteLine("");
            Console.WriteLine("*---- Creazione nuovo contribuente ----*");
            Console.WriteLine("");
            Console.WriteLine("Inserisci il nome");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il cognome");
            string cognome = Console.ReadLine();
            Console.WriteLine("Inserisci la data di nascita");
            DateTime dataN = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il codice fiscale");
            string codFisc = Console.ReadLine();
            Console.WriteLine("Inserisci il sesso (M o F)");
            string sesso = Console.ReadLine();
            Console.WriteLine("Inserisci il comune di residenza");
            string comRes = Console.ReadLine();
            Console.WriteLine("Inserisci il reddito annuo");
            double reddito = Double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double impostaDaPagare = CalcoloImposta(reddito);
            Contribuente newContr = new Contribuente(nome, cognome, dataN, codFisc, sesso, comRes, reddito, impostaDaPagare);
            TuttiContribuenti.Add(newContr);
            Console.WriteLine("");
            Console.WriteLine("*---- FINE Creazione nuovo contribuente ----*");
            Console.WriteLine("");
            newContr.MostraQuestoContribuente();
            ContribuenteMenu();
        }

        private static double CalcoloImposta(double reddito)
        {
            double risultato = 0;
            if (reddito < 15000) risultato = reddito * 23 / 100;
            else if (reddito < 28000) risultato = 3450 + ((reddito - 15000) * 23 / 100);
            else if (reddito < 75000) risultato = 17220 + ((reddito - 55000) * 41 / 100);
            else if (reddito < 55000) risultato = 6960 + ((reddito - 28000) * 38 / 100);
            else if (reddito < 75000) risultato = 17220 + ((reddito - 55000) * 41 / 100);
            else risultato = 25420 + ((reddito - 75000) * 43 / 100);
            return risultato;
        }

        private static void ShowAll()
        {
            Console.WriteLine("");
            Console.WriteLine("*---- INIZIO Lista di tutti i contribuenti ----*");
            Console.WriteLine("");
            foreach (Contribuente item in TuttiContribuenti)
            {
                //Console.WriteLine($"nome {item.Nome}");
                item.MostraQuestoContribuente();
            }
            Console.WriteLine("");
            Console.WriteLine("*---- FINE Lista di tutti i contribuenti ----*");
            Console.WriteLine("");
            ContribuenteMenu();
        }
    }
}