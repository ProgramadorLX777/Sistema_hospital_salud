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
    public partial class Doctores : Form
    {
        public Doctores()
        {
            InitializeComponent();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarDoctores_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtRutDoctor.Text) || string.IsNullOrWhiteSpace(txtNombreDoctor.Text) || String.IsNullOrWhiteSpace(txtApellidoDoctor.Text) || String.IsNullOrWhiteSpace(txtDireccionDoctor.Text) || String.IsNullOrWhiteSpace(txtFechaNacDoctor.Text) || String.IsNullOrWhiteSpace(txtFonoDoctor.Text) || String.IsNullOrWhiteSpace(txtCorreoDoctor.Text) || String.IsNullOrWhiteSpace(txtPacienteAsignadoDoctor.Text) || String.IsNullOrWhiteSpace(txtEspecialidadDoctor.Text)) ;
            {
                MessageBox.Show("Ingrese campos validos");
                return;
            }
            try
            {
                DateTime fechaNacDoctor;
                if (!DateTime.TryParse(txtFechaNacDoctor.Text, out fechaNacDoctor))
                {
                    MessageBox.Show("Ingrese una fecha válida (Formato: AAAA-MM-DD)");
                    return;
                }
                this.doctoresTableAdapter.Insert(txtRutDoctor.Text, txtNombreDoctor.Text, txtApellidoDoctor.Text, txtDireccionDoctor.Text, fechaNacDoctor, txtFonoDoctor.Text, txtCorreoDoctor.Text, txtPacienteAsignadoDoctor.Text, Convert.ToInt32(txtEspecialidadDoctor.Text));
                this.doctoresTableAdapter.Fill(this.benjaDataSet.doctores);

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
            txtRutDoctor.Clear();
            txtNombreDoctor.Clear();
            txtApellidoDoctor.Clear();
            txtDireccionDoctor.Clear();
            txtFechaNacDoctor.Clear();
            txtFonoDoctor.Clear();
            txtCorreoDoctor.Clear();
            txtPacienteAsignadoDoctor.Clear();
            txtEspecialidadDoctor.Clear();
        }

        private void btnActualizarDoctores_Click(object sender, EventArgs e)
        {
            try
            {
                this.doctoresTableAdapter.Update(this.benjaDataSet.doctores);
                MessageBox.Show("Cambios guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message);
            }
        }

        private void btnEliminarDoctores_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                try
                {
                    int rowIndex = selectedRow.Index;
                    dataGridView1.Rows.RemoveAt(rowIndex);

                    this.doctoresTableAdapter.Update(this.benjaDataSet.doctores);
                    this.doctoresTableAdapter.Fill(this.benjaDataSet.doctores);

                    MessageBox.Show("Registro eliminado correctamente");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione fila a eliminar");
            }
        }

        private void Doctores_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'benjaDataSet.doctores' Puede moverla o quitarla según sea necesario.
            this.doctoresTableAdapter.Fill(this.benjaDataSet.doctores);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtActualizarFonoDoctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtActualizarCorreoDoctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void txtActualizarEspecialidadDoctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtActualizarPacienteAsignadoDoctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPacienteAsignadoDoctor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
