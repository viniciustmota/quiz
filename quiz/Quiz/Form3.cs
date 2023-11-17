using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Quiz
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

        private async void verificaAcerto()
        {
            Pontos pontos = new Pontos();
            if (radioButton4.Checked == true)
            {
                this.BackColor = Color.Green;
                pontos.Certo = pontos.Certo + 1;
            }
            else
            {
                this.BackColor = Color.Red;
                pontos.Erro = pontos.Erro + 1;
            }

            // Adiciona um atraso de 2 segundos antes de trocar de tela
            await Task.Delay(1000);

            Form4 tela = new Form4();
            tela.Show();
            this.Hide();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            verificaAcerto();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            verificaAcerto();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            verificaAcerto();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            verificaAcerto();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
