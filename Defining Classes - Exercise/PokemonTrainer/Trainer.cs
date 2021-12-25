using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
            CollectedPokemons = new List<Pokemon>();
        }
        public string Name { get; set; }
        public int Badges { get; set; } = 0;
        public List<Pokemon> CollectedPokemons { get; set; }
    }
}
