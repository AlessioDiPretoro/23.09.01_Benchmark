using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benchmark
{
    public class Contribuente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public string Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public double RedditoAnnuale { get; set; }
        public double ImpostaDaPagare { get; set; }

        public Contribuente(string _nome, string _cognome, DateTime _dataNascita,
            string _codFisc, string _sesso, string _comuneRes, double _redditoAnnuo, double impostaDaPagare)
        {
            Nome = _nome;
            Cognome = _cognome;
            DataNascita = _dataNascita;
            CodiceFiscale = _codFisc;
            Sesso = _sesso;
            ComuneResidenza = _comuneRes;
            RedditoAnnuale = _redditoAnnuo;
            ImpostaDaPagare = impostaDaPagare;
        }

        public void MostraQuestoContribuente()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("");
            Console.WriteLine("Calcolo dell'imposta da versare");
            Console.WriteLine($"Contribuente {Nome} {Cognome}");
            Console.WriteLine($"nato il {DataNascita.ToShortDateString()} {Sesso}");
            Console.WriteLine($"resitente in {ComuneResidenza}");
            Console.WriteLine($"codice fiscale {CodiceFiscale}");
            Console.WriteLine($"reddito dichiarato: {RedditoAnnuale}");
            Console.WriteLine($"IMPOSTA DA VERSARE: {ImpostaDaPagare}");
            Console.WriteLine("");
            Console.WriteLine("==================================================");
        }
    }
}