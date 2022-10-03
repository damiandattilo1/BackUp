using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Deposito
    {
        /// <summary>
        /// Lista de Producto y capacidad maxima del deposito
        /// </summary>
        private List<Producto> productos;
        private int capacidadMaxima;

        /// <summary>
        /// Propiedades
        /// </summary>
        public List<Producto> Productos
        {
            get { return productos; }

        }

        public int CapacidadMaxima
        {
            get { return capacidadMaxima; }
            set { capacidadMaxima = value; }
        }

        /// <summary>
        /// Constructor privado que inicializa la lista de productos
        /// </summary>
        private Deposito()
        {
            this.productos = new List<Producto>();
        }

        /// <summary>
        /// Constructor publico que inicializa la capacidad maxima e invoca al constructor privado
        /// </summary>
        /// <param name="capacidadMaxima"></param>
        public Deposito(int capacidadMaxima) :this()
        {
            this.capacidadMaxima = capacidadMaxima;
        }

        /// <summary>
        /// Sobrecarga del operador + que agrega un producto al deposito o si el producto ya existe, aumenta su stock mediante el metodo ModificarStock
        /// </summary>
        /// <param name="d"></param> deposito
        /// <param name="p"></param> producto
        /// <returns></returns>
        public static Deposito operator +(Deposito d, Producto p)
        {
            bool existe;
            
            if(d is not null && p is not null)
            {
                existe = p.ModificarStock(d, true);
                if (!existe)
                {
                    d.productos.Add(p);
                }
                
            }
            return d;
        }

        /// <summary>
        /// Sobrecarga del operador - que quita stock del deposito o, si el stock llega a cero, lo quita mediante el metodo ModificarStock
        /// </summary>
        /// <param name="d"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        //public static Deposito operator -(Deposito d, Producto p)
        public static bool operator -(Deposito d, Producto p)
        {
            bool existe = p.ModificarStock(d, false);

            return existe;
        }

        public string GenerarFactura(Producto p)
        {
            StringBuilder sb = new StringBuilder();



            return sb.ToString();
        }
    }
}
