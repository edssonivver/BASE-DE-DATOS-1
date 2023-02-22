
namespace PROYECTO_PROGRAMACION_II
{
    partial class VGVentas
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbxVentas = new System.Windows.Forms.GroupBox();
            this.btnDesplegarLista = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dvgVentas = new System.Windows.Forms.DataGridView();
            this.lblNumRegistros = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNId_Ventas = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtI_Cliente = new System.Windows.Forms.TextBox();
            this.txtId_Productos = new System.Windows.Forms.TextBox();
            this.txtCuenta_a_Pagar = new System.Windows.Forms.TextBox();
            this.txtCuenta_Pagada = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotal_a_Pagar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTipo_Moneda_De_Pago = new System.Windows.Forms.TextBox();
            this.gbxVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(479, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 47);
            this.label1.TabIndex = 57;
            this.label1.Text = "VENTAS";
            // 
            // gbxVentas
            // 
            this.gbxVentas.Controls.Add(this.label9);
            this.gbxVentas.Controls.Add(this.textBox2);
            this.gbxVentas.Controls.Add(this.btnDesplegarLista);
            this.gbxVentas.Controls.Add(this.btnAgregar);
            this.gbxVentas.Controls.Add(this.btnModificar);
            this.gbxVentas.Controls.Add(this.btnEliminar);
            this.gbxVentas.Controls.Add(this.dvgVentas);
            this.gbxVentas.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxVentas.Location = new System.Drawing.Point(2, 56);
            this.gbxVentas.Name = "gbxVentas";
            this.gbxVentas.Size = new System.Drawing.Size(637, 275);
            this.gbxVentas.TabIndex = 56;
            this.gbxVentas.TabStop = false;
            this.gbxVentas.Text = "Lista de Ventas";
            // 
            // btnDesplegarLista
            // 
            this.btnDesplegarLista.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesplegarLista.Location = new System.Drawing.Point(39, 212);
            this.btnDesplegarLista.Name = "btnDesplegarLista";
            this.btnDesplegarLista.Size = new System.Drawing.Size(87, 23);
            this.btnDesplegarLista.TabIndex = 55;
            this.btnDesplegarLista.Text = "ACTUALIZAR";
            this.btnDesplegarLista.UseVisualStyleBackColor = true;
            this.btnDesplegarLista.Click += new System.EventHandler(this.btnDesplegarLista_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(39, 96);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 23);
            this.btnAgregar.TabIndex = 39;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(39, 135);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 23);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(39, 174);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 23);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dvgVentas
            // 
            this.dvgVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVentas.Location = new System.Drawing.Point(187, 32);
            this.dvgVentas.Name = "dvgVentas";
            this.dvgVentas.RowHeadersWidth = 51;
            this.dvgVentas.Size = new System.Drawing.Size(444, 203);
            this.dvgVentas.TabIndex = 35;
            this.dvgVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgVentas_CellContentClick_1);
            // 
            // lblNumRegistros
            // 
            this.lblNumRegistros.AutoSize = true;
            this.lblNumRegistros.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRegistros.Location = new System.Drawing.Point(171, 20);
            this.lblNumRegistros.Name = "lblNumRegistros";
            this.lblNumRegistros.Size = new System.Drawing.Size(13, 13);
            this.lblNumRegistros.TabIndex = 54;
            this.lblNumRegistros.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "NUMERO DEREGISTROS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Nuevo Id Ventas";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNId_Ventas
            // 
            this.txtNId_Ventas.Location = new System.Drawing.Point(28, 371);
            this.txtNId_Ventas.Name = "txtNId_Ventas";
            this.txtNId_Ventas.Size = new System.Drawing.Size(100, 20);
            this.txtNId_Ventas.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(565, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Cuenta Pagada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(432, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Cuenta a Pagar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(155, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "Id_Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 84;
            this.label3.Text = "Id Productos";
            // 
            // txtI_Cliente
            // 
            this.txtI_Cliente.Location = new System.Drawing.Point(158, 371);
            this.txtI_Cliente.Name = "txtI_Cliente";
            this.txtI_Cliente.Size = new System.Drawing.Size(100, 20);
            this.txtI_Cliente.TabIndex = 83;
            // 
            // txtId_Productos
            // 
            this.txtId_Productos.Location = new System.Drawing.Point(300, 371);
            this.txtId_Productos.Name = "txtId_Productos";
            this.txtId_Productos.Size = new System.Drawing.Size(100, 20);
            this.txtId_Productos.TabIndex = 82;
            // 
            // txtCuenta_a_Pagar
            // 
            this.txtCuenta_a_Pagar.Location = new System.Drawing.Point(435, 371);
            this.txtCuenta_a_Pagar.Name = "txtCuenta_a_Pagar";
            this.txtCuenta_a_Pagar.Size = new System.Drawing.Size(100, 20);
            this.txtCuenta_a_Pagar.TabIndex = 81;
            // 
            // txtCuenta_Pagada
            // 
            this.txtCuenta_Pagada.Location = new System.Drawing.Point(568, 371);
            this.txtCuenta_Pagada.Name = "txtCuenta_Pagada";
            this.txtCuenta_Pagada.Size = new System.Drawing.Size(100, 20);
            this.txtCuenta_Pagada.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 420);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 91;
            this.label8.Text = "Total_a_Pagar";
            // 
            // txtTotal_a_Pagar
            // 
            this.txtTotal_a_Pagar.Location = new System.Drawing.Point(211, 446);
            this.txtTotal_a_Pagar.Name = "txtTotal_a_Pagar";
            this.txtTotal_a_Pagar.Size = new System.Drawing.Size(100, 20);
            this.txtTotal_a_Pagar.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 87;
            this.label9.Text = "Id Ventas";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(39, 57);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(366, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 13);
            this.label10.TabIndex = 93;
            this.label10.Text = "Tipo Moneda De Pago";
            // 
            // txtTipo_Moneda_De_Pago
            // 
            this.txtTipo_Moneda_De_Pago.Location = new System.Drawing.Point(369, 446);
            this.txtTipo_Moneda_De_Pago.Name = "txtTipo_Moneda_De_Pago";
            this.txtTipo_Moneda_De_Pago.Size = new System.Drawing.Size(100, 20);
            this.txtTipo_Moneda_De_Pago.TabIndex = 92;
            // 
            // VGVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 509);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTipo_Moneda_De_Pago);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTotal_a_Pagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNId_Ventas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtI_Cliente);
            this.Controls.Add(this.txtId_Productos);
            this.Controls.Add(this.txtCuenta_a_Pagar);
            this.Controls.Add(this.txtCuenta_Pagada);
            this.Controls.Add(this.lblNumRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbxVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VGVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.VGVentas_Load);
            this.gbxVentas.ResumeLayout(false);
            this.gbxVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxVentas;
        private System.Windows.Forms.Label lblNumRegistros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dvgVentas;
        private System.Windows.Forms.Button btnDesplegarLista;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNId_Ventas;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtI_Cliente;
        private System.Windows.Forms.TextBox txtId_Productos;
        private System.Windows.Forms.TextBox txtCuenta_a_Pagar;
        private System.Windows.Forms.TextBox txtCuenta_Pagada;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotal_a_Pagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTipo_Moneda_De_Pago;
    }
}