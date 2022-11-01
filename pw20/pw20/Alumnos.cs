using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pw20
{
    public partial class Alumnos : Form
    {

        private String _sCadenaConexion = String.Empty;
        private int pEstadocivil, pCveSexo;

        public Alumnos()
        {
            InitializeComponent();
        }

        private void Alumnos_Load(object sender, EventArgs e)
        {
            CargaComboCarreras();
            CargaComboMaterias();
            CargaGrid();
        }

        private void CargaComboCarreras()
        {
            //_sCadenaConexion = "Server=localhost\\SQLSERVERKEVIN;Database=PrograWeb20;user=sa;password=ncR19czt";
            _sCadenaConexion = "Data Source=192.168.201.9\\LABSQL;Initial Catalog=PrograWeb20;user id=PWEB21;password=PWEB21";
            SqlConnection conexionDB = new SqlConnection(_sCadenaConexion);
            SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionDB;
            comandoSQL.CommandText = "sp_Carreras_Prl";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'T'));

            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);
            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);

            cboCarreras.DisplayMember = "Nom_Carrera";
            cboCarreras.ValueMember = "Id_Carrera";
            cboCarreras.DataSource = resultado;
        }

        private void CargaComboMaterias()
        {
            _sCadenaConexion = "Data Source = 192.168.201.9\\LABSQL; Database=PrograWeb20;" + "user = PWEB21; password = PWEB21"; // Abrir_base_datos();
            SqlConnection conexionDB = new SqlConnection(_sCadenaConexion);
            SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionDB;
            comandoSQL.CommandText = "sp_Materias_Prl";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", 'T'));

            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);

            cboMaterias.DisplayMember = "Nom_Materia";
            cboMaterias.ValueMember = "Id_Materia";
            cboMaterias.DataSource = resultado;
        }

        private void CargaGrid()
        {
            _sCadenaConexion = "Data Source= 192.168.201.9\\LABSQL; Initial Catalog=PrograWeb20;" + "user=PWEB21;password=PWEB21"; // Abrir_base_datos();
            SqlConnection conexionDB = new SqlConnection(_sCadenaConexion);
            SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionDB;
            comandoSQL.CommandText = "sp_Carreras_Prl";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", "T"));

            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);

            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);

            cboMaterias.DisplayMember = "Nom_Materia";
            cboMaterias.ValueMember = "Id_Materia";
            cboMaterias.DataSource = resultado;

            dgvAlumnos.DataSource = resultado;
        }

        private void dgvAlumnos_DoubleClick(object sender, EventArgs e)
        {
            this.txtNocontrol.Text = dgvAlumnos.CurrentRow.Cells["Id_Control"].Value.ToString();
            this.txtNombre.Text = dgvAlumnos.CurrentRow.Cells["Nombre"].Value.ToString();
            this.txtApaterno.Text = dgvAlumnos.CurrentRow.Cells["Ape_Paterno"].Value.ToString();
            this.txtAmaterno.Text = dgvAlumnos.CurrentRow.Cells["Ape_Materno"].Value.ToString();
            this.dtpFecha.Value = Convert.ToDateTime(dgvAlumnos.CurrentRow.Cells["Fecha_ing"].Value.ToString());

            pEstadocivil = 0;
            pEstadocivil = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["Estado_Civil"].Value.ToString());

            if (pEstadocivil == 1)
            {
                this.optSoltero.Checked = true;
            }
            if (pEstadocivil == 2)
            {
                this.optCasado.Checked = true;
            }
            if (pEstadocivil == 3)
            {
                this.optDivorciado.Checked = true;
            }
            if (pEstadocivil == 4)
            {
                this.optUnionLibre.Checked = true;
            }

            pCveSexo = 0;
            pCveSexo = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells["Cve_Sexo_Alu"].Value.ToString());
            // Faltan dos lineas de codigo aqui :c
        }

        /* Nose donde va este codigo O.o
         * if (this.txtNocontrol.Text.Equals(""))
            {

            } else
            {
                _sCadenaConexion = "Data Source= 192.168.201.9\\LABSQL; Initial Catalog=PrograWeb20;" + "user=PWEB21;password=PWEB21";

                SqlConnection conexionDB = new SqlConnection(_sCadenaConexion);
                SqlCommand comandoSQL = new SqlCommand();

                comandoSQL.Connection = conexionDB;
                comandoSQL.CommandText = "sp_Alumnos_Prl";
                comandoSQL.CommandType = CommandType.StoredProcedure;

                comandoSQL.Parameters.Add(new SqlParameter("@OPERACION", "L"));
                comandoSQL.Parameters.Add(new SqlParameter("@Id_Control", Convert.ToInt32(this.txtNocontrol.Text)));

                SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);

                DataTable resultado = new DataTable();
                adaptador.Fill(resultado);

                if(resultado.Rows.Count == 0)
                {

                } else
                {
                    this.txtNombre.Text = resultado.Rows[0]["Nombre"].ToString();
                    this.txtApaterno.Text = resultado.Rows[0]["Ape_Paterno"].ToString();
                    this.txtApaterno.Text = resultado.Rows[0]["Ape_Materno"].ToString();
                    this.dtpFecha.Value = Convert.ToDateTime(resultado.Rows[0]["Fecha_ing"].ToString());

                    pEstadocivil = 0;
                    pEstadocivil = Convert.ToInt32(resultado.Rows[0]["Estado_Civil"].ToString());

                    if (pEstadocivil == 1)
                    {
                        this.optSoltero.Checked = true;
                    }
                    if (pEstadocivil == 2)
                    {
                        this.optCasado.Checked = true;
                    }
                    if (pEstadocivil == 3)
                    {
                        this.optDivorciado.Checked = true;
                    }
                    if (pEstadocivil == 4)
                    {
                        this.optUnionLibre.Checked = true;
                    }

                    pCveSexo = 0;
                    pCveSexo = Convert.ToInt32(resultado.Rows[0]["Cve_Sexo_Alu"].ToString());

                    if(pCveSexo == 1)
                    {
                        this.optMasculino.Checked = true;
                    }
                    if(pCveSexo == 2)
                    {
                        this.optFemenino.Checked = true;
                    }

                    cboCarreras.SelectedValue = Convert.ToInt32(resultado.Rows[0]["Id_Carreras"]);
                    cboMaterias.SelectedValue = Convert.ToInt32(resultado.Rows[0]["Id_Materias"]);
                }
            }
         */
    }
}
