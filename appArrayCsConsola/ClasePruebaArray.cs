using System;
using System.Collections.Generic;
using System.Text;

namespace appArrayCsConsola
{
    class ClasePruebaArray
    {
        
        private string[] arreglo = new string[5];

        public string[] Arreglo
        {
            get { return arreglo; }
            set { arreglo = value; }
        }
        private int indice;

        public int Indice
        {
            get { return indice; }
            set { indice = value; }
        }

        public ClasePruebaArray()
        {
            for (int i = 0; i < arreglo.Length; i++)
            { arreglo[i] = ""; }
            indice = 0;
            
        }
        
        public ClasePruebaArray(string valor, int indice)
        {   

            this.indice = indice;
            arreglo[indice-1] = valor;
        }

        public override string ToString()
        {
            string respuesta = "S";
            while (respuesta == "S")
            {
                Console.WriteLine("Que indice desea imprimir? ");
                indice = int.Parse(Console.ReadLine());
                Console.WriteLine("El indice " + indice + " contiene: " + arreglo[indice - 1]);

                Console.WriteLine("Desea consultar algun otro indice? [S/N] ");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToUpper();

            }
            return "";
        }

    }
}
