using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U1T2.Exercises
{
    public class Ej10
    {
        public int Action()
        {
            int addition = 0;
            int counter = 1;

            while (counter <= 100)
            {
                if(counter % 2 == 0)
                {
                    addition += counter;
                }
                counter++;
            }

            return addition;
        }
    }
}
