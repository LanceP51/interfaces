using System;
using interfaces.Interfaces;

namespace interfaces.Models{
    public class Copperhead : IAnimal, ISlitherin{
        public string Pattern {get; set;}
        public string Length {get; set;}
        public string Lifespan { get; set; }
        public string AdultSize { get; set; }
        public bool canBePet { get; set; }
        public bool isEdible { get; set; }
        public string Color { get; set; }
        public string Movement { get; set; }
        public bool Poisonous { get; set; }
    }
}