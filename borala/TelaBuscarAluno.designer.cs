
namespace borala
{
    partial class TelaBuscarAluno
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.boraLati44DataSet1 = new borala.BoraLati44DataSet1();
            this.boraLati44DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boraLati44DataSet2 = new borala.BoraLati44DataSet2();
            this.alunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alunoTableAdapter = new borala.BoraLati44DataSet2TableAdapters.AlunoTableAdapter();
            this.idAlunoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGresponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFresponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeresponsavelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rendaMensalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acessointernetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(42, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 571);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlunoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nomeSocialDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.rGresponsavelDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.cPFresponsavelDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cEPDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.uFDataGridViewTextBoxColumn,
            this.dtNascimentoDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.nomeresponsavelDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.rendaMensalDataGridViewTextBoxColumn,
            this.complementoDataGridViewTextBoxColumn,
            this.acessointernetDataGridViewTextBoxColumn,
            this.cADDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alunoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(37, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1100, 499);
            this.dataGridView1.TabIndex = 0;
            // 
            // boraLati44DataSet1
            // 
            this.boraLati44DataSet1.DataSetName = "BoraLati44DataSet1";
            this.boraLati44DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // boraLati44DataSet1BindingSource
            // 
            this.boraLati44DataSet1BindingSource.DataSource = this.boraLati44DataSet1;
            this.boraLati44DataSet1BindingSource.Position = 0;
            // 
            // boraLati44DataSet2
            // 
            this.boraLati44DataSet2.DataSetName = "BoraLati44DataSet2";
            this.boraLati44DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alunoBindingSource
            // 
            this.alunoBindingSource.DataMember = "Aluno";
            this.alunoBindingSource.DataSource = this.boraLati44DataSet2;
            // 
            // alunoTableAdapter
            // 
            this.alunoTableAdapter.ClearBeforeFill = true;
            // 
            // idAlunoDataGridViewTextBoxColumn
            // 
            this.idAlunoDataGridViewTextBoxColumn.DataPropertyName = "IdAluno";
            this.idAlunoDataGridViewTextBoxColumn.HeaderText = "IdAluno";
            this.idAlunoDataGridViewTextBoxColumn.Name = "idAlunoDataGridViewTextBoxColumn";
            this.idAlunoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // nomeSocialDataGridViewTextBoxColumn
            // 
            this.nomeSocialDataGridViewTextBoxColumn.DataPropertyName = "NomeSocial";
            this.nomeSocialDataGridViewTextBoxColumn.HeaderText = "NomeSocial";
            this.nomeSocialDataGridViewTextBoxColumn.Name = "nomeSocialDataGridViewTextBoxColumn";
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            // 
            // rGresponsavelDataGridViewTextBoxColumn
            // 
            this.rGresponsavelDataGridViewTextBoxColumn.DataPropertyName = "RGresponsavel";
            this.rGresponsavelDataGridViewTextBoxColumn.HeaderText = "RGresponsavel";
            this.rGresponsavelDataGridViewTextBoxColumn.Name = "rGresponsavelDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // cPFresponsavelDataGridViewTextBoxColumn
            // 
            this.cPFresponsavelDataGridViewTextBoxColumn.DataPropertyName = "CPFresponsavel";
            this.cPFresponsavelDataGridViewTextBoxColumn.HeaderText = "CPFresponsavel";
            this.cPFresponsavelDataGridViewTextBoxColumn.Name = "cPFresponsavelDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // cEPDataGridViewTextBoxColumn
            // 
            this.cEPDataGridViewTextBoxColumn.DataPropertyName = "CEP";
            this.cEPDataGridViewTextBoxColumn.HeaderText = "CEP";
            this.cEPDataGridViewTextBoxColumn.Name = "cEPDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            // 
            // uFDataGridViewTextBoxColumn
            // 
            this.uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            this.uFDataGridViewTextBoxColumn.HeaderText = "UF";
            this.uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            // 
            // dtNascimentoDataGridViewTextBoxColumn
            // 
            this.dtNascimentoDataGridViewTextBoxColumn.DataPropertyName = "dtNascimento";
            this.dtNascimentoDataGridViewTextBoxColumn.HeaderText = "dtNascimento";
            this.dtNascimentoDataGridViewTextBoxColumn.Name = "dtNascimentoDataGridViewTextBoxColumn";
            // 
            // generoDataGridViewTextBoxColumn
            // 
            this.generoDataGridViewTextBoxColumn.DataPropertyName = "Genero";
            this.generoDataGridViewTextBoxColumn.HeaderText = "Genero";
            this.generoDataGridViewTextBoxColumn.Name = "generoDataGridViewTextBoxColumn";
            // 
            // nomeresponsavelDataGridViewTextBoxColumn
            // 
            this.nomeresponsavelDataGridViewTextBoxColumn.DataPropertyName = "Nomeresponsavel";
            this.nomeresponsavelDataGridViewTextBoxColumn.HeaderText = "Nomeresponsavel";
            this.nomeresponsavelDataGridViewTextBoxColumn.Name = "nomeresponsavelDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // rendaMensalDataGridViewTextBoxColumn
            // 
            this.rendaMensalDataGridViewTextBoxColumn.DataPropertyName = "RendaMensal";
            this.rendaMensalDataGridViewTextBoxColumn.HeaderText = "RendaMensal";
            this.rendaMensalDataGridViewTextBoxColumn.Name = "rendaMensalDataGridViewTextBoxColumn";
            // 
            // complementoDataGridViewTextBoxColumn
            // 
            this.complementoDataGridViewTextBoxColumn.DataPropertyName = "Complemento";
            this.complementoDataGridViewTextBoxColumn.HeaderText = "Complemento";
            this.complementoDataGridViewTextBoxColumn.Name = "complementoDataGridViewTextBoxColumn";
            // 
            // acessointernetDataGridViewTextBoxColumn
            // 
            this.acessointernetDataGridViewTextBoxColumn.DataPropertyName = "Acessointernet";
            this.acessointernetDataGridViewTextBoxColumn.HeaderText = "Acessointernet";
            this.acessointernetDataGridViewTextBoxColumn.Name = "acessointernetDataGridViewTextBoxColumn";
            // 
            // cADDataGridViewTextBoxColumn
            // 
            this.cADDataGridViewTextBoxColumn.DataPropertyName = "CAD";
            this.cADDataGridViewTextBoxColumn.HeaderText = "CAD";
            this.cADDataGridViewTextBoxColumn.Name = "cADDataGridViewTextBoxColumn";
            // 
            // TelaBuscarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 637);
            this.Controls.Add(this.panel1);
            this.Name = "TelaBuscarAluno";
            this.Text = "TelaBuscarAluno";
            this.Load += new System.EventHandler(this.TelaBuscarAluno_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource boraLati44DataSet1BindingSource;
        private BoraLati44DataSet1 boraLati44DataSet1;
        private BoraLati44DataSet2 boraLati44DataSet2;
        private System.Windows.Forms.BindingSource alunoBindingSource;
        private BoraLati44DataSet2TableAdapters.AlunoTableAdapter alunoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlunoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGresponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFresponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeresponsavelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rendaMensalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn complementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acessointernetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cADDataGridViewTextBoxColumn;
    }
}