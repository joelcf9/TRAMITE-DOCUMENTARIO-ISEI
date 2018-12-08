namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    partial class FRMSEGUIMIENTODOCUMENTOEXTERNO
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
            System.Windows.Forms.Label numero_respuesta_extLabel;
            System.Windows.Forms.Label numero_correlativoLabel;
            System.Windows.Forms.Label asuntoLabel;
            System.Windows.Forms.Label derivar_areaLabel;
            System.Windows.Forms.Label fecha_salidaLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label observacionLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.numero_respuesta_extTextBox = new System.Windows.Forms.TextBox();
            this.detalle_documento_externoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTramite = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramite();
            this.numero_correlativoTextBox = new System.Windows.Forms.TextBox();
            this.asuntoTextBox = new System.Windows.Forms.TextBox();
            this.derivar_areaComboBox = new System.Windows.Forms.ComboBox();
            this.fecha_salidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.observacionTextBox = new System.Windows.Forms.TextBox();
            this.detalle_documento_externoTableAdapter = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.detalle_documento_externoTableAdapter();
            this.tableAdapterManager = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager();
            this.detalle_documento_externoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNEDITAR = new System.Windows.Forms.Button();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.cbbuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            numero_respuesta_extLabel = new System.Windows.Forms.Label();
            numero_correlativoLabel = new System.Windows.Forms.Label();
            asuntoLabel = new System.Windows.Forms.Label();
            derivar_areaLabel = new System.Windows.Forms.Label();
            fecha_salidaLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            observacionLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_documento_externoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_documento_externoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // numero_respuesta_extLabel
            // 
            numero_respuesta_extLabel.AutoSize = true;
            numero_respuesta_extLabel.Location = new System.Drawing.Point(4, 30);
            numero_respuesta_extLabel.Name = "numero_respuesta_extLabel";
            numero_respuesta_extLabel.Size = new System.Drawing.Size(139, 16);
            numero_respuesta_extLabel.TabIndex = 0;
            numero_respuesta_extLabel.Text = "numero respuesta ext:";
            // 
            // numero_correlativoLabel
            // 
            numero_correlativoLabel.AutoSize = true;
            numero_correlativoLabel.Location = new System.Drawing.Point(21, 58);
            numero_correlativoLabel.Name = "numero_correlativoLabel";
            numero_correlativoLabel.Size = new System.Drawing.Size(122, 16);
            numero_correlativoLabel.TabIndex = 2;
            numero_correlativoLabel.Text = "numero correlativo:";
            // 
            // asuntoLabel
            // 
            asuntoLabel.AutoSize = true;
            asuntoLabel.Location = new System.Drawing.Point(92, 86);
            asuntoLabel.Name = "asuntoLabel";
            asuntoLabel.Size = new System.Drawing.Size(51, 16);
            asuntoLabel.TabIndex = 4;
            asuntoLabel.Text = "asunto:";
            // 
            // derivar_areaLabel
            // 
            derivar_areaLabel.AutoSize = true;
            derivar_areaLabel.Location = new System.Drawing.Point(59, 137);
            derivar_areaLabel.Name = "derivar_areaLabel";
            derivar_areaLabel.Size = new System.Drawing.Size(84, 16);
            derivar_areaLabel.TabIndex = 6;
            derivar_areaLabel.Text = "derivar area:";
            // 
            // fecha_salidaLabel
            // 
            fecha_salidaLabel.AutoSize = true;
            fecha_salidaLabel.Location = new System.Drawing.Point(59, 168);
            fecha_salidaLabel.Name = "fecha_salidaLabel";
            fecha_salidaLabel.Size = new System.Drawing.Size(84, 16);
            fecha_salidaLabel.TabIndex = 8;
            fecha_salidaLabel.Text = "fecha salida:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(62, 195);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(81, 16);
            descripcionLabel.TabIndex = 10;
            descripcionLabel.Text = "descripcion:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(90, 233);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(53, 16);
            estadoLabel.TabIndex = 12;
            estadoLabel.Text = "estado:";
            // 
            // observacionLabel
            // 
            observacionLabel.AutoSize = true;
            observacionLabel.Location = new System.Drawing.Point(57, 263);
            observacionLabel.Name = "observacionLabel";
            observacionLabel.Size = new System.Drawing.Size(86, 16);
            observacionLabel.TabIndex = 14;
            observacionLabel.Text = "observacion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(numero_respuesta_extLabel);
            this.groupBox1.Controls.Add(this.numero_respuesta_extTextBox);
            this.groupBox1.Controls.Add(numero_correlativoLabel);
            this.groupBox1.Controls.Add(this.numero_correlativoTextBox);
            this.groupBox1.Controls.Add(asuntoLabel);
            this.groupBox1.Controls.Add(this.asuntoTextBox);
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
            this.groupBox1.Location = new System.Drawing.Point(12, 105);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(481, 310);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REGISTRO DE SEGUIMIENTO DE DOCUMENTO";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Settings_48px;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(278, 55);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 24);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numero_respuesta_extTextBox
            // 
            this.numero_respuesta_extTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_externoBindingSource, "numero_respuesta_ext", true));
            this.numero_respuesta_extTextBox.Location = new System.Drawing.Point(181, 27);
            this.numero_respuesta_extTextBox.Name = "numero_respuesta_extTextBox";
            this.numero_respuesta_extTextBox.Size = new System.Drawing.Size(90, 22);
            this.numero_respuesta_extTextBox.TabIndex = 1;
            // 
            // detalle_documento_externoBindingSource
            // 
            this.detalle_documento_externoBindingSource.DataMember = "detalle_documento_externo";
            this.detalle_documento_externoBindingSource.DataSource = this.dataSetTramite;
            // 
            // dataSetTramite
            // 
            this.dataSetTramite.DataSetName = "DataSetTramite";
            this.dataSetTramite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // numero_correlativoTextBox
            // 
            this.numero_correlativoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_externoBindingSource, "numero_correlativo", true));
            this.numero_correlativoTextBox.Location = new System.Drawing.Point(181, 55);
            this.numero_correlativoTextBox.Name = "numero_correlativoTextBox";
            this.numero_correlativoTextBox.Size = new System.Drawing.Size(90, 22);
            this.numero_correlativoTextBox.TabIndex = 3;
            // 
            // asuntoTextBox
            // 
            this.asuntoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_externoBindingSource, "asunto", true));
            this.asuntoTextBox.Location = new System.Drawing.Point(181, 83);
            this.asuntoTextBox.Multiline = true;
            this.asuntoTextBox.Name = "asuntoTextBox";
            this.asuntoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.asuntoTextBox.Size = new System.Drawing.Size(272, 45);
            this.asuntoTextBox.TabIndex = 5;
            // 
            // derivar_areaComboBox
            // 
            this.derivar_areaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_externoBindingSource, "derivar_area", true));
            this.derivar_areaComboBox.FormattingEnabled = true;
            this.derivar_areaComboBox.Location = new System.Drawing.Point(181, 134);
            this.derivar_areaComboBox.Name = "derivar_areaComboBox";
            this.derivar_areaComboBox.Size = new System.Drawing.Size(272, 24);
            this.derivar_areaComboBox.TabIndex = 7;
            // 
            // fecha_salidaDateTimePicker
            // 
            this.fecha_salidaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.detalle_documento_externoBindingSource, "fecha_salida", true));
            this.fecha_salidaDateTimePicker.Location = new System.Drawing.Point(181, 164);
            this.fecha_salidaDateTimePicker.Name = "fecha_salidaDateTimePicker";
            this.fecha_salidaDateTimePicker.Size = new System.Drawing.Size(272, 22);
            this.fecha_salidaDateTimePicker.TabIndex = 9;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_externoBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(181, 192);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.descripcionTextBox.Size = new System.Drawing.Size(272, 32);
            this.descripcionTextBox.TabIndex = 11;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_externoBindingSource, "estado", true));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(181, 230);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(272, 24);
            this.estadoComboBox.TabIndex = 13;
            // 
            // observacionTextBox
            // 
            this.observacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalle_documento_externoBindingSource, "observacion", true));
            this.observacionTextBox.Location = new System.Drawing.Point(181, 260);
            this.observacionTextBox.Multiline = true;
            this.observacionTextBox.Name = "observacionTextBox";
            this.observacionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.observacionTextBox.Size = new System.Drawing.Size(272, 44);
            this.observacionTextBox.TabIndex = 15;
            // 
            // detalle_documento_externoTableAdapter
            // 
            this.detalle_documento_externoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adm_sistemaTableAdapter = null;
            this.tableAdapterManager.areasTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.detalle_documento_externoTableAdapter = this.detalle_documento_externoTableAdapter;
            this.tableAdapterManager.detalle_documento_internoTableAdapter = null;
            this.tableAdapterManager.documento_externoTableAdapter = null;
            this.tableAdapterManager.documento_internoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // detalle_documento_externoDataGridView
            // 
            this.detalle_documento_externoDataGridView.AllowUserToAddRows = false;
            this.detalle_documento_externoDataGridView.AllowUserToDeleteRows = false;
            this.detalle_documento_externoDataGridView.AutoGenerateColumns = false;
            this.detalle_documento_externoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalle_documento_externoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.detalle_documento_externoDataGridView.DataSource = this.detalle_documento_externoBindingSource;
            this.detalle_documento_externoDataGridView.Location = new System.Drawing.Point(12, 461);
            this.detalle_documento_externoDataGridView.Name = "detalle_documento_externoDataGridView";
            this.detalle_documento_externoDataGridView.ReadOnly = true;
            this.detalle_documento_externoDataGridView.Size = new System.Drawing.Size(625, 197);
            this.detalle_documento_externoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "numero_respuesta_ext";
            this.dataGridViewTextBoxColumn1.HeaderText = "numero_respuesta_ext";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "numero_correlativo";
            this.dataGridViewTextBoxColumn2.HeaderText = "numero_correlativo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "asunto";
            this.dataGridViewTextBoxColumn3.HeaderText = "asunto";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "derivar_area";
            this.dataGridViewTextBoxColumn4.HeaderText = "derivar_area";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fecha_salida";
            this.dataGridViewTextBoxColumn5.HeaderText = "fecha_salida";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn6.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn7.HeaderText = "estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "observacion";
            this.dataGridViewTextBoxColumn8.HeaderText = "observacion";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
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
            this.BTNGUARDAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Save_Archive_48px;
            this.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGUARDAR.Location = new System.Drawing.Point(499, 296);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(138, 53);
            this.BTNGUARDAR.TabIndex = 68;
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
            this.BTNEDITAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Edit_File_48px;
            this.BTNEDITAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEDITAR.Location = new System.Drawing.Point(499, 176);
            this.BTNEDITAR.Name = "BTNEDITAR";
            this.BTNEDITAR.Size = new System.Drawing.Size(138, 51);
            this.BTNEDITAR.TabIndex = 66;
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
            this.BTNCANCELAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Cancel_File_48px;
            this.BTNCANCELAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCANCELAR.Location = new System.Drawing.Point(499, 236);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(138, 51);
            this.BTNCANCELAR.TabIndex = 67;
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
            this.BTNNUEVO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNNUEVO.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Add_List_48px;
            this.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNNUEVO.Location = new System.Drawing.Point(499, 114);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(138, 53);
            this.BTNNUEVO.TabIndex = 65;
            this.BTNNUEVO.Text = "NUEVO";
            this.BTNNUEVO.UseVisualStyleBackColor = false;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
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
            this.BTNELIMINAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Delete_File_48px;
            this.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNELIMINAR.Location = new System.Drawing.Point(499, 358);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(138, 56);
            this.BTNELIMINAR.TabIndex = 69;
            this.BTNELIMINAR.Text = "ELIMINAR";
            this.BTNELIMINAR.UseVisualStyleBackColor = false;
            this.BTNELIMINAR.Click += new System.EventHandler(this.BTNELIMINAR_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Open_Folder_48px;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(561, 432);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 25);
            this.button3.TabIndex = 74;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Search_48px;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(527, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 25);
            this.button1.TabIndex = 73;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(220, 433);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(301, 22);
            this.txtbuscar.TabIndex = 72;
            // 
            // cbbuscar
            // 
            this.cbbuscar.FormattingEnabled = true;
            this.cbbuscar.Items.AddRange(new object[] {
            "NOMBRE TRAMITANTE",
            "DNI",
            "AREA",
            "CODIGO MP"});
            this.cbbuscar.Location = new System.Drawing.Point(93, 433);
            this.cbbuscar.Name = "cbbuscar";
            this.cbbuscar.Size = new System.Drawing.Size(121, 24);
            this.cbbuscar.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Buscar por:";
            // 
            // FRMSEGUIMIENTODOCUMENTOEXTERNO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 661);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.cbbuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNEDITAR);
            this.Controls.Add(this.BTNCANCELAR);
            this.Controls.Add(this.BTNNUEVO);
            this.Controls.Add(this.detalle_documento_externoDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMSEGUIMIENTODOCUMENTOEXTERNO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FRMSEGUIMIENTODOCUMENTOEXTERNO";
            this.Activated += new System.EventHandler(this.FRMSEGUIMIENTODOCUMENTOEXTERNO_Activated);
            this.Load += new System.EventHandler(this.FRMSEGUIMIENTODOCUMENTOEXTERNO_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_documento_externoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalle_documento_externoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DataSetTramite dataSetTramite;
        private System.Windows.Forms.BindingSource detalle_documento_externoBindingSource;
        private DataSetTramiteTableAdapters.detalle_documento_externoTableAdapter detalle_documento_externoTableAdapter;
        private DataSetTramiteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox numero_respuesta_extTextBox;
        private System.Windows.Forms.TextBox numero_correlativoTextBox;
        private System.Windows.Forms.TextBox asuntoTextBox;
        private System.Windows.Forms.ComboBox derivar_areaComboBox;
        private System.Windows.Forms.DateTimePicker fecha_salidaDateTimePicker;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.TextBox observacionTextBox;
        private System.Windows.Forms.DataGridView detalle_documento_externoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNEDITAR;
        private System.Windows.Forms.Button BTNCANCELAR;
        private System.Windows.Forms.Button BTNNUEVO;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbuscar;
        private System.Windows.Forms.ComboBox cbbuscar;
        private System.Windows.Forms.Label label1;
    }
}