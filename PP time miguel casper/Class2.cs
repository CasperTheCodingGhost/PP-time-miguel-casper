﻿using System;

//I denne oppgaven skal du prøve å programmere deg selv 🤓 Du har noen gitte egenskaper og ting du liker å gjøre.
//Lag et hovedprogram der hver av deltakerene har sin klasse som kan printe ut en introduksjonstekst, og også utføre hver sine hobbyer.

// Utskrift i konsollen kan feks se sånn her ut: 
// Hei, jeg heter Bjarne! Jeg er 40 år gammel og jeg har svart hår
// Se på meg, nå løper jeg i åkeren.
// Nå sitter jeg og gamer litt farmingsimulator!

// Hei, jeg heter Kurt! Jeg er 55 år gammel og jeg har brunt hår
// Nå er jeg ute på fisketur.
// Se, jeg kan også klatre høyt i klatreparken!

namespace PP_time_miguel_casper
{
    class Deltaker2
    {
        public Deltaker2(string name, int age, string firstHobby, string secondHobby)
        {
            Name = name;
            Age = age;
            FirstHobby = firstHobby;
            SecondHobby = secondHobby;


        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string FirstHobby { get; set; }
        public string SecondHobby { get; set; }

        public void Introduction()
        {
            string Name = "Miguel";
            int Age = 34;
            Console.WriteLine($"Hei, jeg heter {Name} og jeg er {Age} år gammel!");
        }

        public void firstHobby() 
        {
            string firstHobby = "Jeg har forvillet meg litt i skogen?!";
            Console.WriteLine($"{firstHobby}");
        }

        public void secondHobby() 
        {
            string secondHobby = "Nå depleta vi en key i WoW igjen f***.";
            Console.WriteLine($"{secondHobby}");
        }
    }
}
