using EsercizioGiorno2S1.Models;

Persona persona1 = new Persona()
{
    Nome = "Giulia",
    Cognome = "Arbia",
    Eta = 32,
};

persona1.GetNome(persona1.Nome);
Console.WriteLine("-----------");
persona1.GetCognome(persona1.Cognome);
Console.WriteLine("-----------");
persona1.GetEta(persona1.Eta);
Console.WriteLine("-----------");
persona1.GetDetails(persona1.Nome, persona1.Cognome, persona1.Eta);
