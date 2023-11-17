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

namespace Quiz
{
    public partial class Form1 : Form
    {

        private void playSimpleSound()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"C:\Users\Fatec\Desktop\quiz\quiz\Som\musica.wav");
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
