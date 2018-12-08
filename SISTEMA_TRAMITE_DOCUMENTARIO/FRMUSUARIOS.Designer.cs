namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    partial class FRMUSUARIOS
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
            System.Windows.Forms.Label id_usuarioLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label correo_electronicoLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label contraseñaLabel;
            System.Windows.Forms.Label tipo_administradorLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.id_usuarioTextBox = new System.Windows.Forms.TextBox();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.correo_electronicoTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.tipo_administradorComboBox = new System.Windows.Forms.ComboBox();
            this.dataSetTramite = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramite();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNEDITAR = new System.Windows.Forms.Button();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.adm_sistemaTableAdapter = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.adm_sistemaTableAdapter();
            this.tableAdapterManager = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager();
            this.admsistemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cbbuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.adm_sistemaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_usuarioLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            correo_electronicoLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            contraseñaLabel = new System.Windows.Forms.Label();
            tipo_administradorLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admsistemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adm_sistemaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_usuarioLabel
            // 
            id_usuarioLabel.AutoSize = true;
            id_usuarioLabel.Location = new System.Drawing.Point(73, 19);
            id_usuarioLabel.Name = "id_usuarioLabel";
            id_usuarioLabel.Size = new System.Drawing.Size(69, 16);
            id_usuarioLabel.TabIndex = 0;
            id_usuarioLabel.Text = "id usuario:";
            id_usuarioLabel.Visible = false;
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Location = new System.Drawing.Point(78, 60);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(64, 16);
            nombresLabel.TabIndex = 4;
            nombresLabel.Text = "nombres:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(75, 88);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(67, 16);
            apellidosLabel.TabIndex = 6;
            apellidosLabel.Text = "apellidos:";
            // 
            // correo_electronicoLabel
            // 
            correo_electronicoLabel.AutoSize = true;
            correo_electronicoLabel.Location = new System.Drawing.Point(23, 116);
            correo_electronicoLabel.Name = "correo_electronicoLabel";
            correo_electronicoLabel.Size = new System.Drawing.Size(119, 16);
            correo_electronicoLabel.TabIndex = 8;
            correo_electronicoLabel.Text = "correo electronico:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(87, 144);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(55, 16);
            usuarioLabel.TabIndex = 10;
            usuarioLabel.Text = "usuario:";
            // 
            // contraseñaLabel
            // 
            contraseñaLabel.AutoSize = true;
            contraseñaLabel.Location = new System.Drawing.Point(64, 172);
            contraseñaLabel.Name = "contraseñaLabel";
            contraseñaLabel.Size = new System.Drawing.Size(78, 16);
            contraseñaLabel.TabIndex = 12;
            contraseñaLabel.Text = "contraseña:";
            // 
            // tipo_administradorLabel
            // 
            tipo_administradorLabel.AutoSize = true;
            tipo_administradorLabel.Location = new System.Drawing.Point(24, 200);
            tipo_administradorLabel.Name = "tipo_administradorLabel";
            tipo_administradorLabel.Size = new System.Drawing.Size(118, 16);
            tipo_administradorLabel.TabIndex = 14;
            tipo_administradorLabel.Text = "tipo administrador:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(id_usuarioLabel);
            this.groupBox1.Controls.Add(this.id_usuarioTextBox);
            this.groupBox1.Controls.Add(nombresLabel);
            this.groupBox1.Controls.Add(this.nombresTextBox);
            this.groupBox1.Controls.Add(apellidosLabel);
            this.groupBox1.Controls.Add(this.apellidosTextBox);
            this.groupBox1.Controls.Add(correo_electronicoLabel);
            this.groupBox1.Controls.Add(this.correo_electronicoTextBox);
            this.groupBox1.Controls.Add(usuarioLabel);
            this.groupBox1.Controls.Add(this.usuarioTextBox);
            this.groupBox1.Controls.Add(contraseñaLabel);
            this.groupBox1.Controls.Add(this.contraseñaTextBox);
            this.groupBox1.Controls.Add(tipo_administradorLabel);
            this.groupBox1.Controls.Add(this.tipo_administradorComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.groupBox1.Location = new System.Drawing.Point(13, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(435, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE USUARIOS";
            // 
            // id_usuarioTextBox
            // 
            this.id_usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admsistemaBindingSource, "id_usuario", true));
            this.id_usuarioTextBox.Location = new System.Drawing.Point(148, 16);
            this.id_usuarioTextBox.Name = "id_usuarioTextBox";
            this.id_usuarioTextBox.Size = new System.Drawing.Size(79, 22);
            this.id_usuarioTextBox.TabIndex = 1;
            this.id_usuarioTextBox.Visible = false;
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admsistemaBindingSource, "nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(148, 57);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(265, 22);
            this.nombresTextBox.TabIndex = 5;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admsistemaBindingSource, "apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(148, 85);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(265, 22);
            this.apellidosTextBox.TabIndex = 7;
            // 
            // correo_electronicoTextBox
            // 
            this.correo_electronicoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admsistemaBindingSource, "correo_electronico", true));
            this.correo_electronicoTextBox.Location = new System.Drawing.Point(148, 113);
            this.correo_electronicoTextBox.Name = "correo_electronicoTextBox";
            this.correo_electronicoTextBox.Size = new System.Drawing.Size(265, 22);
            this.correo_electronicoTextBox.TabIndex = 9;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admsistemaBindingSource, "usuario", true));
            this.usuarioTextBox.Location = new System.Drawing.Point(148, 141);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(164, 22);
            this.usuarioTextBox.TabIndex = 11;
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admsistemaBindingSource, "contraseña", true));
            this.contraseñaTextBox.Location = new System.Drawing.Point(148, 169);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(164, 22);
            this.contraseñaTextBox.TabIndex = 13;
            // 
            // tipo_administradorComboBox
            // 
            this.tipo_administradorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.admsistemaBindingSource, "tipo_administrador", true));
            this.tipo_administradorComboBox.FormattingEnabled = true;
            this.tipo_administradorComboBox.Items.AddRange(new object[] {
            "ADMINISTRADOR",
            "SECRETARIA",
            "DIRECTOR"});
            this.tipo_administradorComboBox.Location = new System.Drawing.Point(148, 197);
            this.tipo_administradorComboBox.Name = "tipo_administradorComboBox";
            this.tipo_administradorComboBox.Size = new System.Drawing.Size(164, 24);
            this.tipo_administradorComboBox.TabIndex = 15;
            // 
            // dataSetTramite
            // 
            this.dataSetTramite.DataSetName = "DataSetTramite";
            this.dataSetTramite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // BTNELIMINAR
            // 
            this.BTNELIMINAR.BackColor = System.Drawing.Color.Transparent;
            this.BTNELIMINAR.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNELIMINAR.FlatAppearance.BorderSize = 0;
            this.BTNELIMINAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BTNELIMINAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNELIMINAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNELIMINAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Delete_File_48px;
            this.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNELIMINAR.Location = new System.Drawing.Point(478, 280);
            this.BTNELIMINAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(138, 59);
            this.BTNELIMINAR.TabIndex = 64;
            this.BTNELIMINAR.Text = "ELIMINAR";
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.BackColor = System.Drawing.Color.Transparent;
            this.BTNGUARDAR.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNGUARDAR.FlatAppearance.BorderSize = 0;
            this.BTNGUARDAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BTNGUARDAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNGUARDAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNGUARDAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNGUARDAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNGUARDAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Save_Archive_48px;
            this.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGUARDAR.Location = new System.Drawing.Point(478, 220);
            this.BTNGUARDAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(138, 52);
            this.BTNGUARDAR.TabIndex = 63;
            this.BTNGUARDAR.Text = "GUARDAR";
            this.BTNGUARDAR.UseVisualStyleBackColor = false;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // BTNEDITAR
            // 
            this.BTNEDITAR.BackColor = System.Drawing.Color.Transparent;
            this.BTNEDITAR.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNEDITAR.FlatAppearance.BorderSize = 0;
            this.BTNEDITAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BTNEDITAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNEDITAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNEDITAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNEDITAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEDITAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Edit_File_48px;
            this.BTNEDITAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEDITAR.Location = new System.Drawing.Point(478, 97);
            this.BTNEDITAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNEDITAR.Name = "BTNEDITAR";
            this.BTNEDITAR.Size = new System.Drawing.Size(138, 46);
            this.BTNEDITAR.TabIndex = 61;
            this.BTNEDITAR.Text = "EDITAR";
            this.BTNEDITAR.UseVisualStyleBackColor = false;
            this.BTNEDITAR.Click += new System.EventHandler(this.BTNEDITAR_Click);
            // 
            // BTNCANCELAR
            // 
            this.BTNCANCELAR.BackColor = System.Drawing.Color.Transparent;
            this.BTNCANCELAR.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNCANCELAR.FlatAppearance.BorderSize = 0;
            this.BTNCANCELAR.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BTNCANCELAR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNCANCELAR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNCANCELAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCANCELAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCANCELAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Cancel_File_48px;
            this.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCANCELAR.Location = new System.Drawing.Point(478, 151);
            this.BTNCANCELAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(138, 61);
            this.BTNCANCELAR.TabIndex = 62;
            this.BTNCANCELAR.Text = "CANCELAR";
            this.BTNCANCELAR.UseVisualStyleBackColor = false;
            this.BTNCANCELAR.Click += new System.EventHandler(this.BTNCANCELAR_Click);
            // 
            // BTNNUEVO
            // 
            this.BTNNUEVO.BackColor = System.Drawing.Color.Transparent;
            this.BTNNUEVO.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.BTNNUEVO.FlatAppearance.BorderSize = 0;
            this.BTNNUEVO.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.BTNNUEVO.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BTNNUEVO.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BTNNUEVO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNNUEVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNUEVO.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Add_List_48px;
            this.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVO.Location = new System.Drawing.Point(478, 42);
            this.BTNNUEVO.Margin = new System.Windows.Forms.Padding(4);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(138, 47);
            this.BTNNUEVO.TabIndex = 60;
            this.BTNNUEVO.Text = "NUEVO";
            this.BTNNUEVO.UseVisualStyleBackColor = false;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
            // 
            // adm_sistemaTableAdapter
            // 
            this.adm_sistemaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adm_sistemaTableAdapter = this.adm_sistemaTableAdapter;
            this.tableAdapterManager.areasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.detalle_documento_externoTableAdapter = null;
            this.tableAdapterManager.detalle_documento_internoTableAdapter = null;
            this.tableAdapterManager.documento_externoTableAdapter = null;
            this.tableAdapterManager.documento_internoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // admsistemaBindingSource
            // 
            this.admsistemaBindingSource.DataMember = "adm_sistema";
            this.admsistemaBindingSource.DataSource = this.dataSetTramite;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Open_Folder_48px;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(443, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 25);
            this.button3.TabIndex = 69;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Search_48px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(409, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 25);
            this.button2.TabIndex = 68;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(181, 317);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(222, 22);
            this.txtbuscar.TabIndex = 67;
            // 
            // cbbuscar
            // 
            this.cbbuscar.FormattingEnabled = true;
            this.cbbuscar.Items.AddRange(new object[] {
            "NOMBRE",
            "APELLIDO",
            "USUARIO"});
            this.cbbuscar.Location = new System.Drawing.Point(81, 317);
            this.cbbuscar.Name = "cbbuscar";
            this.cbbuscar.Size = new System.Drawing.Size(94, 24);
            this.cbbuscar.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 65;
            this.label1.Text = "Buscar por:";
            // 
            // adm_sistemaDataGridView
            // 
            this.adm_sistemaDataGridView.AutoGenerateColumns = false;
            this.adm_sistemaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adm_sistemaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.adm_sistemaDataGridView.DataSource = this.admsistemaBindingSource;
            this.adm_sistemaDataGridView.Location = new System.Drawing.Point(13, 360);
            this.adm_sistemaDataGridView.Name = "adm_sistemaDataGridView";
            this.adm_sistemaDataGridView.Size = new System.Drawing.Size(611, 220);
            this.adm_sistemaDataGridView.TabIndex = 69;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_usuario";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_usuario";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombres";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombres";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn3.HeaderText = "apellidos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "correo_electronico";
            this.dataGridViewTextBoxColumn4.HeaderText = "correo_electronico";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "usuario";
            this.dataGridViewTextBoxColumn5.HeaderText = "usuario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "contraseña";
            this.dataGridViewTextBoxColumn6.HeaderText = "contraseña";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "tipo_administrador";
            this.dataGridViewTextBoxColumn7.HeaderText = "tipo_administrador";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // FRMUSUARIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(636, 623);
            this.Controls.Add(this.adm_sistemaDataGridView);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.cbbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNEDITAR);
            this.Controls.Add(this.BTNCANCELAR);
            this.Controls.Add(this.BTNNUEVO);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMUSUARIOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMUSUARIOS";
            this.Load += new System.EventHandler(this.FRMUSUARIOS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admsistemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adm_sistemaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNEDITAR;
        private System.Windows.Forms.Button BTNCANCELAR;
        private System.Windows.Forms.Button BTNNUEVO;
        private DataSetTramite dataSetTramite;
        private DataSetTramiteTableAdapters.adm_sistemaTableAdapter adm_sistemaTableAdapter;
        private DataSetTramiteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox id_usuarioTextBox;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox correo_electronicoTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.ComboBox tipo_administradorComboBox;
        private System.Windows.Forms.BindingSource admsistemaBindingSource;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cbbuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView adm_sistemaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}