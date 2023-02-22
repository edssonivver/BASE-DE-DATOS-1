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
    public partial class VGVIProducto : Form
    {
        ProductoBD prod = new ProductoBD();

        public VGVIProducto()
        {
            InitializeComponent();
        }

        private void VGVIProducto_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            prod.listarInventario(out dt, out nr);
            dgvProducto.DataSource = dt;
            if (nr > 0)
                dgvProducto.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            prod.eliminarProducto(Convert.ToString(dgvProducto.Rows[dgvProducto.CurrentRow.Index].Cells[0].Value));
            dgvProducto.Rows.RemoveAt(dgvProducto.CurrentRow.Index);
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            prod.adicionarProducto(Convert.ToString(txtId_Producto.Text),

                Convert.ToString(txtNombre.Text),

                Convert.ToDecimal(txtPrecio.Text),

                Convert.ToString(txtTipo_Moenda.Text),

                Convert.ToString(txtMarca.Text),

                Convert.ToString(txtStock.Text),

                Convert.ToString(txtUbicacion_del_Producto.Text));

            prod.listarInventario(out dt, out nr);
            dgvProducto.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataTable dt; int nr = 0;

            prod.modificarProducto(Convert.ToString(txtId_Producto.Text),

                Convert.ToString(txtNombre.Text),

                Convert.ToDecimal(txtPrecio.Text),

                Convert.ToString(txtTipo_Moenda.Text),

                Convert.ToString(txtMarca.Text),

                Convert.ToString(txtStock.Text),

                Convert.ToString(txtUbicacion_del_Producto.Text),

                Convert.ToString(txtNId_Producto.Text));

            prod.listarInventario(out dt, out nr);
            dgvProducto.DataSource = dt;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

            DataTable dt; int nr = 0;
            prod.listarInventario(out dt, out nr);
            dgvProducto.DataSource = dt;
            if (nr > 0)
                dgvProducto.Columns[0].ReadOnly = true;
            lblNumRegistros.Text = Convert.ToString(nr);
        }


        private void btn_volver_Click(object sender, EventArgs e)
        {
            
            VGInventario INVENTARIO = new VGInventario();
            INVENTARIO.Show();
            this.Close();


        }


        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!dgvProducto.Rows[e.RowIndex].IsNewRow)
            {
                dgvProducto.Rows.RemoveAt(e.RowIndex);
            }
        }


        class ProductoBD
        {
            public SqlConnection conexion;
            public SqlDataAdapter adaptador;
            public DataTable dt;

            public ProductoBD()
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

            public void listarInventario(out DataTable dataTable, out int numreg)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("PA_MostrarProductos", conexion);
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

            public void eliminarProducto(string id)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_EliminarProductos";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Producto", SqlDbType.VarChar).Value = id;

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

            public void adicionarProducto(string id, string nom, decimal pre, string tp, string m, string st, string u)
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_AdicionarProductos";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Producto", SqlDbType.VarChar).Value = "Prod-" + id;  
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@Precio", SqlDbType.Float).Value = pre;
                cmd.Parameters.Add("@Tipo_Moenda", SqlDbType.VarChar).Value = tp;
                cmd.Parameters.Add("@Marca", SqlDbType.VarChar).Value = m;
                cmd.Parameters.Add("@Stock", SqlDbType.VarChar).Value = st;
                cmd.Parameters.Add("@Ubicacion_del_Producto", SqlDbType.VarChar).Value = u;

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

            public void modificarProducto(string id, string nom, decimal pre, string tp, string m, string st, string u, string idN)   // cambiar por string el id
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "PA_ModificarProductos";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conexion;
                conexion.Open();
                cmd.Parameters.Add("@Id_Producto", SqlDbType.VarChar).Value = id;  // Int y modificar bda sino quitar el +1 y ver que pasa
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar).Value = nom;
                cmd.Parameters.Add("@Precio", SqlDbType.Float).Value = pre;
                cmd.Parameters.Add("@Tipo_Moenda", SqlDbType.VarChar).Value = tp;
                cmd.Parameters.Add("@Marca", SqlDbType.VarChar).Value = m;
                cmd.Parameters.Add("@Stock", SqlDbType.VarChar).Value = st;
                cmd.Parameters.Add("@Ubicacion_del_Producto", SqlDbType.VarChar).Value = u;
                cmd.Parameters.Add("@Id_ProductoNew", SqlDbType.VarChar).Value = idN;

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
