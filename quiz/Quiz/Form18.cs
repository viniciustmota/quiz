using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form18 : Form
    {

        private Image gifImage;
        public Form18()
        {
            InitializeComponent();
            CarregarGif();
            this.Load += new EventHandler(Form18_Load);
            Pontos p = new Pontos();
            label3.Text = "Sua pontuação foi de " + Convert.ToString(p.Certo);
            label4.Text = "Total de erros: " + Convert.ToString(p.Erro);
        }
        private void CarregarGif()
        {
            string diretorioDoAplicativo = Application.StartupPath;

            // Constrói o caminho completo para o arquivo de som
            string caminhoDoGif = Path.Combine(diretorioDoAplicativo, "../", "../", "../", "Videos", "perdedor.gif");

            // Substitua "seu_gif.gif" pelo caminho do seu arquivo GIF
            gifImage = Image.FromFile(caminhoDoGif);

            // Exibe apenas o primeiro quadro do GIF
            pictureBox1.Image = gifImage;
            gifImage.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Time, 0);
        }

        private async void Form18_Load(object sender, EventArgs e)
        {
            await Task.Delay(6000);
            groupBox1.Visible = true;
            await Task.Delay(500);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pontos p = new Pontos();
            p.Certo = 0;
            p.Erro = 0;
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
