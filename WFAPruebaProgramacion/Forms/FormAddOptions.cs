using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAPruebaProgramacion.Models;

namespace WFAPruebaProgramacion.Forms
{
    public partial class FormAddOptions : Form
    {

        private AMPMContext _context;
        private int _IdProduct;

        public FormAddOptions(int idproduct, AMPMContext context)
        {
            InitializeComponent();
            _context = context;
            _IdProduct = idproduct;
            var listProduct = _context.Productos.Where(p => p.Id == idproduct).ToList();
            foreach (var product in listProduct)
            {
                txtProductName.Text = product.Nombre.ToString();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtOptionName.Text))
            {
                MessageBox.Show("Debe ingresar un nombre de opcion", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _context.Opciones.Add(new Opcione
                {
                    Nombre = txtOptionName.Text,
                    Idproducto = _IdProduct,
                    Estado = rdActiveOption.Checked ? true : false

                });

                int savechanges = _context.SaveChanges();

                if (savechanges > 0)
                {
                    MessageBox.Show("Registro guardado correctamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error al registrar. Contactese con el Administraro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel; 
                    this.Close();
                }


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            this.Close();
        }
    }
}
