using WFAPruebaProgramacion.Forms;
using WFAPruebaProgramacion.Models;

namespace WFAPruebaProgramacion
{
    public partial class Login : Form
    {

        private AMPMContext ampm;
        public Login()
        {
            InitializeComponent();
            ampm = new AMPMContext();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                lblWarning.Text = "Ingresar Nombre de Usuario";
                lblWarning.Visible = true;
                

            }
            else if (string.IsNullOrEmpty(password))
            {
                lblWarning.Text = "Ingresar Contraseña";
                lblWarning.Visible = true;
                
            }
            else
            {
                

                if (ampm.Usuarios.Any(u => u.Usuario1 == username && u.Clave == password))
                {
                    this.Hide();
                    FMainMenu menu = new FMainMenu(ampm);
                    menu.FormClosed += (s, args) => this.Close();
                    menu.Show();
                }
                else
                {
                    lblWarning.Text = "Error de autenticación.";
                    lblWarning.Visible = true;
                }
            }

            

            
        }
    }
}
