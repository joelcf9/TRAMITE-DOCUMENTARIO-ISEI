namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    partial class FRMAREAS
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
            System.Windows.Forms.Label id_areaLabel;
            System.Windows.Forms.Label codigoLabel;
            System.Windows.Forms.Label encargardo_areaLabel;
            System.Windows.Forms.Label nombre_areaLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nombre_areaComboBox = new System.Windows.Forms.ComboBox();
            this.areasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetTramite = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramite();
            this.id_areaTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.encargardo_areaTextBox = new System.Windows.Forms.TextBox();
            this.areasTableAdapter = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.areasTableAdapter();
            this.tableAdapterManager = new SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager();
            this.areasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNELIMINAR = new System.Windows.Forms.Button();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.BTNEDITAR = new System.Windows.Forms.Button();
            this.BTNCANCELAR = new System.Windows.Forms.Button();
            this.BTNNUEVO = new System.Windows.Forms.Button();
            id_areaLabel = new System.Windows.Forms.Label();
            codigoLabel = new System.Windows.Forms.Label();
            encargardo_areaLabel = new System.Windows.Forms.Label();
            nombre_areaLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // id_areaLabel
            // 
            id_areaLabel.AutoSize = true;
            id_areaLabel.Location = new System.Drawing.Point(84, 26);
            id_areaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            id_areaLabel.Name = "id_areaLabel";
            id_areaLabel.Size = new System.Drawing.Size(53, 16);
            id_areaLabel.TabIndex = 0;
            id_areaLabel.Text = "id area:";
            id_areaLabel.Visible = false;
            // 
            // codigoLabel
            // 
            codigoLabel.AutoSize = true;
            codigoLabel.Location = new System.Drawing.Point(84, 69);
            codigoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            codigoLabel.Name = "codigoLabel";
            codigoLabel.Size = new System.Drawing.Size(53, 16);
            codigoLabel.TabIndex = 2;
            codigoLabel.Text = "codigo:";
            // 
            // encargardo_areaLabel
            // 
            encargardo_areaLabel.AutoSize = true;
            encargardo_areaLabel.Location = new System.Drawing.Point(25, 133);
            encargardo_areaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            encargardo_areaLabel.Name = "encargardo_areaLabel";
            encargardo_areaLabel.Size = new System.Drawing.Size(112, 16);
            encargardo_areaLabel.TabIndex = 6;
            encargardo_areaLabel.Text = "encargardo area:";
            // 
            // nombre_areaLabel
            // 
            nombre_areaLabel.AutoSize = true;
            nombre_areaLabel.Location = new System.Drawing.Point(49, 103);
            nombre_areaLabel.Name = "nombre_areaLabel";
            nombre_areaLabel.Size = new System.Drawing.Size(88, 16);
            nombre_areaLabel.TabIndex = 7;
            nombre_areaLabel.Text = "nombre area:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(nombre_areaLabel);
            this.groupBox1.Controls.Add(this.nombre_areaComboBox);
            this.groupBox1.Controls.Add(id_areaLabel);
            this.groupBox1.Controls.Add(this.id_areaTextBox);
            this.groupBox1.Controls.Add(codigoLabel);
            this.groupBox1.Controls.Add(this.codigoTextBox);
            this.groupBox1.Controls.Add(encargardo_areaLabel);
            this.groupBox1.Controls.Add(this.encargardo_areaTextBox);
            this.groupBox1.Location = new System.Drawing.Point(16, 44);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(470, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "AREAS DE LA UNIVERSIDAD TECNOLOGICA DE LOS ANDES";
            // 
            // nombre_areaComboBox
            // 
            this.nombre_areaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areasBindingSource, "nombre_area", true));
            this.nombre_areaComboBox.FormattingEnabled = true;
            this.nombre_areaComboBox.Items.AddRange(new object[] {
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
            this.nombre_areaComboBox.Location = new System.Drawing.Point(157, 99);
            this.nombre_areaComboBox.Name = "nombre_areaComboBox";
            this.nombre_areaComboBox.Size = new System.Drawing.Size(291, 24);
            this.nombre_areaComboBox.TabIndex = 8;
            // 
            // areasBindingSource
            // 
            this.areasBindingSource.DataMember = "areas";
            this.areasBindingSource.DataSource = this.dataSetTramite;
            // 
            // dataSetTramite
            // 
            this.dataSetTramite.DataSetName = "DataSetTramite";
            this.dataSetTramite.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // id_areaTextBox
            // 
            this.id_areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areasBindingSource, "id_area", true));
            this.id_areaTextBox.Location = new System.Drawing.Point(157, 23);
            this.id_areaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.id_areaTextBox.Name = "id_areaTextBox";
            this.id_areaTextBox.Size = new System.Drawing.Size(96, 22);
            this.id_areaTextBox.TabIndex = 1;
            this.id_areaTextBox.Visible = false;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areasBindingSource, "codigo", true));
            this.codigoTextBox.Location = new System.Drawing.Point(157, 66);
            this.codigoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.Size = new System.Drawing.Size(204, 22);
            this.codigoTextBox.TabIndex = 3;
            // 
            // encargardo_areaTextBox
            // 
            this.encargardo_areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areasBindingSource, "encargardo_area", true));
            this.encargardo_areaTextBox.Location = new System.Drawing.Point(157, 130);
            this.encargardo_areaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.encargardo_areaTextBox.Name = "encargardo_areaTextBox";
            this.encargardo_areaTextBox.Size = new System.Drawing.Size(291, 22);
            this.encargardo_areaTextBox.TabIndex = 7;
            // 
            // areasTableAdapter
            // 
            this.areasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.adm_sistemaTableAdapter = null;
            this.tableAdapterManager.areasTableAdapter = this.areasTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.detalle_documento_externoTableAdapter = null;
            this.tableAdapterManager.detalle_documento_internoTableAdapter = null;
            this.tableAdapterManager.documento_externoTableAdapter = null;
            this.tableAdapterManager.documento_internoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SISTEMA_TRAMITE_DOCUMENTARIO.DataSetTramiteTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // areasDataGridView
            // 
            this.areasDataGridView.AllowUserToAddRows = false;
            this.areasDataGridView.AllowUserToDeleteRows = false;
            this.areasDataGridView.AutoGenerateColumns = false;
            this.areasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.areasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.areasDataGridView.DataSource = this.areasBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.areasDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.areasDataGridView.Location = new System.Drawing.Point(19, 258);
            this.areasDataGridView.Name = "areasDataGridView";
            this.areasDataGridView.ReadOnly = true;
            this.areasDataGridView.Size = new System.Drawing.Size(467, 220);
            this.areasDataGridView.TabIndex = 69;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_area";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_area";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "codigo";
            this.dataGridViewTextBoxColumn2.HeaderText = "codigo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombre_area";
            this.dataGridViewTextBoxColumn3.HeaderText = "nombre_area";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "encargardo_area";
            this.dataGridViewTextBoxColumn4.HeaderText = "encargardo_area";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
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
            this.BTNELIMINAR.Location = new System.Drawing.Point(494, 351);
            this.BTNELIMINAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNELIMINAR.Name = "BTNELIMINAR";
            this.BTNELIMINAR.Size = new System.Drawing.Size(148, 76);
            this.BTNELIMINAR.TabIndex = 69;
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
            this.BTNGUARDAR.Image = global::SISTEMA_TRAMITE_DOCUMENTARIO.Properties.Resources.Save_Archive_48px;
            this.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNGUARDAR.Location = new System.Drawing.Point(494, 278);
            this.BTNGUARDAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(148, 58);
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
            this.BTNEDITAR.Location = new System.Drawing.Point(494, 122);
            this.BTNEDITAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNEDITAR.Name = "BTNEDITAR";
            this.BTNEDITAR.Size = new System.Drawing.Size(148, 63);
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
            this.BTNCANCELAR.Location = new System.Drawing.Point(494, 200);
            this.BTNCANCELAR.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCANCELAR.Name = "BTNCANCELAR";
            this.BTNCANCELAR.Size = new System.Drawing.Size(148, 63);
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
            this.BTNNUEVO.Location = new System.Drawing.Point(494, 52);
            this.BTNNUEVO.Margin = new System.Windows.Forms.Padding(4);
            this.BTNNUEVO.Name = "BTNNUEVO";
            this.BTNNUEVO.Size = new System.Drawing.Size(148, 55);
            this.BTNNUEVO.TabIndex = 65;
            this.BTNNUEVO.Text = "NUEVO";
            this.BTNNUEVO.UseVisualStyleBackColor = false;
            this.BTNNUEVO.Click += new System.EventHandler(this.BTNNUEVO_Click);
            // 
            // FRMAREAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 490);
            this.Controls.Add(this.areasDataGridView);
            this.Controls.Add(this.BTNELIMINAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.BTNEDITAR);
            this.Controls.Add(this.BTNCANCELAR);
            this.Controls.Add(this.BTNNUEVO);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FRMAREAS";
            this.Text = "FRMAREAS";
            this.Load += new System.EventHandler(this.FRMAREAS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.areasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetTramite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areasDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private DataSetTramite dataSetTramite;
        private System.Windows.Forms.BindingSource areasBindingSource;
        private DataSetTramiteTableAdapters.areasTableAdapter areasTableAdapter;
        private DataSetTramiteTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox id_areaTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.TextBox encargardo_areaTextBox;
        private System.Windows.Forms.Button BTNELIMINAR;
        private System.Windows.Forms.Button BTNGUARDAR;
        private System.Windows.Forms.Button BTNEDITAR;
        private System.Windows.Forms.Button BTNCANCELAR;
        private System.Windows.Forms.Button BTNNUEVO;
        private System.Windows.Forms.DataGridView areasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ComboBox nombre_areaComboBox;
    }
}