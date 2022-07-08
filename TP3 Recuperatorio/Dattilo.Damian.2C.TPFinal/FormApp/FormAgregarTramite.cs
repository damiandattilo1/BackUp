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
    public partial class FormAgregarTramite : Form
    {
        
        Cliente<Entidad> lista;
        bool esPersona;
        public FormAgregarTramite(Cliente<Entidad> lista)
        {
            InitializeComponent();
            this.lista = lista;
        }

        private void FormAgregarTramite_Load(object sender, EventArgs e)
        {
            foreach(Entidad item in lista.clientes)
            {
                listBox1.Items.Add(item);
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            Persona p1 = listBox1.SelectedItem as Persona;
            Empresa e1 = listBox1.SelectedItem as Empresa;
            if(p1 is not null)
            {
                switch(listBox2.SelectedItem.ToString())
                {
                    case "Prestamo":
                        p1.AgregarTramite(Persona.TramitesPersona.Prestamo);
                        break;
                    case "PlazoFijo":
                        p1.AgregarTramite(Persona.TramitesPersona.PlazoFijo);
                        break;
                    case "AperturaCajaAhorro":
                        p1.AgregarTramite(Persona.TramitesPersona.AperturaCajaAhorro);
                        break;
                    case "TarjetasDeCredito":
                        p1.AgregarTramite(Persona.TramitesPersona.TarjetasDeCredito);
                        break;
                    default:
                        
                        break;
                }
            }
            else
            {
                switch (listBox2.SelectedItem.ToString())
                {
                    case "PagoSalarios":
                        e1.AgregarTramite(Empresa.TramitesEmpresa.PagoSalarios);
                        break;
                    case "CuentaCorriente":
                        e1.AgregarTramite(Empresa.TramitesEmpresa.CuentaCorriente);
                        break;
                    case "Inversiones":
                        e1.AgregarTramite(Empresa.TramitesEmpresa.Inversiones);
                        break;
                    case "Credito":
                        e1.AgregarTramite(Empresa.TramitesEmpresa.Credito);
                        break;
                    default:

                        break;
                }
            }
            this.Close();
            
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            Persona p = listBox1.SelectedItem as Persona;

            listBox2.Items.Clear();
            
            if(p is not null)
            {
                listBox2.Items.Add(Persona.TramitesPersona.Prestamo);
                listBox2.Items.Add(Persona.TramitesPersona.PlazoFijo);
                listBox2.Items.Add(Persona.TramitesPersona.AperturaCajaAhorro);
                listBox2.Items.Add(Persona.TramitesPersona.TarjetasDeCredito);
            }
            else
            {
                listBox2.Items.Add(Empresa.TramitesEmpresa.PagoSalarios);
                listBox2.Items.Add(Empresa.TramitesEmpresa.Inversiones);
                listBox2.Items.Add(Empresa.TramitesEmpresa.CuentaCorriente);
                listBox2.Items.Add(Empresa.TramitesEmpresa.Credito);
            }
        }
    }
}
