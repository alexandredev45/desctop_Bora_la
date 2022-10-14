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
    public partial class TelaBuscarProf : Form
    {
        public TelaBuscarProf()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AtualizarProfessor tela = new AtualizarProfessor();
            tela.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarProfessor tela = new CadastrarProfessor();
            tela.Show();
        }

        private void TelaBuscarProf_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'boraLati44DataSet5.Prof'. Você pode movê-la ou removê-la conforme necessário.
            this.profTableAdapter.Fill(this.boraLati44DataSet5.Prof);

        }

        private void bnt_cadastrar_prof_Click(object sender, EventArgs e)
        {
            AtualizarProfessor tela = new AtualizarProfessor();
            tela.Show();
        }
    }
}
