using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            Nota objnota = new Nota()
            {
                TituloNota = txttitulo.Text.ToString(),
                ContenidoNota = txtcontenido.Text.ToString()
            };
            if (objnota.TituloNota != "" && objnota.ContenidoNota != "")
            {
                CN_Nota.Registrar(objnota);
                MessageBox.Show("Guardado con éxito");
                Limpiar();
            }
            else if (objnota.TituloNota == "")
            {
                MessageBox.Show("El título no puede estar vacío");
                txttitulo.Select();
            }
            else
            {
                MessageBox.Show("El contenido no puede estar vacío");
                txtcontenido.Select();
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            txttitulo.Select();
        }
        private void Limpiar()
        {
            txttitulo.Text = "";
            txtcontenido.Text = "";

            txttitulo.Select();
        }
    }
}
