using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotacionamento_de_Imagens
{
    public static class Imagem
    {
        public static Bitmap rotacionar(Bitmap imagemOriginal, Rotacionamento rotacionamento)
        {
            Bitmap imagemProcessada;
            if ((rotacionamento == Rotacionamento.Esquerda) || (rotacionamento == Rotacionamento.Direita))
            {
                imagemProcessada = new Bitmap(imagemOriginal.Height, imagemOriginal.Width);
            }
            else
            {
                imagemProcessada = new Bitmap(imagemOriginal.Width, imagemOriginal.Height);
            }
            if(rotacionamento == Rotacionamento.Esquerda)
            {
                for(int i = 0, l = 0; i < imagemOriginal.Height; i++, l++)
                {
                    for (int j = 0, k = imagemProcessada.Height-1; j < imagemOriginal.Width; j++, k--)
                    {
                        Color cor = imagemOriginal.GetPixel(j, i);
                        imagemProcessada.SetPixel(l, k, cor);
                    }
                }
            } else if(rotacionamento == Rotacionamento.Direita)
            {
                for (int i = 0, l = imagemProcessada.Width-1; i < imagemOriginal.Height; i++, l--)
                {
                    for (int j = 0, k = 0; j < imagemOriginal.Width; j++, k++)
                    {
                        Color cor = imagemOriginal.GetPixel(j, i);
                        imagemProcessada.SetPixel(l, k, cor);
                    }
                }
            }
            return imagemProcessada;
        }

    }
}
