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
            SoundPlayer simpleSound = new SoundPlayer(@"V:\Dev\quiz\quiz\Som\musica.wav");
            simpleSound.Play();
        }

        public Form1()
        {
            InitializeComponent();
            playSimpleSound();
        }

        private void COMEÇAR_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
