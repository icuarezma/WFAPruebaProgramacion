using System.Data;
using System.Numerics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WFAPruebaProgramacion.Models;

namespace WFAPruebaProgramacion.Forms
{
    public partial class FMainMenu : Form
    {
        private AMPMContext _context;
        private BindingSource bindingSource;
        private DataTable dataTable;

        public FMainMenu(AMPMContext context)
        {
            InitializeComponent();
            _context = context;
            dgUsers.DataSource = _context.Usuarios.ToList();
            fillDataTableFromContext();

            //bindingSource = new BindingSource();
            //bindingSource.DataSource = listProducts;
            //dgvProducts.DataSource = bindingSource;
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

        private void fillDataTableFromContext()
        {
            var listProducts = _context.Productos.ToList().Select(
                                        p => new
                                        {
                                            p.Id,
                                            p.Codigo,
                                            p.Nombre,
                                            p.Existencia,
                                            Estado = (bool)p.Estado ? "Activo" : "Inactivo",
                                            p.Proveedor,
                                            p.Imagen
                                        }).ToList();

            dataTable = new DataTable("MyTable");
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Codigo", typeof(string));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Existencia", typeof(int));
            dataTable.Columns.Add("Estado", typeof(string));
            dataTable.Columns.Add("Proveedor", typeof(string));



            foreach (var product in listProducts)
            {
                DataRow row = dataTable.NewRow();
                row["Id"] = product.Id;
                row["Codigo"] = product.Codigo;
                row["Nombre"] = product.Nombre;
                row["Existencia"] = product.Existencia;
                row["Estado"] = product.Estado;
                row["Proveedor"] = product.Proveedor;

                dataTable.Rows.Add(row);
            }
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dgvProducts.DataSource = bindingSource;


        }

        private void txtFilterByName_TextChanged(object sender, EventArgs e)
        {
            bindingSource.Filter = $"Nombre LIKE '%{txtFilterByName.Text}%'";
        }

        private void checkStateFilterByName_CheckedChanged(object sender, EventArgs e)
        {
            txtFilterByName.Enabled = checkStateFilterByName.Checked;
        }

        private void rbActives_CheckedChanged(object sender, EventArgs e)
        {
            bindingSource.Filter = $"Estado = 'Activo'";
        }

        private void rbInactives_CheckedChanged(object sender, EventArgs e)
        {
            bindingSource.Filter = $"Estado = 'Inactivo'";
        }

        private void rbAllByState_CheckedChanged(object sender, EventArgs e)
        {
            bindingSource.RemoveFilter();
        }

        private void dgvProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];

                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value.ToString());

                btnAddOptions.Enabled = true;

                Producto pro = _context.Productos.Find(id);
                fillDataOptions(id);


                if (pro != null)
                {
                    byte[] imagenBytes = pro.Imagen;
                    if (imagenBytes != null && imagenBytes.Length > 0)
                    {
                        try
                        {
                            using (MemoryStream ms = new MemoryStream(imagenBytes))
                            {
                                Image imagen = Image.FromStream(ms);
                                pbImage.Image = imagen;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al cargar la imagen: {ex.Message}");
                            pbImage.Image = null;
                        }

                    }
                    else
                    {
                        pbImage.Image = null;
                    }
                }
                else
                {
                    MessageBox.Show("Producto no encontrado");
                }





            }
        }

        private void fillDataOptions(int id)
        {

            dataGridOptions.DataSource = _context.Opciones.Where(o => o.Idproducto == id).ToList().Select(
                    lo => new
                    {
                        lo.Id,
                        lo.Nombre,
                        Estado = (bool)lo.Estado ? "Activo" : "Inactivo"
                    }
                ).ToList(); ;
        }

        private void btnAddOptions_Click(object sender, EventArgs e)
        {


            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["Id"].Value.ToString());

                FormAddOptions fao = new FormAddOptions(id,_context);
                DialogResult result = fao.ShowDialog();

                if (result == DialogResult.OK)
                {
                    fillDataOptions(id);
                }
                
            }
            else
            {
                MessageBox.Show("Debe seleccionra un producto en la tabla","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }
    }
}
