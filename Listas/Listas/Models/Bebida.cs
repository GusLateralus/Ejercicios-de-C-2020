using System;

namespace Listas.Models
{
    internal class Bebida
    {
        private string marca;
        private double precio;
        private int cantidad;

        public Bebida()
        { 
        
        }

        public Bebida(string marca, double precio, int cantidad)
        { 
            this.marca = marca;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        // Getters y Setters

        public string Marca{ get; set;}
        public double Precio { get; set;}

        public int Cantidad{ get; set;}
    }
}
