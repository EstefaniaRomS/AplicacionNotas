using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Inicio : Form
    {
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public Inicio()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.White;
            }
            menu.BackColor = Color.Silver;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            contenedor.Controls.Add(formulario);
            
            formulario.Show();

        }

        private void menuver_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmVerNotas());
        }

        private void menuagregar_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmAgregar());
        }
    }
}
