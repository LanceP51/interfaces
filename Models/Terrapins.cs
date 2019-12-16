using System;
using interfaces.Interfaces;

namespace interfaces.Models{
    public class Terrapins : IAnimal, IWalking, ISwimming{
        public bool ForSoup {get; set;}
        public string Location {get; set;}
        public string Lifespan { get; set; }
        public string AdultSize { get; set; }
        public bool canBePet { get; set; }
        public bool isEdible { get; set; }
        public string Color { get; set; }
        public bool isHousePest { get; set; }
        public string LegLength { get; set; }
        public bool canRun { get; set; }
        public bool Freshwater { get; set; }
        public bool Fins { get; set; }
    }
}