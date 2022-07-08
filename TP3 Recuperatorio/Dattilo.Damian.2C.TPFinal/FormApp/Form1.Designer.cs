namespace FormApp
{
    partial class rBtnEmpresa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMostrarListaClientes = new System.Windows.Forms.Button();
            this.btnNuevaPersona = new System.Windows.Forms.Button();
            this.btnNuevaEmpresa = new System.Windows.Forms.Button();
            this.btnAgregarTramite = new System.Windows.Forms.Button();
            this.btnGuardarListaClientes = new System.Windows.Forms.Button();
            this.btnLeerListaClientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMostrarListaClientes
            // 
            this.btnMostrarListaClientes.Location = new System.Drawing.Point(456, 187);
            this.btnMostrarListaClientes.Name = "btnMostrarListaClientes";
            this.btnMostrarListaClientes.Size = new System.Drawing.Size(184, 69);
            this.btnMostrarListaClientes.TabIndex = 5;
            this.btnMostrarListaClientes.Text = "Mostrar Lista Clientes";
            this.btnMostrarListaClientes.UseVisualStyleBackColor = true;
            this.btnMostrarListaClientes.Click += new System.EventHandler(this.btnMostrarListaClientes_Click);
            // 
            // btnNuevaPersona
            // 
            this.btnNuevaPersona.Location = new System.Drawing.Point(202, 90);
            this.btnNuevaPersona.Name = "btnNuevaPersona";
            this.btnNuevaPersona.Size = new System.Drawing.Size(190, 76);
            this.btnNuevaPersona.TabIndex = 6;
            this.btnNuevaPersona.Text = "Nueva Persona";
            this.btnNuevaPersona.UseVisualStyleBackColor = true;
            this.btnNuevaPersona.Click += new System.EventHandler(this.btnNuevaPersona_Click);
            // 
            // btnNuevaEmpresa
            // 
            this.btnNuevaEmpresa.Location = new System.Drawing.Point(695, 90);
            this.btnNuevaEmpresa.Name = "btnNuevaEmpresa";
            this.btnNuevaEmpresa.Size = new System.Drawing.Size(211, 76);
            this.btnNuevaEmpresa.TabIndex = 7;
            this.btnNuevaEmpresa.Text = "Nueva Empresa";
            this.btnNuevaEmpresa.UseVisualStyleBackColor = true;
            this.btnNuevaEmpresa.Click += new System.EventHandler(this.btnNuevaEmpresa_Click);
            // 
            // btnAgregarTramite
            // 
            this.btnAgregarTramite.Location = new System.Drawing.Point(450, 331);
            this.btnAgregarTramite.Name = "btnAgregarTramite";
            this.btnAgregarTramite.Size = new System.Drawing.Size(190, 73);
            this.btnAgregarTramite.TabIndex = 9;
            this.btnAgregarTramite.Text = "Agregar Tramite";
            this.btnAgregarTramite.UseVisualStyleBackColor = true;
            this.btnAgregarTramite.Click += new System.EventHandler(this.btnAgregarTramite_Click);
            // 
            // btnGuardarListaClientes
            // 
            this.btnGuardarListaClientes.Location = new System.Drawing.Point(750, 354);
            this.btnGuardarListaClientes.Name = "btnGuardarListaClientes";
            this.btnGuardarListaClientes.Size = new System.Drawing.Size(201, 50);
            this.btnGuardarListaClientes.TabIndex = 10;
            this.btnGuardarListaClientes.Text = "Guardar Lista Clientes";
            this.btnGuardarListaClientes.UseVisualStyleBackColor = true;
            this.btnGuardarListaClientes.Click += new System.EventHandler(this.btnGuardarListaClientes_Click);
            // 
            // btnLeerListaClientes
            // 
            this.btnLeerListaClientes.Location = new System.Drawing.Point(99, 354);
            this.btnLeerListaClientes.Name = "btnLeerListaClientes";
            this.btnLeerListaClientes.Size = new System.Drawing.Size(181, 50);
            this.btnLeerListaClientes.TabIndex = 11;
            this.btnLeerListaClientes.Text = "Leer Lista Clientes";
            this.btnLeerListaClientes.UseVisualStyleBackColor = true;
            this.btnLeerListaClientes.Click += new System.EventHandler(this.btnLeerListaClientes_Click);
            // 
            // rBtnEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 486);
            this.Controls.Add(this.btnLeerListaClientes);
            this.Controls.Add(this.btnGuardarListaClientes);
            this.Controls.Add(this.btnAgregarTramite);
            this.Controls.Add(this.btnNuevaEmpresa);
            this.Controls.Add(this.btnNuevaPersona);
            this.Controls.Add(this.btnMostrarListaClientes);
            this.Name = "rBtnEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.rBtnEmpresa_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnMostrarListaClientes;
        private System.Windows.Forms.Button btnNuevaPersona;
        private System.Windows.Forms.Button btnNuevaEmpresa;
        private System.Windows.Forms.Button btnAgregarTramite;
        private System.Windows.Forms.Button btnGuardarListaClientes;
        private System.Windows.Forms.Button btnLeerListaClientes;
    }
}
