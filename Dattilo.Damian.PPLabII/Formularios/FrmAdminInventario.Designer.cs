namespace Formularios
{
    partial class FrmAdminInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.btnSumarStock = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbAgregar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.ItemHeight = 20;
            this.lstProductos.Location = new System.Drawing.Point(115, 77);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(561, 284);
            this.lstProductos.TabIndex = 0;
            // 
            // btnSumarStock
            // 
            this.btnSumarStock.Location = new System.Drawing.Point(318, 367);
            this.btnSumarStock.Name = "btnSumarStock";
            this.btnSumarStock.Size = new System.Drawing.Size(177, 57);
            this.btnSumarStock.TabIndex = 2;
            this.btnSumarStock.Text = "Sumar stock";
            this.btnSumarStock.UseVisualStyleBackColor = true;
            this.btnSumarStock.Click += new System.EventHandler(this.btnSumarStock_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(525, 367);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(171, 58);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbAgregar
            // 
            this.cmbAgregar.FormattingEnabled = true;
            this.cmbAgregar.Location = new System.Drawing.Point(81, 382);
            this.cmbAgregar.Name = "cmbAgregar";
            this.cmbAgregar.Size = new System.Drawing.Size(151, 28);
            this.cmbAgregar.TabIndex = 5;
            this.cmbAgregar.Text = "Agregar Producto";
            // 
            // FrmAdminInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbAgregar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnSumarStock);
            this.Controls.Add(this.lstProductos);
            this.Name = "FrmAdminInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de Inventario";
            this.Load += new System.EventHandler(this.FrmAdminInventario_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Button btnSumarStock;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbAgregar;
    }
}