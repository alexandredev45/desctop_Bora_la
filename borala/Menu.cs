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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscarProf tela = new TelaBuscarProf();
            tela.MdiParent = this;
            tela.Show();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscarAluno tela = new TelaBuscarAluno ();
            tela.MdiParent = this;
            tela.Show();
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscarCurso tela = new TelaBuscarCurso();
            tela.MdiParent = this;
            tela.Show();
        }

        private void galeriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscarGaleria tela = new TelaBuscarGaleria();
            tela.MdiParent = this;
            tela.Show();
        }

        private void eventosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscarEvento tela = new TelaBuscarEvento();
            tela.MdiParent = this;
            tela.Show();
        }

        private void turmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaBuscarTurma tela = new TelaBuscarTurma();
            tela.MdiParent = this;
            tela.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login tela = new Login();
            tela.Show();

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
