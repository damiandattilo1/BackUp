﻿using System;
using System.Text;

namespace Biblioteca
{
    /// <summary>
    /// Clase abstracta de la cual se van a heredar los distintos tipos de productos
    /// </summary>
    public abstract class Producto
    {
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        private int id;
        private eMarca marca;
        private double precio;
        private string modelo;
        private int stock;
        private eTag tag;


        /// <summary>
        /// Propiedades para cada atributo
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public eMarca Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public eTag Tag
        {
            get { return tag; }
            set { tag = value; }
        }

        /// <summary>
        /// Constructor privado que inicializa el stock
        /// </summary>
        private Producto()
        {
            this.stock = 1;
        }
        /// <summary>
        /// Constructor publico 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="precio"></param>
        public Producto(int id, eMarca marca, string modelo, eTag tag, double precio) :this()
        {
            this.id = id;
            this.marca = marca;
            this.modelo = modelo;
            this.tag = tag;
            this.precio = precio;
        }
       
        /// <summary>
        /// Polimorfismo del ToString para mostrar todos los datos comunes a todos los productos
        /// </summary>
        /// <returns></returns> Los datos en formato string
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Id: {this.Id} ");
            sb.AppendLine($"Marca: {this.Marca} ");
            sb.AppendLine($"Modelo: {this.Modelo} ");

            return sb.ToString();
        }

        /// <summary>
        /// Agrega datos de precio, stock y tags al ToString de cada herencia
        /// </summary>
        /// <returns></returns>

        public string DatosExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Precio: {this.Precio} ");
            sb.AppendLine($"Stock: {this.Stock} ");
            sb.AppendLine($"Tags: {this.Tag}");

            return sb.ToString();
        }

        /// <summary>
        /// Sobrecarga del operador == Dos productos son iguales si tienen el mismo id
        /// </summary>
        /// <param name="p1"></param> Producto 1
        /// <param name="p2"></param> Producto 2
        /// <returns></returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1 is not null && p2 is not null)
            {
                return p1.Id == p2.Id;
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        /// <summary>
        /// Polimorfismo de Equals
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is not null && obj is Deposito)
            {
                retorno = ((Deposito)obj == this);
            }
            return retorno;
        }

        /// <summary>
        /// Busca un producto en un deposito y suma o resta el stock (segun el booleano recibido por parametro). Cuando el stock llega a cero, se elimina el producto del deposito
        /// </summary>
        /// <param name="d"></param> Deposito 
        /// <param name="esSuma"></param> Booleano que contiene true si el stock se debe sumar o false si el stock se debe restar
        /// <returns></returns> Indica si el producto se encontro y se pudo sumar o restar el stock
        public bool ModificarStock(Deposito d, bool esSuma)
        {
            Producto producto = BuscarProducto(d);
            if(d is not null && producto is not null && esSuma)
            {
                producto.Stock++; 
                return true;
            }
            else if(!esSuma)
            {
                producto.Stock--;
                return true;
            }
            return false;
        }

        /// <summary>
        /// Busca la instancia de producto en la lista de un deposito
        /// </summary>
        /// <param name="deposito"></param>
        /// <returns></returns>

        private Producto BuscarProducto(Deposito deposito)
        {
            if(deposito is not null)
            {
                foreach(Producto item in deposito.Productos)
                {
                    if(item == this)
                    {
                        return item;
                    }
                }
            }
            return null;
        }


    }
}
