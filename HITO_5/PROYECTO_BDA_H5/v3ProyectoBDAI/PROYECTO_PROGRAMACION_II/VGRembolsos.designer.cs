
namespace PROYECTO_PROGRAMACION_II
{
    partial class VGRembolsos
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
            this.gbxRembolsos = new System.Windows.Forms.GroupBox();
            this.lblNumRegistros = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dvgRembolsos = new System.Windows.Forms.DataGridView();
            this.btnActualizarLista = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNId_Rembolsos = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtId_Cliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId_Productos_Rembolsados = new System.Windows.Forms.TextBox();
            this.txtTipo_Moenda = new System.Windows.Forms.TextBox();
            this.txtMonto_Rembolsado = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtId_Rembolsos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbxRembolsos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRembolsos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(559, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 41);
            this.label1.TabIndex = 79;
            this.label1.Text = "REMBOLSOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // gbxRembolsos
            // 
            this.gbxRembolsos.Controls.Add(this.label9);
            this.gbxRembolsos.Controls.Add(this.txtId_Rembolsos);
            this.gbxRembolsos.Controls.Add(this.btnActualizarLista);
            this.gbxRembolsos.Controls.Add(this.btnAgregar);
            this.gbxRembolsos.Controls.Add(this.label5);
            this.gbxRembolsos.Controls.Add(this.label7);
            this.gbxRembolsos.Controls.Add(this.btnModificar);
            this.gbxRembolsos.Controls.Add(this.txtTipo_Moenda);
            this.gbxRembolsos.Controls.Add(this.label3);
            this.gbxRembolsos.Controls.Add(this.txtStock);
            this.gbxRembolsos.Controls.Add(this.btnEliminar);
            this.gbxRembolsos.Controls.Add(this.label4);
            this.gbxRembolsos.Controls.Add(this.txtMonto_Rembolsado);
            this.gbxRembolsos.Controls.Add(this.dvgRembolsos);
            this.gbxRembolsos.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxRembolsos.Location = new System.Drawing.Point(1, 53);
            this.gbxRembolsos.Name = "gbxRembolsos";
            this.gbxRembolsos.Size = new System.Drawing.Size(765, 338);
            this.gbxRembolsos.TabIndex = 78;
            this.gbxRembolsos.TabStop = false;
            this.gbxRembolsos.Text = "LISTA DE REEMBOLSOS";
            // 
            // lblNumRegistros
            // 
            this.lblNumRegistros.AutoSize = true;
            this.lblNumRegistros.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRegistros.Location = new System.Drawing.Point(148, 20);
            this.lblNumRegistros.Name = "lblNumRegistros";
            this.lblNumRegistros.Size = new System.Drawing.Size(13, 13);
            this.lblNumRegistros.TabIndex = 54;
            this.lblNumRegistros.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 53;
            this.label6.Text = "NUMERO DEREGISTROS";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(26, 100);
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
            this.btnModificar.Location = new System.Drawing.Point(26, 141);
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
            this.btnEliminar.Location = new System.Drawing.Point(26, 184);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 23);
            this.btnEliminar.TabIndex = 36;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dvgRembolsos
            // 
            this.dvgRembolsos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgRembolsos.Location = new System.Drawing.Point(158, 42);
            this.dvgRembolsos.Name = "dvgRembolsos";
            this.dvgRembolsos.RowHeadersWidth = 51;
            this.dvgRembolsos.Size = new System.Drawing.Size(597, 225);
            this.dvgRembolsos.TabIndex = 35;
            this.dvgRembolsos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgRembolsos_CellContentClick);
            // 
            // btnActualizarLista
            // 
            this.btnActualizarLista.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarLista.Location = new System.Drawing.Point(26, 230);
            this.btnActualizarLista.Name = "btnActualizarLista";
            this.btnActualizarLista.Size = new System.Drawing.Size(93, 24);
            this.btnActualizarLista.TabIndex = 77;
            this.btnActualizarLista.Text = "ACTUALIZAR";
            this.btnActualizarLista.UseVisualStyleBackColor = true;
            this.btnActualizarLista.Click += new System.EventHandler(this.btnActualizarLista_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 115;
            this.label2.Text = "Id_Rembolsos";
            // 
            // txtNId_Rembolsos
            // 
            this.txtNId_Rembolsos.Location = new System.Drawing.Point(55, 357);
            this.txtNId_Rembolsos.Name = "txtNId_Rembolsos";
            this.txtNId_Rembolsos.Size = new System.Drawing.Size(100, 20);
            this.txtNId_Rembolsos.TabIndex = 114;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(180, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 113;
            this.label8.Text = "Id_Cliente";
            // 
            // txtId_Cliente
            // 
            this.txtId_Cliente.Location = new System.Drawing.Point(183, 357);
            this.txtId_Cliente.Name = "txtId_Cliente";
            this.txtId_Cliente.Size = new System.Drawing.Size(100, 20);
            this.txtId_Cliente.TabIndex = 112;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(668, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 111;
            this.label7.Text = "Motivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 110;
            this.label3.Text = "Monto_Rembolsado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Id_Productos_Rembolsados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 108;
            this.label5.Text = "Tipo Moneda";
            // 
            // txtId_Productos_Rembolsados
            // 
            this.txtId_Productos_Rembolsados.Location = new System.Drawing.Point(305, 357);
            this.txtId_Productos_Rembolsados.Name = "txtId_Productos_Rembolsados";
            this.txtId_Productos_Rembolsados.Size = new System.Drawing.Size(100, 20);
            this.txtId_Productos_Rembolsados.TabIndex = 107;
            // 
            // txtTipo_Moenda
            // 
            this.txtTipo_Moenda.Location = new System.Drawing.Point(552, 303);
            this.txtTipo_Moenda.Name = "txtTipo_Moenda";
            this.txtTipo_Moenda.Size = new System.Drawing.Size(100, 21);
            this.txtTipo_Moenda.TabIndex = 106;
            // 
            // txtMonto_Rembolsado
            // 
            this.txtMonto_Rembolsado.Location = new System.Drawing.Point(435, 305);
            this.txtMonto_Rembolsado.Name = "txtMonto_Rembolsado";
            this.txtMonto_Rembolsado.Size = new System.Drawing.Size(100, 21);
            this.txtMonto_Rembolsado.TabIndex = 105;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(671, 304);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 21);
            this.txtStock.TabIndex = 104;
            // 
            // txtId_Rembolsos
            // 
            this.txtId_Rembolsos.Location = new System.Drawing.Point(26, 63);
            this.txtId_Rembolsos.Name = "txtId_Rembolsos";
            this.txtId_Rembolsos.Size = new System.Drawing.Size(100, 21);
            this.txtId_Rembolsos.TabIndex = 115;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 116;
            this.label9.Text = "Id_Rembolsos";
            // 
            // VGRembolsos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 445);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNId_Rembolsos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtId_Cliente);
            this.Controls.Add(this.txtId_Productos_Rembolsados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbxRembolsos);
            this.Controls.Add(this.lblNumRegistros);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VGRembolsos";
            this.Text = "Rembolsos";
            this.Load += new System.EventHandler(this.VGRembolsos_Load);
            this.gbxRembolsos.ResumeLayout(false);
            this.gbxRembolsos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgRembolsos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxRembolsos;
        private System.Windows.Forms.Label lblNumRegistros;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dvgRembolsos;
        private System.Windows.Forms.Button btnActualizarLista;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId_Rembolsos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipo_Moenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMonto_Rembolsado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNId_Rembolsos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtId_Cliente;
        private System.Windows.Forms.TextBox txtId_Productos_Rembolsados;
    }
}