using System;
using interfaces.Interfaces;

namespace interfaces.Models{
    public class TimberRattler : IAnimal, ISlitherin{
        public int NumOfRattles {get; set;}
        public string Lifespan { get; set; }
        public string AdultSize { get; set; }
        public bool canBePet { get; set; }
        public bool isEdible { get; set; }
        public string Color { get; set; }
        public string Movement { get; set; }
        public bool Poisonous { get; set; }
    }
}