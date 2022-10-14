
namespace borala
{
    partial class TelaBuscarTurma
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
            this.boraLati44DataSet4 = new borala.BoraLati44DataSet4();
            this.turmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.turmaTableAdapter = new borala.BoraLati44DataSet4TableAdapters.TurmaTableAdapter();
            this.idTurmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(39, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(847, 379);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idTurmaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.periodoDataGridViewTextBoxColumn,
            this.horarioInicioDataGridViewTextBoxColumn,
            this.horarioFimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.turmaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(581, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // boraLati44DataSet4
            // 
            this.boraLati44DataSet4.DataSetName = "BoraLati44DataSet4";
            this.boraLati44DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // turmaBindingSource
            // 
            this.turmaBindingSource.DataMember = "Turma";
            this.turmaBindingSource.DataSource = this.boraLati44DataSet4;
            // 
            // turmaTableAdapter
            // 
            this.turmaTableAdapter.ClearBeforeFill = true;
            // 
            // idTurmaDataGridViewTextBoxColumn
            // 
            this.idTurmaDataGridViewTextBoxColumn.DataPropertyName = "IdTurma";
            this.idTurmaDataGridViewTextBoxColumn.HeaderText = "IdTurma";
            this.idTurmaDataGridViewTextBoxColumn.Name = "idTurmaDataGridViewTextBoxColumn";
            this.idTurmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // periodoDataGridViewTextBoxColumn
            // 
            this.periodoDataGridViewTextBoxColumn.DataPropertyName = "Periodo";
            this.periodoDataGridViewTextBoxColumn.HeaderText = "Periodo";
            this.periodoDataGridViewTextBoxColumn.Name = "periodoDataGridViewTextBoxColumn";
            // 
            // horarioInicioDataGridViewTextBoxColumn
            // 
            this.horarioInicioDataGridViewTextBoxColumn.DataPropertyName = "HorarioInicio";
            this.horarioInicioDataGridViewTextBoxColumn.HeaderText = "HorarioInicio";
            this.horarioInicioDataGridViewTextBoxColumn.Name = "horarioInicioDataGridViewTextBoxColumn";
            // 
            // horarioFimDataGridViewTextBoxColumn
            // 
            this.horarioFimDataGridViewTextBoxColumn.DataPropertyName = "HorarioFim";
            this.horarioFimDataGridViewTextBoxColumn.HeaderText = "HorarioFim";
            this.horarioFimDataGridViewTextBoxColumn.Name = "horarioFimDataGridViewTextBoxColumn";
            // 
            // TelaBuscarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 450);
            this.Controls.Add(this.panel1);
            this.Name = "TelaBuscarTurma";
            this.Text = "TelaBuscarTurma";
            this.Load += new System.EventHandler(this.TelaBuscarTurma_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turmaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BoraLati44DataSet4 boraLati44DataSet4;
        private System.Windows.Forms.BindingSource turmaBindingSource;
        private BoraLati44DataSet4TableAdapters.TurmaTableAdapter turmaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idTurmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioFimDataGridViewTextBoxColumn;
    }
}