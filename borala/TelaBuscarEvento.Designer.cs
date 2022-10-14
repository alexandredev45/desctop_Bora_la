
namespace borala
{
    partial class TelaBuscarEvento
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
            this.boraLati44DataSet3 = new borala.BoraLati44DataSet3();
            this.eventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventoTableAdapter = new borala.BoraLati44DataSet3TableAdapters.EventoTableAdapter();
            this.idEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGerenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(31, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 565);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEventoDataGridViewTextBoxColumn,
            this.nomeEventoDataGridViewTextBoxColumn,
            this.descricaoEventoDataGridViewTextBoxColumn,
            this.dataEventoDataGridViewTextBoxColumn,
            this.localEventoDataGridViewTextBoxColumn,
            this.idGerenciaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.eventoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(692, 496);
            this.dataGridView1.TabIndex = 0;
            // 
            // boraLati44DataSet3
            // 
            this.boraLati44DataSet3.DataSetName = "BoraLati44DataSet3";
            this.boraLati44DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventoBindingSource
            // 
            this.eventoBindingSource.DataMember = "Evento";
            this.eventoBindingSource.DataSource = this.boraLati44DataSet3;
            // 
            // eventoTableAdapter
            // 
            this.eventoTableAdapter.ClearBeforeFill = true;
            // 
            // idEventoDataGridViewTextBoxColumn
            // 
            this.idEventoDataGridViewTextBoxColumn.DataPropertyName = "IdEvento";
            this.idEventoDataGridViewTextBoxColumn.HeaderText = "IdEvento";
            this.idEventoDataGridViewTextBoxColumn.Name = "idEventoDataGridViewTextBoxColumn";
            this.idEventoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeEventoDataGridViewTextBoxColumn
            // 
            this.nomeEventoDataGridViewTextBoxColumn.DataPropertyName = "NomeEvento";
            this.nomeEventoDataGridViewTextBoxColumn.HeaderText = "NomeEvento";
            this.nomeEventoDataGridViewTextBoxColumn.Name = "nomeEventoDataGridViewTextBoxColumn";
            // 
            // descricaoEventoDataGridViewTextBoxColumn
            // 
            this.descricaoEventoDataGridViewTextBoxColumn.DataPropertyName = "DescricaoEvento";
            this.descricaoEventoDataGridViewTextBoxColumn.HeaderText = "DescricaoEvento";
            this.descricaoEventoDataGridViewTextBoxColumn.Name = "descricaoEventoDataGridViewTextBoxColumn";
            // 
            // dataEventoDataGridViewTextBoxColumn
            // 
            this.dataEventoDataGridViewTextBoxColumn.DataPropertyName = "DataEvento";
            this.dataEventoDataGridViewTextBoxColumn.HeaderText = "DataEvento";
            this.dataEventoDataGridViewTextBoxColumn.Name = "dataEventoDataGridViewTextBoxColumn";
            // 
            // localEventoDataGridViewTextBoxColumn
            // 
            this.localEventoDataGridViewTextBoxColumn.DataPropertyName = "LocalEvento";
            this.localEventoDataGridViewTextBoxColumn.HeaderText = "LocalEvento";
            this.localEventoDataGridViewTextBoxColumn.Name = "localEventoDataGridViewTextBoxColumn";
            // 
            // idGerenciaDataGridViewTextBoxColumn
            // 
            this.idGerenciaDataGridViewTextBoxColumn.DataPropertyName = "IdGerencia";
            this.idGerenciaDataGridViewTextBoxColumn.HeaderText = "IdGerencia";
            this.idGerenciaDataGridViewTextBoxColumn.Name = "idGerenciaDataGridViewTextBoxColumn";
            // 
            // TelaBuscarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 627);
            this.Controls.Add(this.panel1);
            this.Name = "TelaBuscarEvento";
            this.Text = "TelaBuscarEvento";
            this.Load += new System.EventHandler(this.TelaBuscarEvento_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BoraLati44DataSet3 boraLati44DataSet3;
        private System.Windows.Forms.BindingSource eventoBindingSource;
        private BoraLati44DataSet3TableAdapters.EventoTableAdapter eventoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localEventoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGerenciaDataGridViewTextBoxColumn;
    }
}