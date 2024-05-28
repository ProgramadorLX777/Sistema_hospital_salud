namespace Hospital
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benjaDataSet = new Hospital.benjaDataSet();
            this.pacientesTableAdapter = new Hospital.benjaDataSetTableAdapters.pacientesTableAdapter();
            this.hospitalDataSetPacientes = new Hospital.hospitalDataSetPacientes();
            this.pacientesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter1 = new Hospital.hospitalDataSetPacientesTableAdapters.pacientesTableAdapter();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblHora = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminarPacientes2 = new System.Windows.Forms.Button();
            this.btnActualizarPacientes2 = new System.Windows.Forms.Button();
            this.tabla_registros = new System.Windows.Forms.DataGridView();
            this.rutpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrepacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidopacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionpacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fonopacienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarPacientes = new System.Windows.Forms.Button();
            this.txtFonoPaciente = new System.Windows.Forms.TextBox();
            this.txtFechaNacPaciente = new System.Windows.Forms.TextBox();
            this.txtApellidoPaciente = new System.Windows.Forms.TextBox();
            this.txtDireccionPaciente = new System.Windows.Forms.TextBox();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.txtRutPaciente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnEliminarEspecialidades2 = new System.Windows.Forms.Button();
            this.btnActualizarEspecialidades2 = new System.Windows.Forms.Button();
            this.tabla_especialidades = new System.Windows.Forms.DataGridView();
            this.idespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSetEspecialidades = new Hospital.hospitalDataSetEspecialidades();
            this.btnAgregarEspecialidades = new System.Windows.Forms.Button();
            this.txtDescripcionEspecialidad = new System.Windows.Forms.TextBox();
            this.txtCategoriaEspecialidad = new System.Windows.Forms.TextBox();
            this.txtNombreEspecialidad = new System.Windows.Forms.TextBox();
            this.txtIdEspecialidad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblFechaHora = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnEliminarDoctores2 = new System.Windows.Forms.Button();
            this.btnActualizarDoctores2 = new System.Windows.Forms.Button();
            this.txtEspecialidadDoctor = new System.Windows.Forms.TextBox();
            this.txtPacienteAsignadoDoctor = new System.Windows.Forms.TextBox();
            this.txtCorreoDoctor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabla_doctores = new System.Windows.Forms.DataGridView();
            this.rutdoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombredoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidodoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcciondoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanacimientoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fonodoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correodoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pacienteasignadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidaddoctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hospitalDataSetDoctores = new Hospital.hospitalDataSetDoctores();
            this.btnAgregarDoctores = new System.Windows.Forms.Button();
            this.txtFonoDoctor = new System.Windows.Forms.TextBox();
            this.txtFechaNacDoctor = new System.Windows.Forms.TextBox();
            this.txtApellidoDoctor = new System.Windows.Forms.TextBox();
            this.txtDireccionDoctor = new System.Windows.Forms.TextBox();
            this.txtNombreDoctor = new System.Windows.Forms.TextBox();
            this.txtRutDoctor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.especialidadesTableAdapter = new Hospital.hospitalDataSetEspecialidadesTableAdapters.especialidadesTableAdapter();
            this.doctoresTableAdapter = new Hospital.hospitalDataSetDoctoresTableAdapters.doctoresTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pacientesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benjaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource1)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_registros)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_especialidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetEspecialidades)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_doctores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetDoctores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "pacientes";
            this.pacientesBindingSource.DataSource = this.benjaDataSet;
            // 
            // benjaDataSet
            // 
            this.benjaDataSet.DataSetName = "benjaDataSet";
            this.benjaDataSet.Namespace = "http://tempuri.org/benjaDataSet3.xsd";
            this.benjaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // hospitalDataSetPacientes
            // 
            this.hospitalDataSetPacientes.DataSetName = "hospitalDataSetPacientes";
            this.hospitalDataSetPacientes.Namespace = "http://tempuri.org/hospitalDataSetPacientes.xsd";
            this.hospitalDataSetPacientes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesBindingSource1
            // 
            this.pacientesBindingSource1.DataMember = "pacientes";
            this.pacientesBindingSource1.DataSource = this.hospitalDataSetPacientes;
            // 
            // pacientesTableAdapter1
            // 
            this.pacientesTableAdapter1.ClearBeforeFill = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tabPage1.Controls.Add(this.lblHora);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btnEliminarPacientes2);
            this.tabPage1.Controls.Add(this.btnActualizarPacientes2);
            this.tabPage1.Controls.Add(this.tabla_registros);
            this.tabPage1.Controls.Add(this.btnAgregarPacientes);
            this.tabPage1.Controls.Add(this.txtFonoPaciente);
            this.tabPage1.Controls.Add(this.txtFechaNacPaciente);
            this.tabPage1.Controls.Add(this.txtApellidoPaciente);
            this.tabPage1.Controls.Add(this.txtDireccionPaciente);
            this.tabPage1.Controls.Add(this.txtNombrePaciente);
            this.tabPage1.Controls.Add(this.txtRutPaciente);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1159, 522);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pacientes";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(51, 23);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(66, 23);
            this.lblHora.TabIndex = 21;
            this.lblHora.Text = "label23";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1035, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Cerrar Sesión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnEliminarPacientes2
            // 
            this.btnEliminarPacientes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPacientes2.Location = new System.Drawing.Point(935, 441);
            this.btnEliminarPacientes2.Name = "btnEliminarPacientes2";
            this.btnEliminarPacientes2.Size = new System.Drawing.Size(165, 34);
            this.btnEliminarPacientes2.TabIndex = 17;
            this.btnEliminarPacientes2.Text = "Eliminar";
            this.btnEliminarPacientes2.UseVisualStyleBackColor = true;
            this.btnEliminarPacientes2.Click += new System.EventHandler(this.btnEliminarPacientes2_Click);
            // 
            // btnActualizarPacientes2
            // 
            this.btnActualizarPacientes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarPacientes2.Location = new System.Drawing.Point(935, 360);
            this.btnActualizarPacientes2.Name = "btnActualizarPacientes2";
            this.btnActualizarPacientes2.Size = new System.Drawing.Size(165, 34);
            this.btnActualizarPacientes2.TabIndex = 16;
            this.btnActualizarPacientes2.Text = "Modificar ";
            this.btnActualizarPacientes2.UseVisualStyleBackColor = true;
            this.btnActualizarPacientes2.Click += new System.EventHandler(this.btnActualizarPacientes2_Click);
            // 
            // tabla_registros
            // 
            this.tabla_registros.AutoGenerateColumns = false;
            this.tabla_registros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_registros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutpacienteDataGridViewTextBoxColumn,
            this.nombrepacienteDataGridViewTextBoxColumn,
            this.apellidopacienteDataGridViewTextBoxColumn,
            this.direccionpacienteDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn,
            this.fonopacienteDataGridViewTextBoxColumn});
            this.tabla_registros.DataSource = this.pacientesBindingSource1;
            this.tabla_registros.Location = new System.Drawing.Point(51, 267);
            this.tabla_registros.Name = "tabla_registros";
            this.tabla_registros.Size = new System.Drawing.Size(815, 224);
            this.tabla_registros.TabIndex = 15;
            // 
            // rutpacienteDataGridViewTextBoxColumn
            // 
            this.rutpacienteDataGridViewTextBoxColumn.DataPropertyName = "rut_paciente";
            this.rutpacienteDataGridViewTextBoxColumn.HeaderText = "rut_paciente";
            this.rutpacienteDataGridViewTextBoxColumn.Name = "rutpacienteDataGridViewTextBoxColumn";
            // 
            // nombrepacienteDataGridViewTextBoxColumn
            // 
            this.nombrepacienteDataGridViewTextBoxColumn.DataPropertyName = "nombre_paciente";
            this.nombrepacienteDataGridViewTextBoxColumn.HeaderText = "nombre_paciente";
            this.nombrepacienteDataGridViewTextBoxColumn.Name = "nombrepacienteDataGridViewTextBoxColumn";
            // 
            // apellidopacienteDataGridViewTextBoxColumn
            // 
            this.apellidopacienteDataGridViewTextBoxColumn.DataPropertyName = "apellido_paciente";
            this.apellidopacienteDataGridViewTextBoxColumn.HeaderText = "apellido_paciente";
            this.apellidopacienteDataGridViewTextBoxColumn.Name = "apellidopacienteDataGridViewTextBoxColumn";
            // 
            // direccionpacienteDataGridViewTextBoxColumn
            // 
            this.direccionpacienteDataGridViewTextBoxColumn.DataPropertyName = "direccion_paciente";
            this.direccionpacienteDataGridViewTextBoxColumn.HeaderText = "direccion_paciente";
            this.direccionpacienteDataGridViewTextBoxColumn.Name = "direccionpacienteDataGridViewTextBoxColumn";
            // 
            // fechanacimientoDataGridViewTextBoxColumn
            // 
            this.fechanacimientoDataGridViewTextBoxColumn.DataPropertyName = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.HeaderText = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn.Name = "fechanacimientoDataGridViewTextBoxColumn";
            // 
            // fonopacienteDataGridViewTextBoxColumn
            // 
            this.fonopacienteDataGridViewTextBoxColumn.DataPropertyName = "fono_paciente";
            this.fonopacienteDataGridViewTextBoxColumn.HeaderText = "fono_paciente";
            this.fonopacienteDataGridViewTextBoxColumn.Name = "fonopacienteDataGridViewTextBoxColumn";
            // 
            // btnAgregarPacientes
            // 
            this.btnAgregarPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPacientes.Location = new System.Drawing.Point(935, 278);
            this.btnAgregarPacientes.Name = "btnAgregarPacientes";
            this.btnAgregarPacientes.Size = new System.Drawing.Size(165, 34);
            this.btnAgregarPacientes.TabIndex = 13;
            this.btnAgregarPacientes.Text = "Agregar ";
            this.btnAgregarPacientes.UseVisualStyleBackColor = true;
            this.btnAgregarPacientes.Click += new System.EventHandler(this.btnAgregarPacientes_Click);
            // 
            // txtFonoPaciente
            // 
            this.txtFonoPaciente.Location = new System.Drawing.Point(847, 197);
            this.txtFonoPaciente.Name = "txtFonoPaciente";
            this.txtFonoPaciente.Size = new System.Drawing.Size(172, 20);
            this.txtFonoPaciente.TabIndex = 12;
            // 
            // txtFechaNacPaciente
            // 
            this.txtFechaNacPaciente.Location = new System.Drawing.Point(847, 147);
            this.txtFechaNacPaciente.Name = "txtFechaNacPaciente";
            this.txtFechaNacPaciente.Size = new System.Drawing.Size(172, 20);
            this.txtFechaNacPaciente.TabIndex = 11;
            // 
            // txtApellidoPaciente
            // 
            this.txtApellidoPaciente.Location = new System.Drawing.Point(312, 195);
            this.txtApellidoPaciente.Name = "txtApellidoPaciente";
            this.txtApellidoPaciente.Size = new System.Drawing.Size(172, 20);
            this.txtApellidoPaciente.TabIndex = 10;
            // 
            // txtDireccionPaciente
            // 
            this.txtDireccionPaciente.Location = new System.Drawing.Point(847, 101);
            this.txtDireccionPaciente.Name = "txtDireccionPaciente";
            this.txtDireccionPaciente.Size = new System.Drawing.Size(172, 20);
            this.txtDireccionPaciente.TabIndex = 9;
            this.txtDireccionPaciente.TextChanged += new System.EventHandler(this.txtDireccionPaciente_TextChanged);
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(312, 148);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(172, 20);
            this.txtNombrePaciente.TabIndex = 8;
            this.txtNombrePaciente.TextChanged += new System.EventHandler(this.txtNombrePaciente_TextChanged);
            // 
            // txtRutPaciente
            // 
            this.txtRutPaciente.Location = new System.Drawing.Point(312, 101);
            this.txtRutPaciente.Name = "txtRutPaciente";
            this.txtRutPaciente.Size = new System.Drawing.Size(172, 20);
            this.txtRutPaciente.TabIndex = 7;
            this.txtRutPaciente.TextChanged += new System.EventHandler(this.txtRutPaciente_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(630, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 40);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fono Paciente\r\n(978456123):\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(630, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 40);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Nacimiento \r\n(Formato AA-MM-DD):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(630, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dirección Paciente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido Paciente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre Paciente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rut Paciente\r\n(11222333-4):\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(434, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos Pacientes";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1167, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Aquamarine;
            this.tabPage5.Controls.Add(this.lblFecha);
            this.tabPage5.Controls.Add(this.btnCerrarSesion);
            this.tabPage5.Controls.Add(this.btnEliminarEspecialidades2);
            this.tabPage5.Controls.Add(this.btnActualizarEspecialidades2);
            this.tabPage5.Controls.Add(this.tabla_especialidades);
            this.tabPage5.Controls.Add(this.btnAgregarEspecialidades);
            this.tabPage5.Controls.Add(this.txtDescripcionEspecialidad);
            this.tabPage5.Controls.Add(this.txtCategoriaEspecialidad);
            this.tabPage5.Controls.Add(this.txtNombreEspecialidad);
            this.tabPage5.Controls.Add(this.txtIdEspecialidad);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1159, 522);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Especialidades";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(47, 22);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 23);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "label";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Location = new System.Drawing.Point(1025, 22);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(99, 23);
            this.btnCerrarSesion.TabIndex = 19;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnEliminarEspecialidades2
            // 
            this.btnEliminarEspecialidades2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEspecialidades2.Location = new System.Drawing.Point(887, 451);
            this.btnEliminarEspecialidades2.Name = "btnEliminarEspecialidades2";
            this.btnEliminarEspecialidades2.Size = new System.Drawing.Size(216, 34);
            this.btnEliminarEspecialidades2.TabIndex = 17;
            this.btnEliminarEspecialidades2.Text = "Eliminar";
            this.btnEliminarEspecialidades2.UseVisualStyleBackColor = true;
            this.btnEliminarEspecialidades2.Click += new System.EventHandler(this.btnEliminarEspecialidades2_Click);
            // 
            // btnActualizarEspecialidades2
            // 
            this.btnActualizarEspecialidades2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEspecialidades2.Location = new System.Drawing.Point(887, 367);
            this.btnActualizarEspecialidades2.Name = "btnActualizarEspecialidades2";
            this.btnActualizarEspecialidades2.Size = new System.Drawing.Size(216, 34);
            this.btnActualizarEspecialidades2.TabIndex = 16;
            this.btnActualizarEspecialidades2.Text = "Actualizar";
            this.btnActualizarEspecialidades2.UseVisualStyleBackColor = true;
            this.btnActualizarEspecialidades2.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabla_especialidades
            // 
            this.tabla_especialidades.AutoGenerateColumns = false;
            this.tabla_especialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_especialidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idespecialidadDataGridViewTextBoxColumn,
            this.nombreespecialidadDataGridViewTextBoxColumn,
            this.descripcionespecialidadDataGridViewTextBoxColumn,
            this.categoriaespecialidadDataGridViewTextBoxColumn});
            this.tabla_especialidades.DataSource = this.especialidadesBindingSource;
            this.tabla_especialidades.Location = new System.Drawing.Point(37, 267);
            this.tabla_especialidades.Name = "tabla_especialidades";
            this.tabla_especialidades.Size = new System.Drawing.Size(803, 231);
            this.tabla_especialidades.TabIndex = 15;
            // 
            // idespecialidadDataGridViewTextBoxColumn
            // 
            this.idespecialidadDataGridViewTextBoxColumn.DataPropertyName = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn.HeaderText = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn.Name = "idespecialidadDataGridViewTextBoxColumn";
            // 
            // nombreespecialidadDataGridViewTextBoxColumn
            // 
            this.nombreespecialidadDataGridViewTextBoxColumn.DataPropertyName = "nombre_especialidad";
            this.nombreespecialidadDataGridViewTextBoxColumn.HeaderText = "nombre_especialidad";
            this.nombreespecialidadDataGridViewTextBoxColumn.Name = "nombreespecialidadDataGridViewTextBoxColumn";
            // 
            // descripcionespecialidadDataGridViewTextBoxColumn
            // 
            this.descripcionespecialidadDataGridViewTextBoxColumn.DataPropertyName = "descripcion_especialidad";
            this.descripcionespecialidadDataGridViewTextBoxColumn.HeaderText = "descripcion_especialidad";
            this.descripcionespecialidadDataGridViewTextBoxColumn.Name = "descripcionespecialidadDataGridViewTextBoxColumn";
            // 
            // categoriaespecialidadDataGridViewTextBoxColumn
            // 
            this.categoriaespecialidadDataGridViewTextBoxColumn.DataPropertyName = "categoria_especialidad";
            this.categoriaespecialidadDataGridViewTextBoxColumn.HeaderText = "categoria_especialidad";
            this.categoriaespecialidadDataGridViewTextBoxColumn.Name = "categoriaespecialidadDataGridViewTextBoxColumn";
            // 
            // especialidadesBindingSource
            // 
            this.especialidadesBindingSource.DataMember = "especialidades";
            this.especialidadesBindingSource.DataSource = this.hospitalDataSetEspecialidades;
            // 
            // hospitalDataSetEspecialidades
            // 
            this.hospitalDataSetEspecialidades.DataSetName = "hospitalDataSetEspecialidades";
            this.hospitalDataSetEspecialidades.Namespace = "http://tempuri.org/hospitalDataSetEspecialidades.xsd";
            this.hospitalDataSetEspecialidades.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregarEspecialidades
            // 
            this.btnAgregarEspecialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEspecialidades.Location = new System.Drawing.Point(887, 280);
            this.btnAgregarEspecialidades.Name = "btnAgregarEspecialidades";
            this.btnAgregarEspecialidades.Size = new System.Drawing.Size(216, 34);
            this.btnAgregarEspecialidades.TabIndex = 13;
            this.btnAgregarEspecialidades.Text = "Agregar";
            this.btnAgregarEspecialidades.UseVisualStyleBackColor = true;
            this.btnAgregarEspecialidades.Click += new System.EventHandler(this.btnAgregarEspecialidades_Click_1);
            // 
            // txtDescripcionEspecialidad
            // 
            this.txtDescripcionEspecialidad.Location = new System.Drawing.Point(706, 122);
            this.txtDescripcionEspecialidad.Name = "txtDescripcionEspecialidad";
            this.txtDescripcionEspecialidad.Size = new System.Drawing.Size(172, 20);
            this.txtDescripcionEspecialidad.TabIndex = 10;
            // 
            // txtCategoriaEspecialidad
            // 
            this.txtCategoriaEspecialidad.Location = new System.Drawing.Point(706, 172);
            this.txtCategoriaEspecialidad.Name = "txtCategoriaEspecialidad";
            this.txtCategoriaEspecialidad.Size = new System.Drawing.Size(172, 20);
            this.txtCategoriaEspecialidad.TabIndex = 9;
            this.txtCategoriaEspecialidad.TextChanged += new System.EventHandler(this.txtCategoriaEspecialidad_TextChanged_1);
            // 
            // txtNombreEspecialidad
            // 
            this.txtNombreEspecialidad.Location = new System.Drawing.Point(275, 174);
            this.txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            this.txtNombreEspecialidad.Size = new System.Drawing.Size(172, 20);
            this.txtNombreEspecialidad.TabIndex = 8;
            this.txtNombreEspecialidad.TextChanged += new System.EventHandler(this.txtNombreEspecialidad_TextChanged);
            // 
            // txtIdEspecialidad
            // 
            this.txtIdEspecialidad.Location = new System.Drawing.Point(275, 122);
            this.txtIdEspecialidad.Name = "txtIdEspecialidad";
            this.txtIdEspecialidad.Size = new System.Drawing.Size(172, 20);
            this.txtIdEspecialidad.TabIndex = 7;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(585, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 20);
            this.label15.TabIndex = 4;
            this.label15.Text = "Categoría:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(572, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "Descripción:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(170, 176);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 20);
            this.label17.TabIndex = 2;
            this.label17.Text = "Nombre:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(195, 120);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 20);
            this.label18.TabIndex = 1;
            this.label18.Text = "ID :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(399, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(308, 31);
            this.label19.TabIndex = 0;
            this.label19.Text = "Registrar Especialidad";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage2.Controls.Add(this.lblFechaHora);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnEliminarDoctores2);
            this.tabPage2.Controls.Add(this.btnActualizarDoctores2);
            this.tabPage2.Controls.Add(this.txtEspecialidadDoctor);
            this.tabPage2.Controls.Add(this.txtPacienteAsignadoDoctor);
            this.tabPage2.Controls.Add(this.txtCorreoDoctor);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tabla_doctores);
            this.tabPage2.Controls.Add(this.btnAgregarDoctores);
            this.tabPage2.Controls.Add(this.txtFonoDoctor);
            this.tabPage2.Controls.Add(this.txtFechaNacDoctor);
            this.tabPage2.Controls.Add(this.txtApellidoDoctor);
            this.tabPage2.Controls.Add(this.txtDireccionDoctor);
            this.tabPage2.Controls.Add(this.txtNombreDoctor);
            this.tabPage2.Controls.Add(this.txtRutDoctor);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1159, 522);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Doctores";
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.AutoSize = true;
            this.lblFechaHora.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaHora.Location = new System.Drawing.Point(75, 19);
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(66, 23);
            this.lblFechaHora.TabIndex = 26;
            this.lblFechaHora.Text = "label23";
            this.lblFechaHora.Click += new System.EventHandler(this.label23_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1037, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Cerrar Sesión";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEliminarDoctores2
            // 
            this.btnEliminarDoctores2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDoctores2.Location = new System.Drawing.Point(986, 460);
            this.btnEliminarDoctores2.Name = "btnEliminarDoctores2";
            this.btnEliminarDoctores2.Size = new System.Drawing.Size(150, 34);
            this.btnEliminarDoctores2.TabIndex = 23;
            this.btnEliminarDoctores2.Text = "Eliminar";
            this.btnEliminarDoctores2.UseVisualStyleBackColor = true;
            this.btnEliminarDoctores2.Click += new System.EventHandler(this.btnEliminarDoctores2_Click);
            // 
            // btnActualizarDoctores2
            // 
            this.btnActualizarDoctores2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDoctores2.Location = new System.Drawing.Point(987, 383);
            this.btnActualizarDoctores2.Name = "btnActualizarDoctores2";
            this.btnActualizarDoctores2.Size = new System.Drawing.Size(149, 34);
            this.btnActualizarDoctores2.TabIndex = 22;
            this.btnActualizarDoctores2.Text = "Actualizar";
            this.btnActualizarDoctores2.UseVisualStyleBackColor = true;
            this.btnActualizarDoctores2.Click += new System.EventHandler(this.btnActualizarDoctores2_Click);
            // 
            // txtEspecialidadDoctor
            // 
            this.txtEspecialidadDoctor.Location = new System.Drawing.Point(847, 201);
            this.txtEspecialidadDoctor.Name = "txtEspecialidadDoctor";
            this.txtEspecialidadDoctor.Size = new System.Drawing.Size(172, 20);
            this.txtEspecialidadDoctor.TabIndex = 21;
            this.txtEspecialidadDoctor.TextChanged += new System.EventHandler(this.txtEspecialidadDoctor_TextChanged);
            // 
            // txtPacienteAsignadoDoctor
            // 
            this.txtPacienteAsignadoDoctor.Location = new System.Drawing.Point(847, 163);
            this.txtPacienteAsignadoDoctor.Name = "txtPacienteAsignadoDoctor";
            this.txtPacienteAsignadoDoctor.Size = new System.Drawing.Size(172, 20);
            this.txtPacienteAsignadoDoctor.TabIndex = 20;
            // 
            // txtCorreoDoctor
            // 
            this.txtCorreoDoctor.Location = new System.Drawing.Point(847, 128);
            this.txtCorreoDoctor.Name = "txtCorreoDoctor";
            this.txtCorreoDoctor.Size = new System.Drawing.Size(172, 20);
            this.txtCorreoDoctor.TabIndex = 19;
            this.txtCorreoDoctor.TextChanged += new System.EventHandler(this.txtCorreoDoctor_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(637, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(196, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Id Especialidad Doctor:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(663, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Paciente Asignado:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(700, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Correo Doctor:";
            // 
            // tabla_doctores
            // 
            this.tabla_doctores.AutoGenerateColumns = false;
            this.tabla_doctores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_doctores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rutdoctorDataGridViewTextBoxColumn,
            this.nombredoctorDataGridViewTextBoxColumn,
            this.apellidodoctorDataGridViewTextBoxColumn,
            this.direcciondoctorDataGridViewTextBoxColumn,
            this.fechanacimientoDataGridViewTextBoxColumn1,
            this.fonodoctorDataGridViewTextBoxColumn,
            this.correodoctorDataGridViewTextBoxColumn,
            this.pacienteasignadoDataGridViewTextBoxColumn,
            this.especialidaddoctorDataGridViewTextBoxColumn});
            this.tabla_doctores.DataSource = this.doctoresBindingSource;
            this.tabla_doctores.Location = new System.Drawing.Point(21, 297);
            this.tabla_doctores.Name = "tabla_doctores";
            this.tabla_doctores.Size = new System.Drawing.Size(944, 215);
            this.tabla_doctores.TabIndex = 15;
            // 
            // rutdoctorDataGridViewTextBoxColumn
            // 
            this.rutdoctorDataGridViewTextBoxColumn.DataPropertyName = "rut_doctor";
            this.rutdoctorDataGridViewTextBoxColumn.HeaderText = "rut_doctor";
            this.rutdoctorDataGridViewTextBoxColumn.Name = "rutdoctorDataGridViewTextBoxColumn";
            // 
            // nombredoctorDataGridViewTextBoxColumn
            // 
            this.nombredoctorDataGridViewTextBoxColumn.DataPropertyName = "nombre_doctor";
            this.nombredoctorDataGridViewTextBoxColumn.HeaderText = "nombre_doctor";
            this.nombredoctorDataGridViewTextBoxColumn.Name = "nombredoctorDataGridViewTextBoxColumn";
            // 
            // apellidodoctorDataGridViewTextBoxColumn
            // 
            this.apellidodoctorDataGridViewTextBoxColumn.DataPropertyName = "apellido_doctor";
            this.apellidodoctorDataGridViewTextBoxColumn.HeaderText = "apellido_doctor";
            this.apellidodoctorDataGridViewTextBoxColumn.Name = "apellidodoctorDataGridViewTextBoxColumn";
            // 
            // direcciondoctorDataGridViewTextBoxColumn
            // 
            this.direcciondoctorDataGridViewTextBoxColumn.DataPropertyName = "direccion_doctor";
            this.direcciondoctorDataGridViewTextBoxColumn.HeaderText = "direccion_doctor";
            this.direcciondoctorDataGridViewTextBoxColumn.Name = "direcciondoctorDataGridViewTextBoxColumn";
            // 
            // fechanacimientoDataGridViewTextBoxColumn1
            // 
            this.fechanacimientoDataGridViewTextBoxColumn1.DataPropertyName = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn1.HeaderText = "fecha_nacimiento";
            this.fechanacimientoDataGridViewTextBoxColumn1.Name = "fechanacimientoDataGridViewTextBoxColumn1";
            // 
            // fonodoctorDataGridViewTextBoxColumn
            // 
            this.fonodoctorDataGridViewTextBoxColumn.DataPropertyName = "fono_doctor";
            this.fonodoctorDataGridViewTextBoxColumn.HeaderText = "fono_doctor";
            this.fonodoctorDataGridViewTextBoxColumn.Name = "fonodoctorDataGridViewTextBoxColumn";
            // 
            // correodoctorDataGridViewTextBoxColumn
            // 
            this.correodoctorDataGridViewTextBoxColumn.DataPropertyName = "correo_doctor";
            this.correodoctorDataGridViewTextBoxColumn.HeaderText = "correo_doctor";
            this.correodoctorDataGridViewTextBoxColumn.Name = "correodoctorDataGridViewTextBoxColumn";
            // 
            // pacienteasignadoDataGridViewTextBoxColumn
            // 
            this.pacienteasignadoDataGridViewTextBoxColumn.DataPropertyName = "paciente_asignado";
            this.pacienteasignadoDataGridViewTextBoxColumn.HeaderText = "paciente_asignado";
            this.pacienteasignadoDataGridViewTextBoxColumn.Name = "pacienteasignadoDataGridViewTextBoxColumn";
            // 
            // especialidaddoctorDataGridViewTextBoxColumn
            // 
            this.especialidaddoctorDataGridViewTextBoxColumn.DataPropertyName = "especialidad_doctor";
            this.especialidaddoctorDataGridViewTextBoxColumn.HeaderText = "especialidad_doctor";
            this.especialidaddoctorDataGridViewTextBoxColumn.Name = "especialidaddoctorDataGridViewTextBoxColumn";
            // 
            // doctoresBindingSource
            // 
            this.doctoresBindingSource.DataMember = "doctores";
            this.doctoresBindingSource.DataSource = this.hospitalDataSetDoctores;
            // 
            // hospitalDataSetDoctores
            // 
            this.hospitalDataSetDoctores.DataSetName = "hospitalDataSetDoctores";
            this.hospitalDataSetDoctores.Namespace = "http://tempuri.org/hospitalDataSetDoctores.xsd";
            this.hospitalDataSetDoctores.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAgregarDoctores
            // 
            this.btnAgregarDoctores.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarDoctores.Location = new System.Drawing.Point(987, 310);
            this.btnAgregarDoctores.Name = "btnAgregarDoctores";
            this.btnAgregarDoctores.Size = new System.Drawing.Size(149, 34);
            this.btnAgregarDoctores.TabIndex = 13;
            this.btnAgregarDoctores.Text = "Agregar";
            this.btnAgregarDoctores.UseVisualStyleBackColor = true;
            this.btnAgregarDoctores.Click += new System.EventHandler(this.btnAgregarDoctores_Click);
            // 
            // txtFonoDoctor
            // 
            this.txtFonoDoctor.Location = new System.Drawing.Point(847, 94);
            this.txtFonoDoctor.Name = "txtFonoDoctor";
            this.txtFonoDoctor.Size = new System.Drawing.Size(172, 20);
            this.txtFonoDoctor.TabIndex = 12;
            // 
            // txtFechaNacDoctor
            // 
            this.txtFechaNacDoctor.Location = new System.Drawing.Point(379, 249);
            this.txtFechaNacDoctor.Name = "txtFechaNacDoctor";
            this.txtFechaNacDoctor.Size = new System.Drawing.Size(172, 20);
            this.txtFechaNacDoctor.TabIndex = 11;
            // 
            // txtApellidoDoctor
            // 
            this.txtApellidoDoctor.Location = new System.Drawing.Point(379, 165);
            this.txtApellidoDoctor.Name = "txtApellidoDoctor";
            this.txtApellidoDoctor.Size = new System.Drawing.Size(172, 20);
            this.txtApellidoDoctor.TabIndex = 10;
            // 
            // txtDireccionDoctor
            // 
            this.txtDireccionDoctor.Location = new System.Drawing.Point(379, 205);
            this.txtDireccionDoctor.Name = "txtDireccionDoctor";
            this.txtDireccionDoctor.Size = new System.Drawing.Size(172, 20);
            this.txtDireccionDoctor.TabIndex = 9;
            // 
            // txtNombreDoctor
            // 
            this.txtNombreDoctor.Location = new System.Drawing.Point(379, 129);
            this.txtNombreDoctor.Name = "txtNombreDoctor";
            this.txtNombreDoctor.Size = new System.Drawing.Size(172, 20);
            this.txtNombreDoctor.TabIndex = 8;
            // 
            // txtRutDoctor
            // 
            this.txtRutDoctor.Location = new System.Drawing.Point(379, 90);
            this.txtRutDoctor.Name = "txtRutDoctor";
            this.txtRutDoctor.Size = new System.Drawing.Size(172, 20);
            this.txtRutDoctor.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(713, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 40);
            this.label11.TabIndex = 6;
            this.label11.Text = "Fono Doctor\r\n(978654321):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(127, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 40);
            this.label12.TabIndex = 5;
            this.label12.Text = "Fecha Nacimiento\r\n(AA-MM-DD):\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(127, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Dirección Doctor:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(127, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "Apellido Doctor:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(127, 127);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 20);
            this.label20.TabIndex = 2;
            this.label20.Text = "Nombre Doctor:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(127, 77);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(122, 40);
            this.label21.TabIndex = 1;
            this.label21.Text = "Rut Doctor\r\n(11111111-1):\r\n";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(462, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(260, 31);
            this.label22.TabIndex = 0;
            this.label22.Text = "Registrar Doctores";
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // doctoresTableAdapter
            // 
            this.doctoresTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pacientesBindingSource2
            // 
            this.pacientesBindingSource2.DataMember = "pacientes";
            this.pacientesBindingSource2.DataSource = this.hospitalDataSetPacientes;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 550);
            this.Controls.Add(this.tabControl1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benjaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource1)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_registros)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_especialidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetEspecialidades)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_doctores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hospitalDataSetDoctores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private benjaDataSet benjaDataSet;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private benjaDataSetTableAdapters.pacientesTableAdapter pacientesTableAdapter;
        private hospitalDataSetPacientes hospitalDataSetPacientes;
        private System.Windows.Forms.BindingSource pacientesBindingSource1;
        private hospitalDataSetPacientesTableAdapters.pacientesTableAdapter pacientesTableAdapter1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnEliminarPacientes2;
        private System.Windows.Forms.Button btnActualizarPacientes2;
        private System.Windows.Forms.DataGridView tabla_registros;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrepacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidopacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionpacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fonopacienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAgregarPacientes;
        private System.Windows.Forms.TextBox txtFonoPaciente;
        private System.Windows.Forms.TextBox txtFechaNacPaciente;
        private System.Windows.Forms.TextBox txtApellidoPaciente;
        private System.Windows.Forms.TextBox txtDireccionPaciente;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.TextBox txtRutPaciente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnEliminarEspecialidades2;
        private System.Windows.Forms.Button btnActualizarEspecialidades2;
        private System.Windows.Forms.DataGridView tabla_especialidades;
        private System.Windows.Forms.Button btnAgregarEspecialidades;
        private System.Windows.Forms.TextBox txtDescripcionEspecialidad;
        private System.Windows.Forms.TextBox txtCategoriaEspecialidad;
        private System.Windows.Forms.TextBox txtNombreEspecialidad;
        private System.Windows.Forms.TextBox txtIdEspecialidad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtEspecialidadDoctor;
        private System.Windows.Forms.TextBox txtPacienteAsignadoDoctor;
        private System.Windows.Forms.TextBox txtCorreoDoctor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView tabla_doctores;
        private System.Windows.Forms.Button btnAgregarDoctores;
        private System.Windows.Forms.TextBox txtFonoDoctor;
        private System.Windows.Forms.TextBox txtFechaNacDoctor;
        private System.Windows.Forms.TextBox txtApellidoDoctor;
        private System.Windows.Forms.TextBox txtDireccionDoctor;
        private System.Windows.Forms.TextBox txtNombreDoctor;
        private System.Windows.Forms.TextBox txtRutDoctor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button btnEliminarDoctores2;
        private System.Windows.Forms.Button btnActualizarDoctores2;
        private hospitalDataSetEspecialidades hospitalDataSetEspecialidades;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private hospitalDataSetEspecialidadesTableAdapters.especialidadesTableAdapter especialidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreespecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionespecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaespecialidadDataGridViewTextBoxColumn;
        private hospitalDataSetDoctores hospitalDataSetDoctores;
        private System.Windows.Forms.BindingSource doctoresBindingSource;
        private hospitalDataSetDoctoresTableAdapters.doctoresTableAdapter doctoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutdoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombredoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidodoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direcciondoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanacimientoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fonodoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correodoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pacienteasignadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidaddoctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblFechaHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.BindingSource pacientesBindingSource2;
    }
}