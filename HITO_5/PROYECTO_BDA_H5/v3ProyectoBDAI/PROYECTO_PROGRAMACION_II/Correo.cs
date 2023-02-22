using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace EnvioCorreo
{
    public partial class FmCorreo : Form
    {
        const string Usuario = "correopruebagerente@gmail.com";  // Credenciales --> Datos de acceso de un correo los cuales utiliza para hacerl el envio del cerreo 
        const string Password = "zyvvawpfwpcgszal" /*"abc951EFG123!"*/;  // ESTA ES LA CONTRASEÑA ORIGINAL 
        // lo que esta de naranja clave de acceso de que nos proporciona gmail para poder enlazar con sus servivios
        public FmCorreo()
        {
            InitializeComponent();
        }

        private void btnEnviarCorreo_Click(object sender, EventArgs e)
        {
            
            string Error = "";
            StringBuilder MensajeBuilder = new StringBuilder();
            MensajeBuilder.Append(txtMensaje.Text.Trim());
            EnviarCorreo(MensajeBuilder, DateTime.Now, txtDeg.Text.Trim(), txtPara.Textbox.Trim(), txtAsunto.Textbox.Trim(), out Error);  // trim borra los espacios vacios que estan antes y despues del texto
        }


        public static void EnviarCorreo(StringBuilder Mensaje, DateTime FechaEnvio, String De, String Para, String Asunto, out string Error)
        {
            
            Error = "";
            try
            {
                Mensaje.Append(Environment.NewLine);
                Mensaje.Append(string.Format("Este correo ha sido enviado el dia {0:dd/MM/yyyy} a las {0:HH:mm:ss} Horas: \n\n",FechaEnvio));
                Mensaje.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(De); // De parte de quien fue enviado el mensaje
                mail.To.Add(Para); // Aquien se le envia el mensaje
                mail.Subject = Asunto;
                mail.Body = Mensaje.ToString(); // Cuerpo del mesnaje 

                SmtpClient smtp = new SmtpClient("smtp.gmail.com"); //Enlaza la conexion con el gmail
                smtp.Port = 587; // asignacion del puerto --> el puerto 587 nos permite enviar correos desde el gmail
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(Usuario, Password);
                smtp.EnableSsl = true;
                smtp.Send(mail);

                Error = "Exito Mensaje Enviado Correctamente";
                MessageBox.Show(Error);
            }
            catch (Exception ex)
            {
                Error= "Error" + ex.Message;
                MessageBox.Show(Error);
                return;
            }
        }

        private void txtDe_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Error = "";
            StringBuilder MensajeBuilder = new StringBuilder();
            MensajeBuilder.Append(txtMensaje.Text.Trim());
            EnviarCorreo(MensajeBuilder, DateTime.Now, txtDeg.Text.Trim(), txtPara.Textbox.Trim(), txtAsunto.Textbox.Trim(), out Error);  
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }
    }
}
