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
    /// <summary>
    /// Formulario Para hacer el loguin a la aplicacion
    /// </summary>
    public partial class FrmLoguin : Form
    {
        Deposito deposito;
        public FrmLoguin()
        {
            InitializeComponent();
            this.deposito = new Deposito(50);
        }

        /// <summary>
        /// Evento del boton Loguin que verifica que usuario y contrasena correspondan al vendedor o al dueno
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoguin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "dueño@gmail.com" && txtPassword.Text == "123utn456")
            {
                FrmMenuPrincipal menu = new FrmMenuPrincipal(deposito);
                this.Hide();
                menu.ShowDialog();
                this.Close();
            }
            else if (txtUsuario.Text == "vendedor@vende.com" && txtPassword.Text == "444ven555")
            {
                this.Hide();
                FrmVenta frmVenta = new FrmVenta(deposito, false);
                frmVenta.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o password incorrecto/s", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDueño_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "dueño@gmail.com";
            txtPassword.Text = "123utn456";
        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "vendedor@vende.com";
            txtPassword.Text = "444ven555";
        }

        private void FrmLoguin_Load(object sender, EventArgs e)
        {
            Celular c1 = new Celular(1234, eMarca.Samsung, "sj474", 80000, 128, eSistemaCelular.Android, eResolucionCamara.Mp12, true);
            Televisor t2 = new Televisor(1444, eMarca.Philips, "ph8471", 100000, 42, eSistemaTV.AndroidTV, eResolucion.UHD, true);
            PC p3 = new PC(1818, eMarca.HP, "HP142", 120000, 500, 8, eSistemaPC.Windows, eDisco.HDD);

            deposito = deposito + c1;
            deposito = deposito + t2;
            deposito = deposito + p3;


        }
    }
}
