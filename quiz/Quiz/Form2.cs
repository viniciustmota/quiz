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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private async void verificaAcerto()
        {
            Pontos pontos = new Pontos();
            if (radioButton2.Checked == true)
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

            Form3 tela = new Form3();
            tela.Show();
            this.Hide();
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            verificaAcerto();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            verificaAcerto();
        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            verificaAcerto();
        }

        private void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            verificaAcerto();
        }
    }
}
