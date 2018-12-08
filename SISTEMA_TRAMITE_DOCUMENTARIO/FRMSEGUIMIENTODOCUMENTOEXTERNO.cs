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
    public partial class FRMSEGUIMIENTODOCUMENTOEXTERNO : Form
    {
        DateTime fecha = DateTime.UtcNow;
        public FRMSEGUIMIENTODOCUMENTOEXTERNO()
        {
            InitializeComponent();
        }

        private void detalle_documento_externoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.detalle_documento_externoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTramite);

        }
        public void cargardatos()
        {
           // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.detalle_documento_externo' Puede moverla o quitarla según sea necesario.
            this.detalle_documento_externoTableAdapter.Fill(this.dataSetTramite.detalle_documento_externo);

        }
        public void botones_activos()
        {
            numero_respuesta_extTextBox.Enabled = true;
            numero_correlativoTextBox.Enabled = true;
            derivar_areaComboBox.Enabled = true;
            fecha_salidaDateTimePicker.Enabled = true;
            descripcionTextBox.Enabled = true;
            estadoComboBox.Enabled = true;
            observacionTextBox.Enabled = true;
            asuntoTextBox.Enabled = true;
            button2.Enabled = true;

        }
        public void botones_desactivados()
        {
            numero_respuesta_extTextBox.Enabled = false;
            numero_correlativoTextBox.Enabled = false;
            derivar_areaComboBox.Enabled = false;
            fecha_salidaDateTimePicker.Enabled = false;
            descripcionTextBox.Enabled = false;
            estadoComboBox.Enabled = false;
            observacionTextBox.Enabled = false;
            asuntoTextBox.Enabled = false;
            button2.Enabled = false;

        }
        private void FRMSEGUIMIENTODOCUMENTOEXTERNO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.detalle_documento_externo' Puede moverla o quitarla según sea necesario.
            this.detalle_documento_externoTableAdapter.Fill(this.dataSetTramite.detalle_documento_externo);
            BTNGUARDAR.Tag = "Guardar";
            cargardatos();
            botones_desactivados();
            BTNNUEVO.Enabled = true;
            BTNEDITAR.Enabled = true;
            BTNCANCELAR.Enabled = false;
            BTNELIMINAR.Enabled = true;
            BTNGUARDAR.Enabled = false;
        }

        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            detalle_documento_externoBindingSource.AddNew();
            BTNGUARDAR.Tag = "GuardarI";
            botones_activos();
            numero_correlativoTextBox.Focus();
            fecha_salidaDateTimePicker.Text = fecha.ToString();

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
                        this.detalle_documento_externoBindingSource.EndEdit();
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
                    this.detalle_documento_externoBindingSource.EndEdit();
                    detalle_documento_externoTableAdapter.Update(this.dataSetTramite);

                    BTNNUEVO.Enabled = true;
                    BTNEDITAR.Enabled = true;
                    BTNCANCELAR.Enabled = false;
                    BTNELIMINAR.Enabled = true;
                    BTNGUARDAR.Enabled = false;

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
                    detalle_documento_externoBindingSource.RemoveCurrent();
                    this.Validate();
                    detalle_documento_externoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dataSetTramite);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMBUSCARDOCEXTERNO docenterno = new FRMBUSCARDOCEXTERNO();
            docenterno.Show();
        }

        private void FRMSEGUIMIENTODOCUMENTOEXTERNO_Activated(object sender, EventArgs e)
        {
            numero_correlativoTextBox.Text = FRMBUSCARDOCINTERNO.NumeroDoc;
            asuntoTextBox.Text = FRMBUSCARDOCINTERNO.NombreAsunto;
        }
    }
}
