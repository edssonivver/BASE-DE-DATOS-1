﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PERSONAL_EMPLEADO
{
    public partial class Form1 : Form
    {

        PersonalEmpleadosBD pg = new PersonalEmpleadosBD();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            pg.listarPersonalEmpleados(out dt, out nr);
            dgvPersonalEmpleado.DataSource = dt;
            if (nr > 0)
                dgvPersonalEmpleado.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        class PersonalEmpleadosBD
        {
            public SqlConnection conexion;
            public SqlDataAdapter adaptador;
            public DataTable dt;

            public PersonalEmpleadosBD()
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
                    SqlCommand cmd = new SqlCommand("PA_MostrarPersonalEmpleado", conexion);
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

            public void eliminarPersonalEmpleados(int id)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_EliminarPersonalEmpleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Empleado", SqlDbType.Int).Value = id;

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

            public void adicionarPersonalEmpleados(int id, string nom, string ape, string suel, string tur)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarPersonalEmpleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Empleado", SqlDbType.Int).Value = id + 1;
                cmd.Parameters.Add("@Nombre_Empleado", SqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@Apellido_Empleado", SqlDbType.VarChar).Value = ape;
                cmd.Parameters.Add("@Sueldo_Empleado", SqlDbType.VarChar).Value = suel;
                cmd.Parameters.Add("@Turno_Empleado", SqlDbType.VarChar).Value = tur;

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

            public void modificarPersonalEmpleados(int id, string nom, string ape, string suel, string tur)   // cambiar por string el id
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarPersonalEmpleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Empleado", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@Nombre_Empleado", SqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@Apellido_Empleado", SqlDbType.VarChar).Value = ape;
                cmd.Parameters.Add("@Sueldo_Empleado", SqlDbType.VarChar).Value = suel;
                cmd.Parameters.Add("@Turno_Empleado", SqlDbType.VarChar).Value = tur;


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
                    cmd.CommandText = "PA_BuscarIdEmpleado";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Id_Empleado", SqlDbType.Int).Value = nom;

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
                    cmd.CommandText = "PA_BuscarNombreEmpleado";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Nombre_Empleado", SqlDbType.VarChar).Value = apPaterno;

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
                    cmd.CommandText = "PA_BuscarApellidoEmpleado";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Apellido_Empleado", SqlDbType.VarChar).Value = apMaterno;

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
                    cmd.CommandText = "PA_BuscarSueldoEmpleado";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Sueldo_Empleado", SqlDbType.VarChar).Value = ed;

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
                    cmd.CommandText = "PA_BuscarTurnoEmpleado";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = conexion;
                    conexion.Open();
                    cmd.Parameters.Add("@Turno_Empleado", SqlDbType.VarChar).Value = ed;

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


        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            pg.eliminarPersonalEmpleados(Convert.ToInt32(dgvPersonalEmpleado.Rows[dgvPersonalEmpleado.CurrentRow.Index].Cells[0].Value));
            dgvPersonalEmpleado.Rows.RemoveAt(dgvPersonalEmpleado.CurrentRow.Index);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            pg.adicionarPersonalEmpleados(Convert.ToInt32(dgvPersonalEmpleado.Rows[dgvPersonalEmpleado.CurrentRow.Index - 1].Cells[0].Value),

                Convert.ToString(dgvPersonalEmpleado.Rows[dgvPersonalEmpleado.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dgvPersonalEmpleado.Rows[dgvPersonalEmpleado.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dgvPersonalEmpleado.Rows[dgvPersonalEmpleado.CurrentRow.Index].Cells[3].Value),

                Convert.ToString(dgvPersonalEmpleado.Rows[dgvPersonalEmpleado.CurrentRow.Index].Cells[4].Value));

            pg.listarPersonalEmpleados(out dt, out nr);
            dgvPersonalEmpleado.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            pg.modificarPersonalEmpleados(Convert.ToInt32(dgvPersonalEmpleado.Rows[dgvPersonalEmpleado.CurrentRow.Index].Cells[0].Value),

                Convert.ToString(dgvPersonalEmpleado.Rows[dgvPersonalEmpleado.CurrentRow.Index].Cells[1].Value),

                Convert.ToString(dgvPersonalEmpleado.Rows[dgvPersonalEmpleado.CurrentRow.Index].Cells[2].Value),

                Convert.ToString(dgvPersonalEmpleado.Rows[dgvPersonalEmpleado.CurrentRow.Index].Cells[3].Value),

                Convert.ToString(dgvPersonalEmpleado.Rows[dgvPersonalEmpleado.CurrentRow.Index].Cells[4].Value));

            pg.listarPersonalEmpleados(out dt, out nr);
            dgvPersonalEmpleado.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            pg.listarPersonalEmpleados(out dt, out nr);
            dgvPersonalEmpleado.DataSource = dt;
            if (nr > 0)
                dgvPersonalEmpleado.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }

        private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;
            switch (cmbBuscar.SelectedIndex)
            {
                case 0:
                    pg.buscarIdGerente(Convert.ToInt32(txtBuscar.Text), out dt, out nr);
                    dgvPersonalEmpleado.DataSource = dt;
                    break;
                case 1:
                    pg.buscarNombreGerente(txtBuscar.Text, out dt, out nr);
                    dgvPersonalEmpleado.DataSource = dt;
                    break;
                case 2:
                    pg.buscarApellidoGerente(txtBuscar.Text, out dt, out nr);
                    dgvPersonalEmpleado.DataSource = dt;
                    break;
                case 3:
                    pg.buscarSueldoGerente(txtBuscar.Text, out dt, out nr);
                    dgvPersonalEmpleado.DataSource = dt;
                    break;
                case 4:
                    pg.buscarTurnoGerente(txtBuscar.Text, out dt, out nr);
                    dgvPersonalEmpleado.DataSource = dt;
                    break;
            }
            lblNumRegistros.Text = Convert.ToString(nr);
        }

        private void dgvPersonalGerente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvPersonalEmpleado.Rows[e.RowIndex].IsNewRow)
            {
                dgvPersonalEmpleado.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
