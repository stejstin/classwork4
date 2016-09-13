using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class SuzukiFactory : carFactory
    {
        private string model;
        private int speed;

        public SuzukiFactory( string model, int speed)
        {
            this.model = model;
            this.speed = speed;
        }
        public override Car GetCar()
        {
            Car suzuki1 = new suzuki();
            suzuki1.Model = model;
            suzuki1.Speed = speed;
            return suzuki1;
            
        }
    }
}
