using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Quiz
{
    public partial class Form1 : Form
    {

        private void playSimpleSound()
        {
            // Obtém o diretório de inicialização do aplicativo
            string diretorioDoAplicativo = Application.StartupPath;

            // Constrói o caminho completo para o arquivo de som
            string caminhoDoSom = Path.Combine(diretorioDoAplicativo, "../", "../", "../", "Som", "musica.wav");

            // Cria e reproduz o player de som
            SoundPlayer simpleSound = new SoundPlayer(caminhoDoSom);

            simpleSound.PlayLooping();
        }




        public Form1()
        {
            InitializeComponent();
            playSimpleSound();
        }

        private void COMEÇAR_Click(object sender, EventArgs e)
        {
            Form2 tela = new Form2();
            tela.Show();
            this.Hide();
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Fatec\Desktop\quiz\quiz\Som\musica.wav");
            simpleSound.Stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
