using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_PROGRAMACION_II
{
    public partial class VGLoginPersonal : Form
    {

        LoginPersonalDB client = new LoginPersonalDB();

        public VGLoginPersonal()
        {
            InitializeComponent();
        }

        private void VGLoginPersonal_Load(object sender, EventArgs e)
        {

        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvLogin_Personal.Rows[e.RowIndex].IsNewRow)
            {
                dgvLogin_Personal.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            client.eliminarCliente(Convert.ToString(txtId_Login_Personal.Text));
            dgvLogin_Personal.Rows.RemoveAt(dgvLogin_Personal.CurrentRow.Index);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt2; int nr2 = 0;

            client.adicionarCliente(Convert.ToString(txtId_Login_Personal.Text),

                Convert.ToString(txtContraseña.Text),

                Convert.ToString(txtUsuario.Text));

            client.listarClientes(out dt2, out nr2);
            dgvLogin_Personal.DataSource = dt2;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataTable dt2; int nr2 = 0;

            client.modificarCliente(Convert.ToString(txtId_Login_Personal.Text),

                Convert.ToString(txtContraseña.Text),

                 Convert.ToString(txtUsuario.Text),

                 Convert.ToString(txtNId_Login_Personal.Text));

            client.listarClientes(out dt2, out nr2);
            dgvLogin_Personal.DataSource = dt2;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt2; int nr2 = 0;
            client.listarClientes(out dt2, out nr2);
            dgvLogin_Personal.DataSource = dt2;
            if (nr2 > 0)
                dgvLogin_Personal.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }


        private void Form9_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt2; int nr2 = 0;
            client.listarClientes(out dt2, out nr2);
            dgvLogin_Personal.DataSource = dt2;
            if (nr2 > 0)
                dgvLogin_Personal.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr2);
        }



        class LoginPersonalDB
        {
            public SqlConnection conexion;
            public SqlDataAdapter adaptador;
            public DataTable dt2;

            public LoginPersonalDB()
            {
                try
                {
                    conexion = new SqlConnection("server=localhost;Database=DB_SistemaDeVentas;integrated security=true"); // PONER LA BASE DE DATOS AQUI este es un EJEMPLO
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

            public void listarClientes(out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_MostrarLoginPersonal", conexion); // Modificar el PA  
                    adaptador = new SqlDataAdapter(cmd);
                    dt2 = new DataTable();

                    adaptador.Fill(dt2);
                    dataTable = dt2;
                    numreg = dt2.Rows.Count;
                }
                catch (Exception ex)
                {
                    dataTable = dt2;
                    numreg = dt2.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }
            }

            public void eliminarCliente(string id) // CAMBIAR EL INT Y VARIABLE Si Fuera NECESARIO
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_EliminarLoginPersonal"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Login_Personal", SqlDbType.VarChar).Value = id;  // MODIFICAR EL @id y VARIABLE 

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                conexion.Close();
            }

            public void adicionarCliente(string id, string con, string us) // CAMBIAR EL TIPOS DE DATOS "INT,etc" Y VARIABLE segun a lo de la base de datos
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarLoginPersonal"; // Modificar el PA
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Login_Personal", SqlDbType.VarChar).Value = "P-" + id;
                cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = con;
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = us;


                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                conexion.Close();
            }

            public void modificarCliente(string id, string con, string us, string Nid)    // CAMBIAR EL TIPOS DE DATOS "INT,etc" Y VARIABLE segun a lo de la base de datos
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarLoginPersonal"; // MODIFICAR EL PA 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Login_Personal", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Contraseña", SqlDbType.VarChar).Value = con;
                cmd.Parameters.Add("@Usuario", SqlDbType.VarChar).Value = us;
                cmd.Parameters.Add("@Id_Login_PersonalNew", SqlDbType.VarChar).Value = Nid;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

                conexion.Close();
            }

        }

    }
}
