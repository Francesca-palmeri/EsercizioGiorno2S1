using EsercizioGiorno2S1.Models;

Persona persona1 = new Persona()
{
    Nome = "Giulia",
    Cognome = "Arbia",
    Eta = 32,
};

persona1.GetNome();
Console.WriteLine("-----------");
persona1.GetCognome();
Console.WriteLine("-----------");
persona1.GetEta();
Console.WriteLine("-----------");
persona1.GetDetails();
