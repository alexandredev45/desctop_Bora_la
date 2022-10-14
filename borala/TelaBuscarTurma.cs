using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace borala
{
    public partial class TelaBuscarTurma : Form
    {
        public TelaBuscarTurma()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AtualizarTurma tela = new AtualizarTurma();
            tela.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.Show();
        }

        private void TelaBuscarTurma_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'boraLati44DataSet4.Turma'. Você pode movê-la ou removê-la conforme necessário.
            this.turmaTableAdapter.Fill(this.boraLati44DataSet4.Turma);

        }
    }
}
