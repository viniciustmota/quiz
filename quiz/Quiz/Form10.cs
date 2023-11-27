using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
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

            Form11 tela = new Form11();
            tela.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            verificaAcerto();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            verificaAcerto();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            verificaAcerto();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            verificaAcerto();
        }
    }
}
