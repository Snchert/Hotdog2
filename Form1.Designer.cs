namespace Proyecto_individual
{
    partial class Form1
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
            this.btnRegistrarVenta = new System.Windows.Forms.Button();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.dgvVisualizador = new System.Windows.Forms.DataGridView();
            this.btnVerInventario = new System.Windows.Forms.Button();
            this.btnVerVentas = new System.Windows.Forms.Button();
            this.btnCorteDia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarVenta
            // 
            this.btnRegistrarVenta.Location = new System.Drawing.Point(148, 187);
            this.btnRegistrarVenta.Name = "btnRegistrarVenta";
            this.btnRegistrarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarVenta.TabIndex = 0;
            this.btnRegistrarVenta.Text = "Vender";
            this.btnRegistrarVenta.UseVisualStyleBackColor = true;
            this.btnRegistrarVenta.Click += new System.EventHandler(this.btnRegistrarVenta_Click_1);
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(306, 98);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(121, 24);
            this.cmbProductos.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(281, 140);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 22);
            this.txtCantidad.TabIndex = 2;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // dgvVisualizador
            // 
            this.dgvVisualizador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisualizador.Location = new System.Drawing.Point(213, 278);
            this.dgvVisualizador.Name = "dgvVisualizador";
            this.dgvVisualizador.RowHeadersWidth = 51;
            this.dgvVisualizador.RowTemplate.Height = 24;
            this.dgvVisualizador.Size = new System.Drawing.Size(240, 150);
            this.dgvVisualizador.TabIndex = 3;
            this.dgvVisualizador.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVisualizador_CellContentClick);
            // 
            // btnVerInventario
            // 
            this.btnVerInventario.Location = new System.Drawing.Point(409, 187);
            this.btnVerInventario.Name = "btnVerInventario";
            this.btnVerInventario.Size = new System.Drawing.Size(121, 23);
            this.btnVerInventario.TabIndex = 4;
            this.btnVerInventario.Text = "Ver Ingredientes";
            this.btnVerInventario.UseVisualStyleBackColor = true;
            this.btnVerInventario.Click += new System.EventHandler(this.btnVerInventario_Click);
            // 
            // btnVerVentas
            // 
            this.btnVerVentas.Location = new System.Drawing.Point(409, 239);
            this.btnVerVentas.Name = "btnVerVentas";
            this.btnVerVentas.Size = new System.Drawing.Size(132, 23);
            this.btnVerVentas.TabIndex = 5;
            this.btnVerVentas.Text = "Historial de Ventas";
            this.btnVerVentas.UseVisualStyleBackColor = true;
            this.btnVerVentas.Click += new System.EventHandler(this.btnVerVentas_Click);
            // 
            // btnCorteDia
            // 
            this.btnCorteDia.Location = new System.Drawing.Point(148, 239);
            this.btnCorteDia.Name = "btnCorteDia";
            this.btnCorteDia.Size = new System.Drawing.Size(92, 23);
            this.btnCorteDia.TabIndex = 6;
            this.btnCorteDia.Text = "Corte Diario";
            this.btnCorteDia.UseVisualStyleBackColor = true;
            this.btnCorteDia.Click += new System.EventHandler(this.btnCorteDia_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCorteDia);
            this.Controls.Add(this.btnVerVentas);
            this.Controls.Add(this.btnVerInventario);
            this.Controls.Add(this.dgvVisualizador);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.btnRegistrarVenta);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisualizador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarVenta;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView dgvVisualizador;
        private System.Windows.Forms.Button btnVerInventario;
        private System.Windows.Forms.Button btnVerVentas;
        private System.Windows.Forms.Button btnCorteDia;
    }
}

