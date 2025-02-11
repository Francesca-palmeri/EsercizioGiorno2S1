

namespace EsercizioGiorno2S1.Models
{
    
        public class Persona
        {
            public string Nome { get; set; } = "Francesca";
            public string Cognome { get; set; } = "Palmeri";
            public int Eta { get; set; } = 30;



            public void GetNome(string Nome)
            {
                Console.WriteLine("Nome: " + Nome);
            }

            public void GetCognome(string Cognome)
            {
                Console.WriteLine("Cognome:" + Cognome);
            }

            public void GetEta(int Eta)
            {
                Console.WriteLine("Età: " + Eta);
            }

            public void GetDetails(string Nome, string Cognome, int Eta)
            {
                Console.WriteLine("Nome: " + Nome);
                Console.WriteLine("Cognome: " + Cognome);
                Console.WriteLine("Età: " + Eta);
            }
        }
    }
