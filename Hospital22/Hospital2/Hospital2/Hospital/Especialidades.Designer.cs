namespace Hospital
{
    partial class Especialidades
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaespecialidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.benjaDataSet = new Hospital.benjaDataSet();
            this.btnVolverMenu = new System.Windows.Forms.Button();
            this.btnAgregarEspecialidades = new System.Windows.Forms.Button();
            this.txtDescripcionEspecialidad = new System.Windows.Forms.TextBox();
            this.txtCategoriaEspecialidad = new System.Windows.Forms.TextBox();
            this.txtNombreEspecialidad = new System.Windows.Forms.TextBox();
            this.txtIdEspecialidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtActualizarDescripcionEspecialidad = new System.Windows.Forms.TextBox();
            this.txtActualizarCategoriaEspecialidad = new System.Windows.Forms.TextBox();
            this.txtActualizarNombreEspecialidad = new System.Windows.Forms.TextBox();
            this.txtActualizarIdEspecialidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idespecialidadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreespecialidadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionespecialidadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaespecialidadDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnActualizarEspecialidad = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idespecialidadDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreespecialidadDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionespecialidadDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaespecialidadDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEliminarIdEspecialidad = new System.Windows.Forms.TextBox();
            this.btnEliminarEspecialidad = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnBuscarEspecialidad = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.idespecialidadDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreespecialidadDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionespecialidadDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaespecialidadDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarIdEspecialidad = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.especialidadesTableAdapter = new Hospital.benjaDataSetTableAdapters.especialidadesTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.benjaDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 503);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Aquamarine;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnVolverMenu);
            this.tabPage1.Controls.Add(this.btnAgregarEspecialidades);
            this.tabPage1.Controls.Add(this.txtDescripcionEspecialidad);
            this.tabPage1.Controls.Add(this.txtCategoriaEspecialidad);
            this.tabPage1.Controls.Add(this.txtNombreEspecialidad);
            this.tabPage1.Controls.Add(this.txtIdEspecialidad);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(817, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Especialidad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idespecialidadDataGridViewTextBoxColumn,
            this.nombreespecialidadDataGridViewTextBoxColumn,
            this.descripcionespecialidadDataGridViewTextBoxColumn,
            this.categoriaespecialidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.especialidadesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(36, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(520, 204);
            this.dataGridView1.TabIndex = 15;
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
            this.especialidadesBindingSource.DataSource = this.benjaDataSet;
            // 
            // benjaDataSet
            // 
            this.benjaDataSet.DataSetName = "benjaDataSet";
            this.benjaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVolverMenu
            // 
            this.btnVolverMenu.Font = new System.Drawing.Font("Symbol", 8.25F);
            this.btnVolverMenu.Location = new System.Drawing.Point(687, 16);
            this.btnVolverMenu.Name = "btnVolverMenu";
            this.btnVolverMenu.Size = new System.Drawing.Size(82, 25);
            this.btnVolverMenu.TabIndex = 14;
            this.btnVolverMenu.Text = "Volver";
            this.btnVolverMenu.UseVisualStyleBackColor = true;
            // 
            // btnAgregarEspecialidades
            // 
            this.btnAgregarEspecialidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEspecialidades.Location = new System.Drawing.Point(630, 212);
            this.btnAgregarEspecialidades.Name = "btnAgregarEspecialidades";
            this.btnAgregarEspecialidades.Size = new System.Drawing.Size(131, 34);
            this.btnAgregarEspecialidades.TabIndex = 13;
            this.btnAgregarEspecialidades.Text = "Agregar";
            this.btnAgregarEspecialidades.UseVisualStyleBackColor = true;
            this.btnAgregarEspecialidades.Click += new System.EventHandler(this.btnAgregarEspecialidades_Click);
            // 
            // txtDescripcionEspecialidad
            // 
            this.txtDescripcionEspecialidad.Location = new System.Drawing.Point(517, 102);
            this.txtDescripcionEspecialidad.Name = "txtDescripcionEspecialidad";
            this.txtDescripcionEspecialidad.Size = new System.Drawing.Size(172, 20);
            this.txtDescripcionEspecialidad.TabIndex = 10;
            this.txtDescripcionEspecialidad.TextChanged += new System.EventHandler(this.txtDescripcionEspecialidad_TextChanged);
            // 
            // txtCategoriaEspecialidad
            // 
            this.txtCategoriaEspecialidad.Location = new System.Drawing.Point(517, 145);
            this.txtCategoriaEspecialidad.Name = "txtCategoriaEspecialidad";
            this.txtCategoriaEspecialidad.Size = new System.Drawing.Size(172, 20);
            this.txtCategoriaEspecialidad.TabIndex = 9;
            this.txtCategoriaEspecialidad.TextChanged += new System.EventHandler(this.txtCategoriaEspecialidad_TextChanged);
            // 
            // txtNombreEspecialidad
            // 
            this.txtNombreEspecialidad.Location = new System.Drawing.Point(140, 145);
            this.txtNombreEspecialidad.Name = "txtNombreEspecialidad";
            this.txtNombreEspecialidad.Size = new System.Drawing.Size(172, 20);
            this.txtNombreEspecialidad.TabIndex = 8;
            // 
            // txtIdEspecialidad
            // 
            this.txtIdEspecialidad.Location = new System.Drawing.Point(140, 100);
            this.txtIdEspecialidad.Name = "txtIdEspecialidad";
            this.txtIdEspecialidad.Size = new System.Drawing.Size(172, 20);
            this.txtIdEspecialidad.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(385, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Categoría:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descripción:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Especialidad";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Aquamarine;
            this.tabPage2.Controls.Add(this.txtActualizarDescripcionEspecialidad);
            this.tabPage2.Controls.Add(this.txtActualizarCategoriaEspecialidad);
            this.tabPage2.Controls.Add(this.txtActualizarNombreEspecialidad);
            this.tabPage2.Controls.Add(this.txtActualizarIdEspecialidad);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.btnActualizarEspecialidad);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Actualizar Especialidad";
            // 
            // txtActualizarDescripcionEspecialidad
            // 
            this.txtActualizarDescripcionEspecialidad.Location = new System.Drawing.Point(515, 144);
            this.txtActualizarDescripcionEspecialidad.Name = "txtActualizarDescripcionEspecialidad";
            this.txtActualizarDescripcionEspecialidad.Size = new System.Drawing.Size(172, 20);
            this.txtActualizarDescripcionEspecialidad.TabIndex = 35;
            // 
            // txtActualizarCategoriaEspecialidad
            // 
            this.txtActualizarCategoriaEspecialidad.Location = new System.Drawing.Point(515, 172);
            this.txtActualizarCategoriaEspecialidad.Name = "txtActualizarCategoriaEspecialidad";
            this.txtActualizarCategoriaEspecialidad.Size = new System.Drawing.Size(172, 20);
            this.txtActualizarCategoriaEspecialidad.TabIndex = 34;
            // 
            // txtActualizarNombreEspecialidad
            // 
            this.txtActualizarNombreEspecialidad.Location = new System.Drawing.Point(157, 170);
            this.txtActualizarNombreEspecialidad.Name = "txtActualizarNombreEspecialidad";
            this.txtActualizarNombreEspecialidad.Size = new System.Drawing.Size(172, 20);
            this.txtActualizarNombreEspecialidad.TabIndex = 33;
            // 
            // txtActualizarIdEspecialidad
            // 
            this.txtActualizarIdEspecialidad.Location = new System.Drawing.Point(157, 141);
            this.txtActualizarIdEspecialidad.Name = "txtActualizarIdEspecialidad";
            this.txtActualizarIdEspecialidad.Size = new System.Drawing.Size(172, 20);
            this.txtActualizarIdEspecialidad.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Categoría:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(401, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(78, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 29;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(121, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "ID:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idespecialidadDataGridViewTextBoxColumn1,
            this.nombreespecialidadDataGridViewTextBoxColumn1,
            this.descripcionespecialidadDataGridViewTextBoxColumn1,
            this.categoriaespecialidadDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.especialidadesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(157, 282);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(442, 118);
            this.dataGridView2.TabIndex = 27;
            // 
            // idespecialidadDataGridViewTextBoxColumn1
            // 
            this.idespecialidadDataGridViewTextBoxColumn1.DataPropertyName = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn1.HeaderText = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn1.Name = "idespecialidadDataGridViewTextBoxColumn1";
            // 
            // nombreespecialidadDataGridViewTextBoxColumn1
            // 
            this.nombreespecialidadDataGridViewTextBoxColumn1.DataPropertyName = "nombre_especialidad";
            this.nombreespecialidadDataGridViewTextBoxColumn1.HeaderText = "nombre_especialidad";
            this.nombreespecialidadDataGridViewTextBoxColumn1.Name = "nombreespecialidadDataGridViewTextBoxColumn1";
            // 
            // descripcionespecialidadDataGridViewTextBoxColumn1
            // 
            this.descripcionespecialidadDataGridViewTextBoxColumn1.DataPropertyName = "descripcion_especialidad";
            this.descripcionespecialidadDataGridViewTextBoxColumn1.HeaderText = "descripcion_especialidad";
            this.descripcionespecialidadDataGridViewTextBoxColumn1.Name = "descripcionespecialidadDataGridViewTextBoxColumn1";
            // 
            // categoriaespecialidadDataGridViewTextBoxColumn1
            // 
            this.categoriaespecialidadDataGridViewTextBoxColumn1.DataPropertyName = "categoria_especialidad";
            this.categoriaespecialidadDataGridViewTextBoxColumn1.HeaderText = "categoria_especialidad";
            this.categoriaespecialidadDataGridViewTextBoxColumn1.Name = "categoriaespecialidadDataGridViewTextBoxColumn1";
            // 
            // btnActualizarEspecialidad
            // 
            this.btnActualizarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEspecialidad.Location = new System.Drawing.Point(629, 213);
            this.btnActualizarEspecialidad.Name = "btnActualizarEspecialidad";
            this.btnActualizarEspecialidad.Size = new System.Drawing.Size(137, 34);
            this.btnActualizarEspecialidad.TabIndex = 25;
            this.btnActualizarEspecialidad.Text = "Actualizar";
            this.btnActualizarEspecialidad.UseVisualStyleBackColor = true;
            this.btnActualizarEspecialidad.Click += new System.EventHandler(this.btnActualizarEspecialidad_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(217, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(318, 31);
            this.label8.TabIndex = 1;
            this.label8.Text = "Actualizar Especialidad";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Aquamarine;
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Controls.Add(this.txtEliminarIdEspecialidad);
            this.tabPage3.Controls.Add(this.btnEliminarEspecialidad);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(788, 425);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar Especialidad";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idespecialidadDataGridViewTextBoxColumn2,
            this.nombreespecialidadDataGridViewTextBoxColumn2,
            this.descripcionespecialidadDataGridViewTextBoxColumn2,
            this.categoriaespecialidadDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.especialidadesBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(156, 211);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(442, 160);
            this.dataGridView3.TabIndex = 41;
            // 
            // idespecialidadDataGridViewTextBoxColumn2
            // 
            this.idespecialidadDataGridViewTextBoxColumn2.DataPropertyName = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn2.HeaderText = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn2.Name = "idespecialidadDataGridViewTextBoxColumn2";
            // 
            // nombreespecialidadDataGridViewTextBoxColumn2
            // 
            this.nombreespecialidadDataGridViewTextBoxColumn2.DataPropertyName = "nombre_especialidad";
            this.nombreespecialidadDataGridViewTextBoxColumn2.HeaderText = "nombre_especialidad";
            this.nombreespecialidadDataGridViewTextBoxColumn2.Name = "nombreespecialidadDataGridViewTextBoxColumn2";
            // 
            // descripcionespecialidadDataGridViewTextBoxColumn2
            // 
            this.descripcionespecialidadDataGridViewTextBoxColumn2.DataPropertyName = "descripcion_especialidad";
            this.descripcionespecialidadDataGridViewTextBoxColumn2.HeaderText = "descripcion_especialidad";
            this.descripcionespecialidadDataGridViewTextBoxColumn2.Name = "descripcionespecialidadDataGridViewTextBoxColumn2";
            // 
            // categoriaespecialidadDataGridViewTextBoxColumn2
            // 
            this.categoriaespecialidadDataGridViewTextBoxColumn2.DataPropertyName = "categoria_especialidad";
            this.categoriaespecialidadDataGridViewTextBoxColumn2.HeaderText = "categoria_especialidad";
            this.categoriaespecialidadDataGridViewTextBoxColumn2.Name = "categoriaespecialidadDataGridViewTextBoxColumn2";
            // 
            // txtEliminarIdEspecialidad
            // 
            this.txtEliminarIdEspecialidad.Location = new System.Drawing.Point(432, 88);
            this.txtEliminarIdEspecialidad.Name = "txtEliminarIdEspecialidad";
            this.txtEliminarIdEspecialidad.Size = new System.Drawing.Size(191, 20);
            this.txtEliminarIdEspecialidad.TabIndex = 40;
            // 
            // btnEliminarEspecialidad
            // 
            this.btnEliminarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEspecialidad.Location = new System.Drawing.Point(617, 127);
            this.btnEliminarEspecialidad.Name = "btnEliminarEspecialidad";
            this.btnEliminarEspecialidad.Size = new System.Drawing.Size(155, 34);
            this.btnEliminarEspecialidad.TabIndex = 38;
            this.btnEliminarEspecialidad.Text = "Eliminar";
            this.btnEliminarEspecialidad.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(75, 88);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(351, 20);
            this.label20.TabIndex = 26;
            this.label20.Text = "Ingrese el ID de la Especialidad a eliminar:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(267, 22);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(293, 31);
            this.label21.TabIndex = 25;
            this.label21.Text = "Eliminar Especialidad";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Aquamarine;
            this.tabPage4.Controls.Add(this.btnBuscarEspecialidad);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.txtBuscarIdEspecialidad);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(788, 425);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Buscar Especialidad";
            // 
            // btnBuscarEspecialidad
            // 
            this.btnBuscarEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarEspecialidad.Location = new System.Drawing.Point(617, 129);
            this.btnBuscarEspecialidad.Name = "btnBuscarEspecialidad";
            this.btnBuscarEspecialidad.Size = new System.Drawing.Size(130, 34);
            this.btnBuscarEspecialidad.TabIndex = 44;
            this.btnBuscarEspecialidad.Text = "Buscar";
            this.btnBuscarEspecialidad.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idespecialidadDataGridViewTextBoxColumn3,
            this.nombreespecialidadDataGridViewTextBoxColumn3,
            this.descripcionespecialidadDataGridViewTextBoxColumn3,
            this.categoriaespecialidadDataGridViewTextBoxColumn3});
            this.dataGridView4.DataSource = this.especialidadesBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(123, 186);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(440, 208);
            this.dataGridView4.TabIndex = 43;
            // 
            // idespecialidadDataGridViewTextBoxColumn3
            // 
            this.idespecialidadDataGridViewTextBoxColumn3.DataPropertyName = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn3.HeaderText = "id_especialidad";
            this.idespecialidadDataGridViewTextBoxColumn3.Name = "idespecialidadDataGridViewTextBoxColumn3";
            // 
            // nombreespecialidadDataGridViewTextBoxColumn3
            // 
            this.nombreespecialidadDataGridViewTextBoxColumn3.DataPropertyName = "nombre_especialidad";
            this.nombreespecialidadDataGridViewTextBoxColumn3.HeaderText = "nombre_especialidad";
            this.nombreespecialidadDataGridViewTextBoxColumn3.Name = "nombreespecialidadDataGridViewTextBoxColumn3";
            // 
            // descripcionespecialidadDataGridViewTextBoxColumn3
            // 
            this.descripcionespecialidadDataGridViewTextBoxColumn3.DataPropertyName = "descripcion_especialidad";
            this.descripcionespecialidadDataGridViewTextBoxColumn3.HeaderText = "descripcion_especialidad";
            this.descripcionespecialidadDataGridViewTextBoxColumn3.Name = "descripcionespecialidadDataGridViewTextBoxColumn3";
            // 
            // categoriaespecialidadDataGridViewTextBoxColumn3
            // 
            this.categoriaespecialidadDataGridViewTextBoxColumn3.DataPropertyName = "categoria_especialidad";
            this.categoriaespecialidadDataGridViewTextBoxColumn3.HeaderText = "categoria_especialidad";
            this.categoriaespecialidadDataGridViewTextBoxColumn3.Name = "categoriaespecialidadDataGridViewTextBoxColumn3";
            // 
            // txtBuscarIdEspecialidad
            // 
            this.txtBuscarIdEspecialidad.Location = new System.Drawing.Point(424, 94);
            this.txtBuscarIdEspecialidad.Name = "txtBuscarIdEspecialidad";
            this.txtBuscarIdEspecialidad.Size = new System.Drawing.Size(191, 20);
            this.txtBuscarIdEspecialidad.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(75, 92);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(343, 20);
            this.label16.TabIndex = 41;
            this.label16.Text = "Ingrese el ID de la Especialidad a buscar:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(241, 24);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(279, 31);
            this.label15.TabIndex = 26;
            this.label15.Text = "Buscar Especialidad";
            // 
            // especialidadesTableAdapter
            // 
            this.especialidadesTableAdapter.ClearBeforeFill = true;
            // 
            // Especialidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 505);
            this.Controls.Add(this.tabControl1);
            this.Name = "Especialidades";
            this.Text = "Especialidades";
            this.Load += new System.EventHandler(this.Especialidades_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.especialidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.benjaDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVolverMenu;
        private System.Windows.Forms.Button btnAgregarEspecialidades;
        private System.Windows.Forms.TextBox txtDescripcionEspecialidad;
        private System.Windows.Forms.TextBox txtCategoriaEspecialidad;
        private System.Windows.Forms.TextBox txtNombreEspecialidad;
        private System.Windows.Forms.TextBox txtIdEspecialidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnActualizarEspecialidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox txtEliminarIdEspecialidad;
        private System.Windows.Forms.Button btnEliminarEspecialidad;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnBuscarEspecialidad;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.TextBox txtBuscarIdEspecialidad;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtActualizarDescripcionEspecialidad;
        private System.Windows.Forms.TextBox txtActualizarCategoriaEspecialidad;
        private System.Windows.Forms.TextBox txtActualizarNombreEspecialidad;
        private System.Windows.Forms.TextBox txtActualizarIdEspecialidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private benjaDataSet benjaDataSet;
        private System.Windows.Forms.BindingSource especialidadesBindingSource;
        private benjaDataSetTableAdapters.especialidadesTableAdapter especialidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreespecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionespecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaespecialidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecialidadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreespecialidadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionespecialidadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaespecialidadDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecialidadDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreespecialidadDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionespecialidadDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaespecialidadDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idespecialidadDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreespecialidadDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionespecialidadDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaespecialidadDataGridViewTextBoxColumn3;
    }
}