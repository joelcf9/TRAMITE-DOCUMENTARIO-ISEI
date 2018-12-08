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
    public partial class FRMBUSCARDOCEXTERNO : Form
    {
        public FRMBUSCARDOCEXTERNO()
        {
            InitializeComponent();
        }
        public static string NumeroDoc, NombreAsunto;
       
        private void documento_externoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.documento_externoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTramite);

        }

        private void FRMBUSCARDOCEXTERNO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_externo' Puede moverla o quitarla según sea necesario.
            this.documento_externoTableAdapter.Fill(this.dataSetTramite.documento_externo);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numerodoc, nombreasunto;
            try
            {

                numerodoc = documento_externoDataGridView[0, documento_externoDataGridView.CurrentCell.RowIndex].Value.ToString();
                nombreasunto = documento_externoDataGridView[2, documento_externoDataGridView.CurrentCell.RowIndex].Value.ToString();

                NumeroDoc = numerodoc;
                NombreAsunto = nombreasunto;
                Close();
            }
            catch (Exception ex)
            {
                  MessageBox.Show("No hay registros de documentos");
                    
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.documento_externoTableAdapter.buscarpornombredniMP(this.dataSetTramite.documento_externo,textBox1.Text);

        }
    }
}
