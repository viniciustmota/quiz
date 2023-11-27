using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quiz
{
    public partial class Form17 : Form
    {

        private Image gifImage;
        public Form17()
        {
            InitializeComponent();
            CarregarGif();
        }

        private void CarregarGif()
        {
            string diretorioDoAplicativo = Application.StartupPath;

            // Constrói o caminho completo para o arquivo de som
            string caminhoDoGif = Path.Combine(diretorioDoAplicativo, "../", "../", "../", "Videos", "vencedor.gif");

            // Substitua "seu_gif.gif" pelo caminho do seu arquivo GIF
            gifImage = Image.FromFile(caminhoDoGif);

            // Exibe apenas o primeiro quadro do GIF
            pictureBox1.Image = gifImage;
            gifImage.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Time, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
