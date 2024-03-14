using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoCobra.Entidades
{
    internal class Comida
    {
        public Point Posicao { get; private set; }

        public Random Rnd { get; private set; }


        public Comida()
        {
            Posicao= new Point(100,100);
            Rnd= new Random();
        }

        public void Draw(Graphics graphics)
        {
            graphics.FillEllipse(Brushes.Purple,Posicao.X,Posicao.Y,20,20);
        }
        public void GerarNovaPosicao()
        {
            int x = Rnd.Next(20,Inf.SIZEW-20);
            int y = Rnd.Next(20, Inf.SIZEW - 20);
            Posicao = new Point(x,y);
        }
    }
}
