using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Clase Televisor heredada de producto
    /// </summary>
    public class Televisor : Producto
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private int pulgadas;
        private eSistemaTV sistemaOperativo;
        private eResolucion resolucion;
        private bool esSmart;

        /// <summary>
        /// Propiedades para cada atributo
        /// </summary>
        public int Pulgadas
        {
            get { return pulgadas; }
            set { pulgadas = value; }
        }

        public eSistemaTV SistemaOperativo
        {
            get { return sistemaOperativo; }
            set { sistemaOperativo = value; }
        }
        public eResolucion Resolucion
        {
            get { return resolucion; }
            set { resolucion = value; }
        }

        public bool EsSmart
        {
            get { return esSmart; }
            set { esSmart = value; }
        }


        /// <summary>
        /// Constructor que reutiliza el constructor de la clase base
        /// </summary>
        /// <param name="id"></param>
        /// <param name="marca"></param>
        /// <param name="modelo"></param>
        /// <param name="precio"></param>
        /// <param name="pulgadas"></param>
        /// <param name="sistemaOperativo"></param>
        /// <param name="resolucion"></param>
        public Televisor(int id, eMarca marca, string modelo, double precio, int pulgadas, eSistemaTV sistemaOperativo, eResolucion resolucion, bool esSmart) : base(id, marca, modelo, precio)
        {
            this.pulgadas = pulgadas;
            this.sistemaOperativo = sistemaOperativo;
            this.resolucion = resolucion;
            this.esSmart = esSmart;
        }

        /// <summary>
        /// Polimorfismo de ToString que reutiliza el polimorfismo de la clase base y agrega datos propios del televisor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());
            
            sb.AppendLine($"Pulgadas: {this.Pulgadas}");
            sb.AppendLine($"Sistema Operativo: {this.SistemaOperativo.ToString()}");
            sb.AppendLine($"Resolucion: {this.Resolucion.ToString()}");
            sb.Append("Es Smart: ");
            if(esSmart)
            {
                sb.AppendLine("Si");
            }
            else
            {
                sb.AppendLine("No");
            }

            return sb.ToString();
        }
    }
}
