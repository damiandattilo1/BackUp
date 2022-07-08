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
using Persistencia;
using static System.Environment;

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


        private void btnMostrarListaClientes_Click(object sender, EventArgs e)
        {

            MostrarClientes form = new MostrarClientes(clientes);
            form.Show();

        }

        private void btnNuevaPersona_Click(object sender, EventArgs e)
        {
            FormPersona formPersona = new FormPersona(clientes);
            formPersona.Show();
        }

        private void btnNuevaEmpresa_Click(object sender, EventArgs e)
        {
            FormEmpresa formEmpresa = new FormEmpresa(clientes);
            formEmpresa.Show();
        }

        private void rBtnEmpresa_Load(object sender, EventArgs e)
        {
            /*PersonaDAO listaPersonas = new PersonaDAO();
            List<Persona> personaList = new List<Persona>();
            personaList = listaPersonas.Leer();
            this.clientes.Agregar*/
        }

        private void btnAgregarTramite_Click(object sender, EventArgs e)
        {
            FormAgregarTramite form = new FormAgregarTramite(clientes);
            form.Show();

        }

        private void btnGuardarListaClientes_Click(object sender, EventArgs e)
        {
            Serializadora<Entidad> s = new Serializadora<Entidad>();
            foreach(Entidad item in this.clientes.clientes)
            {
                s.Guardar(GetFolderPath(SpecialFolder.Desktop), "Serializado.json", item);
            }
        }

        private void btnLeerListaClientes_Click(object sender, EventArgs e)
        {
            Entidad e1;
            Serializadora<Entidad> s = new Serializadora<Entidad>();
            clientes.clientes.Clear();
            do
            {
                e1 = s.Leer(GetFolderPath(SpecialFolder.Desktop), "Serializado.json");
                if(e1 is not null)
                {
                    clientes.clientes.Add(e1);
                }
            } while (e1 is not null);
                    
        }
    }
}
