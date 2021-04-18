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
        public static Bitmap rotacionar(Bitmap imagemOriginal, Orientacao orientacao)
        {
            Bitmap imagemProcessada;
            if ((orientacao == Orientacao.Esquerda) || (orientacao == Orientacao.Direita))
            {
                imagemProcessada = new Bitmap(imagemOriginal.Height, imagemOriginal.Width);
            }
            else
            {
                imagemProcessada = new Bitmap(imagemOriginal.Width, imagemOriginal.Height);
            }
            if(orientacao == Orientacao.Esquerda)
            {
                for(int i = 0, k = 0; i < imagemOriginal.Height; i++, k++)
                {
                    for (int j = 0, l = (imagemProcessada.Height - 1); j < imagemOriginal.Width; j++, l--)
                    {
                        Color cor = imagemOriginal.GetPixel(j, i);
                        if((l < imagemProcessada.Width) && (k < imagemProcessada.Height))
                        {
                            imagemProcessada.SetPixel(k, l, cor);
                        }
                        
                    }
                }
            }
            
            return imagemProcessada;
        }

    }
}
