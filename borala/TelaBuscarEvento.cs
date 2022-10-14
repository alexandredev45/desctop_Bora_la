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
    public partial class TelaBuscarEvento : Form
    {
        public TelaBuscarEvento()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AtualizarEventos tela = new AtualizarEventos();
            tela.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastrarEventos tela = new CadastrarEventos();
            tela.Show();
        }

        private void TelaBuscarEvento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'boraLati44DataSet3.Evento'. Você pode movê-la ou removê-la conforme necessário.
            this.eventoTableAdapter.Fill(this.boraLati44DataSet3.Evento);

        }

        private void btn_cadastrar_evento_Click(object sender, EventArgs e)
        {
            CadastrarEventos tela = new CadastrarEventos();
            tela.Show();
        }
    }
}
