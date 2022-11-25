using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CalcoloTasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Esegui();
        }

        public static void Esegui()
        {
            Console.WriteLine("\n-------------------------------------------------------");
            Console.WriteLine("\n************** Portale calcolo imposte  *****************");
            Console.WriteLine("\n----------------------- V.1 ---------------------------");
            Console.WriteLine("\n \t ************** MENU ****************");
            Console.WriteLine("0 - per uscire");
            Console.WriteLine("1 -  Calcola imposte contribuente");
            Console.WriteLine("\n-------------------------------------------------------");


            switch (Console.ReadLine())
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":
                    CreaContribuente();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\t\t\n => Digita 0 o 1!!!!!");
                    Esegui();
                    break;
            }
        }

        public static void CreaContribuente()
        {
            try
            {
                Console.WriteLine("\n===============  Inserisci contribuente  ==============");
                Console.WriteLine("\nSeguire i seguenti passaggi");
                Console.WriteLine("\nDigita il tuo nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("\nDigita il tuo cognome: ");
                string cognome = Console.ReadLine();
                Console.WriteLine("\nDigita la tua data di nascita: ");
                string dataNascita = Console.ReadLine();
                var dataNascitaParse = DateTime.Parse(dataNascita);
                Console.WriteLine("\nDigita il tuo codice fiscale: ");
                string codiceFiscale = Console.ReadLine();
                Console.WriteLine("\nDigita M o F per il sesso: ");
                char sesso = char.Parse(Console.ReadLine());
                Console.WriteLine("\nDigita il tuo comune di residenza: ");
                string comuneResidenza = Console.ReadLine();
                Console.WriteLine("\nDigita il tuo reddito annuale: ");
                double redditoAnnuale = double.Parse(Console.ReadLine());

                Contribuente c = new Contribuente(nome, cognome, dataNascitaParse, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);

                Console.WriteLine("\n\t\tCalcolo tasse in corso....");
                Thread.Sleep(2000);
                c.CalcoloReddito();
                Console.WriteLine("================= Fine programma... ===============");
                Console.WriteLine("\n \t ************** MENU ****************");
                Console.WriteLine("\n0 - per uscire");
                Console.WriteLine("1 - Calcola imposte nuovo contribuente");
                Console.WriteLine("\n-------------------------------------------------------");


                switch (Console.ReadLine())
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        CreaContribuente();
                        break;
                    default:
                        Console.WriteLine("Digita 0 o 1");
                        Esegui();
                        break;
                }
            }catch (Exception ex)
            {
                Console.WriteLine($"Errore:{ex.Message}");
                Console.WriteLine("\n\tInput non corretto... \n\tRiavvio programma....");
                Thread.Sleep(3000);

                Console.Clear();
                Esegui();
            }
        }
    }
}
