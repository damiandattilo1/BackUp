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
    public partial class FrmConfirmarVenta : Form
    {
        Producto producto;
        public FrmConfirmarVenta(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }

        private void FrmConfirmarVenta_Load(object sender, EventArgs e)
        {
            rtbMostrarProducto.Text = producto.ToString();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            producto.Stock--;
            this.Close();
        }
    }
}
