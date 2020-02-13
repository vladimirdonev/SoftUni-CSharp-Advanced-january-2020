using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string command = null;
            List<Pokemon> pokemons = new List<Pokemon>();
            var trainers = new Dictionary<string,Trainer>(); 
            while(command != "Tournament")
            {
                command = Console.ReadLine();
                if(command == "Tournament")
                {
                    break;
                }
                string[] splitedinput = command.Split(" ");
                string Trainername = splitedinput[0];
                string pokemonName = splitedinput[1];
                string pokemonElement = splitedinput[2];
                int pokemonHealth = int.Parse(splitedinput[3]);
                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
                Trainer trainer = new Trainer(Trainername);
                if (trainers.ContainsKey(Trainername))
                {
                    trainers[Trainername].Pokemons.Add(pokemon);
                }
                else
                {
                    trainers.Add(Trainername, trainer);
                    trainers[Trainername].Pokemons.Add(pokemon);
                }
            }
            while(command != "End")
            {
                command = Console.ReadLine();
                if(command == "End")
                {
                    break;
                }
                switch (command)
                {
                    case "Fire":
                        Checkpokemon(command, trainers);
                        break;
                    case "Water":
                        Checkpokemon(command, trainers);
                        break;
                    case "Electricity":
                        Checkpokemon(command, trainers);
                        break;


                }
            }
            
            foreach (var trainer in trainers.OrderByDescending(x => x.Value.NumberofBadges))
            {
                Console.WriteLine($"{trainer.Key} {trainer.Value.NumberofBadges} {trainer.Value.Pokemons.Count}");
            }
        }

        private static void Checkpokemon(string command,Dictionary<string,Trainer> trainers)
        {

            foreach (Trainer trainer in trainers.Values)
            {
                if (trainer.Pokemons.Any(p => p.Element == command))
                {
                    trainer.NumberofBadges++;
                }
                else
                {
                    foreach (Pokemon pokemon in trainer.Pokemons)
                    {
                        pokemon.Health -= 10;
                    }
                }
            }

            foreach (Trainer trainer in trainers.Values)
            {
                for (int i = 0; i < trainer.Pokemons.Count; i++)
                {
                    if (trainer.Pokemons[i].Health <= 0)
                    {
                        trainer.Pokemons.RemoveAt(i);
                        i--;
                    }
                }
            }
        }
    }
}
