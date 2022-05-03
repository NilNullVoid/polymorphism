using System;

namespace Engines
{
    class InternalCombustionEngine: Engine
    {
        public string FuelType {get;}
        public InternalCombustionEngine() { }
        public InternalCombustionEngine(string fuelType, int horsePower, int energyStoreMaxSize):base(horsePower, energyStoreMaxSize) {
            this.FuelType = fuelType;
        }
        override public void Rev() {
            if(--CurrentEnergyStore <= 0)
            {
                Console.WriteLine("OUT OF FUEL");
            }
            else { Console.WriteLine("VROOOOMMMM!"); --CurrentEnergyStore; }
        }
        override public void Rev(int i) {
            for(int x = 0; x < i; x++) {Rev();}
        }
        public override void Refuel() {
            Console.WriteLine("REFUELED TO FULL");
        }
        public override void Refuel(int i) {
            CurrentEnergyStore = Math.Clamp(i, 0, EnergyStoreMaxSize);
            Console.WriteLine(CurrentEnergyStore<i ? "REFUELED TO FULL" : $"REFUELLED {i} LITRES");
        }
    }
}