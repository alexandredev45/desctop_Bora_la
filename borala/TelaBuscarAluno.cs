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
    public partial class TelaBuscarAluno : Form
    {
        public TelaBuscarAluno()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           CadastrarAluno tela = new CadastrarAluno();
            tela.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AtualizarAluno tela = new AtualizarAluno();
            tela.Show();
        }

        private void TelaBuscarAluno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'boraLati44DataSet2.Aluno'. Você pode movê-la ou removê-la conforme necessário.
            this.alunoTableAdapter.Fill(this.boraLati44DataSet2.Aluno);

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            AtualizarAluno tela = new AtualizarAluno();
            tela.Show();
        }
    }
}
