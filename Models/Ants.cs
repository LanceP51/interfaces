using System;
using System.Collections.Generic;
using interfaces.Interfaces;

namespace interfaces.Models{
    public class Ants : IAnimal, IWalking{
        public bool DestructiveAnt {get; set;}
        public string AntClass {get; set;}
        public string Lifespan { get; set; }
        public string AdultSize { get; set; }
        public bool canBePet { get; set; }
        public bool isEdible { get; set; }
        public string Color { get; set; }
        public bool isHousePest { get; set; }
        public string LegLength { get; set; }
        public bool canRun { get; set; }

        public List<Ants> AllAnts = new List<Ants>();
    }
}