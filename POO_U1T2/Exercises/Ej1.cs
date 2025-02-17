using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U1T2.Exercises
{
    public class Ej1
    {
        public decimal num;

        public void Action()
        {
            num = decimal.Parse(Console.ReadLine());

            if (num == 0)
            {
                Console.WriteLine("El numero que digitó es 0");
            }
            else if (num > 0)
            {
                Console.WriteLine("El numero que digitó es Positivo");
            }
            else
            {
                Console.WriteLine("El numero que digitó es Negativo");
            }
        }
    } 
}
