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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
