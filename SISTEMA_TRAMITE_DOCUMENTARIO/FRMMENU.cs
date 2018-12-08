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
    public partial class FRMMENU : Form
    {
        public FRMMENU()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToLongTimeString();
    
            label3.Text = DateTime.Now.ToLongDateString();
        }

        private void BTNNUEVOEXTERNO_Click(object sender, EventArgs e)
        {
            FRMDOCUMENTOEXTERNO docext = new FRMDOCUMENTOEXTERNO();
            docext.Show();
        }

        private void BTNNUEVOINTERNO_Click(object sender, EventArgs e)
        {
            FRMDOCUMETOINTERNO docint = new FRMDOCUMETOINTERNO();
            docint.Show();
        }

        private void BTNUSUARIOS_Click(object sender, EventArgs e)
        {
            FRMUSUARIOS i = new FRMUSUARIOS();
            i.Show();
        }

        private void BTNNUEVATRA_Click(object sender, EventArgs e)
        {
            FRMAREAS AREAS = new FRMAREAS();
            AREAS.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void derivarDocInternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMSEGUIMIENTODOCUMENTOINTERNO i = new FRMSEGUIMIENTODOCUMENTOINTERNO();
            i.Show();
        }

        private void derivarDocExternoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMSEGUIMIENTODOCUMENTOEXTERNO ex = new FRMSEGUIMIENTODOCUMENTOEXTERNO();
            ex.Show();
        }




     


    }
}
