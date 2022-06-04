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
            this.rBtnEmpresa1 = new System.Windows.Forms.RadioButton();
            this.rBtnPersona = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnMostrarListaClientes = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rBtnEmpresa1
            // 
            this.rBtnEmpresa1.AutoSize = true;
            this.rBtnEmpresa1.Location = new System.Drawing.Point(40, 52);
            this.rBtnEmpresa1.Name = "rBtnEmpresa1";
            this.rBtnEmpresa1.Size = new System.Drawing.Size(87, 24);
            this.rBtnEmpresa1.TabIndex = 0;
            this.rBtnEmpresa1.TabStop = true;
            this.rBtnEmpresa1.Text = "Empresa";
            this.rBtnEmpresa1.UseVisualStyleBackColor = true;
            // 
            // rBtnPersona
            // 
            this.rBtnPersona.AutoSize = true;
            this.rBtnPersona.Location = new System.Drawing.Point(40, 95);
            this.rBtnPersona.Name = "rBtnPersona";
            this.rBtnPersona.Size = new System.Drawing.Size(81, 24);
            this.rBtnPersona.TabIndex = 1;
            this.rBtnPersona.TabStop = true;
            this.rBtnPersona.Text = "Persona";
            this.rBtnPersona.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnEmpresa1);
            this.groupBox1.Controls.Add(this.rBtnPersona);
            this.groupBox1.Location = new System.Drawing.Point(401, 178);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 125);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elija Cliente";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(263, 352);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(178, 69);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnMostrarListaClientes
            // 
            this.btnMostrarListaClientes.Location = new System.Drawing.Point(705, 352);
            this.btnMostrarListaClientes.Name = "btnMostrarListaClientes";
            this.btnMostrarListaClientes.Size = new System.Drawing.Size(184, 69);
            this.btnMostrarListaClientes.TabIndex = 5;
            this.btnMostrarListaClientes.Text = "Mostrar Lista Clientes";
            this.btnMostrarListaClientes.UseVisualStyleBackColor = true;
            this.btnMostrarListaClientes.Click += new System.EventHandler(this.btnMostrarListaClientes_Click);
            // 
            // rBtnEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 486);
            this.Controls.Add(this.btnMostrarListaClientes);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "rBtnEmpresa";
            this.Text = "Empresa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBtnEmpresa1;
        private System.Windows.Forms.RadioButton rBtnPersona;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnMostrarListaClientes;
    }
}
