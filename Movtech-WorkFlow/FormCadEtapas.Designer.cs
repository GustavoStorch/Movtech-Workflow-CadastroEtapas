namespace Movtech_WorkFlow
{
    partial class FormCadEtapas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadEtapas));
            this.lblCodEtapa = new System.Windows.Forms.Label();
            this.lblNomeEtapa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLeadTime = new System.Windows.Forms.Label();
            this.txtCodEtapa = new System.Windows.Forms.TextBox();
            this.txtNomeEtapa = new System.Windows.Forms.TextBox();
            this.txtSeqEtapas = new System.Windows.Forms.TextBox();
            this.txtLeadTime = new System.Windows.Forms.TextBox();
            this.dtgDadosEtapas = new System.Windows.Forms.DataGridView();
            this.colCodEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNomeEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSeqEtapa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLeadTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosEtapas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodEtapa
            // 
            this.lblCodEtapa.AutoSize = true;
            this.lblCodEtapa.Location = new System.Drawing.Point(12, 17);
            this.lblCodEtapa.Name = "lblCodEtapa";
            this.lblCodEtapa.Size = new System.Drawing.Size(63, 20);
            this.lblCodEtapa.TabIndex = 0;
            this.lblCodEtapa.Text = "Código:";
            // 
            // lblNomeEtapa
            // 
            this.lblNomeEtapa.AutoSize = true;
            this.lblNomeEtapa.Location = new System.Drawing.Point(12, 52);
            this.lblNomeEtapa.Name = "lblNomeEtapa";
            this.lblNomeEtapa.Size = new System.Drawing.Size(56, 20);
            this.lblNomeEtapa.TabIndex = 1;
            this.lblNomeEtapa.Text = "Etapa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sequência:";
            // 
            // lblLeadTime
            // 
            this.lblLeadTime.AutoSize = true;
            this.lblLeadTime.Location = new System.Drawing.Point(227, 91);
            this.lblLeadTime.Name = "lblLeadTime";
            this.lblLeadTime.Size = new System.Drawing.Size(87, 20);
            this.lblLeadTime.TabIndex = 3;
            this.lblLeadTime.Text = "Lead Time:";
            // 
            // txtCodEtapa
            // 
            this.txtCodEtapa.Enabled = false;
            this.txtCodEtapa.Location = new System.Drawing.Point(107, 14);
            this.txtCodEtapa.Name = "txtCodEtapa";
            this.txtCodEtapa.Size = new System.Drawing.Size(114, 26);
            this.txtCodEtapa.TabIndex = 0;
            // 
            // txtNomeEtapa
            // 
            this.txtNomeEtapa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomeEtapa.Location = new System.Drawing.Point(107, 49);
            this.txtNomeEtapa.Name = "txtNomeEtapa";
            this.txtNomeEtapa.Size = new System.Drawing.Size(473, 26);
            this.txtNomeEtapa.TabIndex = 1;
            // 
            // txtSeqEtapas
            // 
            this.txtSeqEtapas.Location = new System.Drawing.Point(107, 88);
            this.txtSeqEtapas.Name = "txtSeqEtapas";
            this.txtSeqEtapas.Size = new System.Drawing.Size(114, 26);
            this.txtSeqEtapas.TabIndex = 2;
            // 
            // txtLeadTime
            // 
            this.txtLeadTime.Location = new System.Drawing.Point(320, 88);
            this.txtLeadTime.Name = "txtLeadTime";
            this.txtLeadTime.Size = new System.Drawing.Size(114, 26);
            this.txtLeadTime.TabIndex = 3;
            // 
            // dtgDadosEtapas
            // 
            this.dtgDadosEtapas.AllowUserToAddRows = false;
            this.dtgDadosEtapas.AllowUserToDeleteRows = false;
            this.dtgDadosEtapas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDadosEtapas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDadosEtapas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDadosEtapas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodEtapa,
            this.colNomeEtapa,
            this.colSeqEtapa,
            this.colLeadTime});
            this.dtgDadosEtapas.Location = new System.Drawing.Point(16, 164);
            this.dtgDadosEtapas.Name = "dtgDadosEtapas";
            this.dtgDadosEtapas.ReadOnly = true;
            this.dtgDadosEtapas.RowHeadersWidth = 62;
            this.dtgDadosEtapas.RowTemplate.Height = 28;
            this.dtgDadosEtapas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDadosEtapas.Size = new System.Drawing.Size(564, 269);
            this.dtgDadosEtapas.TabIndex = 6;
            this.dtgDadosEtapas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgDadosEtapas_CellDoubleClick);
            // 
            // colCodEtapa
            // 
            this.colCodEtapa.FillWeight = 27.36317F;
            this.colCodEtapa.HeaderText = "Código";
            this.colCodEtapa.MinimumWidth = 8;
            this.colCodEtapa.Name = "colCodEtapa";
            this.colCodEtapa.ReadOnly = true;
            // 
            // colNomeEtapa
            // 
            this.colNomeEtapa.FillWeight = 60.80705F;
            this.colNomeEtapa.HeaderText = "Etapa";
            this.colNomeEtapa.MinimumWidth = 8;
            this.colNomeEtapa.Name = "colNomeEtapa";
            this.colNomeEtapa.ReadOnly = true;
            // 
            // colSeqEtapa
            // 
            this.colSeqEtapa.FillWeight = 40F;
            this.colSeqEtapa.HeaderText = "Sequência";
            this.colSeqEtapa.MinimumWidth = 8;
            this.colSeqEtapa.Name = "colSeqEtapa";
            this.colSeqEtapa.ReadOnly = true;
            // 
            // colLeadTime
            // 
            this.colLeadTime.FillWeight = 40F;
            this.colLeadTime.HeaderText = "LeadTime";
            this.colLeadTime.MinimumWidth = 8;
            this.colLeadTime.Name = "colLeadTime";
            this.colLeadTime.ReadOnly = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(340, 122);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(116, 34);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(464, 122);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(116, 34);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FormCadEtapas
            // 
            this.AcceptButton = this.btnSalvar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 445);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtgDadosEtapas);
            this.Controls.Add(this.txtLeadTime);
            this.Controls.Add(this.txtSeqEtapas);
            this.Controls.Add(this.txtNomeEtapa);
            this.Controls.Add(this.txtCodEtapa);
            this.Controls.Add(this.lblLeadTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNomeEtapa);
            this.Controls.Add(this.lblCodEtapa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCadEtapas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Etapas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCadEtapas_FormClosing);
            this.Load += new System.EventHandler(this.FormCadEtapas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDadosEtapas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodEtapa;
        private System.Windows.Forms.Label lblNomeEtapa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLeadTime;
        private System.Windows.Forms.TextBox txtCodEtapa;
        private System.Windows.Forms.TextBox txtNomeEtapa;
        private System.Windows.Forms.TextBox txtSeqEtapas;
        private System.Windows.Forms.TextBox txtLeadTime;
        private System.Windows.Forms.DataGridView dtgDadosEtapas;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodEtapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeEtapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSeqEtapa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLeadTime;
    }
}

