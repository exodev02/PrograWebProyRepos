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

namespace PW20a
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        private String _sCadenaConexion = String.Empty;

        private void Alumnos_Load(object sender, EventArgs e)
        {
            CargarComboCarreras();
        }

        private void CargarComboCarreras()
        {
            _sCadenaConexion = "Data Source = 192.168.201.9\\LABSQL; Initial Catalog = PrograWeb20;" + "user = PWEB21; password = PWEB21"; // Abrir_base_datos();
            SqlConnection conexionDB = new SqlConnection(_sCadenaConexion);
            SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionDB;
            comandoSQL.CommandText = "sp_Carreras_Prl";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION",'T'));

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

            dgvAlumnos.DataMember = "Nom_Materia";
            //dgvAlumnos.
        }

        private void txtNocontrol_Click(object sender, EventArgs e)
        {
            if (this.txtNocontrol.Text.Equals(""))
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
                    //pEstadocivil = 0;
                    //pEstadocivil = Convert.ToInt32(resultado.Rows[0]["Estado_Civil"].ToString());
                }
            }
        }
    }
}
