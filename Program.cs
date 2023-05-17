using System;
using System.Collections.Generic;
using System.Linq;
using static PokemonPocket.PokemonMaster;

namespace PokemonPocket
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Pokemons> pocket = new List<Pokemons>();

            //PokemonMaster list for checking pokemon evolution availability.    
            List<PokemonMaster> pokemonMasters = new List<PokemonMaster>(){
            new PokemonMaster("Pikachu", 2, "Raichu"),
            new PokemonMaster("Eevee", 3, "Flareon"),
            new PokemonMaster("Charmander", 1, "Charmeleon")
            };

            string choice = "";


            while (choice.ToUpper() != "Q")
            {
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1) Add Pokemon to my pocket");
                Console.WriteLine("2) List Pokemon in my pocket");
                Console.WriteLine("3) Check if a Pokemon can evolve");
                Console.WriteLine("4) Evolve Pokemon");
                Console.WriteLine("Q) Quit");

                choice = Console.ReadLine();

                if (choice.ToUpper() == "1")
                {   
                    Console.Write("Enter the name of the Pokemon: ");
                    string name = Console.ReadLine();
                    if(name.ToUpper() == "PIKACHU"||name.ToUpper() == "EEVEE"||name.ToUpper() =="CHARMANDER"){

                    Console.Write("Enter Pokemon's HP: ");
                    int HP = int.Parse(Console.ReadLine());

                    Console.Write("Enter Pokemon's EXP: ");
                    int EXP = int.Parse(Console.ReadLine());

                    pocket.Add(new Pokemons(name, HP, EXP));

                    Console.WriteLine("Pokemon added to the pocket.");
                    }else{
                        Console.WriteLine("Unable to add this pokenmon");
                    }

                }
                else if (choice.ToUpper() == "2")
                {
                    if (pocket.Count == 0)
                    {
                        Console.WriteLine("Your pocket is empty.");
                    }
                    else
                    {
                        Console.WriteLine("Pokemon in your pocket:");
                        foreach (Pokemons pokemon in pocket)
                        {
                            Console.WriteLine($"Name: {pokemon.Name}, HP: {pokemon.HP}, EXP: {pokemon.EXP}");
                        }
                    }
                }
                else if (choice.ToUpper() == "3")
                {
                    Console.WriteLine("Check");
                }
                else if (choice.ToUpper() == "4")
                {
                    Console.WriteLine("Check");
                }
                else if (choice.ToUpper() == "5")
                {
                    Console.WriteLine("Check");
                }
                else if (choice.ToUpper() == "Q")
                {
                    Console.WriteLine("exciting program");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }



                Console.WriteLine();
            }
            //Use "Environment.Exit(0);" if you want to implement an exit of the console program
            //Start your assignment 1 requirements below.















        }
    }
}
