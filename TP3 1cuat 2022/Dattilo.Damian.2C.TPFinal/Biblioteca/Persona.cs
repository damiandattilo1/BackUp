using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Biblioteca
{
    public class Persona :Entidad, IHabitual
    {
        protected string apellido;
        protected int dni;
        protected bool cuentaCorriente;

        public override string NombreCompleto
        {
            get
            {
                return string.Format("{0}, {1}", base.nombre, this.apellido);
            }
        }

        public Persona(int id, int dni, string nombre, string apellido, bool cuentaCorriente, int edad) :base(id, nombre, edad)
        {
            this.apellido = apellido;
            this.dni = dni;
            this.cuentaCorriente = cuentaCorriente;
        }

        public bool EsHabitual()
        {
            return this.cuentaCorriente;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Persona");
            sb.Append(base.ToString());
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Edad: {base.edad}");
            sb.AppendFormat("Es habitual: {0}\n", EsHabitual() ? "SI" : "NO");

            return sb.ToString();
        }

        public static bool operator ==(Persona p1, Persona p2)
        {
            return (p1.dni == p2.dni);
        }

        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
    }
}
