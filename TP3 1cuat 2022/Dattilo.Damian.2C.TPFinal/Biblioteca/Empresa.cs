using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Empresa :Entidad
    {
        protected int codigo;
        public override string NombreCompleto
        {
            get
            {
                return base.nombre;
            }
        }

        public Empresa(int id, int codigo, string nombre, int edad) :base(id, nombre, edad)
        {
            this.codigo = codigo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Empresa");
            sb.Append(base.ToString());
            sb.AppendLine($"Codigo: {this.codigo}");
            sb.AppendLine($"Anios en servicio: {base.edad}");

            return sb.ToString();
        }

        public static bool operator ==(Empresa e1, Empresa e2)
        {
            return (e1.codigo == e2.codigo);
        }

        public static bool operator !=(Empresa e1, Empresa e2)
        {
            return !(e1 == e2);
        }

    }
}
