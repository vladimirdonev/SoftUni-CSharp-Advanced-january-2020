using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Trainer
    {
        private string trainername { get; set; }
        private int numberofbadges { get; set; }
        private List<Pokemon> pokemons { get; set; }
        public string TrainerName
        {
            get { return this.trainername; }
            set { this.trainername = value; }
        }
        public int NumberofBadges
        {
            get { return this.numberofbadges; }
            set { this.numberofbadges = value; }
        }
        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }
        public Trainer(string trainername)
        {
            TrainerName = trainername;
            this.NumberofBadges = 0;
            this.Pokemons = new List<Pokemon>();
        }
    }
}
