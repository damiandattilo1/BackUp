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
    public partial class FormPersona : Form
    {
        Cliente<Entidad> clientes;
        public FormPersona(Cliente<Entidad> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            /*Persona persona = CrearPersona();

            if(persona is not null)
            {
                clientes.Agregar(persona);
            }*/
                clientes.Agregar(new Persona(12, 12, "damian", "dattilo", true, 12, Persona.TramitesPersona.PlazoFijo));
                clientes.Agregar(new Persona(23, 12, "cristian", "rojas", true, 12, Persona.TramitesPersona.PlazoFijo));
            clientes.Agregar(new Empresa(8888, 45, "wasd inc", 45, Empresa.TramitesEmpresa.PagoSalarios));
            clientes.Agregar(new Empresa(8788, 45, "haha", 45, Empresa.TramitesEmpresa.PagoSalarios));
            this.Close();
        }

        private Persona CrearPersona()
        {
            int id;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int dni;
            int edad;
            bool cuentaCorriente;

            if (!int.TryParse(txtId.Text, out id) || !int.TryParse(txtDni.Text, out dni) || !int.TryParse(txtEdad.Text, out edad) || nombre == null || apellido == null)
            {
                MessageBox.Show("Ingrese valores validos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            else
            {
                if (rBtnSi.Checked)
                {
                    cuentaCorriente = true;
                }
                else
                {
                    cuentaCorriente = false;
                }

                return new Persona(id, dni, nombre, apellido, cuentaCorriente, edad, Persona.TramitesPersona.PlazoFijo);
            }

        }
        

        private void FormPersona_Load(object sender, EventArgs e)
        {
            this.cmbTramite.Items.AddRange(new String[] { "AperturaCajaAhorro", "PlazoFijo", "TarjetasDeCredito", "Prestamo" });
        }
    }
}
