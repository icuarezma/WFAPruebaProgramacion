using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAPruebaProgramacion.Models;

namespace WFAPruebaProgramacion.Forms
{
    public partial class FMainMenu : Form
    {
        private AMPMContext _context;

        public FMainMenu(AMPMContext context)
        {
            InitializeComponent();
            _context = context;
        }
        private void FMainMenu_Load(object sender, EventArgs e)
        {
            dgUsers.DataSource = _context.Usuarios.ToList();
        }

        private void formPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkFormEnabled_CheckedChanged(object sender, EventArgs e)
        {
            enableField(checkFormEnabled.Checked);
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var fields = new Dictionary<TextBox, string>
            {
                {txtUsername, "Debe ingresar un Nombre de Usuario"},
                {txtPassword, "Debe ingresar una Contraseña"},
                {txtName, "Debe ingresar un Nombre para el Registro"},
                {txtLastname, "Debe ingresar un Apellido para el registro"},
                {txtEmail, "Debe ingresar un Correo Electrónico para el registro"},
                {txtPhone, "Debe ingresar un Número telefónico para el registro"}
            };

            foreach (var field in fields)
            {
                if (string.IsNullOrEmpty(field.Key.Text))
                {
                    lblWarning.Text = field.Value;
                    field.Key.Focus();
                    lblWarning.Visible = true;
                    return;
                }
            }

            string email = txtEmail.Text;
            string phone = txtPhone.Text;

            if (!IsFormatEmail(email))
            {
                lblWarning.Text = "El formato del correo electrónico dígitado es inválido. Formato correcto ejemplo: juanperez@gmail.com";
                txtEmail.Focus();
                lblWarning.Visible = true;
                return;
            }

            if (!IsFormatPhone(phone))
            {
                lblWarning.Text = "El formato del número telefónico dígitado es inválido. Formato correcto ejemplo: 8520-5689";
                txtPhone.Focus();
                lblWarning.Visible = true;
                return;
            }

            _context.Usuarios.Add(new Usuario
            {
                Usuario1 = txtUsername.Text,
                Clave = txtPassword.Text,
                Nombre = txtName.Text,
                Apellido = txtLastname.Text,
                Correo = txtEmail.Text,
                Telefono = txtPhone.Text.Replace("-", ""),
                Fechacreacion = DateOnly.FromDateTime(DateTime.Now)
            });

            int savechanges = _context.SaveChanges();

            if (savechanges > 0)
            {
                MessageBox.Show("Registro guardado correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgUsers.DataSource = _context.Usuarios.ToList();
                dgUsers.Refresh();

                foreach (var field in fields)
                {
                    field.Key.Text = "";
                }
                checkFormEnabled.Checked = false;

            }
            else
            {
                MessageBox.Show("Ha ocurrido un error al registrar. Contactese con el Administraro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsFormatEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9.!#$%&'+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        private bool IsFormatPhone(string phone)
        {
            string pattern = @"^\d{4}-\d{4}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phone);
        }

        private void enableField(bool enable)
        {
            var fields = new List<Control>()
            {
               txtUsername,
               txtPassword,
               txtName,
               txtLastname,
               txtEmail,
               txtPhone,
               btnAddUser
            };

            foreach (var field in fields)
            {
                field.Enabled = enable;
            }
        }

    }
}
