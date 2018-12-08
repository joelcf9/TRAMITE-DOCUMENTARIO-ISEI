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
    public partial class FRMBUSCARAREA : Form
    {
        public FRMBUSCARAREA()
        {
            InitializeComponent();
        }

        public static string IdArea, NombreArea;
        private void areasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.areasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSetTramite);

        }

        
        private void FRMBUSCARAREA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSetTramite.areas' Puede moverla o quitarla según sea necesario.
            this.areasTableAdapter.Fill(this.dataSetTramite.areas);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idarea, nombrearea;
            try
            {
                idarea = dgvbuscararea[0, dgvbuscararea.CurrentCell.RowIndex].Value.ToString();
                nombrearea = dgvbuscararea[2, dgvbuscararea.CurrentCell.RowIndex].Value.ToString();

                IdArea = idarea;
                NombreArea = nombrearea;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay registros de areas");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.areasTableAdapter.buscarporcodigonombre(this.dataSetTramite.areas, textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
