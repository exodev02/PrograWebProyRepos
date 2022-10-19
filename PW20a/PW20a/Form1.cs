using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PW20a
{
    public partial class Form1 : Form
    {

        int I = 1;
        int pMesAño;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No Control     " + txtNocontrol.Text);
            MessageBox.Show("Nombre     " + txtNomalumno.Text);
            MessageBox.Show("Apellido Paterno     " + txtApaterno.Text);
            MessageBox.Show("Apellido Materno     " + txtAmaterno.Text);
            MessageBox.Show("Fecha de Ingreso     " + dtpFechaing.Value);
            MessageBox.Show("Mes del Año     " + cboMesesaño.Text.ToString());

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

        private void txtNocontrol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtNomalumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtApaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void txtAmaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void dtpFechaing_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void cboMesesaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtNocontrol.Text == "")
            {
            } else
            {
                dgvAgregar.Rows.Add(I, txtNocontrol.Text, 
                txtNomalumno.Text, 
                txtApaterno.Text, 
                txtAmaterno.Text, 
                dtpFechaing.Value, 
                cboMesesaño.Text.ToString());
                I = I + 1;
                txtNocontrol.Text = "";
                txtNomalumno.Text = "";
                txtApaterno.Text = "";
                txtAmaterno.Text = "";
                dtpFechaing.Value = System.DateTime.Today;
                txtNocontrol.Focus();
            }
        }
    }
}