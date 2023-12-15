using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lojainformatica
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guardado com sucesso!");
            this.Close();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            DialogResult resposta = new DialogResult();
            resposta = MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
