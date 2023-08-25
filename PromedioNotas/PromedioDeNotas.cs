using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromedioNotas
{
    public partial class PromedioDeNotas : Form
    {
        Promedio objP = new();

        public PromedioDeNotas()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void Agregar()
        {
            if (Valida() == "")
            {
                CapturarDatos();

                double pro = objP.PromedioNotas();
                double nbaja = objP.NotaMasBaja();
                string condic = objP.Condicion();

                txtPromedio.Text = pro.ToString("0.00");
                txtNotaBaja.Text = nbaja.ToString();
                txtCondicion.Text = condic.ToString();

                limpiarDatos();
                txtNota1.Enabled = false;
                txtNota2.Enabled = false;
                txtNota3.Enabled = false;
                txtNota4.Enabled = false;
                txtNombre.Enabled = false;
                btnCalcular.Enabled = false;
            }
            else
            {
                MessageBox.Show($"El error esta en {Valida()}");
            }



        }

        private void limpiarDatos()
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtNota3.Clear();
            txtNota4.Clear();
        }

        private void CapturarDatos()
        {
            objP.nombreEstudiante = txtNombre.Text;
            objP.nota1 = int.Parse(txtNota1.Text);
            objP.nota2 = int.Parse(txtNota2.Text);
            objP.nota3 = int.Parse(txtNota3.Text);
            objP.nota4 = int.Parse(txtNota4.Text);
        }

        private string Valida()
        {
            if (txtNombre.Text.Trim().Length == 0)
            {
                txtNombre.Focus();
                return "Nombre del estudiante";

            }
            else if (txtNota1.Text.Trim().Length == 0)
            {
                txtNota1.Focus();
                return "Nota 1";
            }
            else if (txtNota2.Text.Trim().Length == 0)
            {
                txtNota2.Focus();
                return "Nota 2";
            }
            else if (txtNota3.Text.Trim().Length == 0)
            {
                txtNota3.Focus();
                return "Nota 3";
            }
            else if (txtNota4.Text.Trim().Length == 0)
            {
                txtNota4.Focus();
                return "Nota 4";
            }
            else if(int.Parse(txtNota1.Text) < 0 || int.Parse(txtNota1.Text) > 100)
            {
                return "que no puede ingresar una nota menor a 0 o mayor a 100";
            }
            else if (int.Parse(txtNota2.Text) < 0 || int.Parse(txtNota2.Text) > 100)
            {
                return "que no puede ingresar una nota menor a 0 o mayor a 100";
            }
            else if (int.Parse(txtNota3.Text) < 0 || int.Parse(txtNota3.Text) > 100)
            {
                return "que no puede ingresar una nota menor a 0 o mayor a 100";
            }
            else if (int.Parse(txtNota4.Text) < 0 || int.Parse(txtNota4.Text) > 100)
            {
                return "que no puede ingresar una nota menor a 0 o mayor a 100";
            }

            return "";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtPromedio.Clear();
            txtNotaBaja.Clear();
            txtCondicion.Clear();
            

            txtNota1.Enabled = true;
            txtNota2.Enabled = true;
            txtNota3.Enabled = true;
            txtNota4.Enabled = true;
            txtNombre.Enabled = true;
            btnCalcular.Enabled = true;
            txtNombre.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Está seguro de salir?", "Promedio de Notas",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
