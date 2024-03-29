﻿using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public RepairShop(int capacity)
        {
            this.Capacity = capacity;
            Vehicles = new List<Vehicle>();
        }

        public int Capacity { get; set; }
        public List<Vehicle>? Vehicles { get; set; }

        public int GetCount() => this.Vehicles!.Count;
        public void AddVehicle(Vehicle vehicle)
        {
            if(this.Vehicles!.Count < Capacity)
            {
                this.Vehicles.Add(vehicle);
            }
        }

        public bool RemoveVehicle(string vin) => this.Vehicles!
            .Remove(this.Vehicles.FirstOrDefault(x => x.VIN == vin)!);

        public Vehicle GetLowestMileage()=>this.Vehicles!.OrderBy(x=>x.Milage).FirstOrDefault()!;

        public string Report()
        {           
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Vehicles in the preparatory:");

            foreach (var car in this.Vehicles!)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
