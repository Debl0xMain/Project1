// See https://aka.ms/new-console-template for more information
using System;

// Console.WriteLine("Hello World!");


using System;
using System.Numerics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaration variable
            int year_actuelle = 2023;
            string nom = "";
            string year = "";
            int age = 0;

            //demande nom
            Console.WriteLine("Quel est ton nom ?");
            nom = Console.ReadLine();

            //verifie age valide sinon repose question
            do
            {
                //demande année
                Console.WriteLine("Quel est ton années de naissance ?");
                year = Console.ReadLine();

                //valeur correct
                try
                {
                    //condition try
                    int recup_year = int.Parse(year);
                    //calcul
                    age = year_actuelle - recup_year;
                }
                //renvoie erreur
                catch
                {
                    Console.WriteLine("L\'années de naissance doit etre un nombre");
                }
                if (age >= 100)
                {
                    Console.WriteLine("Vous devez avoir moins de 100ans");
                }
                if (age <= 0)
                {
                    Console.WriteLine("Vous devez etre sortie du ventre de votre mere");
                }

            } while(age <= 0 || age >= 100 );

            //aff si donnée recup valide
            Console.WriteLine("Votre nom est " + nom + " et vous avez " + age + " ans");
        }
    }
}