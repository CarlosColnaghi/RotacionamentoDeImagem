using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rotacionamento_de_Imagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picImagem.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picImagem.Image = Imagem.rotacionar(new Bitmap(picImagem.Image), Rotacionamento.Esquerda);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            picImagem.Image = Imagem.rotacionar(new Bitmap(picImagem.Image), Rotacionamento.Direita);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            picImagem.Image = Imagem.espelhar(new Bitmap(picImagem.Image), Espelhamento.Horizontal);
        }
    }
}
