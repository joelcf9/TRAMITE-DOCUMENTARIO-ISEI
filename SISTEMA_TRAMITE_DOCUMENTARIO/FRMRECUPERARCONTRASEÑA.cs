using SISTEMA_TRAMITE_DOCUMENTARIO.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISTEMA_TRAMITE_DOCUMENTARIO
{
    public partial class FRMRECUPERARCONTRASEÑA : Form
    {
        public FRMRECUPERARCONTRASEÑA()
        {
            InitializeComponent();
        }
    //     public static Properties.Settings Settings
    //{
    //    get
    //    {
    //        return Properties.Settings.Default;
    //    }
    //}
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    SqlConnection sc = new SqlConnection("Server=ACER\\JOEL;DataBase=bd_tramite_documentario;Integrated Security=true");
        //    SqlCommand cmd = new SqlCommand("ValidarCorreoElectronico", sc);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@correo", textcorreo.Text);
        //     try {
        //         sc.Open();
        //         SqlDataReader lector = cmd.ExecuteReader();
        //         if (lector.Read()) 
        //         {
        //             GenerarNuevaContrasena(textcorreo.Text);
        //         }
        //           else {
        //             MessageBox.Show("Correo no encontrado");
        //                }
    
        //        }
        //        catch (Exception ex)
        //                {
        //                  MessageBox.Show(ex.Message);
        //                }
        //      }


        //public void GenerarNuevaContrasena(string email)
        //{
        //    string nuevaContrasena;

        //    nuevaContrasena = InputBox("Ingrese Nueva Contraseña", "Restableser Contraseña").ToString();
        //    if ((nuevaContrasena.Length > 0))
        //    {
        //        SqlConnection sc = new SqlConnection("Data Source=ACER\\JOEL;Initial Catalog=bd_tramite_documentario;Integrated Security=True");
        //        SqlCommand cmd = new SqlCommand("NuevaContrasea", sc);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@Correo", email);
        //        cmd.Parameters.AddWithValue("@Contrase�a", nuevaContrasena);
        //        try
        //        {
        //            sc.Open();
        //            string filasAfectadas = cmd.ToString();
        //            if (filasAfectadas != "0")
        //            {
        //                EnviarCorreoContrasena(nuevaContrasena, email);
        //            }

        //        }
        //        catch (System.Exception End)
        //        {
        //            try
        //            {
        //                this.Close();
        //            }
        //        }
            
        //    }
        //}




private object InputBox(string p1,string p2)
{
 	throw new NotImplementedException();
} 

	
    //   public  void EnviarCorreoContrasena(string contrasenaNueva, string correo) 
    //   {
    //     string  contraseña = this.ToString(Settings.bd_tramite_documentarioConnectionString);
    //    object contraseña;
    //    ((string)(a)) = this..Settings.Contrasena;
    //    string mensaje = String.Empty;
    //    // Creando el correo electronico
    //    string destinatario = correo;
    //    string remitente = "eliascar_888@hotmail.com";
    //    string asunto = "Nueva contraseña Apps Easy";
    //    string cuerpoDelMesaje = ("Su nueva contraseña es:" + (" " + contrasenaNueva));
    //    SmtpClient smtp = new SmtpClient();
    //    smtp.Host = "smtp.live.com";
    //    smtp.Port = 587;
    //    smtp.EnableSsl = true;
    //    smtp.Credentials = new NetworkCredential("eliascar_888@hotmail.com", contraseña, a);
    //    MailMessage ms = new MailMessage(remitente, destinatario, asunto, cuerpoDelMesaje);
    //    try {
    //        Task t = Task.Run(Sub, (Unknown, smtp.Send(ms), ms.Dispose(), MessageBox.Show("Correo enviado, sirvase revisar su bandeja de entrada"), End, Sub);
    //        MessageBox.Show("Esta tarea puede tardar unos segundos, por favor espere.");
    //    }
    //    catch (Exception ex) {
    //        MessageBox.Show(("Error al enviar correo electronico: " + ex.Message));
    //    }
        
    //}


    }
}
