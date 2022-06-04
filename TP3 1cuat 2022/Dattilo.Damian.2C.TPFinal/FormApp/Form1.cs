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

namespace FormApp
{
    public partial class rBtnEmpresa : Form
    {
        Cliente<Entidad> clientes;
        public rBtnEmpresa()
        {
            InitializeComponent();
            this.clientes = new Cliente<Entidad>(50);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(rBtnEmpresa1 == null && rBtnPersona == null)
            {
                MessageBox.Show("Seleccione un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(rBtnPersona.Checked == true)
                {
                    FormPersona formPersona = new FormPersona(clientes);
                    formPersona.Show() ;
                }
                else
                {
                    FormEmpresa formEmpresa = new FormEmpresa(clientes);
                    formEmpresa.Show();
                }

            }
        }

        private void btnMostrarListaClientes_Click(object sender, EventArgs e)
        {
            MostrarClientes lista = new MostrarClientes(clientes);
            lista.Show();
        }
    }
}
