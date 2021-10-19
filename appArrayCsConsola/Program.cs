using System;

namespace appArrayCsConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Arreglo de 10 cadenas de caracteres
            string [] arreglo = new string [10];
            arreglo[0] = "uwu";
            for(int i = 0; i < arreglo.Length; i++)
            { arreglo[i] = "hola" + (i+1);  }
            for (int i = 0; i < arreglo.Length; i++)
            { Console.WriteLine(arreglo[i]); } */

            Console.WriteLine("ingrese el valor de indice en el que desea escribir: ");
            int indice = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese lo que quiere guardar en este indice: ");
            string valor = Console.ReadLine();

            ClasePruebaArray a1;
            a1 = new ClasePruebaArray(valor, indice);
            Console.WriteLine(a1.ToString());

            Console.ReadKey();
        }
    }
}
