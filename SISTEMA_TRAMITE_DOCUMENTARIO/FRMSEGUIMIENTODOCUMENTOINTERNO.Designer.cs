namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    partial class FRMSEGUIMIENTODOCUMENTOINTERNO
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
            System.Windows.Forms.Label numero_respuesta_intLabel;
            System.Windows.Forms.Label numero_correlativoLabel;
            System.Windows.Forms.Label derivar_areaLabel;
            System.Windows.Forms.Label fecha_salidaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label observacionLabel;
            System.Windows.Forms.Label asunto_documentoLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numero_respuesta_intTextBox = new System.Windows.Forms.TextBox();
            this.detalle_documento_internoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTramite = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramite();
            this.numero_correlativoTextBox = new System.Windows.Forms.TextBox();
            this.derivar_areaComboBox = new System.Windows.Forms.ComboBox();
            this.fecha_salidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.observacionTextBox = new System.Windows.Forms.TextBox();
            this.asunto_documentoTextBox = new System.Windows.Forms.TextBox();
            this.detalle_documento_internoTableAdapter = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.detalle_documento_internoTableAdapter();
            this.tableAdapterManager = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNEDITAR = new System.Windows.Forms.Button();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.detalle_documento_internoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cbbuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            numero_respuesta_intLabel = new System.Windows.Forms.Label();
            numero_correlativoLabel = new System.Windows.Forms.Label();
            derivar_areaLabel = new System.Windows.Forms.Label();
            fecha_salidaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            observacionLabel = new System.Windows.Forms.Label();
            asunto_documentoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_documento_internoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_documento_internoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // numero_respuesta_intLabel
            // 
            numero_respuesta_intLabel.AutoSize = true;
            numero_respuesta_intLabel.Location = new System.Drawing.Point(8, 27);
            numero_respuesta_intLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numero_respuesta_intLabel.Name = "numero_respuesta_intLabel";
            numero_respuesta_intLabel.Size = new System.Drawing.Size(135, 16);
            numero_respuesta_intLabel.TabIndex = 0;
            numero_respuesta_intLabel.Text = "numero respuesta int:";
            numero_respuesta_intLabel.Visible = false;
            // 
            // numero_correlativoLabel
            // 
            numero_correlativoLabel.AutoSize = true;
            numero_correlativoLabel.Location = new System.Drawing.Point(21, 59);
            numero_correlativoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            numero_correlativoLabel.Name = "numero_correlativoLabel";
            numero_correlativoLabel.Size = new System.Drawing.Size(122, 16);
            numero_correlativoLabel.TabIndex = 2;
            numero_correlativoLabel.Text = "numero correlativo:";
            // 
            // derivar_areaLabel
            // 
            derivar_areaLabel.AutoSize = true;
            derivar_areaLabel.Location = new System.Drawing.Point(59, 154);
            derivar_areaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            derivar_areaLabel.Name = "derivar_areaLabel";
            derivar_areaLabel.Size = new System.Drawing.Size(84, 16);
            derivar_areaLabel.TabIndex = 4;
            derivar_areaLabel.Text = "derivar area:";
            // 
            // fecha_salidaLabel
            // 
            fecha_salidaLabel.AutoSize = true;
            fecha_salidaLabel.Location = new System.Drawing.Point(59, 188);
            fecha_salidaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            fecha_salidaLabel.Name = "fecha_salidaLabel";
            fecha_salidaLabel.Size = new System.Drawing.Size(84, 16);
            fecha_salidaLabel.TabIndex = 6;
            fecha_salidaLabel.Text = "fecha salida:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(62, 219);
            descripcionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(81, 16);
            descripcionLabel.TabIndex = 8;
            descripcionLabel.Text = "descripcion:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(90, 272);
            estadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(53, 16);
            estadoLabel.TabIndex = 10;
            estadoLabel.Text = "estado:";
            // 
            // observacionLabel
            // 
            observacionLabel.AutoSize = true;
            observacionLabel.Location = new System.Drawing.Point(57, 305);
            observacionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            observacionLabel.Name = "observacionLabel";
            observacionLabel.Size = new System.Drawing.Size(86, 16);
            observacionLabel.TabIndex = 12;
            observacionLabel.Text = "observacion:";
            // 
            // asunto_documentoLabel
            // 
            asunto_documentoLabel.AutoSize = true;
            asunto_documentoLabel.Location = new System.Drawing.Point(22, 91);
            asunto_documentoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            asunto_documentoLabel.Name = "asunto_documentoLabel";
            asunto_documentoLabel.Size = new System.Drawing.Size(121, 16);
            asunto_documentoLabel.TabIndex = 14;
            asunto_documentoLabel.Text = "asunto documento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(numero_respuesta_intLabel);
            this.groupBox1.Controls.Add(this.numero_respuesta_intTextBox);
            this.groupBox1.Controls.Add(numero_correlativoLabel);
            this.groupBox1.Controls.Add(this.numero_correlativoTextBox);
            this.groupBox1.Controls.Add(derivar_areaLabel);
            this.groupBox1.Controls.Add(this.derivar_areaComboBox);
            this.groupBox1.Controls.Add(fecha_salidaLabel);
            this.groupBox1.Controls.Add(this.fecha_salidaDateTimePicker);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Controls.Add(this.estadoComboBox);
            this.groupBox1.Controls.Add(observacionLabel);
            this.groupBox1.Controls.Add(this.observacionTextBox);
            this.groupBox1.Controls.Add(asunto_documentoLabel);
            this.groupBox1.Controls.Add(this.asunto_documentoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 95);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(460, 379);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO SEGUIMIENTO DEL DOCUMENTO";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Settings_48px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(251, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 24);
            this.button1.TabIndex = 21;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numero_respuesta_intTextBox
            // 
            this.numero_respuesta_intTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_internoBindingSource, "numero_respuesta_int", true));
            this.numero_respuesta_intTextBox.Location = new System.Drawing.Point(151, 23);
            this.numero_respuesta_intTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numero_respuesta_intTextBox.Name = "numero_respuesta_intTextBox";
            this.numero_respuesta_intTextBox.Size = new System.Drawing.Size(92, 22);
            this.numero_respuesta_intTextBox.TabIndex = 1;
            this.numero_respuesta_intTextBox.Visible = false;
            // 
            // detalle_documento_internoBindingSource
            // 
            this.detalle_documento_internoBindingSource.DataMember = "detalle_documento_interno";
            this.detalle_documento_internoBindingSource.DataSource = this.dataSetTramite;
            // 
            // dataSetTramite
            // 
            this.dataSetTramite.DataSetName = "DataSetTramite";
            this.dataSetTramite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numero_correlativoTextBox
            // 
            this.numero_correlativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_internoBindingSource, "numero_correlativo", true));
            this.numero_correlativoTextBox.Location = new System.Drawing.Point(151, 55);
            this.numero_correlativoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.numero_correlativoTextBox.Name = "numero_correlativoTextBox";
            this.numero_correlativoTextBox.Size = new System.Drawing.Size(92, 22);
            this.numero_correlativoTextBox.TabIndex = 3;
            // 
            // derivar_areaComboBox
            // 
            this.derivar_areaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_internoBindingSource, "derivar_area", true));
            this.derivar_areaComboBox.FormattingEnabled = true;
            this.derivar_areaComboBox.Items.AddRange(new object[] {
            "RECTORADO(R)",
            "VICE RECTORADO ACADEMICO (VRA)",
            "VICE RECTORADO DE INVESTIGACION",
            "OFICINA DE CONTROL INTERNO (OCI)",
            "OFICINA DE ASESORIA JURIDICA (AOJ)",
            "OFICINA DE IMAGEN INSTITUCIONAL (OII)",
            "OFICINA DE PLANIFICACION DE DESARROLLO UNIVERSITARIO (OPDU)",
            "OF. COOPERACION TECNICA Y RALACIONES UNIVERSITARIAS",
            "DIRECCION GENERAL DE ADMINISTRACION (GIGA)",
            "SUB DIRECCION DE CONTABILIDAD (SD. CONT.)",
            "SUB DIRECCION DE TESORERIA",
            "AREA CUENTAS POR COBRAR",
            "SUB DIRECCION DE LOGISTICA Y SERVICIOS GENERALES",
            "SUB DIRECCION DE PROYECTOS Y OBRAS",
            "SUB DIRECCION DE RECURSOS HUMANOS",
            "SUB DIRECCION DE PRODUCCIONES DE BIENES Y SERVICIOS",
            "DIRECCION  DE SERVICIOS ACADEMICOS",
            "SUB DIRECCION DE COMPUTO E INFORMATICA",
            "DIRECCION DE RESPONSABILIDAD SOCIAL",
            "BIBLIOTECA",
            "BIENESTAR UNIVERSITARIO",
            "GRADOS Y TITULOS",
            "TRIBUNAL DE HONOR",
            "CAJA",
            "DIRECCION DE LA ESCUELA DE PROSGRADO (EPG)",
            "DIRECCION DE CALIDAD Y ACREDITACION UNIVERSITARIA (DCAU)",
            "FACULTAD DE CIENCIAS JURIDICAS, CONTABLES Y SOCIALES",
            "ESCUELA PROFECIONAL DE DERECHO",
            "ESCUELA PROFECIONAL DE CONTABILIDAD",
            "ESCUELA PROFECIONAL DE EDUCACION",
            "ESCUELA PROFECIONAL DE TURISMO, HOTELERIA Y GASTRONOMIA",
            "FACULTAD DE CIENCIAS DE LA SALUD",
            "ESCUELA PROFECIONAL DE ENFERMAERIA",
            "ESCUELA PROFECIONAL DE ESTOMOLOGIA",
            "FACULTAD DE INGENIERIA",
            "ESCUELA PROFECIONAL DE AGRONOMIA",
            "ESCUELA PROFECIONAL DE INGENIERIA AMBIENTAL Y RECURSOS NATURALES",
            "ESCUELA PROFECIONAL DE INGENIERIA CIVIL",
            "ESCUELA PROFECIONAL DE INGENIERIA DE SISTEMAS E INFORMATICA"});
            this.derivar_areaComboBox.Location = new System.Drawing.Point(151, 150);
            this.derivar_areaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.derivar_areaComboBox.Name = "derivar_areaComboBox";
            this.derivar_areaComboBox.Size = new System.Drawing.Size(293, 24);
            this.derivar_areaComboBox.TabIndex = 5;
            // 
            // fecha_salidaDateTimePicker
            // 
            this.fecha_salidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.detalle_documento_internoBindingSource, "fecha_salida", true));
            this.fecha_salidaDateTimePicker.Location = new System.Drawing.Point(151, 183);
            this.fecha_salidaDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.fecha_salidaDateTimePicker.Name = "fecha_salidaDateTimePicker";
            this.fecha_salidaDateTimePicker.Size = new System.Drawing.Size(293, 22);
            this.fecha_salidaDateTimePicker.TabIndex = 7;
            this.fecha_salidaDateTimePicker.ValueChanged += new System.EventHandler(this.fecha_salidaDateTimePicker_ValueChanged);
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_internoBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(151, 215);
            this.descripcionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descripcionTextBox.Size = new System.Drawing.Size(293, 45);
            this.descripcionTextBox.TabIndex = 9;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_internoBindingSource, "estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Items.AddRange(new object[] {
            "REVISADO",
            "DERIVADO",
            "RECHASADO",
            "OBSERVADO"});
            this.estadoComboBox.Location = new System.Drawing.Point(151, 268);
            this.estadoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(171, 24);
            this.estadoComboBox.TabIndex = 11;
            // 
            // observacionTextBox
            // 
            this.observacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_internoBindingSource, "observacion", true));
            this.observacionTextBox.Location = new System.Drawing.Point(151, 302);
            this.observacionTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.observacionTextBox.Multiline = true;
            this.observacionTextBox.Name = "observacionTextBox";
            this.observacionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.observacionTextBox.Size = new System.Drawing.Size(293, 51);
            this.observacionTextBox.TabIndex = 13;
            // 
            // asunto_documentoTextBox
            // 
            this.asunto_documentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_internoBindingSource, "asunto", true));
            this.asunto_documentoTextBox.Location = new System.Drawing.Point(151, 87);
            this.asunto_documentoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.asunto_documentoTextBox.Multiline = true;
            this.asunto_documentoTextBox.Name = "asunto_documentoTextBox";
            this.asunto_documentoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.asunto_documentoTextBox.Size = new System.Drawing.Size(293, 54);
            this.asunto_documentoTextBox.TabIndex = 15;
            // 
            // detalle_documento_internoTableAdapter
            // 
            this.detalle_documento_internoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adm_sistemaTableAdapter = null;
            this.tableAdapterManager.areasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.detalle_documento_externoTableAdapter = null;
            this.tableAdapterManager.detalle_documento_internoTableAdapter = this.detalle_documento_internoTableAdapter;
            this.tableAdapterManager.documento_externoTableAdapter = null;
            this.tableAdapterManager.documento_internoTableAdapter = null;
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
            this.BTNELIMINAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNELIMINAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Delete_File_48px;
            this.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNELIMINAR.Location = new System.Drawing.Point(484, 398);
            this.BTNELIMINAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(135, 59);
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
            this.BTNGUARDAR.Location = new System.Drawing.Point(484, 323);
            this.BTNGUARDAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(135, 59);
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
            this.BTNEDITAR.Location = new System.Drawing.Point(484, 170);
            this.BTNEDITAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNEDITAR.Name = "BTNEDITAR";
            this.BTNEDITAR.Size = new System.Drawing.Size(135, 62);
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
            this.BTNCANCELAR.Location = new System.Drawing.Point(484, 248);
            this.BTNCANCELAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(135, 59);
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
            this.BTNNUEVO.Location = new System.Drawing.Point(484, 98);
            this.BTNNUEVO.Margin = new System.Windows.Forms.Padding(4);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(135, 56);
            this.BTNNUEVO.TabIndex = 60;
            this.BTNNUEVO.Text = "NUEVO";
            this.BTNNUEVO.UseVisualStyleBackColor = false;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
            // 
            // detalle_documento_internoDataGridView
            // 
            this.detalle_documento_internoDataGridView.AutoGenerateColumns = false;
            this.detalle_documento_internoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalle_documento_internoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9});
            this.detalle_documento_internoDataGridView.DataSource = this.detalle_documento_internoBindingSource;
            this.detalle_documento_internoDataGridView.Location = new System.Drawing.Point(16, 517);
            this.detalle_documento_internoDataGridView.Name = "detalle_documento_internoDataGridView";
            this.detalle_documento_internoDataGridView.Size = new System.Drawing.Size(664, 220);
            this.detalle_documento_internoDataGridView.TabIndex = 64;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numero_respuesta_int";
            this.dataGridViewTextBoxColumn1.HeaderText = "numero_respuesta_int";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "numero_correlativo";
            this.dataGridViewTextBoxColumn2.HeaderText = "numero_correlativo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "asunto";
            this.dataGridViewTextBoxColumn3.HeaderText = "asunto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "derivar_area";
            this.dataGridViewTextBoxColumn4.HeaderText = "derivar_area";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fecha_salida";
            this.dataGridViewTextBoxColumn5.HeaderText = "fecha_salida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn7.HeaderText = "estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "observacion";
            this.dataGridViewTextBoxColumn9.HeaderText = "observacion";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Open_Folder_48px;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(566, 488);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 25);
            this.button3.TabIndex = 79;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Search_48px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(532, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 25);
            this.button2.TabIndex = 78;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(225, 489);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(301, 22);
            this.txtbuscar.TabIndex = 77;
            // 
            // cbbuscar
            // 
            this.cbbuscar.FormattingEnabled = true;
            this.cbbuscar.Items.AddRange(new object[] {
            "NOMBRE TRAMITANTE",
            "DNI",
            "AREA",
            "CODIGO MP"});
            this.cbbuscar.Location = new System.Drawing.Point(98, 489);
            this.cbbuscar.Name = "cbbuscar";
            this.cbbuscar.Size = new System.Drawing.Size(121, 24);
            this.cbbuscar.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 75;
            this.label1.Text = "Buscar por:";
            // 
            // FRMSEGUIMIENTODOCUMENTOINTERNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(692, 749);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.cbbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detalle_documento_internoDataGridView);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNEDITAR);
            this.Controls.Add(this.BTNCANCELAR);
            this.Controls.Add(this.BTNNUEVO);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMSEGUIMIENTODOCUMENTOINTERNO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRMSEGUIMIENTODOCUMENTO";
            this.Activated += new System.EventHandler(this.FRMSEGUIMIENTODOCUMENTOINTERNO_Activated);
            this.Load += new System.EventHandler(this.FRMSEGUIMIENTODOCUMENTOINTERNO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_documento_internoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_documento_internoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DataSetTramite dataSetTramite;
        private System.Windows.Forms.BindingSource detalle_documento_internoBindingSource;
        private DataSetTramiteTableAdapters.detalle_documento_internoTableAdapter detalle_documento_internoTableAdapter;
        private DataSetTramiteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox numero_respuesta_intTextBox;
        private System.Windows.Forms.TextBox numero_correlativoTextBox;
        private System.Windows.Forms.ComboBox derivar_areaComboBox;
        private System.Windows.Forms.DateTimePicker fecha_salidaDateTimePicker;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.TextBox observacionTextBox;
        private System.Windows.Forms.TextBox asunto_documentoTextBox;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNEDITAR;
        private System.Windows.Forms.Button BTNCANCELAR;
        private System.Windows.Forms.Button BTNNUEVO;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridView detalle_documento_internoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cbbuscar;
        private System.Windows.Forms.Label label1;
    }
}