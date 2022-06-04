using System;
using System.Text;

namespace Biblioteca
{
    public abstract class Entidad
    {
        protected int id;
        protected string nombre;
        protected int edad;

        public abstract string NombreCompleto { get; }

        public Entidad(int id, string nombre, int edad)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.id}");
            sb.AppendLine(this.NombreCompleto);

            return sb.ToString();
        }

        public static bool operator ==(Entidad c1, Entidad c2)
        {
            return (c1.id == c2.id);
        }

        public static bool operator !=(Entidad c1, Entidad c2)
        {
            return !(c1 == c2);
        }

    }
}
