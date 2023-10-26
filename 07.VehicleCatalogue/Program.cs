using System.Data;
using System.Diagnostics;
using static _07.VehicleCatalogue.Program;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        public class Truck
        {
            public Truck(string brand, string model, string weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }
        }
        public class Car
        {
            public Car(string brand, string model, string horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }
            public string Brand { get; set; }
            public string Model { get; set; }
            public string HorsePower { get; set; }
        }
        public class Catalog
        {
            public Catalog() // инициализация на Cars и Trucks листовете в конструктора
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }
            public List<Car> Cars { get; }


            public List<Truck> Trucks { get; }

        }

        static void Main(string[] args)
        {

            string command = "";
            Catalog catalogueVehicle = new Catalog();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] token = command.Split('/');


                string type = token[0];
                string brand = token[1];
                string model = token[2];
                string horsePowerOrWeight = token[3];



                if (type == "Car")
                {
                    catalogueVehicle.Cars.Add(new Car(brand, model, horsePowerOrWeight));
                }
                else
                {
                    catalogueVehicle.Trucks.Add(new Truck(brand, model, horsePowerOrWeight));
                }

            }
            if (catalogueVehicle.Cars.Count > 0)
            {
                Console.WriteLine($"Cars:");
                foreach (Car carList in catalogueVehicle.Cars.OrderBy(car => car.Brand))
                {
                    Console.WriteLine($"{carList.Brand}: {carList.Model} - {carList.HorsePower}hp");
                }
            }

            if (catalogueVehicle.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks:");
                foreach (Truck truckList in catalogueVehicle.Trucks.OrderBy(truck => truck.Brand))
                {
                    Console.WriteLine($"{truckList.Brand}: {truckList.Model} - {truckList.Weight}kg");
                }
            }
        }
    }
}