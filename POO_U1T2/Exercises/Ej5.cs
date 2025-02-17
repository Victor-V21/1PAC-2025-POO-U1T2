using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_U1T2.Exercises
{
    public class Ej5
    {
        public void SelectFood(int selec)
        {
            switch (selec)
            {
                case 1:
                    Console.WriteLine("Se selecciono la Hamburguesa su precio es Lsp.100.00");
                    break;
                case 2:
                    Console.WriteLine("Se selecciono la Pizza su precio es Lsp.200.00");
                    break;
                case 3:
                    Console.WriteLine("Se selecciono la Ensalada su precio es Lsp.90.00");
                    break;

                default: Console.WriteLine("Seleccion equivocada");
                    break;
            }

        }
    }
}
