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
    public partial class FormMDI : Form
    {

        private Timer timer;

        public FormMDI()
        {
            InitializeComponent();
            InicializarRelogio();
        }

        private void InicializarRelogio()
        {
            // Configuração do Timer
            timer = new Timer();
            timer.Interval = 1000; // Atualiza a cada segundo
            timer.Tick += Timer_Tick;
            timer.Start();

            // Exibição inicial da data e hora
            AtualizarDataHora();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Atualiza a data e hora a cada intervalo do timer
            AtualizarDataHora();
        }

        private void AtualizarDataHora()
        {
            // Atualiza o texto da ToolStripStatusLabel com a data e hora atual
            label1.Text = DateTime.Now.ToString("HH:mm");
        }


        private void FecharFormulariosFilhos()
        {
            // Percorre todos os formulários filhos do FormMDI
            foreach (Form formularioFilho in this.MdiChildren)
            {
                // Fecha o formulário, exceto o próprio FormMDI
                if (formularioFilho != this)
                {
                    formularioFilho.Close();
                }
            }
        }


        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resposta = new DialogResult();
            resposta = MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void FormMDI_Load(object sender, EventArgs e)
        {

        }

        public void AtivarMenuStrip()
        {
            menuStrip1.Enabled = true;
        }

        public void AtivarToolStrip()
        {
            toolStrip1.Enabled = true;
        }

        public void DesativarToolStrip()
        {
            toolStrip1.Enabled = false;
        }

        public void AtivarPictureBox()
        {
            pictureBox1.Visible = true;
        }

        public void DesativarPictureBox2()
        {
            pictureBox2.Visible = false;
        }

        public void AtivarPictureBox2()
        {
            pictureBox2.Visible = true;
        }

        public void DesativarMenuStrip()
        {
            menuStrip1.Enabled = false;
        }

        public void DesativarPictureBox()
        {
            pictureBox1.Visible = false;
        }

        public void AtivarLogadoComo()
        {
            label2.Visible = true;
            label3.Visible = true;
            label3.Text = "Paulo Barreira";
        }

        public void DesativarLogadoComo()
        {
            label2.Visible = false;
            label3.Visible = false;
            label3.Text = "";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(this);
            form1.MdiParent = this;
            form1.Show();
        }

        private void registoDeAvariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.MdiParent = this;
            form2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult resposta = new DialogResult();
            resposta = MessageBox.Show("Deseja mesmo dar logout? Aviso: Todas as páginas abertas vão fechar!", "Logout", MessageBoxButtons.YesNo);
            if (resposta == DialogResult.Yes)
            {
                DesativarMenuStrip();
                DesativarPictureBox();
                AtivarPictureBox2();
                FecharFormulariosFilhos();
                DesativarToolStrip();
                DesativarLogadoComo();
                MessageBox.Show("Deu Logout!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                Form1 form1 = new Form1(this);
                form1.MdiParent = this;
                form1.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
