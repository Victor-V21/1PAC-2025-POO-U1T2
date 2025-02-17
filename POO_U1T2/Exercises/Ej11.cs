using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U1T2.Exercises
{
    internal class Ej11
    {

        public void Action(int num) 
        {
            int counter = 0;

            Console.WriteLine($"Tabla de multiplicar de {num}:\n");

            while (counter <= num)
            {
                Console.WriteLine($"{num} x {counter} = {num*counter}");
                counter++;
            }
        }
    }
}
