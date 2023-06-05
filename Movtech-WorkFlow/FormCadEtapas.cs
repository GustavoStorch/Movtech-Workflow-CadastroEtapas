using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Movtech_WorkFlow
{
    public partial class FormCadEtapas : Form
    {
        public FormCadEtapas()
        {
            InitializeComponent();
        }

        private void FormCadEtapas_Load(object sender, EventArgs e)
        {
            CarregaID();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Tem certeza que deseja excluir a Etapa?", "Ops, tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao excluir a Etapa!\n{ex.Message}");
            }
        }

        public void LimparForm()
        {
            txtCodEtapa.Text = string.Empty;
            txtNomeEtapa.Text = string.Empty;
            txtSeqEtapas.Text = string.Empty;
            txtLeadTime.Text = string.Empty;
        }

        private void InitializeTable()
        {
            dtgDadosEtapas.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                EtapasDAO dao = new EtapasDAO(connection);
                List<EtapasModel> etapas = dao.GetEtapas();
                foreach(EtapasModel etapa in etapas)
                {
                    DataGridViewRow row = dtgDadosEtapas.Rows[dtgDadosEtapas.Rows.Add()];
                    row.Cells[colCodEtapa.Index].Value = etapa.CodEtapas;
                    row.Cells[colNomeEtapa.Index].Value = etapa.Etapas;
                    row.Cells[colSeqEtapa.Index].Value = etapa.SeqOrdem;
                    row.Cells[colLeadTime.Index].Value = etapa.LeadTime;
                }
            }
        }

        private void CarregaID()
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT('MvtCadEtapas') + 1", connection);
                int nextCod = Convert.ToInt32(command.ExecuteScalar());

                txtCodEtapa.Text = nextCod.ToString();
            }
        }
    }
}
