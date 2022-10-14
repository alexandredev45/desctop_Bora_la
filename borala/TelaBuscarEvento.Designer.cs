
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
            this.idEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localEventoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idGerenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.boraLati44DataSet3 = new borala.BoraLati44DataSet3();
            this.eventoTableAdapter = new borala.BoraLati44DataSet3TableAdapters.EventoTableAdapter();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_cadastrar_evento = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(31, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 437);
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
            this.dataGridView1.Size = new System.Drawing.Size(692, 389);
            this.dataGridView1.TabIndex = 0;
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
            // eventoBindingSource
            // 
            this.eventoBindingSource.DataMember = "Evento";
            this.eventoBindingSource.DataSource = this.boraLati44DataSet3;
            // 
            // boraLati44DataSet3
            // 
            this.boraLati44DataSet3.DataSetName = "BoraLati44DataSet3";
            this.boraLati44DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventoTableAdapter
            // 
            this.eventoTableAdapter.ClearBeforeFill = true;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Location = new System.Drawing.Point(467, 506);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(98, 39);
            this.btn_cadastrar.TabIndex = 6;
            this.btn_cadastrar.Text = "Excluir";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(352, 506);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 39);
            this.button2.TabIndex = 5;
            this.button2.Text = "Atualizar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_cadastrar_evento
            // 
            this.btn_cadastrar_evento.Location = new System.Drawing.Point(236, 506);
            this.btn_cadastrar_evento.Name = "btn_cadastrar_evento";
            this.btn_cadastrar_evento.Size = new System.Drawing.Size(98, 39);
            this.btn_cadastrar_evento.TabIndex = 4;
            this.btn_cadastrar_evento.Text = "Cadastrar";
            this.btn_cadastrar_evento.UseVisualStyleBackColor = true;
            this.btn_cadastrar_evento.Click += new System.EventHandler(this.btn_cadastrar_evento_Click);
            // 
            // TelaBuscarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 627);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_cadastrar_evento);
            this.Name = "TelaBuscarEvento";
            this.Text = "TelaBuscarEvento";
            this.Load += new System.EventHandler(this.TelaBuscarEvento_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boraLati44DataSet3)).EndInit();
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
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_cadastrar_evento;
    }
}