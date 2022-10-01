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
    public partial class FrmAdminInventario : Form
    {
        Deposito deposito;
        public FrmAdminInventario(Deposito deposito)
        {
            InitializeComponent();
            this.deposito = deposito;
        }

        private void FrmAdminInventario_Load(object sender, EventArgs e)
        {
            CargarDatos();

            cmbAgregar.Items.Clear();
            cmbAgregar.Items.Add("Celular");
            cmbAgregar.Items.Add("PC");
            cmbAgregar.Items.Add("Televisor");
        }
                


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSumarStock_Click(object sender, EventArgs e)
        {
            if(lstProductos.SelectedItem is not null)
            {
                Producto p = lstProductos.SelectedItem as Producto;
                p.Stock++;
                CargarDatos();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
