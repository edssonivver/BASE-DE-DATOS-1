using System;
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
    public partial class LoginEmpleado : Form
    {
        public LoginEmpleado()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            VGPersonal inicio = new VGPersonal();
            inicio.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaEmpleado ventana = new VentanaEmpleado();
            ventana.Show();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
            ROLL inicio = new ROLL();
            inicio.ShowDialog();
        }
    }
}
