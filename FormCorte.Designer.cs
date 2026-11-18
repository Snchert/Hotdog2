namespace Proyecto_individual
{
    partial class FormCorte
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
            this.corte = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ventas_dia = new System.Windows.Forms.DataGridView();
            this.menu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventas_dia)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.menu, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.corte, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ventas_dia, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(103, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.27451F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.72549F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 359);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // corte
            // 
            this.corte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.corte.Location = new System.Drawing.Point(3, 290);
            this.corte.Name = "corte";
            this.corte.Size = new System.Drawing.Size(569, 35);
            this.corte.TabIndex = 0;
            this.corte.Text = "Corte del dia";
            this.corte.UseVisualStyleBackColor = true;
            this.corte.Click += new System.EventHandler(this.corte_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Corte del dia";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ventas_dia
            // 
            this.ventas_dia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ventas_dia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ventas_dia.Location = new System.Drawing.Point(3, 35);
            this.ventas_dia.Name = "ventas_dia";
            this.ventas_dia.RowHeadersWidth = 51;
            this.ventas_dia.RowTemplate.Height = 24;
            this.ventas_dia.Size = new System.Drawing.Size(569, 249);
            this.ventas_dia.TabIndex = 2;
            this.ventas_dia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ventas_dia_CellContentClick);
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.Location = new System.Drawing.Point(3, 331);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(569, 25);
            this.menu.TabIndex = 1;
            this.menu.Text = "volver al menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // FormCorte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormCorte";
            this.Text = "FormCorte";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ventas_dia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button corte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ventas_dia;
        private System.Windows.Forms.Button menu;
    }
}