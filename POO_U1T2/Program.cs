
using POO_U1T2.Exercises;

Ej1 ej1 = new();
Ej2 ej2 = new();
Ej3 ej3 = new();
Ej4 ej4 = new();
Ej5 ej5 = new();

Ej7 ej7 = new();
Ej8 ej8 = new();
Ej9 ej9 = new();
Ej10 ej10 = new();
Ej11 ej11 = new();

decimal opc = 0;

Console.WriteLine("Digite el ejercicio que desea acceder");
opc = decimal.Parse(Console.ReadLine());
int selec;

switch (opc)
{
    case 1:
        Console.WriteLine("Digite un numero para saber si es positivo, negativo o 0");
        ej1.Action();
        break;
    case 2:
        Console.WriteLine("Ingrese dos numeros para determinar cual es el mayor");
        ej2.Action();
        break;
    case 3:
        Console.WriteLine("Ingrese su genero en una letra (M o F)");
        ej3.IdentifyGender();
        break;

    case 4:
        Console.WriteLine("Ingrese un numero para identificar el dia de la semana");

        selec = int.Parse(Console.ReadLine());
        Console.WriteLine("Su dia de la semana es: " + ej4.IdentifyDayWeek(selec));
        break;
    case 5:
        Console.WriteLine("Que desea comprar:\n" +
            "1.Hamburguesa\n" +
            "2.Pizza\n" +
            "3.Ensalada\n" +
            "Ingrese su seleccion: ");
        selec = int.Parse(Console.ReadLine());
        ej5.SelectFood(selec);

        break;

    case 6:
        Console.WriteLine("Se Imprimiran los numeros del 1 al 100");
        Ej6 ej6 = new();
        break;

    case 7:
        Console.WriteLine("La suma de los numeros del 1 al 100 es: "+ ej7.Action());
        break; 
        
    case 8:
        Console.WriteLine("Digite un numero para calcular su factorial");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Resultado: {num}! = {ej8.Action(num)}");
        break;

    case 9:
        Console.WriteLine("Desea Continuar?(si/no): ");
        ej9.Action();
        break;

    case 10:
        Console.WriteLine("La suma de los numeros pares del 1 al 100 es: "+ ej10.Action());
        break;

    case 11:
        Console.WriteLine("Digite un numero para calcular la tabla de multiplicar");
        int num2 = int.Parse(Console.ReadLine());

        ej11.Action(num2);
        break;

    default:
        Console.WriteLine("No se reconoce el ejercicio " + opc);
        break;
}