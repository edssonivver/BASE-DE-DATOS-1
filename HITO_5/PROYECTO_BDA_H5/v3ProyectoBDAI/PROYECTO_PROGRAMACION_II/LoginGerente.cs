﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PROGRAMACION_II
{
    public partial class LoginGerente : Form
    {
        public LoginGerente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            ROLL inicio = new ROLL();
            inicio.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_login_administrador_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaGerente ventanaGerente = new VentanaGerente();
            ventanaGerente.Show();
        }
    }
}
