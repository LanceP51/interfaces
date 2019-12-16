using System;
using System.Collections.Generic;
using interfaces.Interfaces;
using interfaces.Models;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // ANTS
            Terrarium BedroomTerrarium = new Terrarium();
            Ants Ant1 = new Ants()
            {
                Color = "red", DestructiveAnt= true, isHousePest= true, canRun= true, AdultSize= "0.25 in."
            };
            BedroomTerrarium.Walkers.Add(Ant1);

            //TERRAPINS
            Aquarium MyFishBowl = new Aquarium();
            Terrapins PacificSeaTurtle = new Terrapins(){
                Lifespan = "6 years", Freshwater= false, canRun= true, canBePet= false, Fins= false, Color= "Green", isHousePest= false
            };
            MyFishBowl.Swimmers.Add(PacificSeaTurtle);

            // EARTHWORMS
            DirtBox MyDirtContainer = new DirtBox();
            Earthworm FishinWorm = new Earthworm(){
                isFishBait= true, Color= "Brown", Movement= "squirm"
            };
            MyDirtContainer.Crawlies.Add(FishinWorm);

            // FINCHES
            BirdCage PalaceCage = new BirdCage();
            Finches YellowFinch = new Finches(){
                Wingspan= "7 in.", Color= "Yellow", BeakShape= "curved down", isDarwinian= true
            };
            PalaceCage.Flyers.Add(YellowFinch);

            Console.WriteLine();
        }
    }
}
