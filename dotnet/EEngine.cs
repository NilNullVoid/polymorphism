using System;

namespace Engines
{
    class ElectricEngine: Engine
    {
        public string FuelType {get;}
        public ElectricEngine() { }
        public ElectricEngine(string fuelType, int horsePower, int energyStoreMaxSize):base(horsePower, energyStoreMaxSize) {
            this.FuelType = fuelType;
        }
        override public void Rev() {
            if(--CurrentEnergyStore <= 0)
            {
                Console.WriteLine("FLAT BATTERY");
            }
            else { Console.WriteLine("SWWIIIISSSSHHH!"); --CurrentEnergyStore; }
        }
        override public void Rev(int i) {
            for(int x = 0; x < i; x++) {Rev();}
        }
        public override void Refuel() {
            Console.WriteLine("RECHARGED TO FULL" );
        }
        public override void Refuel(int i) {
            CurrentEnergyStore = Math.Clamp(i, 0, EnergyStoreMaxSize);
            Console.WriteLine(CurrentEnergyStore<i ? "RECHARGED TO FULL"  : $"RECHARGED {i} AMP HOURS");
        }
    }
}