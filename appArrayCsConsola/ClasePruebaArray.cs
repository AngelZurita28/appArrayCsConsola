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
            arreglo[indice] = valor;
        }

        public override string ToString()
        { return "El indice " + indice + " contiene: " + arreglo[indice]; }

    }
}
