using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas.Models
{
    internal class Cerveza: Bebida
    {
        private int cantidadAlcohol;

        public int CantidadAlcohol { get; set; }

        public Cerveza() { 
        
        }
        public Cerveza(int cantidadAlcohol):base(string marca, double precio, int cantidad) 
        {
            this.cantidadAlcohol = cantidadAlcohol;
        
        }
    }
}
