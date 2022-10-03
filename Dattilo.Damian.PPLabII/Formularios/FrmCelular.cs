﻿using System;
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
    public partial class FrmCelular : Form
    {
        private Deposito deposito;
        public FrmCelular(Deposito deposito)
        {
            InitializeComponent();
            this.deposito = deposito;
        }

        private void FrmCelular_Load(object sender, EventArgs e)
        {
            cmbMarca.Items.Clear();
            cmbResolucion.Items.Clear();
            cmbSistema.Items.Clear();
            cmbLiberado.Items.Clear();

            cmbMarca.Items.Add(eMarca.Sony);
            cmbMarca.Items.Add(eMarca.HP);
            cmbMarca.Items.Add(eMarca.Samsung);
            cmbMarca.Items.Add(eMarca.Philips);

            cmbResolucion.Items.Add(eResolucionCamara.Mp10);
            cmbResolucion.Items.Add(eResolucionCamara.Mp12);
            cmbResolucion.Items.Add(eResolucionCamara.Mp15);

            cmbSistema.Items.Add(eSistemaCelular.Android);
            cmbSistema.Items.Add(eSistemaCelular.iOS);
            cmbSistema.Items.Add(eSistemaCelular.WindowsPhone);

            cmbLiberado.Items.Add("Si");
            cmbLiberado.Items.Add("No");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool liberado;
            if(cmbLiberado.Text == "Si")
            {
                liberado = true;
            }
            else
            {
                liberado = false;
            }
            if (Validar())
            {
                Celular celular = new Celular(int.Parse(txtId.Text),(eMarca) cmbMarca.SelectedItem, txtModelo.Text, double.Parse(txtPrecio.Text),int.Parse(txtMemoria.Text), (eSistemaCelular)cmbSistema.SelectedItem,(eResolucionCamara) cmbResolucion.SelectedItem, liberado);
                deposito = deposito + celular;
                MessageBox.Show("Se ha agregado el celular exitosamente", "OK", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);   
            }
            else
            {
                MessageBox.Show("Ingrese correctamente los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Validar()
        {
            int auxInt;
            double auxDouble;
            
            if(int.TryParse(txtId.Text, out auxInt) && double.TryParse(txtPrecio.Text, out auxDouble) && int.TryParse(txtMemoria.Text, out auxInt))
            {
                return true;
            } 
            
            return false;
        }


    }
}