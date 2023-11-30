//I denne oppgaven skal du prøve å programmere deg selv 🤓 Du har noen gitte egenskaper og ting du liker å gjøre.
//Lag et hovedprogram der hver av deltakerene har sin klasse som kan printe ut en introduksjonstekst, og også utføre hver sine hobbyer.

// Utskrift i konsollen kan feks se sånn her ut: 
// Hei, jeg heter Bjarne! Jeg er 40 år gammel og jeg har svart hår
// Se på meg, nå løper jeg i åkeren.
// Nå sitter jeg og gamer litt farmingsimulator!

// Hei, jeg heter Kurt! Jeg er 55 år gammel og jeg har brunt hår
// Nå er jeg ute på fisketur.
// Se, jeg kan også klatre høyt i klatreparken!

using System;
using System.Net.Http.Headers;
using System.Runtime.Serialization;

class Deltaker1 //dette er en klasse som representerer en deltaker i programmet
               // Den har tre egenskaper: Navn, Alder, og FavorittMat
               // Det er en konstruktør som lar deg opprette en deltaker ved å angi navn, alder og favorittmat
{
    public string Navn { get; set; }  //Når du bruker get og set i en egenskap, opprettes en automatisk implementering av backing field. Med andre ord, bak kulissene opprettes en privat variabel som holder verdien for egenskapen
    public int Alder { get; set; }
    public string Favorittmat { get; set; }

    public Deltaker1(string navn, int alder, string favorittMat)
    {
        Navn = navn;
        Alder = alder;
        Favorittmat = favorittMat;
    }

    public void PresenterDeg() //denne metoden skriver ut en introduksjonstekst basert på deltakerens egenskaper
    {
        Console.WriteLine($"Hei, jeg heter {Navn}, og er {Alder} år gammel og elsker {Favorittmat}!");
    }

    public void UtførHobbyer() //metoden kaller på tre private metoder som representerer deltakerens hobbyer: Snowboarding, Coding og Cooking
    {
        Console.WriteLine($"{Navn}, utfører sine hobbyer");
        Snowboarding();
        Coding();
        Cooking();
    }

    private void Snowboarding() //dette simulere denne hobbien
    {
        Console.WriteLine("Jeg står ofte på snowboard når det er vinter, det er gøy. Elsker å shredde bakken :P");
    }
    private void Coding() //dette simulere denne hobbien
    {
        Console.WriteLine("Jeg liker og kode på fritiden og på skolen.");
    }

    private void Cooking() //dette simulere denne hobbien
    {
        Console.WriteLine("Jeg elsker å lage mat, det er en av mine favoritt ting og gjøre :)");
    }
}