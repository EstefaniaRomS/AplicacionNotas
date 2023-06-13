using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmVerNotas : Form
    {
        public frmVerNotas()
        {
            InitializeComponent();
        }

        private void frmVerNotas_Load(object sender, EventArgs e)
        {
            List<Nota> listanota = new CN_Nota().Listar();
            foreach (Nota item in listanota)
            {
                dgvnotas.Rows.Add(new object[] {"",item.IdNota,item.TituloNota,item.ContenidoNota
                });
            }
        }

        private void dgvnotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvnotas.Columns[e.ColumnIndex].Name == "Id")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txtindice.Text = indice.ToString();
                    List<Nota> listanotas = new CN_Nota().Listar();
                    int contador = 0;
                    foreach (Nota item in listanotas)
                    {
                        if (contador == indice)
                        {
                            txtidnota.Text = item.IdNota.ToString();break;
                        }
                        else
                        {
                            contador++;continue;
                        }
                    }

                }
            }
        }
        private void btneliminar_Click(object sender, EventArgs e)
        {
            string Indice = Convert.ToString(txtindice.Text);
            if (Indice != "")
            {
                Nota objnota = new Nota()
                {
                    IdNota = Convert.ToInt32(txtidnota.Text)
                };
                CN_Nota.Eliminar(objnota);
                MessageBox.Show("Correctamente eliminado");
                int Indice1 = Convert.ToInt32(Indice);
                dgvnotas.Rows.RemoveAt(Indice1);
            }
            else
            {
                MessageBox.Show("Por favor selecione una nota");
            }
        }
    }
}
