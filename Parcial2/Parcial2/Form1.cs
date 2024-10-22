using System.Data;
using System.Drawing;

namespace Parcial2
{
    public partial class frmUsuario : Form 
    {
        
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void grbDatosUsuario_Enter(object sender, EventArgs e)
        {internal class Conexion
    {
        public Conexion()
        {
                Conexion objConexion = new Conexion();
                DataSet ds = new DataSet();
                DataTable miTabla = new DataTable();
            }
    }

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Verificar que se haya introducido un nombre de usuario para buscar
            if (txtBuscar.Text == "")
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario para buscar");
                return;
            }

            try
            {
                // Abrir la conexión a la base de datos
                con.Open();

                // Consulta SQL para buscar el usuario por nombre de usuario
                SqlCommand cmd = new SqlCommand("SELECT * FROM usuarios WHERE usuario = @usuario", con);
                cmd.Parameters.AddWithValue("@usuario", txtBuscar.Text);

                // Ejecutar la consulta y leer los resultados
                SqlDataReader reader = cmd.ExecuteReader();

                // Si se encuentra un registro
                if (reader.Read())
                {
                    txtUsuario.Text = reader["usuario"].ToString();
                    txtClave.Text = reader["clave"].ToString();
                    txtNombre.Text = reader["nombre"].ToString();
                    txtDireccion.Text = reader["direccion"].ToString();
                    txtTelefono.Text = reader["telefono"].ToString();
                }
                else
                {
                    MessageBox.Show("Usuario no encontrado");
                }

                // Cerrar el lector y la conexión
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
