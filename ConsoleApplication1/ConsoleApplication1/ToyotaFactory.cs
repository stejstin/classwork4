using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ToyotaFactory : carFactory
    {
        private string model;
        private int speed;

        public ToyotaFactory( string model, int speed)
        {
            this.model = model;
            this.speed = speed;
        }
        public override Car GetCar()
        {
            Car toyota1 = new Toyota();
            toyota1.Model = model;
            toyota1.Speed = speed;
            return toyota1;
        }
    }
}
