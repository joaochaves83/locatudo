
namespace locatudo
{
    partial class frlocatudo
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
            this.txnome = new System.Windows.Forms.TextBox();
            this.txtelefone = new System.Windows.Forms.TextBox();
            this.txcpf = new System.Windows.Forms.TextBox();
            this.txendereco = new System.Windows.Forms.TextBox();
            this.txsexo = new System.Windows.Forms.TextBox();
            this.btlimpar = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.dgtab = new System.Windows.Forms.DataGridView();
            this.dgid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgnome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgtelefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbtelefone = new System.Windows.Forms.Label();
            this.lbcpf = new System.Windows.Forms.Label();
            this.lbendereco = new System.Windows.Forms.Label();
            this.blsexo = new System.Windows.Forms.Label();
            this.bteditar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.txid = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbativo = new System.Windows.Forms.Label();
            this.txativo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtab)).BeginInit();
            this.SuspendLayout();
            // 
            // txnome
            // 
            this.txnome.Location = new System.Drawing.Point(25, 26);
            this.txnome.Name = "txnome";
            this.txnome.Size = new System.Drawing.Size(301, 20);
            this.txnome.TabIndex = 0;
            // 
            // txtelefone
            // 
            this.txtelefone.Location = new System.Drawing.Point(345, 26);
            this.txtelefone.Name = "txtelefone";
            this.txtelefone.Size = new System.Drawing.Size(149, 20);
            this.txtelefone.TabIndex = 2;
            // 
            // txcpf
            // 
            this.txcpf.Location = new System.Drawing.Point(345, 73);
            this.txcpf.Name = "txcpf";
            this.txcpf.Size = new System.Drawing.Size(149, 20);
            this.txcpf.TabIndex = 3;
            // 
            // txendereco
            // 
            this.txendereco.Location = new System.Drawing.Point(25, 73);
            this.txendereco.Name = "txendereco";
            this.txendereco.Size = new System.Drawing.Size(223, 20);
            this.txendereco.TabIndex = 4;
            // 
            // txsexo
            // 
            this.txsexo.Location = new System.Drawing.Point(509, 26);
            this.txsexo.Name = "txsexo";
            this.txsexo.Size = new System.Drawing.Size(75, 20);
            this.txsexo.TabIndex = 5;
            // 
            // btlimpar
            // 
            this.btlimpar.Location = new System.Drawing.Point(509, 105);
            this.btlimpar.Name = "btlimpar";
            this.btlimpar.Size = new System.Drawing.Size(75, 23);
            this.btlimpar.TabIndex = 6;
            this.btlimpar.Text = "Limpar";
            this.btlimpar.UseVisualStyleBackColor = true;
            this.btlimpar.Click += new System.EventHandler(this.btlimpar_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.Location = new System.Drawing.Point(25, 105);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(75, 23);
            this.btsalvar.TabIndex = 7;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = true;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // dgtab
            // 
            this.dgtab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgid,
            this.dgnome,
            this.dgtelefone});
            this.dgtab.Location = new System.Drawing.Point(25, 156);
            this.dgtab.Name = "dgtab";
            this.dgtab.Size = new System.Drawing.Size(559, 282);
            this.dgtab.TabIndex = 8;
            this.dgtab.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgtab_CellContentClick);
            // 
            // dgid
            // 
            this.dgid.HeaderText = "id";
            this.dgid.Name = "dgid";
            // 
            // dgnome
            // 
            this.dgnome.HeaderText = "Nome";
            this.dgnome.Name = "dgnome";
            this.dgnome.Width = 240;
            // 
            // dgtelefone
            // 
            this.dgtelefone.HeaderText = "Telefone";
            this.dgtelefone.Name = "dgtelefone";
            this.dgtelefone.Width = 160;
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Location = new System.Drawing.Point(25, 4);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(35, 13);
            this.lbnome.TabIndex = 9;
            this.lbnome.Text = "Nome";
            // 
            // lbtelefone
            // 
            this.lbtelefone.AutoSize = true;
            this.lbtelefone.Location = new System.Drawing.Point(342, 4);
            this.lbtelefone.Name = "lbtelefone";
            this.lbtelefone.Size = new System.Drawing.Size(49, 13);
            this.lbtelefone.TabIndex = 11;
            this.lbtelefone.Text = "Telefone";
            // 
            // lbcpf
            // 
            this.lbcpf.AutoSize = true;
            this.lbcpf.Location = new System.Drawing.Point(342, 54);
            this.lbcpf.Name = "lbcpf";
            this.lbcpf.Size = new System.Drawing.Size(27, 13);
            this.lbcpf.TabIndex = 12;
            this.lbcpf.Text = "CPF";
            // 
            // lbendereco
            // 
            this.lbendereco.AutoSize = true;
            this.lbendereco.Location = new System.Drawing.Point(22, 54);
            this.lbendereco.Name = "lbendereco";
            this.lbendereco.Size = new System.Drawing.Size(53, 13);
            this.lbendereco.TabIndex = 13;
            this.lbendereco.Text = "Endereço";
            // 
            // blsexo
            // 
            this.blsexo.AutoSize = true;
            this.blsexo.Location = new System.Drawing.Point(506, 4);
            this.blsexo.Name = "blsexo";
            this.blsexo.Size = new System.Drawing.Size(31, 13);
            this.blsexo.TabIndex = 14;
            this.blsexo.Text = "Sexo";
            // 
            // bteditar
            // 
            this.bteditar.Location = new System.Drawing.Point(189, 105);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(75, 23);
            this.bteditar.TabIndex = 15;
            this.bteditar.Text = "Editar";
            this.bteditar.UseVisualStyleBackColor = true;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.Location = new System.Drawing.Point(345, 105);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(75, 23);
            this.btexcluir.TabIndex = 16;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = true;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // txid
            // 
            this.txid.Enabled = false;
            this.txid.Location = new System.Drawing.Point(509, 73);
            this.txid.Name = "txid";
            this.txid.Size = new System.Drawing.Size(75, 20);
            this.txid.TabIndex = 17;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(506, 54);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(16, 13);
            this.lbId.TabIndex = 18;
            this.lbId.Text = "Id";
            // 
            // lbativo
            // 
            this.lbativo.AutoSize = true;
            this.lbativo.Location = new System.Drawing.Point(251, 54);
            this.lbativo.Name = "lbativo";
            this.lbativo.Size = new System.Drawing.Size(31, 13);
            this.lbativo.TabIndex = 20;
            this.lbativo.Text = "Ativo";
            // 
            // txativo
            // 
            this.txativo.Location = new System.Drawing.Point(254, 73);
            this.txativo.Name = "txativo";
            this.txativo.Size = new System.Drawing.Size(72, 20);
            this.txativo.TabIndex = 21;
            // 
            // frlocatudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.txativo);
            this.Controls.Add(this.lbativo);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.txid);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.bteditar);
            this.Controls.Add(this.blsexo);
            this.Controls.Add(this.lbendereco);
            this.Controls.Add(this.lbcpf);
            this.Controls.Add(this.lbtelefone);
            this.Controls.Add(this.lbnome);
            this.Controls.Add(this.dgtab);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btlimpar);
            this.Controls.Add(this.txsexo);
            this.Controls.Add(this.txendereco);
            this.Controls.Add(this.txcpf);
            this.Controls.Add(this.txtelefone);
            this.Controls.Add(this.txnome);
            this.Name = "frlocatudo";
            this.Text = "Locatudo";
            this.Load += new System.EventHandler(this.frlocatudo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtab)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txnome;
        private System.Windows.Forms.TextBox txtelefone;
        private System.Windows.Forms.TextBox txcpf;
        private System.Windows.Forms.TextBox txendereco;
        private System.Windows.Forms.TextBox txsexo;
        private System.Windows.Forms.Button btlimpar;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.DataGridView dgtab;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Label lbtelefone;
        private System.Windows.Forms.Label lbcpf;
        private System.Windows.Forms.Label lbendereco;
        private System.Windows.Forms.Label blsexo;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.TextBox txid;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgnome;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgtelefone;
        private System.Windows.Forms.Label lbativo;
        private System.Windows.Forms.TextBox txativo;
    }
}

