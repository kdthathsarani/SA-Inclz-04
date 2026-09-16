using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            IVehicleFactory factory = new GasolineVehicleFactory();

            
            IVehicle car = factory.CreateCar();
            IVehicle truck = factory.CreateTruck();
            IEngine engine = factory.CreateEngine();

            car.ShowDetails();
            truck.ShowDetails();
            engine.Start();
        }
    }
}
