using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U1T2.Exercises
{
    public class Ej2
    {
        public decimal num1;
        public decimal num2;

       
        public void Action()
        {
            num1 = Decimal.Parse(Console.ReadLine());
            num2 = Decimal.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Los numeros son iguales");
            }
            else
            if (num1 < num2)
            {
                Console.WriteLine($"El numero mayor es: {num2}");
            }
            else
            {
                Console.WriteLine($"El numero mayor es: {num1}");
            }

        }


    }
}
