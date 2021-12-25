using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace PokemonTrainer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();
            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string trainerName = commandArgs[0];
                Pokemon pokemon = new Pokemon(commandArgs[1], commandArgs[2], int.Parse(commandArgs[3]));

                if (!trainers.Exists(x => x.Name == trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainer.CollectedPokemons.Add(pokemon);
                    trainers.Add(trainer);
                }
                else
                {
                    trainers.First(x => x.Name == trainerName).CollectedPokemons.Add(pokemon);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                foreach (var trainer in trainers)
                {
                    if (trainer.CollectedPokemons.Exists(x => x.Element == command))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        trainer.CollectedPokemons.ForEach(x => x.Health -= 10);
                        trainer.CollectedPokemons.RemoveAll(x => x.Health <= 0);
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var trainer in trainers.OrderByDescending(x => x.Badges))
            {
                Console.WriteLine(trainer.Name + ' ' + trainer.Badges + ' ' + trainer.CollectedPokemons.Count);
            }
        }
    }
}
