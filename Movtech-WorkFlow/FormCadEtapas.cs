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
            InitializeTable();
            CarregaID();
            btnExcluir.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    EtapasDAO dao = new EtapasDAO(connection);

                    bool verificaCampos = dao.VerificaCampos(new EtapasModel()
                    {
                        CodEtapas = txtCodEtapa.Text,
                        Etapas = txtNomeEtapa.Text,
                        SeqOrdem = txtSeqEtapas.Text,
                        LeadTime = txtLeadTime.Text
                    });

                    if (verificaCampos)
                    {
                        int count = dao.VerificaRegistros(new EtapasModel()
                        {
                            CodEtapas = txtCodEtapa.Text
                        });

                        if(count > 0)
                        {
                            dao.Editar(new EtapasModel()
                            {
                                CodEtapas = txtCodEtapa.Text,
                                Etapas = txtNomeEtapa.Text,
                                SeqOrdem = txtSeqEtapas.Text,
                                LeadTime = txtLeadTime.Text
                            });
                            MessageBox.Show("Etapa atualizada com sucesso!");
                        } else
                        {
                            dao.Salvar(new EtapasModel()
                            {
                                Etapas = txtNomeEtapa.Text,
                                SeqOrdem = txtSeqEtapas.Text,
                                LeadTime = txtLeadTime.Text
                            });
                            MessageBox.Show("Etapa cadastrada com sucesso!");
                        }
                    }
                }

                InitializeTable();
                LimparForm();
                CarregaID();
                btnExcluir.Enabled = false;
            } catch(Exception ex)
            {
                MessageBox.Show($"Houve um problema ao salvar o usuário!\n{ex.Message}");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult conf = MessageBox.Show("Tem certeza que deseja excluir a Etapa?", "Ops, tem certeza?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if(conf == DialogResult.Yes) 
                { 
                    using (SqlConnection connection = DaoConnection.GetConexao())
                    {
                        EtapasDAO dao = new EtapasDAO(connection);

                        bool verificaCampos = dao.VerificaCampos(new EtapasModel()
                        {
                            CodEtapas = txtCodEtapa.Text,
                            Etapas = txtNomeEtapa.Text,
                            SeqOrdem = txtSeqEtapas.Text,
                            LeadTime = txtLeadTime.Text
                        });

                        if (verificaCampos )
                        {
                            dao.Excluir(new EtapasModel()
                            {
                                CodEtapas = txtCodEtapa.Text
                            });
                            MessageBox.Show("Etapa excluída com sucesso!");
                        }
                    }
                    InitializeTable();
                    LimparForm();
                    CarregaID();
                    btnExcluir.Enabled = false;
                }
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

        private void dtgDadosEtapas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodEtapa.Text = dtgDadosEtapas.Rows[e.RowIndex].Cells[colCodEtapa.Index].Value + "";
                txtNomeEtapa.Text = dtgDadosEtapas.Rows[e.RowIndex].Cells[colNomeEtapa.Index].Value + "";
                txtSeqEtapas.Text = dtgDadosEtapas.Rows[e.RowIndex].Cells[colSeqEtapa.Index].Value + "";
                txtLeadTime.Text = dtgDadosEtapas.Rows[e.RowIndex].Cells[colLeadTime.Index].Value + "";

                if (string.IsNullOrEmpty(txtNomeEtapa.Text)){
                    btnExcluir.Enabled = false;
                    CarregaID();
                } else
                {
                    btnExcluir.Enabled = true;
                }
            }
        }

        private void FormCadEtapas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);

                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
