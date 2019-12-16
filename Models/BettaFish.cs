using System;
using interfaces.Interfaces;

namespace interfaces.Models{
    public class BettaFish : IAnimal, ISwimming{
        public bool ComesInBowl {get; set;}
        public string Lifespan { get; set; }
        public string AdultSize { get; set; }
        public bool canBePet { get; set; }
        public bool isEdible { get; set; }
        public string Color { get; set; }
        public bool Freshwater { get; set; }
        public bool Fins { get; set; }
    }
}