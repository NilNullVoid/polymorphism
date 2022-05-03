using System;

namespace Engines
{
    abstract class Engine
    {
        public int HorsePower {get;}
        public int EnergyStoreMaxSize {get;}
        public int CurrentEnergyStore {get; set;}
        public Engine() { }
        public Engine(int horsePower, int energyStoreMaxSize)
        {
            this.HorsePower = horsePower;
            EnergyStoreMaxSize = energyStoreMaxSize;
            CurrentEnergyStore = energyStoreMaxSize;
        }
        abstract public void Rev();
        abstract public void Rev(int i);
        abstract public void Refuel();
        abstract public void Refuel(int i);
    }
}