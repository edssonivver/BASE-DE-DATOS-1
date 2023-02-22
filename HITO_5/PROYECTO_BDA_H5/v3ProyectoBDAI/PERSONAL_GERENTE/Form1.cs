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


namespace PERSONAL_GERENTE
{
    public partial class Form1 : Form
    {

        PersonalGerenteBD pg = new PersonalGerenteBD();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            pg.listarPersonalGerente(out dt, out nr);
            dgvPersonalGerente.DataSource = dt;
            if (nr > 0)
                dgvPersonalGerente.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pg.eliminarPersonalGerente(Convert.ToInt32(dgvPersonalGerente.Rows[dgvPersonalGerente.CurrentRow.Index].Cells[0].Value));
            dgvPersonalGerente.Rows.RemoveAt(dgvPersonalGerente.CurrentRow.Index);
        }


        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            pg.adicionarPersonalGerente(Convert.ToInt32(dgvPersonalGerente.Rows[dgvPersonalGerente.CurrentRow.Index - 1].Cells[0].Value),

                Convert.ToString(dgvPersonalGerente.Rows[dgvPersonalGerente.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dgvPersonalGerente.Rows[dgvPersonalGerente.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dgvPersonalGerente.Rows[dgvPersonalGerente.CurrentRow.Index].Cells[3].Value),

                Convert.ToString(dgvPersonalGerente.Rows[dgvPersonalGerente.CurrentRow.Index].Cells[4].Value));

            pg.listarPersonalGerente(out dt, out nr);
            dgvPersonalGerente.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            pg.modificarPersonalGerente(Convert.ToInt32(dgvPersonalGerente.Rows[dgvPersonalGerente.CurrentRow.Index].Cells[0].Value),

                Convert.ToString(dgvPersonalGerente.Rows[dgvPersonalGerente.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dgvPersonalGerente.Rows[dgvPersonalGerente.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dgvPersonalGerente.Rows[dgvPersonalGerente.CurrentRow.Index].Cells[3].Value),

                Convert.ToString(dgvPersonalGerente.Rows[dgvPersonalGerente.CurrentRow.Index].Cells[4].Value));

            pg.listarPersonalGerente(out dt, out nr);
            dgvPersonalGerente.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            pg.listarPersonalGerente(out dt, out nr);
            dgvPersonalGerente.DataSource = dt;
            if (nr > 0)
                dgvPersonalGerente.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        class PersonalGerenteBD
        {
            public SqlConnection conexion;
            public SqlDataAdapter adaptador;
            public DataTable dt;

            public PersonalGerenteBD()
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

            public void listarPersonalGerente(out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_MostrarPersonalGerente", conexion);
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

            public void eliminarPersonalGerente(int id)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_EliminarPersonalGerente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Gerente", SqlDbType.Int).Value = id;

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

            public void adicionarPersonalGerente(int id, string nom, string ape, string suel, string tur)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarPersonalGerente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Gerente", SqlDbType.Int).Value = id + 1;
                cmd.Parameters.Add("@Nombre_Gerente", SqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@Apellido_Gerente", SqlDbType.VarChar).Value = ape;
                cmd.Parameters.Add("@Sueldo_Gerente", SqlDbType.VarChar).Value = suel;
                cmd.Parameters.Add("@Turno_Gerente", SqlDbType.VarChar).Value = tur;

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

            public void modificarPersonalGerente(int id, string nom, string ape, string suel, string tur)   // cambiar por string el id
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarPersonalGerente";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Gerente", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@Nombre_Gerente", SqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@Apellido_Gerente", SqlDbType.VarChar).Value = ape;
                cmd.Parameters.Add("@Sueldo_Gerente", SqlDbType.VarChar).Value = suel;
                cmd.Parameters.Add("@Turno_Gerente", SqlDbType.VarChar).Value = tur;


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

            public void buscarIdGerente(int nom, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarIdGerente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@IdGerente", SqlDbType.Int).Value = nom;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }



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
                conexion.Close();
            }

            public void buscarNombreGerente(string apPaterno, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarNombreGerente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Nombre_Gerente", SqlDbType.VarChar).Value = apPaterno;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

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
                conexion.Close();
            }

            public void buscarApellidoGerente(string apMaterno, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarApellidoGerente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Apellido_Gerente", SqlDbType.VarChar).Value = apMaterno;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

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
                conexion.Close();
            }

            public void buscarSueldoGerente(string ed, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscarSueldoGerente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Sueldo_Gerente", SqlDbType.VarChar).Value = ed;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

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
                conexion.Close();
            }


            public void buscarTurnoGerente(string ed, out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "PA_BuscaTurnoGerente";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Turno_Gerente", SqlDbType.VarChar).Value = ed;

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }

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
                conexion.Close();
            }
        }

        private void cmbBuscar_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;
            switch (cmbBuscar.SelectedIndex)
            {
                case 0:
                    pg.buscarIdGerente(Convert.ToInt32(txtBuscar.Text), out dt, out nr);
                    dgvPersonalGerente.DataSource = dt;
                    break;
                case 1:
                    pg.buscarNombreGerente(txtBuscar.Text, out dt, out nr);
                    dgvPersonalGerente.DataSource = dt;
                    break;
                case 2:
                    pg.buscarApellidoGerente(txtBuscar.Text, out dt, out nr);
                    dgvPersonalGerente.DataSource = dt;
                    break;
                case 3:
                    pg.buscarSueldoGerente(txtBuscar.Text, out dt, out nr);
                    dgvPersonalGerente.DataSource = dt;
                    break;
                case 4:
                    pg.buscarTurnoGerente(txtBuscar.Text, out dt, out nr);
                    dgvPersonalGerente.DataSource = dt;
                    break;
            }
            lblNumRegistros.Text = Convert.ToString(nr);
        }

        private void dgvPersonalGerente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvPersonalGerente.Rows[e.RowIndex].IsNewRow)
            {
                dgvPersonalGerente.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
