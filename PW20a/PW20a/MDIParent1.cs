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
    public partial class MDIParent1 : Form
    {

        public MDIParent1()
        {
            InitializeComponent();
        }
        
        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos alumnos = new Alumnos();
            alumnos.MdiParent = this;
            alumnos.Show();
        }

        private void catalogosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }
    }
}
