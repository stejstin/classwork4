using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class CarAssembler
    {
        public void AssembleCar(carFactory factory)
        {
            Car assemblecar = factory.GetCar();
            Console.WriteLine(assemblecar.Company);
            Console.WriteLine(assemblecar.Model);
            Console.WriteLine(assemblecar.Speed);
            Console.Read();
        }

        static void Main(string[] args)
        {
            CarAssembler assemble = new CarAssembler();
            Console.Write("Please enter either toyota or suzuki: ");
            string car = Console.ReadLine();
            if(car == "toyota")
            {
                ToyotaFactory tFactory = new ToyotaFactory("corolla", 60);
                assemble.AssembleCar(tFactory);
                
            }
            else
            {

            }

            Console.Read();
            return;

        }
    }
}
