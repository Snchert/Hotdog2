namespace Proyecto_individual
{
    partial class FormMenu
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
            this.botonVentas = new System.Windows.Forms.Button();
            this.botonInventario = new System.Windows.Forms.Button();
            this.botonCorte = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botonVentas
            // 
            this.botonVentas.Location = new System.Drawing.Point(3, 3);
            this.botonVentas.Name = "botonVentas";
            this.botonVentas.Size = new System.Drawing.Size(194, 23);
            this.botonVentas.TabIndex = 0;
            this.botonVentas.Text = "Iniciar venta";
            this.botonVentas.UseVisualStyleBackColor = true;
            this.botonVentas.Click += new System.EventHandler(this.botonVentas_Click);
            // 
            // botonInventario
            // 
            this.botonInventario.Location = new System.Drawing.Point(3, 37);
            this.botonInventario.Name = "botonInventario";
            this.botonInventario.Size = new System.Drawing.Size(194, 23);
            this.botonInventario.TabIndex = 1;
            this.botonInventario.Text = "Ver inventario";
            this.botonInventario.UseVisualStyleBackColor = true;
            this.botonInventario.Click += new System.EventHandler(this.botonInventario_Click);
            // 
            // botonCorte
            // 
            this.botonCorte.Location = new System.Drawing.Point(3, 67);
            this.botonCorte.Name = "botonCorte";
            this.botonCorte.Size = new System.Drawing.Size(194, 29);
            this.botonCorte.TabIndex = 2;
            this.botonCorte.Text = "Hacer corte";
            this.botonCorte.UseVisualStyleBackColor = true;
            this.botonCorte.Click += new System.EventHandler(this.botonCorte_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.botonVentas, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.botonCorte, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.botonInventario, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(297, 170);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.875F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 99);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonVentas;
        private System.Windows.Forms.Button botonInventario;
        private System.Windows.Forms.Button botonCorte;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}