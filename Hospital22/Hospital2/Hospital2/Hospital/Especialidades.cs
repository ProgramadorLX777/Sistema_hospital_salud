using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
        }

        private void txtCategoriaEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcionEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Especialidades_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'benjaDataSet.especialidades' Puede moverla o quitarla según sea necesario.
            this.especialidadesTableAdapter.Fill(this.benjaDataSet.especialidades);

        }

        private void btnAgregarEspecialidades_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIdEspecialidad.Text) || string.IsNullOrWhiteSpace(txtNombreEspecialidad.Text) || String.IsNullOrWhiteSpace(txtDescripcionEspecialidad.Text) || String.IsNullOrWhiteSpace(txtCategoriaEspecialidad.Text)) ;
            {
                MessageBox.Show("Ingrese campos validos");
                return;
            }
            try
            {
                this.especialidadesTableAdapter.Insert(Convert.ToInt32(txtIdEspecialidad.Text), txtNombreEspecialidad.Text, txtDescripcionEspecialidad.Text,txtCategoriaEspecialidad.Text);
                this.especialidadesTableAdapter.Fill(this.benjaDataSet.especialidades);

                LimpiarCampos();
                MessageBox.Show("Datos ingresados");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos: " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtIdEspecialidad.Clear();
            txtNombreEspecialidad.Clear();
            txtDescripcionEspecialidad.Clear();
            txtCategoriaEspecialidad.Clear();
        }

        private void btnActualizarEspecialidad_Click(object sender, EventArgs e)
        {
            try
            {
                this.especialidadesTableAdapter.Update(this.benjaDataSet.especialidades);
                MessageBox.Show("Cambios guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message);
            }
        }

        private void btnEliminarEspecialidad_Click(object sender, EventArgs e)
        {

        }
    }
}
