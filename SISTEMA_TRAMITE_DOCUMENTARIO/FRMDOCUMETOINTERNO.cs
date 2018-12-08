using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    public partial class FRMDOCUMETOINTERNO : Form
    {
        DateTime fecha = DateTime.UtcNow;
        //string formato = "ddd MMM yyyy  HH mm";

        public FRMDOCUMETOINTERNO()
        {
            InitializeComponent();
        }

        private void documento_internoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.documento_internoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTramite);

        }
        public void cargardatos()
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
            this.documento_internoTableAdapter.Fill(this.dataSetTramite.documento_interno);

        }
        private void FRMDOCUMETOINTERNO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
            this.documento_internoTableAdapter.Fill(this.dataSetTramite.documento_interno);

            BTNGUARDAR.Tag = "Guardar";
            cargardatos();
            botones_desactivados();
            BTNNUEVO.Enabled = true;
            BTNEDITAR.Enabled = true;
            BTNCANCELAR.Enabled = false;
            BTNELIMINAR.Enabled = true;
            BTNGUARDAR.Enabled = false;
        }
        public void botones_activos()
        {
            numero_correlativoNumericUpDown.Enabled = false;
            nombre_tramitanteTextBox.Enabled = true;
            dni_tramitanteTextBox.Enabled = true;
            asunto_tramitanteTextBox.Enabled = true;
            id_areaTextBox.Enabled = true;
            nombre_areaTextBox.Enabled = true;
            tipo_documentoTextBox.Enabled = true;
            fecha_registroDateTimePicker.Enabled = true;
            estadoComboBox.Enabled = true;
            observacionTextBox.Enabled = true;
            numero_registro_MPTextBox.Enabled = true;
            numero_folioNumericUpDown.Enabled = true;
            button1.Enabled = true;
            botonagregar.Enabled = true;


        }
        public void botones_desactivados()
        {

            numero_correlativoNumericUpDown.Enabled = false;
            nombre_tramitanteTextBox.Enabled = false;
            dni_tramitanteTextBox.Enabled = false;
            asunto_tramitanteTextBox.Enabled = false;
            id_areaTextBox.Enabled = false;
            nombre_areaTextBox.Enabled = false;
            tipo_documentoTextBox.Enabled = false;
            fecha_registroDateTimePicker.Enabled = false;
            estadoComboBox.Enabled = false;
            observacionTextBox.Enabled = false;
            numero_registro_MPTextBox.Enabled = false;
            numero_folioNumericUpDown.Enabled = false;
            button1.Enabled = false;
            botonagregar.Enabled = false;
        }
        private void fecha_registroDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            documento_internoBindingSource.AddNew();
            BTNGUARDAR.Tag = "GuardarI";
            botones_activos();
            numero_correlativoNumericUpDown.Focus();
            fecha_registroDateTimePicker.Text = fecha.ToString();

            BTNNUEVO.Enabled = false;
            BTNEDITAR.Enabled = false;
            BTNCANCELAR.Enabled = true;
            BTNELIMINAR.Enabled = false;
            BTNGUARDAR.Enabled = true;
        }

        private void BTNEDITAR_Click(object sender, EventArgs e)
        {
            botones_activos();
            BTNNUEVO.Enabled = false;
            BTNEDITAR.Enabled = false;
            BTNCANCELAR.Enabled = true;
            BTNELIMINAR.Enabled = false;
            BTNGUARDAR.Enabled = true;

            BTNGUARDAR.Tag = "GuardarE";
        }

        private void BTNCANCELAR_Click(object sender, EventArgs e)
        {
            botones_desactivados();

            BTNNUEVO.Enabled = true;
            BTNEDITAR.Enabled = true;
            BTNCANCELAR.Enabled = false;
            BTNELIMINAR.Enabled = true;
            BTNGUARDAR.Enabled = false;
            cargardatos();
        }

        private void BTNGUARDAR_Click(object sender, EventArgs e)
        {
            if (BTNGUARDAR.Tag == "GuardarI")
            {
                if (MessageBox.Show("¿Desea guardar?", "Guardar",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
       == DialogResult.Yes)
                {
                    try
                    {
                        this.Validate();
                        this.documento_internoBindingSource.EndEdit();
                        this.documento_internoTableAdapter.Update(this.dataSetTramite);
                        this.tableAdapterManager.UpdateAll(this.dataSetTramite);

                        BTNNUEVO.Enabled = true;
                        BTNEDITAR.Enabled = true;
                        BTNCANCELAR.Enabled = false;
                        BTNELIMINAR.Enabled = true;
                        BTNGUARDAR.Enabled = false;

                        MessageBox.Show("Documento Guardado");

                        botones_desactivados();
                        cargardatos();
                    }


                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }
                   
                }
           
            }
            else if (BTNGUARDAR.Tag == "GuardarE")
            {
                 try
                {
                    this.Validate();
                    this.documento_internoBindingSource.EndEdit();
                    documento_internoTableAdapter.Update(this.dataSetTramite);

                    BTNNUEVO.Enabled = true;
                    BTNEDITAR.Enabled = true;
                    BTNCANCELAR.Enabled = false;
                    BTNELIMINAR.Enabled = true;
                    BTNGUARDAR.Enabled = true;
                    botones_desactivados();
                    cargardatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }


        private void BTNELIMINAR_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("¿Desea Eliminar?", "Eliminar",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question)
       == DialogResult.Yes)
            {
                try
                {

                    documento_internoBindingSource.RemoveCurrent();
                    this.Validate();
                    documento_internoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dataSetTramite);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
      
            }
        }

        private void numero_registro_MPTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsNumber(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void nombre_tramitanteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            //if (Char.IsLetter(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = false;
        }

        private void dni_tramitanteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsNumber(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMBUSCARAREA area = new FRMBUSCARAREA();
            area.Show();
        }

        private void FRMDOCUMETOINTERNO_Activated(object sender, EventArgs e)
        {
            id_areaTextBox.Text = FRMBUSCARAREA.IdArea;
            nombre_areaTextBox.Text = FRMBUSCARAREA.NombreArea;
        }

        private void botonagregar_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog a = new OpenFileDialog();
                string piclocation;

                a.Filter = null;
                piclocation = a.FileName;
                a.ShowDialog();
                imagenPictureBox.Image = Image.FromFile(a.FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.cbbuscar.Text=="NOMBRE TRAMITANTE")
            {
                 // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
            this.documento_internoTableAdapter.buscarnombretramitante(this.dataSetTramite.documento_interno,txtbuscar.Text);
            }
            else if (this.cbbuscar.Text == "DNI")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.documento_internoTableAdapter.buscardni(this.dataSetTramite.documento_interno, txtbuscar.Text);
            }
            else if (this.cbbuscar.Text == "AREA")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.documento_internoTableAdapter.buscarporarea(this.dataSetTramite.documento_interno, txtbuscar.Text);
            }
            else if (this.cbbuscar.Text == "CODIGO MP")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.documento_internoTableAdapter.buscarporcodigoMP(this.dataSetTramite.documento_interno, txtbuscar.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.documento_internoTableAdapter.buscartodo(this.dataSetTramite.documento_interno);

        }


 
   


    }
}
