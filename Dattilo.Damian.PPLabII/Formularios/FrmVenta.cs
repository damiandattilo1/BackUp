using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Formularios
{
    public partial class FrmVenta : Form
    {
        private Deposito deposito;
        public FrmVenta(Deposito deposito)
        {
            InitializeComponent();
            this.deposito = deposito;
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            lstProductos.Items.Clear();
            foreach (Producto item in deposito.Productos)
            {
                lstProductos.Items.Add(item);
            }
        }
    }
}
