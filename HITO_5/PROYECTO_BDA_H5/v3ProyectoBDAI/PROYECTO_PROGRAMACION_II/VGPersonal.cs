using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PROYECTO_PROGRAMACION_II
{
    public partial class VGPersonal : Form
    {

        PersonalBD pg = new PersonalBD();


        public VGPersonal()
        {
            InitializeComponent();
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pg.eliminarPersonalEmpleados(Convert.ToString(txtId_Personal));
            dgvPersonalEmpleado.Rows.RemoveAt(dgvPersonalEmpleado.CurrentRow.Index);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            pg.adicionarPersonalEmpleados(Convert.ToString(txtId_Personal.Text),

                Convert.ToString(txtNombre.Text),

                Convert.ToString(txtApellido.Text),

                Convert.ToString(txtRoll.Text),

                Convert.ToDecimal(txtSueldo.Text),

                Convert.ToString(txtTipo_Moneda.Text),

                Convert.ToString(txtTurno.Text));

            pg.listarPersonalEmpleados(out dt, out nr);
            dgvPersonalEmpleado.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            pg.modificarPersonalEmpleados(Convert.ToString(txtId_Personal.Text),

                Convert.ToString(txtNombre.Text),

                Convert.ToString(txtApellido.Text),

                Convert.ToString(txtRoll.Text),

                Convert.ToDecimal(txtSueldo.Text),

                Convert.ToString(txtTipo_Moneda.Text),

                Convert.ToString(txtTurno.Text),

                Convert.ToString(txtNId_Personal.Text));

            pg.listarPersonalEmpleados(out dt, out nr);
            dgvPersonalEmpleado.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            pg.listarPersonalEmpleados(out dt, out nr);
            dgvPersonalEmpleado.DataSource = dt;
            if (nr > 0)
                dgvPersonalEmpleado.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }



        private void btn_volver_Click_1(object sender, EventArgs e)
        {
            //VGPersonal VGPersonal = new VGPersonal();
            //VGPersonal.Show();
            //this.Close();
        }


        private void VGPersonalEmpleados_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            pg.listarPersonalEmpleados(out dt, out nr);
            dgvPersonalEmpleado.DataSource = dt;
            if (nr > 0)
                dgvPersonalEmpleado.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void dgvPersonalEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvPersonalEmpleado.Rows[e.RowIndex].IsNewRow)
            {
                dgvPersonalEmpleado.Rows.RemoveAt(e.RowIndex);
            }
        }


        class PersonalBD
        {
            public SqlConnection conexion;
            public SqlDataAdapter adaptador;
            public DataTable dt;

            public PersonalBD()
            {
                try
                {
                    conexion = new SqlConnection("server=localhost;Database=DB_SistemaDeVentas;integrated security=true");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

            public void listarPersonalEmpleados(out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_MostrarPersonal", conexion);
                    adaptador = new SqlDataAdapter(cmd);
                    dt = new DataTable();

                    adaptador.Fill(dt);
                    dataTable = dt;
                    numreg = dt.Rows.Count;
                }
                catch (Exception ex)
                {
                    dataTable = dt;
                    numreg = dt.Rows.Count;

                    MessageBox.Show(ex.Message.ToString());
                }

            }

            public void eliminarPersonalEmpleados(string id)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_EliminarPersonal";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Personal", SqlDbType.VarChar).Value = id;

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

            public void adicionarPersonalEmpleados(string id, string nom, string ap, string r, decimal s, string tp, string t)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarPersonal";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Personal", SqlDbType.VarChar).Value = "P-" + id;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = ap;
                cmd.Parameters.Add("@Roll", SqlDbType.VarChar).Value = r;
                cmd.Parameters.Add("@Sueldo", SqlDbType.Float).Value = s;
                cmd.Parameters.Add("@Tipo_Moneda", SqlDbType.VarChar).Value = tp;
                cmd.Parameters.Add("@Turno", SqlDbType.VarChar).Value = t;

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

            public void modificarPersonalEmpleados(string id, string nom, string ap, string r, decimal s, string tp, string t, string Nid)   // cambiar por string el id
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarPersonal";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Personal", SqlDbType.VarChar).Value = id;
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@Apellido", SqlDbType.VarChar).Value = ap;
                cmd.Parameters.Add("@Roll", SqlDbType.VarChar).Value = r;
                cmd.Parameters.Add("@Sueldo", SqlDbType.Float).Value = s;
                cmd.Parameters.Add("@Tipo_Moneda", SqlDbType.VarChar).Value = tp;
                cmd.Parameters.Add("@Turno", SqlDbType.VarChar).Value = t;
                cmd.Parameters.Add("@Id_PersonalNew", SqlDbType.VarChar).Value = Nid;


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

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
