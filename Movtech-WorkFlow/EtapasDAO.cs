using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Movtech_WorkFlow
{
    public class EtapasDAO
    {
        private SqlConnection Connection { get; }

        public EtapasDAO(SqlConnection connection)
        {
            Connection = connection;
        }

        public void Salvar(EtapasModel etapas)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();

                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"INSERT INTO MvtCadEtapas(etapas, seqOrdem, leadTime) VALUES(@etapas, @seqOrdem, @leadTime)");
                    command.CommandText = sql.ToString();
                    command.Parameters.Add(new SqlParameter("@etapas", etapas.Etapas));
                    command.Parameters.Add(new SqlParameter("@seqOrdem", etapas.SeqOrdem));
                    command.Parameters.Add(new SqlParameter("@leadTime", etapas.LeadTime));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public void Editar(EtapasModel etapas)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                SqlTransaction t = Connection.BeginTransaction();
                
                try
                {
                    StringBuilder sql = new StringBuilder();
                    sql.AppendLine($"UPDATE MvtCadEtapas SET etapas = @etapas, seqOrdem = @seqOrdem, leadTime = @leadTime WHERE codEtapas = @codEtapas");
                    command.CommandText = sql.ToString();
                    command.Parameters.AddWithValue("@codEtapas", etapas.CodEtapas);
                    command.Parameters.Add(new SqlParameter("@etapas", etapas.Etapas));
                    command.Parameters.Add(new SqlParameter("@seqOrdem", etapas.SeqOrdem));
                    command.Parameters.Add(new SqlParameter("@leadTime", etapas.LeadTime));
                    command.Transaction = t;
                    command.ExecuteNonQuery();
                    t.Commit();
                }
                catch (Exception ex)
                {
                    t.Rollback();
                    throw ex;
                }
            }
        }

        public void Excluir(EtapasModel etapas, SqlTransaction t = null)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"DELETE FROM MvtCadEtapas WHERE codEtapas = @codEtapas");
                command.CommandText= sql.ToString();
                command.Parameters.AddWithValue("@codEtapas", etapas.CodEtapas);
                command.ExecuteNonQuery();
            }
        }

        public int VerificaRegistros(EtapasModel etapas)
        {
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine($"SELECT COUNT(codEtapas) FROM MvtCadEtapas WHERE codEtapas = @codEtapas");
                command.CommandText= sql.ToString();
                command.Parameters.AddWithValue("@codEtapas", etapas.CodEtapas);
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }
        }

        public bool VerificaCampos(EtapasModel etapas) 
        { 
            if (string.IsNullOrEmpty(etapas.CodEtapas))
            {
                MessageBox.Show("Informe o campo do Código da Etapa!");
                return false;
            }
            if (string.IsNullOrEmpty(etapas.Etapas))
            {
                MessageBox.Show("Informe o campo do Nome da Etapa!");
                return false;
            }
            if (string.IsNullOrEmpty(etapas.SeqOrdem))
            {
                MessageBox.Show("Informe o campo da Sequência da Etapa!");
                return false;
            }
            if (string.IsNullOrEmpty(etapas.LeadTime))
            {
                MessageBox.Show("Informe o campo do LeadTime da Etapa!");
                return false;
            }
            return true;
        }

        public List<EtapasModel> GetEtapas()
        {
            List<EtapasModel> etapas = new List<EtapasModel>();
            using (SqlCommand command = Connection.CreateCommand())
            {
                StringBuilder sql = new StringBuilder();
                sql.AppendLine("SELECT codEtapas, etapas, seqOrdem, leadTime FROM MvtCadEtapas ORDER BY seqOrdem");
                command.CommandText = sql.ToString();
                using (SqlDataReader dr = command.ExecuteReader()) 
                { 
                    while (dr.Read())
                    {
                        etapas.Add(PopulateDr(dr));
                    }
                }
            }
            return etapas;
        }

        private EtapasModel PopulateDr(SqlDataReader dr)
        {
            string codEtapas = "";
            string etapas = "";
            string seqOrdem = "";
            string leadTime = "";

            if(DBNull.Value != dr["codEtapas"])
            {
                codEtapas = dr["codEtapas"] + "";
            }
            if (DBNull.Value != dr["etapas"])
            {
                etapas = dr["etapas"] + "";
            }
            if (DBNull.Value != dr["seqOrdem"])
            {
                seqOrdem = dr["seqOrdem"] + "";
            }
            if (DBNull.Value != dr["leadTime"])
            {
                leadTime = dr["leadTime"] + "";
            }
            return new EtapasModel()
            {
                CodEtapas = codEtapas,
                Etapas = etapas,
                SeqOrdem = seqOrdem,
                LeadTime = leadTime
            };
        }
    }
}
