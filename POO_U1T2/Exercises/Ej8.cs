using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U1T2.Exercises
{
    public class Ej8
    {

        public int Action(int num)
        {
            int factorial = num;
            
            for (int i = num; i>1; i--)
            {
                factorial *= i-1;
            }
            return factorial;
        }
    }
}
