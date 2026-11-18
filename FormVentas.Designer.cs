namespace Proyecto_individual
{
    partial class FormVentas
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
            this.Productos_venta = new System.Windows.Forms.ComboBox();
            this.Cantidad_venta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data_ventas = new System.Windows.Forms.DataGridView();
            this.Eliminaraventa = new System.Windows.Forms.Button();
            this.Actualizar_venta = new System.Windows.Forms.Button();
            this.agregaraVenta = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.botonMenu = new System.Windows.Forms.Button();
            this.Finalizar_venta = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.data_ventas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Productos_venta
            // 
            this.Productos_venta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Productos_venta.FormattingEnabled = true;
            this.Productos_venta.Location = new System.Drawing.Point(3, 36);
            this.Productos_venta.Name = "Productos_venta";
            this.Productos_venta.Size = new System.Drawing.Size(361, 24);
            this.Productos_venta.TabIndex = 0;
            this.Productos_venta.SelectedIndexChanged += new System.EventHandler(this.Productos_venta_SelectedIndexChanged);
            // 
            // Cantidad_venta
            // 
            this.Cantidad_venta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cantidad_venta.Location = new System.Drawing.Point(370, 36);
            this.Cantidad_venta.Name = "Cantidad_venta";
            this.Cantidad_venta.Size = new System.Drawing.Size(361, 22);
            this.Cantidad_venta.TabIndex = 1;
            this.Cantidad_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cantidad_venta.TextChanged += new System.EventHandler(this.Cantidad_venta_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona el producto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // data_ventas
            // 
            this.data_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.data_ventas, 2);
            this.data_ventas.Location = new System.Drawing.Point(3, 224);
            this.data_ventas.Name = "data_ventas";
            this.data_ventas.RowHeadersWidth = 51;
            this.data_ventas.Size = new System.Drawing.Size(728, 146);
            this.data_ventas.TabIndex = 3;
            this.data_ventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_ventas_CellContentClick);
            // 
            // Eliminaraventa
            // 
            this.Eliminaraventa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Eliminaraventa.Location = new System.Drawing.Point(3, 146);
            this.Eliminaraventa.Name = "Eliminaraventa";
            this.Eliminaraventa.Size = new System.Drawing.Size(361, 23);
            this.Eliminaraventa.TabIndex = 4;
            this.Eliminaraventa.Text = "Eliminar de la venta";
            this.Eliminaraventa.UseVisualStyleBackColor = true;
            this.Eliminaraventa.Click += new System.EventHandler(this.Eliminaraventa_Click);
            // 
            // Actualizar_venta
            // 
            this.Actualizar_venta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Actualizar_venta.Location = new System.Drawing.Point(370, 106);
            this.Actualizar_venta.Name = "Actualizar_venta";
            this.Actualizar_venta.Size = new System.Drawing.Size(361, 23);
            this.Actualizar_venta.TabIndex = 5;
            this.Actualizar_venta.Text = "Cambiar cantidad";
            this.Actualizar_venta.UseVisualStyleBackColor = true;
            this.Actualizar_venta.Click += new System.EventHandler(this.Actualizar_venta_Click);
            // 
            // agregaraVenta
            // 
            this.agregaraVenta.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.agregaraVenta.Location = new System.Drawing.Point(3, 106);
            this.agregaraVenta.Name = "agregaraVenta";
            this.agregaraVenta.Size = new System.Drawing.Size(361, 23);
            this.agregaraVenta.TabIndex = 6;
            this.agregaraVenta.Text = "Agregar a venta";
            this.agregaraVenta.UseVisualStyleBackColor = true;
            this.agregaraVenta.Click += new System.EventHandler(this.agregaraVenta_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cantidad del producto a vender";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // botonMenu
            // 
            this.botonMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.botonMenu.Location = new System.Drawing.Point(370, 146);
            this.botonMenu.Name = "botonMenu";
            this.botonMenu.Size = new System.Drawing.Size(361, 23);
            this.botonMenu.TabIndex = 8;
            this.botonMenu.Text = "volver al menu";
            this.botonMenu.UseVisualStyleBackColor = true;
            this.botonMenu.Click += new System.EventHandler(this.botonMenu_Click_1);
            // 
            // Finalizar_venta
            // 
            this.Finalizar_venta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.Finalizar_venta, 2);
            this.Finalizar_venta.Location = new System.Drawing.Point(3, 184);
            this.Finalizar_venta.Name = "Finalizar_venta";
            this.Finalizar_venta.Size = new System.Drawing.Size(728, 34);
            this.Finalizar_venta.TabIndex = 9;
            this.Finalizar_venta.Text = "Finalizar venta";
            this.Finalizar_venta.UseVisualStyleBackColor = true;
            this.Finalizar_venta.Click += new System.EventHandler(this.Finalizar_venta_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.data_ventas, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Finalizar_venta, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Productos_venta, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.botonMenu, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Eliminaraventa, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Actualizar_venta, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.agregaraVenta, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Cantidad_venta, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.96721F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.03278F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(734, 373);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormVentas";
            this.Text = "FormVentas";
            this.Load += new System.EventHandler(this.FormVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_ventas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Productos_venta;
        private System.Windows.Forms.TextBox Cantidad_venta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView data_ventas;
        private System.Windows.Forms.Button Eliminaraventa;
        private System.Windows.Forms.Button Actualizar_venta;
        private System.Windows.Forms.Button agregaraVenta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botonMenu;
        private System.Windows.Forms.Button Finalizar_venta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}