using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            

            // Validaciones para Pacientes:
            txtRutPaciente.Validating += txtRutPaciente_Validating;
            txtNombrePaciente.Validating += txtNombrePaciente_Validating;
            txtApellidoPaciente.Validating += txtApellidoPaciente_Validating;
            txtDireccionPaciente.Validating += txtDireccionPaciente_Validating;
            txtFechaNacPaciente.Validating += txtFechaNacPaciente_Validating;
            txtFonoPaciente.Validating += txtFonoPaciente_Validating;

            // Validaciones para Especialidades:
            txtIdEspecialidad.Validating += txtIdEspecialidad_Validating;
            txtNombreEspecialidad.Validating += txtNombreEspecialidad_Validating;
            txtDescripcionEspecialidad.Validating += txtDescripcionEspecialidad_Validating;
            txtCategoriaEspecialidad.Validating += txtCategoriaEspecialidad_Validating;

            // Validaciones para Doctores:
            txtRutDoctor.Validating += txtRutDoctor_Validating;
            txtNombreDoctor.Validating += txtNombreDoctor_Validating;
            txtApellidoDoctor.Validating += txtApellidoDoctor_Validating;
            txtDireccionDoctor.Validating += txtDireccionDoctor_Validating;
            txtFechaNacDoctor.Validating += txtFechaNacDoctor_Validating;
            txtFonoDoctor.Validating += txtFonoDoctor_Validating;
            txtCorreoDoctor.Validating += txtCorreoDoctor_Validating;
            txtPacienteAsignadoDoctor.Validating += txtPacienteAsignadoDoctor_Validating;
            txtEspecialidadDoctor.Validating += txtEspecialidadDoctor_Validating;
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSetDoctores.doctores' Puede moverla o quitarla según sea necesario.
            this.doctoresTableAdapter.Fill(this.hospitalDataSetDoctores.doctores);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSetEspecialidades.especialidades' Puede moverla o quitarla según sea necesario.
            this.especialidadesTableAdapter.Fill(this.hospitalDataSetEspecialidades.especialidades);
            // TODO: esta línea de código carga datos en la tabla 'hospitalDataSetPacientes.pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter1.Fill(this.hospitalDataSetPacientes.pacientes);
            // TODO: esta línea de código carga datos en la tabla 'benjaDataSet.pacientes' Puede moverla o quitarla según sea necesario.
            //this.pacientesTableAdapter.Fill(this.benjaDataSet.pacientes);

        }

        // Método para agregar pacientes:
        private void btnAgregarPacientes_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtRutPaciente.Text) || string.IsNullOrWhiteSpace(txtNombrePaciente.Text) || String.IsNullOrWhiteSpace(txtApellidoPaciente.Text) || String.IsNullOrWhiteSpace(txtDireccionPaciente.Text) || String.IsNullOrWhiteSpace(txtFechaNacPaciente.Text) || String.IsNullOrWhiteSpace(txtFonoPaciente.Text))
            {
                MessageBox.Show("Ingrese campos válidos!!");
                return;
            }
            try
            {
                DateTime fechaNacPaciente;
                if (!DateTime.TryParse(txtFechaNacPaciente.Text, out fechaNacPaciente))
                {
                    MessageBox.Show("Ingrese una fecha válida!! (Formato: AAAA-MM-DD)");
                    return;
                }
                this.pacientesTableAdapter1.Insert(txtRutPaciente.Text, txtNombrePaciente.Text, txtApellidoPaciente.Text, txtDireccionPaciente.Text, fechaNacPaciente, txtFonoPaciente.Text);
                this.pacientesTableAdapter1.Fill(this.hospitalDataSetPacientes.pacientes);

                LimpiarCampos();
                MessageBox.Show("Datos ingresados con éxito!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INSERTAR LOS DATOS!!! " + ex.Message);
            }
        }
        private void LimpiarCampos()
        {
            txtRutPaciente.Clear();
            txtNombrePaciente.Clear();
            txtApellidoPaciente.Clear();
            txtDireccionPaciente.Clear();
            txtFechaNacPaciente.Clear();
            txtFonoPaciente.Clear();
        }

        // Método para actualizar pacientes:
        private void btnActualizarPacientes_Click(object sender, EventArgs e)
        {
            /*try
            {
                this.pacientesTableAdapter1.Update(this.hospitalDataSetPacientes.pacientes);
                this.pacientesTableAdapter1.Fill(this.hospitalDataSetPacientes.pacientes);
                MessageBox.Show("Cambios guardados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar cambios: " + ex.Message);
            }*/
        }

        // Método para eliminar pacientes:
        private void btnEliminarPacientes_Click(object sender, EventArgs e)
        {
            /*if (dataGridView3.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView3.SelectedRows[0];
                try
                {
                    int rowIndex = selectedRow.Index;
                    dataGridView3.Rows.RemoveAt(rowIndex);

                    this.pacientesTableAdapter1.Update(this.hospitalDataSetPacientes.pacientes);
                    this.pacientesTableAdapter1.Fill(this.hospitalDataSetPacientes.pacientes);

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
            }*/
        }

        private void btnActualizarPacientes2_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacientesTableAdapter1.Update(this.hospitalDataSetPacientes.pacientes);
                this.pacientesTableAdapter1.Fill(this.hospitalDataSetPacientes.pacientes);
                MessageBox.Show("Cambios guardados correctamente!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL GUARDAR LOS CAMBIOS!! " + ex.Message);
            }
        }

        private void btnEliminarPacientes2_Click(object sender, EventArgs e)
        {
            if (tabla_registros.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tabla_registros.SelectedRows[0];
                try
                {
                    int rowIndex = selectedRow.Index;
                    tabla_registros.Rows.RemoveAt(rowIndex);

                    this.pacientesTableAdapter1.Update(this.hospitalDataSetPacientes.pacientes);
                    this.pacientesTableAdapter1.Fill(this.hospitalDataSetPacientes.pacientes);

                    MessageBox.Show("Registro eliminado correctamente!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL ELIMINAR!!! " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR LA FILA PARA ELIMINAR!!");
            }
        }

        private void btnMostrarPacientes_Click(object sender, EventArgs e)
        {

        }

        private void textbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void textBox_Validated(object sender, EventArgs e)
        {

        }

        private void txtRutPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRutPaciente_Validating(object sender, CancelEventArgs e)
        {
            /*if (string.IsNullOrEmpty(txtRutPaciente.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                string pattern = @"^[a-zA-Z\s]*$"; // Solo permite letras y espacios
                if (Regex.IsMatch(txtRutPaciente.Text, pattern))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo texto (letras y espacios) en este campo.");
                }
            }*/

        }

        private void txtNombrePaciente_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombrePaciente.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                string pattern = @"^[a-zA-Z\s]*$"; // Solo permite letras y espacios
                if (Regex.IsMatch(txtNombrePaciente.Text, pattern))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo texto (letras y espacios) en este campo.");
                }
            }

        }

        private void txtApellidoPaciente_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellidoPaciente.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                string pattern = @"^[a-zA-Z\s]*$"; // Solo permite letras y espacios
                if (Regex.IsMatch(txtApellidoPaciente.Text, pattern))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo texto (letras y espacios) en este campo.");
                }
            }

        }

        private void txtDireccionPaciente_Validating(object sender, CancelEventArgs e)
        {
            /*if (string.IsNullOrEmpty(txtDireccionPaciente.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                string pattern = @"^[a-zA-Z\s]*$"; // Solo permite letras y espacios
                if (Regex.IsMatch(txtDireccionPaciente.Text, pattern))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo texto (letras y espacios) en este campo.");
                }
            }*/

        }

        private void txtFechaNacPaciente_Validating(object sender, CancelEventArgs e)
        {
            /*if (string.IsNullOrEmpty(txtFechaNacPaciente.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                string pattern = @"^[a-zA-Z\s]*$"; // Solo permite letras y espacios
                if (Regex.IsMatch(txtFechaNacPaciente.Text, pattern))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo texto (letras y espacios) en este campo.");
                }
            }*/

        }

        private void txtFonoPaciente_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFonoPaciente.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                decimal number;
                if (decimal.TryParse(txtFonoPaciente.Text, out number))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo números en este campo.");
                }
            }
        }

        private void txtIdEspecialidad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdEspecialidad.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                decimal number;
                if (decimal.TryParse(txtIdEspecialidad.Text, out number))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo números en este campo.");
                }
            }
        }

        private void txtNombreEspecialidad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreEspecialidad.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                string pattern = @"^[a-zA-Z\s]*$"; // Solo permite letras y espacios
                if (Regex.IsMatch(txtNombreEspecialidad.Text, pattern))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo texto (letras y espacios) en este campo.");
                }
            }

        }

        private void txtDescripcionEspecialidad_Validating(object sender, CancelEventArgs e)
        {
            

        }

        private void txtCategoriaEspecialidad_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoriaEspecialidad.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                string pattern = @"^[a-zA-Z\s]*$"; // Solo permite letras y espacios
                if (Regex.IsMatch(txtCategoriaEspecialidad.Text, pattern))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo texto (letras y espacios) en este campo.");
                }
            }

        }
        private void txtRutDoctor_Validating(object sender, CancelEventArgs e)
        {
            /*if (string.IsNullOrEmpty(txtRutDoctor.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                decimal number;
                if (decimal.TryParse(txtRutDoctor.Text, out number))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo números en este campo.");
                }
            }*/
        }

        private void txtNombreDoctor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreDoctor.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                string pattern = @"^[a-zA-Z\s]*$"; // Solo permite letras y espacios
                if (Regex.IsMatch(txtNombreDoctor.Text, pattern))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo texto (letras y espacios) en este campo.");
                }
            }

        }

        private void txtApellidoDoctor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellidoDoctor.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                string pattern = @"^[a-zA-Z\s]*$"; // Solo permite letras y espacios
                if (Regex.IsMatch(txtApellidoDoctor.Text, pattern))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo texto (letras y espacios) en este campo.");
                }
            }

        }

        private void txtDireccionDoctor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDireccionDoctor.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                string pattern = @"^[a-zA-Z\s]*$"; // Solo permite letras y espacios
                if (Regex.IsMatch(txtDireccionDoctor.Text, pattern))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo texto (letras y espacios) en este campo.");
                }
            }

        }

        private void txtFechaNacDoctor_Validating(object sender, CancelEventArgs e)
        {
            /*if (string.IsNullOrEmpty(txtFechaNacDoctor.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                string pattern = @"^[a-zA-Z\s]*$"; // Solo permite letras y espacios
                if (Regex.IsMatch(txtFechaNacDoctor.Text, pattern))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo texto (letras y espacios) en este campo.");
                }
            }*/

        }

        private void txtFonoDoctor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFonoDoctor.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                decimal number;
                if (decimal.TryParse(txtFonoDoctor.Text, out number))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo números en este campo.");
                }
            }
        }

        private void txtCorreoDoctor_Validating(object sender, CancelEventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(txtCorreoDoctor.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                string pattern = @"^[a-zA-Z\s]*$"; // Solo permite letras y espacios
                if (Regex.IsMatch(txtCorreoDoctor.Text, pattern))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo texto (letras y espacios) en este campo.");
                }
            }*/

        }

        private void txtPacienteAsignadoDoctor_Validating(object sender, CancelEventArgs e)
        {
            /*if (string.IsNullOrEmpty(txtCorreoDoctor.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                string pattern = @"^[a-zA-Z\s]*$"; // Solo permite letras y espacios
                if (Regex.IsMatch(txtCorreoDoctor.Text, pattern))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo texto (letras y espacios) en este campo.");
                }
            }*/

        }

        private void txtEspecialidadDoctor_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEspecialidadDoctor.Text))
            {
                e.Cancel = true;
                MessageBox.Show("Por favor, no deje este campo vacío.");
            }
            else
            {
                decimal number;
                if (decimal.TryParse(txtEspecialidadDoctor.Text, out number))
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                    MessageBox.Show("Por favor, ingrese solo números en este campo.");
                }
            }
        }
        private void btnAgregarEspecialidades_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcionEspecialidad_TextChanged(object sender, EventArgs e)
        {

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

        private void btnActualizarEspecialidad_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.especialidadesTableAdapter.Update(this.hospitalDataSetEspecialidades.especialidades);
                this.especialidadesTableAdapter.Fill(this.hospitalDataSetEspecialidades.especialidades);
                MessageBox.Show("Cambios guardados correctamente!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL GUARDAR LOS CAMBIOS!! " + ex.Message);
            }

        }

        private void LimpiarCamposEspecialidad()
        {
            txtIdEspecialidad.Clear();
            txtNombreEspecialidad.Clear();
            txtDescripcionEspecialidad.Clear();
            txtCategoriaEspecialidad.Clear();
        }

        private void LimpiarCamposDoctores()
        {
            txtRutDoctor.Clear();
            txtNombreDoctor.Clear();
            txtApellidoDoctor.Clear();
            txtDireccionDoctor.Clear();
            txtFechaNacDoctor.Clear();
            txtCorreoDoctor.Clear();
            txtFonoDoctor.Clear();
            txtPacienteAsignadoDoctor.Clear();
            txtEspecialidadDoctor.Clear();

        }

        private void btnAgregarEspecialidades_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtIdEspecialidad.Text) || string.IsNullOrWhiteSpace(txtNombreEspecialidad.Text) || String.IsNullOrWhiteSpace(txtDescripcionEspecialidad.Text) || String.IsNullOrWhiteSpace(txtCategoriaEspecialidad.Text))
            {
                MessageBox.Show("Ingrese campos válidos!!");
                return;
            }
            try
            {
                this.especialidadesTableAdapter.Insert(Convert.ToInt32(txtIdEspecialidad.Text), txtNombreEspecialidad.Text, txtDescripcionEspecialidad.Text, txtCategoriaEspecialidad.Text);
                this.especialidadesTableAdapter.Fill(this.hospitalDataSetEspecialidades.especialidades);

                LimpiarCamposEspecialidad();
                MessageBox.Show("Datos ingresados con éxito!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INSERTAR LOS DATOS!!! " + ex.Message);
            }
            
        }

        private void btnEliminarEspecialidades2_Click(object sender, EventArgs e)
        {
            if (tabla_especialidades.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tabla_especialidades.SelectedRows[0];
                try
                {
                    int rowIndex = selectedRow.Index;
                    tabla_especialidades.Rows.RemoveAt(rowIndex);

                    this.especialidadesTableAdapter.Update(this.hospitalDataSetEspecialidades.especialidades);
                    this.especialidadesTableAdapter.Fill(this.hospitalDataSetEspecialidades.especialidades); ;

                    MessageBox.Show("Registro eliminado correctamente!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL ELIMINAR!!! " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR LA FILA PARA ELIMINAR!!");
            }
        }

        private void btnMostrarEspecialidades_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarDoctores_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtRutDoctor.Text) || string.IsNullOrWhiteSpace(txtNombreDoctor.Text) || String.IsNullOrWhiteSpace(txtApellidoDoctor.Text) || String.IsNullOrWhiteSpace(txtDireccionDoctor.Text) || String.IsNullOrWhiteSpace(txtFechaNacDoctor.Text) || String.IsNullOrWhiteSpace(txtFonoDoctor.Text) || String.IsNullOrWhiteSpace(txtCorreoDoctor.Text) || String.IsNullOrWhiteSpace(txtPacienteAsignadoDoctor.Text) || String.IsNullOrWhiteSpace(txtEspecialidadDoctor.Text))
            {
                MessageBox.Show("Ingrese campos válidos!!");
                return;
            }
            try
            {
                this.doctoresTableAdapter.Insert(txtRutDoctor.Text, txtNombreDoctor.Text, txtApellidoDoctor.Text, txtDireccionDoctor.Text, Convert.ToDateTime(txtFechaNacDoctor.Text), txtFonoDoctor.Text, txtCorreoDoctor.Text, txtPacienteAsignadoDoctor.Text, Convert.ToInt32(txtEspecialidadDoctor.Text));
                this.doctoresTableAdapter.Fill(this.hospitalDataSetDoctores.doctores);

                LimpiarCamposDoctores();
                MessageBox.Show("Datos ingresados con éxito!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL INSERTAR LOS DATOS!!! " + ex.Message);
            }
        }

        private void btnActualizarDoctores2_Click(object sender, EventArgs e)
        {
            try
            {
                this.doctoresTableAdapter.Update(this.hospitalDataSetDoctores.doctores);
                this.doctoresTableAdapter.Fill(this.hospitalDataSetDoctores.doctores);
                MessageBox.Show("Cambios guardados correctamente!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL GUARDAR LOS CAMBIOS!! " + ex.Message);
            }
        }

        private void btnEliminarDoctores2_Click(object sender, EventArgs e)
        {
            if (tabla_doctores.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = tabla_doctores.SelectedRows[0];
                try
                {
                    int rowIndex = selectedRow.Index;
                    tabla_doctores.Rows.RemoveAt(rowIndex);

                    this.especialidadesTableAdapter.Update(this.hospitalDataSetEspecialidades.especialidades);
                    this.especialidadesTableAdapter.Fill(this.hospitalDataSetEspecialidades.especialidades); ;

                    MessageBox.Show("Registro eliminado correctamente!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR AL ELIMINAR!!! " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("DEBE SELECCIONAR LA FILA PARA ELIMINAR!!");
            }
        }

        private void btnMostrarDoctores_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Login login = new Login();
            login.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFechaHora.Text = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
          
            
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void txtCategoriaEspecialidad_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtEspecialidadDoctor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRutPaciente_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss - dd/MM/yyyy");
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void txtNombrePaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccionPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreoDoctor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}