using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U1T2.Exercises
{
    public class Ej3
    {
        public string gender;

        public void IdentifyGender()
        {
            gender = Console.ReadLine().ToString();

            if (gender == "m" || gender == "M")
            {
                Console.WriteLine("Es un Hombre");
            } else if (gender == "f" || gender == "F") 
            {
                Console.WriteLine("Es una Mujer");
            } else
            {
                Console.WriteLine("No se identifico su genero");
            }
        }
    }
}
