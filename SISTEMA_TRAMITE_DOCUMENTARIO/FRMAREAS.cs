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
    public partial class FRMAREAS : Form
    {
        public FRMAREAS()
        {
            InitializeComponent();
        }

        private void areasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.areasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTramite);

        }
        public void cargardatos()
        {
            // TODO: esta línea de código carga datos en la tabla 'bd_tramite_documentarioDataSet.areas' Puede moverla o quitarla según sea necesario.
            this.areasTableAdapter.Fill(this.dataSetTramite.areas);
        }
        public void botones_activos()
        {
            id_areaTextBox.Enabled=false;
            codigoTextBox.Enabled = true;
            nombre_areaComboBox.Enabled = true;
            encargardo_areaTextBox.Enabled = true;
        }
        public void botones_desactivados()
        {
            id_areaTextBox.Enabled = false;
            codigoTextBox.Enabled = false;
            nombre_areaComboBox.Enabled = false;
            encargardo_areaTextBox.Enabled = false;
        }

        private void FRMAREAS_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.areas' Puede moverla o quitarla según sea necesario.
            this.areasTableAdapter.Fill(this.dataSetTramite.areas);
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
            areasBindingSource.AddNew();
            BTNGUARDAR.Tag = "GuardarI";
            botones_activos();

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
            cargardatos();
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
                        this.areasBindingSource.EndEdit();
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
                    this.areasBindingSource.EndEdit();

                    areasTableAdapter.Update(this.dataSetTramite);

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
                    //areasTableAdapter.Delete(nombre_areaTextBox.Text, encargardo_areaTextBox.Text);
                    cargardatos();
                    botones_desactivados();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

   
    }
}
