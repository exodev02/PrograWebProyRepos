using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pw20
{
    public partial class Form1 : Form
    {

        int I = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtNocontrol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtApe_paterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtApe_materno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void dtpFecha_ing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cboMesesdelaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNoctrl.Text == "")
            {
            }
            else
            {
                dgvAgregar.Rows.Add(I, txtNoctrl.Text,
                txtNombre.Text,
                txtApe_paterno.Text,
                txtApe_materno.Text,
                dtpFecha_ing.Value,
                cboMesesdelaño.Text.ToString());
                I = I + 1;
                txtNoctrl.Text = "";
                txtNombre.Text = "";
                txtApe_paterno.Text = "";
                txtApe_paterno.Text = "";
                dtpFecha_ing.Value = System.DateTime.Today;
                txtNoctrl.Focus();
            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Control     " + txtNoctrl.Text);
            MessageBox.Show("Nombre     " + txtNombre.Text);
            MessageBox.Show("Apellido Paterno     " + txtApe_paterno.Text);
            MessageBox.Show("Apellido Materno     " + txtApe_materno.Text);
            MessageBox.Show("Fecha de Ingreso     " + dtpFecha_ing.Value);
            MessageBox.Show("Mes del Año     " + cboMesesdelaño.Text.ToString());

            if (rbEnero.Checked)
            {
                MessageBox.Show("Enero");
            }

            if (rbFebrero.Checked)
            {
                MessageBox.Show("Febrero");
            }


            if (rbMarzo.Checked)
            {
                MessageBox.Show("Marzo");
            }

            if (rbAbril.Checked)
            {
                MessageBox.Show("Abril");
            }

            if (rbMayo.Checked)
            {
                MessageBox.Show("Mayo");
            }

            if (rbJunio.Checked)
            {
                MessageBox.Show("Junio");
            }

            if (chkEnero.Checked)
            {
                MessageBox.Show("Enero - Check");
            }

            if (chkFebrero.Checked)
            {
                MessageBox.Show("Febrero - Check");
            }

            if (chkMarzo.Checked)
            {
                MessageBox.Show("Marzo - Check");
            }

            if (chkAbril.Checked)
            {
                MessageBox.Show("Abril - Check");
            }

            if (chkMayo.Checked)
            {
                MessageBox.Show("Mayo - Check");
            }

            if (chkJunio.Checked)
            {
                MessageBox.Show("Junio  - Check");
            }
        }
    }
}
