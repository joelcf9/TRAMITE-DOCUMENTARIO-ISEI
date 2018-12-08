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
    public partial class FRMDOCUMENTOEXTERNO : Form
    {
        DateTime fecha = DateTime.UtcNow;
        //string formato = "MMM ddd d HH mm";
        public FRMDOCUMENTOEXTERNO()
        {
            InitializeComponent();
        }

        private void documento_externoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.documentoexternoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTramite);

        }
        public void cargardatos()
        {
            //// TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_externo' Puede moverla o quitarla según sea necesario.
            this.documento_externoTableAdapter.Fill(this.dataSetTramite.documento_externo);

        }
        private void FRMDOCUMENTOEXTERNO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.detalle_documento_externo' Puede moverla o quitarla según sea necesario.
            this.detalle_documento_externoTableAdapter.Fill(this.dataSetTramite.detalle_documento_externo);
            // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_externo' Puede moverla o quitarla según sea necesario.
            this.documento_externoTableAdapter.Fill(this.dataSetTramite.documento_externo);
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
            id_areaComboBox.Enabled = true;
            nombre_areaTextBox.Enabled = true;
            tipo_documentoTextBox.Enabled = true;
            fecha_registroDateTimePicker.Enabled = true;
            estadoComboBox.Enabled = true;
            observacionTextBox.Enabled = true;
            numero_registro_MPTextBox.Enabled = true;
            numero_folioNumericUpDown.Enabled = true;
            imagenPictureBox.Enabled = true;
            botonagregar.Enabled = true;

        }
        public void botones_desactivados()
        {

            numero_correlativoNumericUpDown.Enabled = false;
            nombre_tramitanteTextBox.Enabled = false;
            dni_tramitanteTextBox.Enabled = false;
            asunto_tramitanteTextBox.Enabled = false;
            id_areaComboBox.Enabled = false;
            nombre_areaTextBox.Enabled = false;
            tipo_documentoTextBox.Enabled = false;
            fecha_registroDateTimePicker.Enabled = false;
            estadoComboBox.Enabled = false;
            observacionTextBox.Enabled = false;
            numero_registro_MPTextBox.Enabled = false;
            numero_folioNumericUpDown.Enabled = false;
            imagenPictureBox.Enabled = false;
            botonagregar.Enabled = false;

        }
        private void BTNNUEVO_Click(object sender, EventArgs e)
        {

            documentoexternoBindingSource.AddNew();
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
                        this.documentoexternoBindingSource.EndEdit();
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
                    this.documentoexternoBindingSource.EndEdit();
                    documento_externoTableAdapter.Update(this.dataSetTramite);

                    BTNNUEVO.Enabled = true;
                    BTNEDITAR.Enabled = true;
                    BTNCANCELAR.Enabled = false;
                    BTNELIMINAR.Enabled = true;
                    BTNGUARDAR.Enabled = true;

                    MessageBox.Show("desea editar el documento", "Editar documento", MessageBoxButtons.OKCancel);

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

                    documentoexternoBindingSource.RemoveCurrent();
                    this.Validate();
                    documentoexternoBindingSource.EndEdit();
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

        private void estadoComboBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void nombre_areaTextBox_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.documento_externoTableAdapter.Fill(this.dataSetTramite.documento_externo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.cbbuscar.Text == "NOMBRE TRAMITANTE")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.documento_externoTableAdapter.buscarpornombre(this.dataSetTramite.documento_externo, txtbuscar.Text);
            }
            else if (this.cbbuscar.Text == "DNI")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.documento_externoTableAdapter.buscarpordni(this.dataSetTramite.documento_externo, txtbuscar.Text);
            }
            else if (this.cbbuscar.Text == "CODIGO MP")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.documento_externoTableAdapter.buscarMP(this.dataSetTramite.documento_externo, txtbuscar.Text);
            }
        }





    }
}
