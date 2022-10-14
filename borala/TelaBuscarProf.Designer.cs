
namespace borala
{
    partial class TelaBuscarProf
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
            this.boraLati44DataSet5 = new borala.BoraLati44DataSet5();
            this.profBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profTableAdapter = new borala.BoraLati44DataSet5TableAdapters.ProfTableAdapter();
            this.idProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDisciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(29, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1443, 379);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProfessorDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.enderecoDataGridViewTextBoxColumn,
            this.uFDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.dtNascimentoDataGridViewTextBoxColumn,
            this.generoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.idTurmaDataGridViewTextBoxColumn,
            this.idDisciplinaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.profBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1401, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // boraLati44DataSet5
            // 
            this.boraLati44DataSet5.DataSetName = "BoraLati44DataSet5";
            this.boraLati44DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // profBindingSource
            // 
            this.profBindingSource.DataMember = "Prof";
            this.profBindingSource.DataSource = this.boraLati44DataSet5;
            // 
            // profTableAdapter
            // 
            this.profTableAdapter.ClearBeforeFill = true;
            // 
            // idProfessorDataGridViewTextBoxColumn
            // 
            this.idProfessorDataGridViewTextBoxColumn.DataPropertyName = "IdProfessor";
            this.idProfessorDataGridViewTextBoxColumn.HeaderText = "IdProfessor";
            this.idProfessorDataGridViewTextBoxColumn.Name = "idProfessorDataGridViewTextBoxColumn";
            this.idProfessorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            // 
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "Cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "Cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            // 
            // enderecoDataGridViewTextBoxColumn
            // 
            this.enderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.HeaderText = "Endereco";
            this.enderecoDataGridViewTextBoxColumn.Name = "enderecoDataGridViewTextBoxColumn";
            // 
            // uFDataGridViewTextBoxColumn
            // 
            this.uFDataGridViewTextBoxColumn.DataPropertyName = "UF";
            this.uFDataGridViewTextBoxColumn.HeaderText = "UF";
            this.uFDataGridViewTextBoxColumn.Name = "uFDataGridViewTextBoxColumn";
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
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
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // idTurmaDataGridViewTextBoxColumn
            // 
            this.idTurmaDataGridViewTextBoxColumn.DataPropertyName = "IdTurma";
            this.idTurmaDataGridViewTextBoxColumn.HeaderText = "IdTurma";
            this.idTurmaDataGridViewTextBoxColumn.Name = "idTurmaDataGridViewTextBoxColumn";
            // 
            // idDisciplinaDataGridViewTextBoxColumn
            // 
            this.idDisciplinaDataGridViewTextBoxColumn.DataPropertyName = "IdDisciplina";
            this.idDisciplinaDataGridViewTextBoxColumn.HeaderText = "IdDisciplina";
            this.idDisciplinaDataGridViewTextBoxColumn.Name = "idDisciplinaDataGridViewTextBoxColumn";
            // 
            // TelaBuscarProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 431);
            this.Controls.Add(this.panel1);
            this.Name = "TelaBuscarProf";
            this.Text = "TelaBuscarProf";
            this.Load += new System.EventHandler(this.TelaBuscarProf_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BoraLati44DataSet5 boraLati44DataSet5;
        private System.Windows.Forms.BindingSource profBindingSource;
        private BoraLati44DataSet5TableAdapters.ProfTableAdapter profTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDisciplinaDataGridViewTextBoxColumn;
    }
}