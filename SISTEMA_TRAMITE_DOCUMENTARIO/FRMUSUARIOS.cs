using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    public partial class FRMUSUARIOS : Form
    {
        public FRMUSUARIOS()
        {
            InitializeComponent();
        }

        private void adm_sistemaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.admsistemaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTramite);

        }
        public void cargardatos()
        {
            //// TODO: esta línea de código carga datos en la tabla 'dataSetTramite.adm_sistema' Puede moverla o quitarla según sea necesario.
            this.adm_sistemaTableAdapter.Fill(this.dataSetTramite.adm_sistema);

        }
        private void FRMUSUARIOS_Load(object sender, EventArgs e)
        {
            //// TODO: esta línea de código carga datos en la tabla 'dataSetTramite.adm_sistema' Puede moverla o quitarla según sea necesario.
            this.adm_sistemaTableAdapter.Fill(this.dataSetTramite.adm_sistema);

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

            id_usuarioTextBox.Enabled = false;
            nombresTextBox.Enabled = true;
            apellidosTextBox.Enabled = true;
            correo_electronicoTextBox.Enabled = true;
            usuarioTextBox.Enabled = true;
            contraseñaTextBox.Enabled = true;
            tipo_administradorComboBox.Enabled = true;
           
        }
        public void botones_desactivados()
        {
            id_usuarioTextBox.Enabled = false;
            nombresTextBox.Enabled = false;
            apellidosTextBox.Enabled = false;
            correo_electronicoTextBox.Enabled = false;
            usuarioTextBox.Enabled = false;
            contraseñaTextBox.Enabled = false;
            tipo_administradorComboBox.Enabled = false;
        }
        private void BTNNUEVO_Click(object sender, EventArgs e)
        {
            admsistemaBindingSource.AddNew();
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
            BTNGUARDAR.Tag = "GuardarE";

            botones_activos();
            BTNNUEVO.Enabled = false;
            BTNEDITAR.Enabled = false;
            BTNCANCELAR.Enabled = true;
            BTNELIMINAR.Enabled = false;
            BTNGUARDAR.Enabled = true;
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
                        this.admsistemaBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.dataSetTramite);

                        BTNNUEVO.Enabled = true;
                        BTNEDITAR.Enabled = true;
                        BTNCANCELAR.Enabled = false;
                        BTNELIMINAR.Enabled = true;
                        BTNGUARDAR.Enabled = false;

                        MessageBox.Show("Usuario registrado");

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
                    this.admsistemaBindingSource.EndEdit();
                    adm_sistemaTableAdapter.Update(this.dataSetTramite);

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
                    admsistemaBindingSource.RemoveCurrent();
                    this.Validate();
                    admsistemaBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.dataSetTramite);
                    cargardatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (this.cbbuscar.Text == "NOMBRE")
            {
                this.adm_sistemaTableAdapter.buscarpornombre(this.dataSetTramite.adm_sistema,txtbuscar.Text);
            }
            else if (this.cbbuscar.Text == "APELLIDO")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.adm_sistemaTableAdapter.buscarporapellido(this.dataSetTramite.adm_sistema,txtbuscar.Text);
            }
            else if (this.cbbuscar.Text == "USUARIO")
            {
                // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
                this.adm_sistemaTableAdapter.buscarporusuario(this.dataSetTramite.adm_sistema,txtbuscar.Text);
            }
        }
    }
}
