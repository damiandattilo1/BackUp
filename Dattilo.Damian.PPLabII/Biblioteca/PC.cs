using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PC : Producto
    {
        /// <summary>
        /// Atributos
        /// </summary>
        private int memoriaDisco;
        private int ram;
        private eSistemaPC sistemaOperativo;
        private eDisco disco;

        /// <summary>
        /// Propuedades para cada atributo
        /// </summary>
        public int MemoriaDisco
        {
            get { return this.memoriaDisco; }
            set { memoriaDisco = value; }
        }

        public int Ram
        {
            get { return this.ram; }
            set { ram = value; }
        }

        public eSistemaPC SistemaOperativo
        {
            get { return this.sistemaOperativo; }
            set { sistemaOperativo = value; }
        }

        public eDisco Disco
        {
            get { return this.disco; }
            set { disco = value; }
        }

        public PC(int id, eMarca marca, string modelo, double precio, int memoriaDisco, int ram, eSistemaPC sistemaOperativo, eDisco disco) : base(id, marca, modelo, precio)
        {
            this.memoriaDisco = memoriaDisco;
            this.ram = ram;
            this.sistemaOperativo = sistemaOperativo;
            this.disco = disco;
        }

        /// <summary>
        /// Polimorfismo de ToString que reutiliza el polimorfismo de la clase base y agrega datos propios de la PC
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.ToString());

            sb.AppendLine($"Memoria: {this.MemoriaDisco} GB");
            sb.AppendLine($"Memoria RAM: {this.Ram}");
            sb.AppendLine($"Sistema Operativo: {this.SistemaOperativo.ToString()}");
            sb.AppendLine($"Disco: {this.Disco.ToString()}");

            return sb.ToString();
        }
    }
}
