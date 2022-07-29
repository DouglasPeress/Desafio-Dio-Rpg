using System;
using rpg.src.Entities;

namespace dotnet__poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero arus = new Knight ("Arus", 23, "Knight");
            Wizard wizard = new Wizard ("Jennica", 23, "White Mage");
            Ninja ninja = new Ninja("Wedge", 42, "Ninja");
            BlackMage blackmage = new BlackMage("Topapa", 42, "Black Mage");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(7));
            Console.WriteLine(ninja);
            Console.WriteLine(blackmage);
        }
    }
}