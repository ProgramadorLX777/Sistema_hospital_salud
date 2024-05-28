using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Registrarse : Form
    {
        private string connectionString;
        public Registrarse()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string usuario = txtRegistrarUsuario.Text;
            string contraseña = txtRegistrarClave.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor ingrese un usuario y contraseña válidos.");
                return;
            }

            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["Hospital.Properties.Settings.ConnectionString"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(cnn))
                {
                    string query = "INSERT INTO Usuarios (nombreUsuario, contraseña) VALUES (@nombreUsuario, @contraseña)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombreUsuario", usuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    connection.Open();
                    command.ExecuteNonQuery();

                    MessageBox.Show("Usuario registrado correctamente. Puede iniciar sesión ahora.");
                    this.Close(); // Cierra el formulario de registro después de registrar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
        }
    }
}
