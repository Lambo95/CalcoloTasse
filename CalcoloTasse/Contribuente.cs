using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcoloTasse
{
    internal class Contribuente
    {
        public struct AliquotaPercentuale
        {

            public const double ScaglionePercentuale1 = 0.23;
            public const double ScaglionePercentuale2 = 0.27;
            public const double ScaglionePercentuale3 = 0.38;
            public const double ScaglionePercentuale4 = 0.41;
            public const double ScaglionePercentuale5 = 0.43;
        }
        public struct AliquotaInt
        {

            public const int ScaglioneInt2 = 3450;
            public const int ScaglioneInt3 = 6960;
            public const int ScaglioneInt4 = 17220;
            public const int ScaglioneInt5 = 25420;
        }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }

        public string CodiceFiscale { get; set; }
        public char Sesso { get; set; }
        public string ComuneResidenza { get; set; }
        public double RedditoAnnuale { get; set; }

        public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale, char sesso, string comuneResidenza, double redditoAnnuale)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = codiceFiscale;
            Sesso = sesso;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;
        }

        public void CalcoloReddito()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            if (RedditoAnnuale < 15000)
            {
                double imposta = RedditoAnnuale * AliquotaPercentuale.ScaglionePercentuale1;
                Console.WriteLine($"CALCOLO DELL’IMPOSTA DA VERSARE:\r\n\r\nContribuente:{Nome} {Cognome},\r\nnato il {DataNascita} {Sesso},\r\nresidente in {ComuneResidenza},\r\ncodice fiscale: {CodiceFiscale}\r\n\r\nReddito dichiarato: {RedditoAnnuale:C}\r\n\r\nIMPOSTA DA VERSARE:  {imposta:C}");
            }
            else if (RedditoAnnuale > 15001 && RedditoAnnuale < 28000)
            {
                double imposta = ((RedditoAnnuale - 15000) * AliquotaPercentuale.ScaglionePercentuale2) + AliquotaInt.ScaglioneInt2;
                Console.WriteLine($"CALCOLO DELL’IMPOSTA DA VERSARE:\r\n\r\nContribuente:{Nome} {Cognome},\r\nnato il {DataNascita.ToString("dd/MM/yyyy")} {Sesso},\r\nresidente in {ComuneResidenza},\r\ncodice fiscale: {CodiceFiscale}\r\n\r\nReddito dichiarato: {RedditoAnnuale:C}\r\n\r\nIMPOSTA DA VERSARE:  {imposta:C}");

            }
            else if (RedditoAnnuale > 28001 && RedditoAnnuale < 55000)
            {
                double imposta = ((RedditoAnnuale - 28000) * AliquotaPercentuale.ScaglionePercentuale3) + AliquotaInt.ScaglioneInt3;
                Console.WriteLine($"CALCOLO DELL’IMPOSTA DA VERSARE:\r\n\r\nContribuente:{Nome} {Cognome},\r\nnato il {DataNascita.ToString("dd/MM/yyyy")} {Sesso},\r\nresidente in {ComuneResidenza},\r\ncodice fiscale: {CodiceFiscale}\r\n\r\nReddito dichiarato: {RedditoAnnuale:C}\r\n\r\nIMPOSTA DA VERSARE:  {imposta:C}");

            }
            else if (RedditoAnnuale > 55001 && RedditoAnnuale < 75000)
            {
                double imposta = ((RedditoAnnuale - 55000) * AliquotaPercentuale.ScaglionePercentuale4) + AliquotaInt.ScaglioneInt4;
                Console.WriteLine($"CALCOLO DELL’IMPOSTA DA VERSARE:\r\n\r\nContribuente:{Nome} {Cognome},\r\nnato il {DataNascita.ToString("dd/MM/yyyy")} {Sesso},\r\nresidente in {ComuneResidenza},\r\ncodice fiscale: {CodiceFiscale}\r\n\r\nReddito dichiarato: {RedditoAnnuale:C}\r\n\r\nIMPOSTA DA VERSARE:  {imposta:C}");

            }
            else if (RedditoAnnuale > 75001)
            {
                double imposta = ((RedditoAnnuale - 75000) * AliquotaPercentuale.ScaglionePercentuale5) + AliquotaInt.ScaglioneInt5;
                Console.WriteLine($"CALCOLO DELL’IMPOSTA DA VERSARE:\r\n\r\nContribuente:{Nome} {Cognome},\r\nnato il {DataNascita.ToString("dd/MM/yyyy")} {Sesso},\r\nresidente in {ComuneResidenza},\r\ncodice fiscale: {CodiceFiscale}\r\n\r\nReddito dichiarato: {RedditoAnnuale:C}\r\n\r\nIMPOSTA DA VERSARE: &euro {imposta}");

            }

        }
    }
}
