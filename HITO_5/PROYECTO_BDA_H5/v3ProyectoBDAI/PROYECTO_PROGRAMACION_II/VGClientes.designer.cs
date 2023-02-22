
namespace PROYECTO_PROGRAMACION_II
{
    partial class VGClientes
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
            this.gbxClientes = new System.Windows.Forms.GroupBox();
            this.lblNumRegistros = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dvgClientes = new System.Windows.Forms.DataGridView();
            this.btnDesplegarLista = new System.Windows.Forms.Button();
            this.txtId_Cliente = new System.Windows.Forms.TextBox();
            this.txtApellido_Clientes = new System.Windows.Forms.TextBox();
            this.txtNombre_Clientes = new System.Windows.Forms.TextBox();
            this.txtCI = new System.Windows.Forms.TextBox();
            this.txtId_Vendedor = new System.Windows.Forms.TextBox();
            this.lblId_Cliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNId_Cliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(553, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 41);
            this.label1.TabIndex = 69;
            this.label1.Text = "CLIENTES";
            // 
            // gbxClientes
            // 
            this.gbxClientes.Controls.Add(this.label2);
            this.gbxClientes.Controls.Add(this.txtNId_Cliente);
            this.gbxClientes.Controls.Add(this.label7);
            this.gbxClientes.Controls.Add(this.label5);
            this.gbxClientes.Controls.Add(this.label4);
            this.gbxClientes.Controls.Add(this.label3);
            this.gbxClientes.Controls.Add(this.lblId_Cliente);
            this.gbxClientes.Controls.Add(this.txtId_Vendedor);
            this.gbxClientes.Controls.Add(this.txtId_Cliente);
            this.gbxClientes.Controls.Add(this.txtCI);
            this.gbxClientes.Controls.Add(this.txtNombre_Clientes);
            this.gbxClientes.Controls.Add(this.txtApellido_Clientes);
            this.gbxClientes.Controls.Add(this.btnAgregar);
            this.gbxClientes.Controls.Add(this.btnModificar);
            this.gbxClientes.Controls.Add(this.btnEliminar);
            this.gbxClientes.Controls.Add(this.dvgClientes);
            this.gbxClientes.Controls.Add(this.btnDesplegarLista);
            this.gbxClientes.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxClientes.Location = new System.Drawing.Point(42, 57);
            this.gbxClientes.Name = "gbxClientes";
            this.gbxClientes.Size = new System.Drawing.Size(689, 308);
            this.gbxClientes.TabIndex = 68;
            this.gbxClientes.TabStop = false;
            this.gbxClientes.Text = "LISTA DE CLIENTES";
            // 
            // lblNumRegistros
            // 
            this.lblNumRegistros.AutoSize = true;
            this.lblNumRegistros.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRegistros.Location = new System.Drawing.Point(184, 21);
            this.lblNumRegistros.Name = "lblNumRegistros";
            this.lblNumRegistros.Size = new System.Drawing.Size(13, 13);
            this.lblNumRegistros.TabIndex = 54;
            this.lblNumRegistros.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "NUMERO DEREGISTROS";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(8, 84);
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
            this.btnModificar.Location = new System.Drawing.Point(9, 125);
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
            this.btnEliminar.Location = new System.Drawing.Point(6, 167);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 23);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dvgClientes
            // 
            this.dvgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgClientes.Location = new System.Drawing.Point(117, 20);
            this.dvgClientes.Name = "dvgClientes";
            this.dvgClientes.RowHeadersWidth = 51;
            this.dvgClientes.Size = new System.Drawing.Size(566, 209);
            this.dvgClientes.TabIndex = 35;
            this.dvgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgClientes_CellContentClick);
            // 
            // btnDesplegarLista
            // 
            this.btnDesplegarLista.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesplegarLista.Location = new System.Drawing.Point(8, 205);
            this.btnDesplegarLista.Name = "btnDesplegarLista";
            this.btnDesplegarLista.Size = new System.Drawing.Size(87, 24);
            this.btnDesplegarLista.TabIndex = 67;
            this.btnDesplegarLista.Text = "ACTUALIZAR";
            this.btnDesplegarLista.UseVisualStyleBackColor = true;
            this.btnDesplegarLista.Click += new System.EventHandler(this.btnDesplegarLista_Click);
            // 
            // txtId_Cliente
            // 
            this.txtId_Cliente.Location = new System.Drawing.Point(6, 45);
            this.txtId_Cliente.Name = "txtId_Cliente";
            this.txtId_Cliente.Size = new System.Drawing.Size(100, 21);
            this.txtId_Cliente.TabIndex = 68;
            // 
            // txtApellido_Clientes
            // 
            this.txtApellido_Clientes.Location = new System.Drawing.Point(564, 272);
            this.txtApellido_Clientes.Name = "txtApellido_Clientes";
            this.txtApellido_Clientes.Size = new System.Drawing.Size(100, 21);
            this.txtApellido_Clientes.TabIndex = 69;
            // 
            // txtNombre_Clientes
            // 
            this.txtNombre_Clientes.Location = new System.Drawing.Point(431, 272);
            this.txtNombre_Clientes.Name = "txtNombre_Clientes";
            this.txtNombre_Clientes.Size = new System.Drawing.Size(100, 21);
            this.txtNombre_Clientes.TabIndex = 70;
            // 
            // txtCI
            // 
            this.txtCI.Location = new System.Drawing.Point(296, 272);
            this.txtCI.Name = "txtCI";
            this.txtCI.Size = new System.Drawing.Size(100, 21);
            this.txtCI.TabIndex = 71;
            // 
            // txtId_Vendedor
            // 
            this.txtId_Vendedor.Location = new System.Drawing.Point(154, 272);
            this.txtId_Vendedor.Name = "txtId_Vendedor";
            this.txtId_Vendedor.Size = new System.Drawing.Size(100, 21);
            this.txtId_Vendedor.TabIndex = 72;
            // 
            // lblId_Cliente
            // 
            this.lblId_Cliente.AutoSize = true;
            this.lblId_Cliente.Location = new System.Drawing.Point(6, 20);
            this.lblId_Cliente.Name = "lblId_Cliente";
            this.lblId_Cliente.Size = new System.Drawing.Size(56, 13);
            this.lblId_Cliente.TabIndex = 73;
            this.lblId_Cliente.Text = "Id Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "CI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 75;
            this.label4.Text = "Id Vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 76;
            this.label5.Text = "Nombre del Cliente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Apellido del cliente";
            // 
            // txtNId_Cliente
            // 
            this.txtNId_Cliente.Location = new System.Drawing.Point(24, 272);
            this.txtNId_Cliente.Name = "txtNId_Cliente";
            this.txtNId_Cliente.Size = new System.Drawing.Size(100, 21);
            this.txtNId_Cliente.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 79;
            this.label2.Text = "Nuevo Id Cliente";
            // 
            // VGClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 397);
            this.Controls.Add(this.lblNumRegistros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbxClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VGClientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Form9_Load);
            this.gbxClientes.ResumeLayout(false);
            this.gbxClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxClientes;
        private System.Windows.Forms.Label lblNumRegistros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dvgClientes;
        private System.Windows.Forms.Button btnDesplegarLista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblId_Cliente;
        private System.Windows.Forms.TextBox txtId_Vendedor;
        private System.Windows.Forms.TextBox txtCI;
        private System.Windows.Forms.TextBox txtNombre_Clientes;
        private System.Windows.Forms.TextBox txtApellido_Clientes;
        private System.Windows.Forms.TextBox txtId_Cliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNId_Cliente;
    }
}