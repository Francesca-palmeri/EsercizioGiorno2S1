

namespace EsercizioGiorno2S1.Models
{
    
        public class Persona
        {
            public string Nome { get; set; } = "Francesca";
            public string Cognome { get; set; } = "Palmeri";
            public int Eta { get; set; } = 30;



            public void GetNome()
            {
                Console.WriteLine("Nome: " + Nome);
            }

            public void GetCognome()
            {
                Console.WriteLine("Cognome:" + Cognome);
            }

            public void GetEta()
            {
                Console.WriteLine("Età: " + Eta);
            }

            public void GetDetails()
            {
                Console.WriteLine("Nome: " + Nome);
                Console.WriteLine("Cognome: " + Cognome);
                Console.WriteLine("Età: " + Eta);
            }
        }
    }
