using JogoCobra.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoCobra
{
    public partial class Jogo : Form
    {
        private Comida comida;
        private Cobra cobra;
        public Jogo()
        {
            InitializeComponent();
            InitializeGame();

        }

        private void InitializeGame()
        {
            comida = new Comida();
            cobra = new Cobra();
            ClientSize = new System.Drawing.Size(Inf.SIZEW, Inf.SIZEW);
            timerJogo.Interval = 200;
            timerJogo.Tick += timerJogo_Tick;
            timerJogo.Start();
            this.BackColor = Color.Aquamarine;
            this.Text = "Jogo da cobra";
            Inf.nivel = 1;
            Inf.pontos = 0;
        }

        private void Jogo_Paint(object sender, PaintEventArgs e)
        {
            comida.Draw(e.Graphics);
            cobra.Draw(e.Graphics);

        }

        private void timerJogo_Tick(object sender, EventArgs e)
        {
            cobra.Mover();
            Invalidate();
            AtualizarInf();
            Verificarcolisao();
        }
        private void AtualizarInf()
        {
            tslNivel.Text = Inf.nivel.ToString();
            tslNivel.Text = Inf.pontos.ToString();
        }

        private void Jogo_KeyDown(object sender, KeyEventArgs e)
        {
            cobra.HandleKeyPress(e.KeyCode);
        }
        private void Verificarcolisao()
        {
            if (Math.Abs(cobra.Cabeca.X - comida.Posicao.X) <= 18 && Math.Abs(cobra.Cabeca.Y - comida.Posicao.Y) <= 18)
            {
                cobra.Grow();
                cobra.AumenarPontuacao();
                if (Inf.pontos % 50 == 0)
                {
                    Inf.nivel++;
                    timerJogo.Interval -= 10;
                }
                comida.GerarNovaPosicao();
            }
            if (cobra.VerificarColisaoFronteira() || cobra.VerificarColisaoPropria())
                FimJogo();
        }
        private void FimJogo()
        {
            timerJogo.Stop();
            MessageBox.Show($"Fim de jogo!\nPontuação:{Inf.pontos},\nNível:{Inf.nivel} ");
        }

        private void Jogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32 && timerJogo.Enabled == false)
                timerJogo.Start();
            else if (e.KeyChar == 32 && timerJogo.Enabled == true)
                timerJogo.Stop();

            if (e.KeyChar == 13)
                InitializeGame();
        }

        private void Jogo_Load(object sender, EventArgs e)
        {

        }
    }
}
