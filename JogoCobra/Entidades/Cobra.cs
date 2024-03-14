using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using JogoCobra.Entidades.Enums;

namespace JogoCobra.Entidades
{
    internal class Cobra
    {
        public List<Point> Corpo { get; private set; }
        public short Tamanho { get; private set; }

        private Direcao direcao;
        
        public Cobra()
        {
            Corpo = new List<Point> { new Point(40, 40)};
            Tamanho = 1;
            direcao = Direcao.RIGHT;
            Inf.pontos = 0;
        }
        public Point Cabeca
        {
            get
            {
                return Corpo.First();
            }
            private set { }
        }
        public void AumenarPontuacao()
        {
            Inf.pontos += 10;
        }
        public void Mover()
        {
            Point novaCabeca = Cabeca;
            switch (direcao)
            {
                case (Direcao.UP):
                    novaCabeca.Y -= 5;
                break;

                case(Direcao.DOWN):
                    novaCabeca.Y += 5;
                break;

                case (Direcao.LEFT):
                    novaCabeca.X -= 5;
                break;

                case (Direcao.RIGHT):
                    novaCabeca.X += 5;
                break;

            }
            Corpo.Insert(0, novaCabeca);
            while(Corpo.Count > Tamanho) 
                Corpo.RemoveAt(Corpo.Count-1);
        }
        public void Draw(Graphics graphics)
        {
            foreach (Point segment in Corpo)
                graphics.FillRectangle(Brushes.Green, segment.X, segment.Y, 25, 25);
        }
        public void Grow()
        {
            Tamanho++;
        }
        public bool VerificarColisaoPropria()
        {
            return Corpo.Count> 1 && Corpo.Skip(1).Any(segmento=> segmento == Cabeca);
        }
        public bool VerificarColisaoFronteira()
        {
            return (Cabeca.X<0 || Cabeca.Y>Inf.SIZEW-10 || Cabeca.Y<0 || Cabeca.Y>Inf.SIZEW-10);
        }
        public void HandleKeyPress(Keys key)
        {
            switch (key)
            {
                case Keys.Up:
                    direcao = Direcao.UP;
                    break;
                case Keys.Down:
                    direcao= Direcao.DOWN;
                    break;
                case Keys.Left:
                    direcao = Direcao.LEFT;
                    break;
                case Keys.Right:
                    direcao = Direcao.RIGHT;
                    break;
                    

            }
        }
    }
    

}
