
namespace borala
{
    partial class CadastrarEventos
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
            this.eventoTitulo = new System.Windows.Forms.Label();
            this.cadastrarEvento = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.descricaoEvento = new System.Windows.Forms.Label();
            this.localEvento = new System.Windows.Forms.Label();
            this.dataEvento = new System.Windows.Forms.Label();
            this.nomeEvento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eventoTitulo
            // 
            this.eventoTitulo.AutoSize = true;
            this.eventoTitulo.BackColor = System.Drawing.Color.White;
            this.eventoTitulo.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventoTitulo.Location = new System.Drawing.Point(309, 50);
            this.eventoTitulo.Name = "eventoTitulo";
            this.eventoTitulo.Size = new System.Drawing.Size(233, 25);
            this.eventoTitulo.TabIndex = 19;
            this.eventoTitulo.Text = "Cadastro de Eventos ";
            // 
            // cadastrarEvento
            // 
            this.cadastrarEvento.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cadastrarEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastrarEvento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cadastrarEvento.Location = new System.Drawing.Point(376, 570);
            this.cadastrarEvento.Name = "cadastrarEvento";
            this.cadastrarEvento.Size = new System.Drawing.Size(101, 31);
            this.cadastrarEvento.TabIndex = 18;
            this.cadastrarEvento.Text = "Cadastrar";
            this.cadastrarEvento.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(211, 338);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(393, 198);
            this.textBox4.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(211, 236);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(219, 62);
            this.textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(211, 165);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(464, 20);
            this.textBox1.TabIndex = 14;
            // 
            // descricaoEvento
            // 
            this.descricaoEvento.AutoSize = true;
            this.descricaoEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoEvento.Location = new System.Drawing.Point(125, 338);
            this.descricaoEvento.Name = "descricaoEvento";
            this.descricaoEvento.Size = new System.Drawing.Size(80, 20);
            this.descricaoEvento.TabIndex = 13;
            this.descricaoEvento.Text = "Descrição";
            // 
            // localEvento
            // 
            this.localEvento.AutoSize = true;
            this.localEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localEvento.Location = new System.Drawing.Point(147, 234);
            this.localEvento.Name = "localEvento";
            this.localEvento.Size = new System.Drawing.Size(51, 20);
            this.localEvento.TabIndex = 12;
            this.localEvento.Text = "Local ";
            // 
            // dataEvento
            // 
            this.dataEvento.AutoSize = true;
            this.dataEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEvento.Location = new System.Drawing.Point(154, 163);
            this.dataEvento.Name = "dataEvento";
            this.dataEvento.Size = new System.Drawing.Size(44, 20);
            this.dataEvento.TabIndex = 11;
            this.dataEvento.Text = "Data";
            // 
            // nomeEvento
            // 
            this.nomeEvento.AutoSize = true;
            this.nomeEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeEvento.Location = new System.Drawing.Point(154, 107);
            this.nomeEvento.Name = "nomeEvento";
            this.nomeEvento.Size = new System.Drawing.Size(51, 20);
            this.nomeEvento.TabIndex = 10;
            this.nomeEvento.Text = "Nome";
            // 
            // CadastroEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.eventoTitulo);
            this.Controls.Add(this.cadastrarEvento);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.descricaoEvento);
            this.Controls.Add(this.localEvento);
            this.Controls.Add(this.dataEvento);
            this.Controls.Add(this.nomeEvento);
            this.Name = "CadastroEventos";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label eventoTitulo;
        private System.Windows.Forms.Button cadastrarEvento;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label descricaoEvento;
        private System.Windows.Forms.Label localEvento;
        private System.Windows.Forms.Label dataEvento;
        private System.Windows.Forms.Label nomeEvento;
    }
}

