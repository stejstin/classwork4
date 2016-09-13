using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     public abstract class Car
    {
        public virtual string Company
        {
            get;
   
        }

        public virtual string Model
        {
            get;
            set;
        }

         public virtual int Speed
        {
            get;
            set;     
        }
    }
}
