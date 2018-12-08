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
    public partial class FRMBUSCARDOCINTERNO : Form
    {
        public FRMBUSCARDOCINTERNO()
        {
            InitializeComponent();
        }
        public static string NumeroDoc,NombreAsunto;
       
        private void documento_internoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.documento_internoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTramite);

        }

        private void FRMBUSCARDOCINTERNO_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.documento_interno' Puede moverla o quitarla según sea necesario.
            this.documento_internoTableAdapter.Fill(this.dataSetTramite.documento_interno);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string numerodoc,nombreasunto;
            try
            {
                numerodoc = dgvbuscardocinterno[0, dgvbuscardocinterno.CurrentCell.RowIndex].Value.ToString();
                nombreasunto = dgvbuscardocinterno[2, dgvbuscardocinterno.CurrentCell.RowIndex].Value.ToString();

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
            
            this.documento_internoTableAdapter.buscarporMPnombredni(this.dataSetTramite.documento_interno,textBox1.Text);
        }

        private void dgvbuscardocinterno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
