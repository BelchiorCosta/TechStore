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
    public partial class Form1 : Form
    {
        public string Nome = "Paulo Barreira";
        public Form1()
        {
            InitializeComponent();
        }

        private FormMDI mdiForm;
        public Form1(FormMDI mdiForm)
        {
            InitializeComponent();
            this.mdiForm = mdiForm;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "Pbarreira" && txtPass.Text == "programar" && txtNome.Text == Nome)
            {
                MessageBox.Show("Login com sucesso!");
                this.Close();
                mdiForm.AtivarMenuStrip();
                mdiForm.AtivarPictureBox();
                mdiForm.DesativarPictureBox2();
                mdiForm.AtivarToolStrip();
                mdiForm.AtivarLogadoComo();
            }
            else
            {
                MessageBox.Show("Login inválido!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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
