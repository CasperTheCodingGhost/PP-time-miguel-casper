using PP_time_miguel_casper;
using System;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Create participants
            Deltaker1 deltaker1 = new Deltaker1("Casper", 22, "Sushi");
            Deltaker2 deltaker2 = new Deltaker2("Miguel", 34, "Svart", "WoW");

            Console.Clear();
            Console.WriteLine("Hvilken deltaker har du lyst til å bli kjent med? (Press 1 eller 2)");

            var input = GetIntInput(2);

            switch (input)
            {
                case 1:
                    PresentAndDelay(deltaker1);
                    break;
                case 2:
                    PresentAndDelay(deltaker2);
                    break;
                default:
                    Console.WriteLine("Ugyldig valg. Avslutter programmet.");
                    return;
            }
        }
    }

    static void PresentAndDelay(Deltaker1 deltaker)
    {
        deltaker.PresenterDeg();
        deltaker.UtførHobbyer();
        Console.WriteLine();
        Thread.Sleep(10000);
    }

    static void PresentAndDelay(Deltaker2 deltaker)
    {
        deltaker.Introduction();
        deltaker.firstHobby();
        Console.WriteLine();
        Thread.Sleep(10000);
    }

    static int GetIntInput(int max, string errorMessage = "Det er ikke et gyldig valg!")
    {
        var input = Console.ReadLine();
        try
        {
            var number = int.Parse(input);
            if (number >= 1 && number <= max) return number;
            Console.WriteLine(errorMessage);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ikke et tall, prøv igjen");
        }
        return GetIntInput(max);
    }
}