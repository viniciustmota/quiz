﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private async void verificaAcerto()
        {
            Pontos pontos = new Pontos();
            if (radioButton1.Checked == true)
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

            Form5 tela = new Form5();
            tela.Show();
            this.Hide();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            verificaAcerto();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
