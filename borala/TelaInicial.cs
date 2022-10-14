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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        Timer timer = new Timer();

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            
            timer.Enabled = true;
            timer.Interval = 3000;
            timer.Start();
            timer.Tick += new EventHandler(Tempo);
         }

        private void Tempo(object myObject, EventArgs myEventArgs)
        {
            timer.Stop();
            timer.Enabled = false;

            Login f = new Login();
            f.Show();
            this.Hide();
        }


        private void label1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
