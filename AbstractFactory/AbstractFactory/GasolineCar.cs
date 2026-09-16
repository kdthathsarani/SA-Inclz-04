using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
   public class GasolineCar : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Gasoline Car");
        }
    }
}
