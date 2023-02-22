namespace EnvioCorreo
{
    partial class FmCorreo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnviarCorreo = new System.Windows.Forms.Button();
            this.txtDeg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_x = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.txtAsunto = new PROYECTO_PROGRAMACION_II.customTextBox();
            this.txtMensaje = new PROYECTO_PROGRAMACION_II.customTextBox();
            this.txtPara = new PROYECTO_PROGRAMACION_II.customTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnviarCorreo
            // 
            this.btnEnviarCorreo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnEnviarCorreo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.btnEnviarCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarCorreo.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviarCorreo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnviarCorreo.Location = new System.Drawing.Point(72, 364);
            this.btnEnviarCorreo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnviarCorreo.Name = "btnEnviarCorreo";
            this.btnEnviarCorreo.Size = new System.Drawing.Size(229, 48);
            this.btnEnviarCorreo.TabIndex = 15;
            this.btnEnviarCorreo.Text = "ENVIAR CORREO";
            this.btnEnviarCorreo.UseVisualStyleBackColor = true;
            this.btnEnviarCorreo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDeg
            // 
            this.txtDeg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDeg.Location = new System.Drawing.Point(44, 61);
            this.txtDeg.Name = "txtDeg";
            this.txtDeg.Size = new System.Drawing.Size(271, 20);
            this.txtDeg.TabIndex = 22;
            this.txtDeg.Text = "correopruebagerente@gmail.com";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(41, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "De:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_x);
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 30);
            this.panel1.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PROYECTO_PROGRAMACION_II.Properties.Resources.close;
            this.button1.Location = new System.Drawing.Point(329, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 28);
            this.button1.TabIndex = 25;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_x
            // 
            this.btn_x.FlatAppearance.BorderSize = 0;
            this.btn_x.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(101)))), ((int)(((byte)(113)))));
            this.btn_x.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(3)))));
            this.btn_x.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_x.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x.Location = new System.Drawing.Point(566, 0);
            this.btn_x.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_x.Name = "btn_x";
            this.btn_x.Size = new System.Drawing.Size(38, 28);
            this.btn_x.TabIndex = 14;
            this.btn_x.UseVisualStyleBackColor = true;
            // 
            // btn_min
            // 
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(235)))), ((int)(((byte)(236)))));
            this.btn_min.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.Location = new System.Drawing.Point(531, 0);
            this.btn_min.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(38, 28);
            this.btn_min.TabIndex = 13;
            this.btn_min.UseVisualStyleBackColor = true;
            // 
            // txtAsunto
            // 
            this.txtAsunto.BackColor = System.Drawing.Color.White;
            this.txtAsunto.customMultiline = false;
            this.txtAsunto.customText = "ASUNTO:";
            this.txtAsunto.Location = new System.Drawing.Point(44, 154);
            this.txtAsunto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.password = false;
            this.txtAsunto.Size = new System.Drawing.Size(230, 50);
            this.txtAsunto.TabIndex = 19;
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.White;
            this.txtMensaje.customMultiline = true;
            this.txtMensaje.customText = "MENSAJE:";
            this.txtMensaje.Location = new System.Drawing.Point(44, 219);
            this.txtMensaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.password = false;
            this.txtMensaje.Size = new System.Drawing.Size(290, 128);
            this.txtMensaje.TabIndex = 18;
            // 
            // txtPara
            // 
            this.txtPara.BackColor = System.Drawing.Color.White;
            this.txtPara.customMultiline = false;
            this.txtPara.customText = "PARA:";
            this.txtPara.Location = new System.Drawing.Point(44, 90);
            this.txtPara.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPara.Name = "txtPara";
            this.txtPara.password = false;
            this.txtPara.Size = new System.Drawing.Size(230, 50);
            this.txtPara.TabIndex = 17;
            // 
            // FmCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(55)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(370, 426);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtDeg);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.btnEnviarCorreo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FmCorreo";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnviarCorreo;
        private PROYECTO_PROGRAMACION_II.customTextBox txtPara;
        private PROYECTO_PROGRAMACION_II.customTextBox txtMensaje;
        private PROYECTO_PROGRAMACION_II.customTextBox txtAsunto;
        private System.Windows.Forms.TextBox txtDeg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_x;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button button1;
    }
}

