using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrito_de_compras
{
    internal class Producto
    {
        //public string nombre;
        //public string color;
        //public string tamaño;
        //public string precio;

        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Tamaño { get; set; }
        public double Precio { get; set; }

        public Producto(string nombre, string color, string tamaño, double precio)
        {
            Nombre = nombre;
            Color = color;
            Tamaño = tamaño;
            Precio = precio;
        }
        public string mostrar()
        {
            return "Nombre: " + Nombre + Environment.NewLine +
                   "Color: " + Color + Environment.NewLine +
                   "Tamaño: " + Tamaño + Environment.NewLine +
                   "Precio: " + Precio.ToString("F2");
        }
    }
}