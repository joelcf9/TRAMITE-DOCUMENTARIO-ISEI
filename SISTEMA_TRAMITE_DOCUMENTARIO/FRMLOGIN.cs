using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }
        //mover formnulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        int Contador;
        //Connection String
        string cs = "Data Source=ACER\\JOEL;Initial Catalog=bd_tramite_documentario;Integrated Security=True";
        //btn_Submit Click event
        
        private void LOGIN_Load(object sender, EventArgs e)
        {
          
        }

        //private void pictboxcerrar_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void pictboxminimizar_Click(object sender, EventArgs e)
        //{
        //    this.WindowState = FormWindowState.Minimized;
        //}
        
        


        private void button1_Click(object sender, EventArgs e)
        {
            if (texusuario.Text == "" || texcontraseña.Text == "" || comboBoxTipo.Text=="" )
            {
                MessageBox.Show("Por favor, proporcione nombre de usuario y contraseña y el tipo de usuario");
                Contador += 1;
                if (Contador == 3)
                {
                    this.Close();
                }
                return;
            }

            try
            {

                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select ID_USUARIO from adm_sistema where usuario=@username and contraseña=@password and tipo_administrador=@administrador" , con);
                cmd.Parameters.AddWithValue("@username", texusuario.Text);
                cmd.Parameters.AddWithValue("@password", texcontraseña.Text);
                cmd.Parameters.AddWithValue("@administrador", comboBoxTipo.Text);
              
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    MessageBox.Show("Bienvenido al Sistema de Tramite Documentario!");
                    this.Hide();


                    FRMMENU fm = new FRMMENU();
                    fm.Show();
                    
                    
                }
                else
                {
                    MessageBox.Show("Ususario o Contraseña esta mal vuelva a intentar!");
                    texusuario.Clear();
                    texcontraseña.Clear();
                    Contador += 1;
                    if (Contador == 3)
                    {
                        this.Close();
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LOGIN_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //FRMRECUPERARCONTRASEÑA recuperar = new FRMRECUPERARCONTRASEÑA();
            //recuperar.Show();
        }

   



    }
}
