namespace Proyecto_individual
{
    partial class FormInventario
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ingredientes = new System.Windows.Forms.ComboBox();
            this.Cantidad_agregar = new System.Windows.Forms.TextBox();
            this.agregar_stock = new System.Windows.Forms.Button();
            this.stock = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.52607F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.47393F));
            this.tableLayoutPanel1.Controls.Add(this.stock, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.ingredientes, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.agregar_stock, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Cantidad_agregar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.menu, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(198, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.74419F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.25581F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 215F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 360);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona los ingredientes:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad a agregar:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ingredientes
            // 
            this.ingredientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ingredientes.FormattingEnabled = true;
            this.ingredientes.Location = new System.Drawing.Point(3, 24);
            this.ingredientes.Name = "ingredientes";
            this.ingredientes.Size = new System.Drawing.Size(247, 24);
            this.ingredientes.TabIndex = 1;
            this.ingredientes.SelectedIndexChanged += new System.EventHandler(this.ingredientes_SelectedIndexChanged);
            // 
            // Cantidad_agregar
            // 
            this.Cantidad_agregar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cantidad_agregar.Location = new System.Drawing.Point(256, 24);
            this.Cantidad_agregar.Name = "Cantidad_agregar";
            this.Cantidad_agregar.Size = new System.Drawing.Size(252, 22);
            this.Cantidad_agregar.TabIndex = 2;
            this.Cantidad_agregar.TextChanged += new System.EventHandler(this.Cantidad_agregar_TextChanged);
            // 
            // agregar_stock
            // 
            this.agregar_stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.agregar_stock, 2);
            this.agregar_stock.Location = new System.Drawing.Point(3, 83);
            this.agregar_stock.Name = "agregar_stock";
            this.agregar_stock.Size = new System.Drawing.Size(505, 29);
            this.agregar_stock.TabIndex = 1;
            this.agregar_stock.Text = "agregar a inventario";
            this.agregar_stock.UseVisualStyleBackColor = true;
            this.agregar_stock.Click += new System.EventHandler(this.agregar_stock_Click);
            // 
            // stock
            // 
            this.stock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.stock, 2);
            this.stock.Location = new System.Drawing.Point(3, 118);
            this.stock.Name = "stock";
            this.stock.RowHeadersWidth = 51;
            this.stock.RowTemplate.Height = 24;
            this.stock.Size = new System.Drawing.Size(505, 209);
            this.stock.TabIndex = 2;
            this.stock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stock_CellContentClick);
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.menu, 2);
            this.menu.Location = new System.Drawing.Point(3, 333);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(505, 24);
            this.menu.TabIndex = 3;
            this.menu.Text = "volvel al menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormInventario";
            this.Text = "FormInventario";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ingredientes;
        private System.Windows.Forms.TextBox Cantidad_agregar;
        private System.Windows.Forms.Button agregar_stock;
        private System.Windows.Forms.DataGridView stock;
        private System.Windows.Forms.Button menu;
    }
}