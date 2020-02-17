using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Arreglo
    {
        private int[] _numeros = new int[10];
        public int[] Numeros 
        { 
            get { return _numeros; }
            set { }
        }

        

        public string Mayor { get; set; }
        public string Menor { get; set; }
    }
}
