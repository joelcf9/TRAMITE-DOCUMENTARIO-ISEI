namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    partial class FRMDOCUMETOINTERNO
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
            System.Windows.Forms.Label numero_correlativoLabel;
            System.Windows.Forms.Label tipo_documentoLabel;
            System.Windows.Forms.Label fecha_registroLabel;
            System.Windows.Forms.Label numero_registro_MPLabel;
            System.Windows.Forms.Label numero_folioLabel;
            System.Windows.Forms.Label nombre_tramitanteLabel;
            System.Windows.Forms.Label dni_tramitanteLabel;
            System.Windows.Forms.Label asunto_tramitanteLabel;
            System.Windows.Forms.Label id_areaLabel;
            System.Windows.Forms.Label nombre_areaLabel;
            System.Windows.Forms.Label observacionLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label imagenLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMDOCUMETOINTERNO));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numero_correlativoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.documento_internoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTramite = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramite();
            this.tipo_documentoTextBox = new System.Windows.Forms.TextBox();
            this.fecha_registroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.numero_registro_MPTextBox = new System.Windows.Forms.TextBox();
            this.numero_folioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imagenPictureBox = new System.Windows.Forms.PictureBox();
            this.botonagregar = new System.Windows.Forms.Button();
            this.id_areaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nombre_tramitanteTextBox = new System.Windows.Forms.TextBox();
            this.dni_tramitanteTextBox = new System.Windows.Forms.TextBox();
            this.asunto_tramitanteTextBox = new System.Windows.Forms.TextBox();
            this.nombre_areaTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.observacionTextBox = new System.Windows.Forms.TextBox();
            this.tableAdapterManager = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNEDITAR = new System.Windows.Forms.Button();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbuscar = new System.Windows.Forms.ComboBox();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.documento_internoTableAdapter = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.documento_internoTableAdapter();
            this.documento_internoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            numero_correlativoLabel = new System.Windows.Forms.Label();
            tipo_documentoLabel = new System.Windows.Forms.Label();
            fecha_registroLabel = new System.Windows.Forms.Label();
            numero_registro_MPLabel = new System.Windows.Forms.Label();
            numero_folioLabel = new System.Windows.Forms.Label();
            nombre_tramitanteLabel = new System.Windows.Forms.Label();
            dni_tramitanteLabel = new System.Windows.Forms.Label();
            asunto_tramitanteLabel = new System.Windows.Forms.Label();
            id_areaLabel = new System.Windows.Forms.Label();
            nombre_areaLabel = new System.Windows.Forms.Label();
            observacionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            imagenLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numero_correlativoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documento_internoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_folioNumericUpDown)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documento_internoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // numero_correlativoLabel
            // 
            numero_correlativoLabel.AutoSize = true;
            numero_correlativoLabel.Enabled = false;
            numero_correlativoLabel.Location = new System.Drawing.Point(15, 19);
            numero_correlativoLabel.Name = "numero_correlativoLabel";
            numero_correlativoLabel.Size = new System.Drawing.Size(122, 16);
            numero_correlativoLabel.TabIndex = 0;
            numero_correlativoLabel.Text = "numero correlativo:";
            numero_correlativoLabel.Visible = false;
            // 
            // tipo_documentoLabel
            // 
            tipo_documentoLabel.AutoSize = true;
            tipo_documentoLabel.Location = new System.Drawing.Point(323, 19);
            tipo_documentoLabel.Name = "tipo_documentoLabel";
            tipo_documentoLabel.Size = new System.Drawing.Size(103, 16);
            tipo_documentoLabel.TabIndex = 12;
            tipo_documentoLabel.Text = "tipo documento:";
            // 
            // fecha_registroLabel
            // 
            fecha_registroLabel.AutoSize = true;
            fecha_registroLabel.Location = new System.Drawing.Point(323, 65);
            fecha_registroLabel.Name = "fecha_registroLabel";
            fecha_registroLabel.Size = new System.Drawing.Size(92, 16);
            fecha_registroLabel.TabIndex = 14;
            fecha_registroLabel.Text = "fecha registro:";
            // 
            // numero_registro_MPLabel
            // 
            numero_registro_MPLabel.AutoSize = true;
            numero_registro_MPLabel.Location = new System.Drawing.Point(10, 48);
            numero_registro_MPLabel.Name = "numero_registro_MPLabel";
            numero_registro_MPLabel.Size = new System.Drawing.Size(127, 16);
            numero_registro_MPLabel.TabIndex = 20;
            numero_registro_MPLabel.Text = "numero registro MP:";
            // 
            // numero_folioLabel
            // 
            numero_folioLabel.AutoSize = true;
            numero_folioLabel.Location = new System.Drawing.Point(53, 71);
            numero_folioLabel.Name = "numero_folioLabel";
            numero_folioLabel.Size = new System.Drawing.Size(84, 16);
            numero_folioLabel.TabIndex = 22;
            numero_folioLabel.Text = "numero folio:";
            // 
            // nombre_tramitanteLabel
            // 
            nombre_tramitanteLabel.AutoSize = true;
            nombre_tramitanteLabel.Location = new System.Drawing.Point(15, 23);
            nombre_tramitanteLabel.Name = "nombre_tramitanteLabel";
            nombre_tramitanteLabel.Size = new System.Drawing.Size(118, 16);
            nombre_tramitanteLabel.TabIndex = 2;
            nombre_tramitanteLabel.Text = "nombre tramitante:";
            // 
            // dni_tramitanteLabel
            // 
            dni_tramitanteLabel.AutoSize = true;
            dni_tramitanteLabel.Location = new System.Drawing.Point(204, 24);
            dni_tramitanteLabel.Name = "dni_tramitanteLabel";
            dni_tramitanteLabel.Size = new System.Drawing.Size(90, 16);
            dni_tramitanteLabel.TabIndex = 4;
            dni_tramitanteLabel.Text = "dni tramitante:";
            // 
            // asunto_tramitanteLabel
            // 
            asunto_tramitanteLabel.AutoSize = true;
            asunto_tramitanteLabel.Location = new System.Drawing.Point(15, 90);
            asunto_tramitanteLabel.Name = "asunto_tramitanteLabel";
            asunto_tramitanteLabel.Size = new System.Drawing.Size(112, 16);
            asunto_tramitanteLabel.TabIndex = 6;
            asunto_tramitanteLabel.Text = "asunto tramitante:";
            // 
            // id_areaLabel
            // 
            id_areaLabel.AutoSize = true;
            id_areaLabel.Location = new System.Drawing.Point(206, 114);
            id_areaLabel.Name = "id_areaLabel";
            id_areaLabel.Size = new System.Drawing.Size(53, 16);
            id_areaLabel.TabIndex = 8;
            id_areaLabel.Text = "id area:";
            // 
            // nombre_areaLabel
            // 
            nombre_areaLabel.AutoSize = true;
            nombre_areaLabel.Location = new System.Drawing.Point(204, 164);
            nombre_areaLabel.Name = "nombre_areaLabel";
            nombre_areaLabel.Size = new System.Drawing.Size(88, 16);
            nombre_areaLabel.TabIndex = 10;
            nombre_areaLabel.Text = "nombre area:";
            // 
            // observacionLabel
            // 
            observacionLabel.AutoSize = true;
            observacionLabel.Location = new System.Drawing.Point(15, 164);
            observacionLabel.Name = "observacionLabel";
            observacionLabel.Size = new System.Drawing.Size(86, 16);
            observacionLabel.TabIndex = 18;
            observacionLabel.Text = "observacion:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(206, 68);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(53, 16);
            estadoLabel.TabIndex = 16;
            estadoLabel.Text = "estado:";
            // 
            // imagenLabel
            // 
            imagenLabel.AutoSize = true;
            imagenLabel.Location = new System.Drawing.Point(522, 23);
            imagenLabel.Name = "imagenLabel";
            imagenLabel.Size = new System.Drawing.Size(56, 16);
            imagenLabel.TabIndex = 22;
            imagenLabel.Text = "imagen:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(numero_correlativoLabel);
            this.groupBox1.Controls.Add(this.numero_correlativoNumericUpDown);
            this.groupBox1.Controls.Add(tipo_documentoLabel);
            this.groupBox1.Controls.Add(this.tipo_documentoTextBox);
            this.groupBox1.Controls.Add(fecha_registroLabel);
            this.groupBox1.Controls.Add(this.fecha_registroDateTimePicker);
            this.groupBox1.Controls.Add(numero_registro_MPLabel);
            this.groupBox1.Controls.Add(this.numero_registro_MPTextBox);
            this.groupBox1.Controls.Add(numero_folioLabel);
            this.groupBox1.Controls.Add(this.numero_folioNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // numero_correlativoNumericUpDown
            // 
            this.numero_correlativoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.documento_internoBindingSource, "numero_correlativo", true));
            this.numero_correlativoNumericUpDown.Enabled = false;
            this.numero_correlativoNumericUpDown.Location = new System.Drawing.Point(137, 16);
            this.numero_correlativoNumericUpDown.Name = "numero_correlativoNumericUpDown";
            this.numero_correlativoNumericUpDown.Size = new System.Drawing.Size(62, 22);
            this.numero_correlativoNumericUpDown.TabIndex = 1;
            this.numero_correlativoNumericUpDown.Visible = false;
            // 
            // documento_internoBindingSource
            // 
            this.documento_internoBindingSource.DataMember = "documento_interno";
            this.documento_internoBindingSource.DataSource = this.dataSetTramite;
            // 
            // dataSetTramite
            // 
            this.dataSetTramite.DataSetName = "DataSetTramite";
            this.dataSetTramite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipo_documentoTextBox
            // 
            this.tipo_documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documento_internoBindingSource, "tipo_documento", true));
            this.tipo_documentoTextBox.Location = new System.Drawing.Point(326, 40);
            this.tipo_documentoTextBox.Name = "tipo_documentoTextBox";
            this.tipo_documentoTextBox.Size = new System.Drawing.Size(200, 22);
            this.tipo_documentoTextBox.TabIndex = 13;
            // 
            // fecha_registroDateTimePicker
            // 
            this.fecha_registroDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.documento_internoBindingSource, "fecha_registro", true));
            this.fecha_registroDateTimePicker.Location = new System.Drawing.Point(326, 82);
            this.fecha_registroDateTimePicker.Name = "fecha_registroDateTimePicker";
            this.fecha_registroDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.fecha_registroDateTimePicker.TabIndex = 15;
            this.fecha_registroDateTimePicker.ValueChanged += new System.EventHandler(this.fecha_registroDateTimePicker_ValueChanged);
            // 
            // numero_registro_MPTextBox
            // 
            this.numero_registro_MPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documento_internoBindingSource, "numero_registro_MP", true));
            this.numero_registro_MPTextBox.Location = new System.Drawing.Point(137, 42);
            this.numero_registro_MPTextBox.Name = "numero_registro_MPTextBox";
            this.numero_registro_MPTextBox.Size = new System.Drawing.Size(158, 22);
            this.numero_registro_MPTextBox.TabIndex = 21;
            this.numero_registro_MPTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numero_registro_MPTextBox_KeyPress);
            // 
            // numero_folioNumericUpDown
            // 
            this.numero_folioNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.documento_internoBindingSource, "numero_folio", true));
            this.numero_folioNumericUpDown.Location = new System.Drawing.Point(137, 68);
            this.numero_folioNumericUpDown.Name = "numero_folioNumericUpDown";
            this.numero_folioNumericUpDown.Size = new System.Drawing.Size(62, 22);
            this.numero_folioNumericUpDown.TabIndex = 23;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.imagenPictureBox);
            this.groupBox2.Controls.Add(imagenLabel);
            this.groupBox2.Controls.Add(this.botonagregar);
            this.groupBox2.Controls.Add(this.id_areaTextBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(nombre_tramitanteLabel);
            this.groupBox2.Controls.Add(this.nombre_tramitanteTextBox);
            this.groupBox2.Controls.Add(dni_tramitanteLabel);
            this.groupBox2.Controls.Add(this.dni_tramitanteTextBox);
            this.groupBox2.Controls.Add(asunto_tramitanteLabel);
            this.groupBox2.Controls.Add(this.asunto_tramitanteTextBox);
            this.groupBox2.Controls.Add(id_areaLabel);
            this.groupBox2.Controls.Add(nombre_areaLabel);
            this.groupBox2.Controls.Add(this.nombre_areaTextBox);
            this.groupBox2.Controls.Add(estadoLabel);
            this.groupBox2.Controls.Add(this.estadoComboBox);
            this.groupBox2.Controls.Add(observacionLabel);
            this.groupBox2.Controls.Add(this.observacionTextBox);
            this.groupBox2.Location = new System.Drawing.Point(23, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(645, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro usuario y documento";
            // 
            // imagenPictureBox
            // 
            this.imagenPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.documento_internoBindingSource, "imagen", true));
            this.imagenPictureBox.Location = new System.Drawing.Point(406, 43);
            this.imagenPictureBox.Name = "imagenPictureBox";
            this.imagenPictureBox.Size = new System.Drawing.Size(216, 226);
            this.imagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagenPictureBox.TabIndex = 23;
            this.imagenPictureBox.TabStop = false;
            // 
            // botonagregar
            // 
            this.botonagregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botonagregar.BackgroundImage")));
            this.botonagregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.botonagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonagregar.Location = new System.Drawing.Point(585, 16);
            this.botonagregar.Name = "botonagregar";
            this.botonagregar.Size = new System.Drawing.Size(37, 24);
            this.botonagregar.TabIndex = 22;
            this.botonagregar.UseVisualStyleBackColor = true;
            this.botonagregar.Click += new System.EventHandler(this.botonagregar_Click);
            // 
            // id_areaTextBox
            // 
            this.id_areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documento_internoBindingSource, "id_area", true));
            this.id_areaTextBox.Location = new System.Drawing.Point(207, 134);
            this.id_areaTextBox.Name = "id_areaTextBox";
            this.id_areaTextBox.Size = new System.Drawing.Size(123, 22);
            this.id_areaTextBox.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(336, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombre_tramitanteTextBox
            // 
            this.nombre_tramitanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documento_internoBindingSource, "nombre_tramitante", true));
            this.nombre_tramitanteTextBox.Location = new System.Drawing.Point(18, 43);
            this.nombre_tramitanteTextBox.Multiline = true;
            this.nombre_tramitanteTextBox.Name = "nombre_tramitanteTextBox";
            this.nombre_tramitanteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.nombre_tramitanteTextBox.Size = new System.Drawing.Size(171, 41);
            this.nombre_tramitanteTextBox.TabIndex = 3;
            this.nombre_tramitanteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nombre_tramitanteTextBox_KeyPress);
            // 
            // dni_tramitanteTextBox
            // 
            this.dni_tramitanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documento_internoBindingSource, "dni_tramitante", true));
            this.dni_tramitanteTextBox.Location = new System.Drawing.Point(207, 43);
            this.dni_tramitanteTextBox.Name = "dni_tramitanteTextBox";
            this.dni_tramitanteTextBox.Size = new System.Drawing.Size(123, 22);
            this.dni_tramitanteTextBox.TabIndex = 5;
            this.dni_tramitanteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dni_tramitanteTextBox_KeyPress);
            // 
            // asunto_tramitanteTextBox
            // 
            this.asunto_tramitanteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documento_internoBindingSource, "asunto_tramitante", true));
            this.asunto_tramitanteTextBox.Location = new System.Drawing.Point(18, 107);
            this.asunto_tramitanteTextBox.Multiline = true;
            this.asunto_tramitanteTextBox.Name = "asunto_tramitanteTextBox";
            this.asunto_tramitanteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.asunto_tramitanteTextBox.Size = new System.Drawing.Size(171, 54);
            this.asunto_tramitanteTextBox.TabIndex = 7;
            // 
            // nombre_areaTextBox
            // 
            this.nombre_areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documento_internoBindingSource, "nombre_area", true));
            this.nombre_areaTextBox.Location = new System.Drawing.Point(207, 189);
            this.nombre_areaTextBox.Multiline = true;
            this.nombre_areaTextBox.Name = "nombre_areaTextBox";
            this.nombre_areaTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.nombre_areaTextBox.Size = new System.Drawing.Size(123, 50);
            this.nombre_areaTextBox.TabIndex = 11;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documento_internoBindingSource, "estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(207, 87);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(123, 24);
            this.estadoComboBox.TabIndex = 17;
            // 
            // observacionTextBox
            // 
            this.observacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.documento_internoBindingSource, "observacion", true));
            this.observacionTextBox.Location = new System.Drawing.Point(18, 189);
            this.observacionTextBox.Multiline = true;
            this.observacionTextBox.Name = "observacionTextBox";
            this.observacionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.observacionTextBox.Size = new System.Drawing.Size(171, 50);
            this.observacionTextBox.TabIndex = 19;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adm_sistemaTableAdapter = null;
            this.tableAdapterManager.areasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.detalle_documento_externoTableAdapter = null;
            this.tableAdapterManager.detalle_documento_internoTableAdapter = null;
            this.tableAdapterManager.documento_externoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.BTNELIMINAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNELIMINAR.Image")));
            this.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNELIMINAR.Location = new System.Drawing.Point(674, 271);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(160, 48);
            this.BTNELIMINAR.TabIndex = 59;
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
            this.BTNGUARDAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNGUARDAR.Image")));
            this.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGUARDAR.Location = new System.Drawing.Point(674, 207);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(160, 56);
            this.BTNGUARDAR.TabIndex = 58;
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
            this.BTNEDITAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNEDITAR.Image")));
            this.BTNEDITAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEDITAR.Location = new System.Drawing.Point(674, 90);
            this.BTNEDITAR.Name = "BTNEDITAR";
            this.BTNEDITAR.Size = new System.Drawing.Size(160, 51);
            this.BTNEDITAR.TabIndex = 56;
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
            this.BTNCANCELAR.Image = ((System.Drawing.Image)(resources.GetObject("BTNCANCELAR.Image")));
            this.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCANCELAR.Location = new System.Drawing.Point(674, 149);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(160, 50);
            this.BTNCANCELAR.TabIndex = 57;
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
            this.BTNNUEVO.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNUEVO.Image = ((System.Drawing.Image)(resources.GetObject("BTNNUEVO.Image")));
            this.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVO.Location = new System.Drawing.Point(674, 29);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(160, 53);
            this.BTNNUEVO.TabIndex = 55;
            this.BTNNUEVO.Text = "NUEVO";
            this.BTNNUEVO.UseVisualStyleBackColor = false;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Buscar por:";
            // 
            // cbbuscar
            // 
            this.cbbuscar.FormattingEnabled = true;
            this.cbbuscar.Items.AddRange(new object[] {
            "NOMBRE TRAMITANTE",
            "DNI",
            "AREA",
            "CODIGO MP"});
            this.cbbuscar.Location = new System.Drawing.Point(105, 404);
            this.cbbuscar.Name = "cbbuscar";
            this.cbbuscar.Size = new System.Drawing.Size(121, 24);
            this.cbbuscar.TabIndex = 61;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(232, 404);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(301, 22);
            this.txtbuscar.TabIndex = 62;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(539, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 25);
            this.button2.TabIndex = 63;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(573, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 25);
            this.button3.TabIndex = 64;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // documento_internoTableAdapter
            // 
            this.documento_internoTableAdapter.ClearBeforeFill = true;
            // 
            // documento_internoDataGridView
            // 
            this.documento_internoDataGridView.AutoGenerateColumns = false;
            this.documento_internoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.documento_internoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewImageColumn1});
            this.documento_internoDataGridView.DataSource = this.documento_internoBindingSource;
            this.documento_internoDataGridView.Location = new System.Drawing.Point(23, 434);
            this.documento_internoDataGridView.Name = "documento_internoDataGridView";
            this.documento_internoDataGridView.Size = new System.Drawing.Size(751, 220);
            this.documento_internoDataGridView.TabIndex = 64;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numero_correlativo";
            this.dataGridViewTextBoxColumn1.HeaderText = "numero_correlativo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "numero_registro_MP";
            this.dataGridViewTextBoxColumn2.HeaderText = "numero_registro_MP";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tipo_documento";
            this.dataGridViewTextBoxColumn3.HeaderText = "tipo_documento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "numero_folio";
            this.dataGridViewTextBoxColumn4.HeaderText = "numero_folio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "nombre_tramitante";
            this.dataGridViewTextBoxColumn5.HeaderText = "nombre_tramitante";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "dni_tramitante";
            this.dataGridViewTextBoxColumn6.HeaderText = "dni_tramitante";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "asunto_tramitante";
            this.dataGridViewTextBoxColumn7.HeaderText = "asunto_tramitante";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "id_area";
            this.dataGridViewTextBoxColumn8.HeaderText = "id_area";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "nombre_area";
            this.dataGridViewTextBoxColumn9.HeaderText = "nombre_area";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "fecha_registro";
            this.dataGridViewTextBoxColumn10.HeaderText = "fecha_registro";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn11.HeaderText = "estado";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "observacion";
            this.dataGridViewTextBoxColumn12.HeaderText = "observacion";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "imagen";
            this.dataGridViewImageColumn1.HeaderText = "imagen";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // FRMDOCUMETOINTERNO
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 728);
            this.Controls.Add(this.documento_internoDataGridView);
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
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.Name = "FRMDOCUMETOINTERNO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMDOCUMETOINTERNO";
            this.Activated += new System.EventHandler(this.FRMDOCUMETOINTERNO_Activated);
            this.Load += new System.EventHandler(this.FRMDOCUMETOINTERNO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numero_correlativoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documento_internoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numero_folioNumericUpDown)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documento_internoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DataSetTramite dataSetTramite;
        private System.Windows.Forms.BindingSource documento_internoBindingSource;
        private DataSetTramiteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.NumericUpDown numero_correlativoNumericUpDown;
        private System.Windows.Forms.TextBox tipo_documentoTextBox;
        private System.Windows.Forms.DateTimePicker fecha_registroDateTimePicker;
        private System.Windows.Forms.TextBox numero_registro_MPTextBox;
        private System.Windows.Forms.NumericUpDown numero_folioNumericUpDown;
        private System.Windows.Forms.TextBox nombre_tramitanteTextBox;
        private System.Windows.Forms.TextBox dni_tramitanteTextBox;
        private System.Windows.Forms.TextBox asunto_tramitanteTextBox;
        private System.Windows.Forms.TextBox nombre_areaTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.TextBox observacionTextBox;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNEDITAR;
        private System.Windows.Forms.Button BTNCANCELAR;
        private System.Windows.Forms.Button BTNNUEVO;
        private System.Windows.Forms.TextBox id_areaTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botonagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbuscar;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox imagenPictureBox;
        private DataSetTramiteTableAdapters.documento_internoTableAdapter documento_internoTableAdapter;
        private System.Windows.Forms.DataGridView documento_internoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}