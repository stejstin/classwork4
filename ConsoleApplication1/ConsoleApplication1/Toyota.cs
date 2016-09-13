using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Toyota : Car
    {
        private string company = "toyota";
        private string model;
        private int speed;


        public override string Company
        {
            get
            {
                return company;
            }
        }

        public override string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }

        }
        public override int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }
    }
}


