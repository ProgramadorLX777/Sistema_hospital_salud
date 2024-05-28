using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LecaroX\\Documents\\hospital.mdf;Integrated Security=True;Connect Timeout=30");

        public bool ValidarAdministrador(string usuario, string contraseña)
        {
            using (var conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LecaroX\\Documents\\hospital.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                conexion.Open();
                var comando = new SqlCommand("SELECT COUNT(1) FROM credenciales WHERE nombreAdmin = @usuario AND passAdmin = @contraseña", conexion);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@contraseña", contraseña);

                int resultado = Convert.ToInt32(comando.ExecuteScalar());
                return resultado == 1;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string pass = txtClave.Text;

            if (ValidarAdministrador(usuario, pass))
            {
                MessageBox.Show("Inicio de sesión exitoso administrador.");
                this.Visible = false;
                MenuPrincipal pacientes = new MenuPrincipal();
                pacientes.Visible = true;
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos!!!.");
                txtUsuario.Text = "";
                txtClave.Text = "";
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
