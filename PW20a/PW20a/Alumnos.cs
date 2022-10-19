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
            _sCadenaConexion = "Data Source= 192.168.201.9\\LABSQL; Initial Catalog=PrograWeb20" + ";user=PWEB21;password=PWEB21"; // Abrir_base_datos();
            SqlConnection conexionDB = new SqlConnection(_sCadenaConexion);
            SqlCommand comandoSQL = new SqlCommand();

            comandoSQL.Connection = conexionDB;
            comandoSQL.CommandText = "sp_Carreras_KLM";
            comandoSQL.CommandType = CommandType.StoredProcedure;

            comandoSQL.Parameters.Add(new SqlParameter("@OPERACION",'T'));

            SqlDataAdapter adaptador = new SqlDataAdapter(comandoSQL);
            DataTable resultado = new DataTable();
            adaptador.Fill(resultado);

            cboMaterias.DisplayMember = "Nom_Materia";
            cboMaterias.ValueMember = "Id_Materia";
            cboMaterias.DataSource = resultado;
        }
    }
}
