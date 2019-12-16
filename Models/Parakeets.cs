using System;
using interfaces.Interfaces;

namespace interfaces.Models{
    public class Parakeets : IAnimal, IFlying{
        public bool ForSale {get; set;}
        public string Lifespan { get; set; }
        public string AdultSize { get; set; }
        public bool canBePet { get; set; }
        public bool isEdible { get; set; }
        public string Color { get; set; }
        public bool isMigrator { get; set; }
        public string Wingspan { get; set; }
        public string BeakShape { get; set; }
    }
}