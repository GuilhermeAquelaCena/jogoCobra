namespace JogoCobra
{
    partial class Jogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jogo));
            statusStrip1 = new StatusStrip();
            tslNivel = new ToolStripStatusLabel();
            tslPontos = new ToolStripStatusLabel();
            tsbJogar = new ToolStripDropDownButton();
            tsbSair = new ToolStripDropDownButton();
            tsbPause = new ToolStripDropDownButton();
            tslJogador = new ToolStripStatusLabel();
            timerJogo = new System.Windows.Forms.Timer(components);
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslNivel, tslPontos, tsbJogar, tsbSair, tsbPause, tslJogador });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(910, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslNivel
            // 
            tslNivel.Name = "tslNivel";
            tslNivel.Size = new Size(34, 17);
            tslNivel.Text = "Nível";
            // 
            // tslPontos
            // 
            tslPontos.Name = "tslPontos";
            tslPontos.Size = new Size(44, 17);
            tslPontos.Text = "Pontos";
            // 
            // tsbJogar
            // 
            tsbJogar.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbJogar.Image = (Image)resources.GetObject("tsbJogar.Image");
            tsbJogar.ImageTransparentColor = Color.Magenta;
            tsbJogar.Name = "tsbJogar";
            tsbJogar.Size = new Size(48, 20);
            tsbJogar.Text = "Jogar";
            // 
            // tsbSair
            // 
            tsbSair.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbSair.Image = (Image)resources.GetObject("tsbSair.Image");
            tsbSair.ImageTransparentColor = Color.Magenta;
            tsbSair.Name = "tsbSair";
            tsbSair.Size = new Size(39, 20);
            tsbSair.Text = "Sair";
            // 
            // tsbPause
            // 
            tsbPause.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbPause.Image = (Image)resources.GetObject("tsbPause.Image");
            tsbPause.ImageTransparentColor = Color.Magenta;
            tsbPause.Name = "tsbPause";
            tsbPause.Size = new Size(51, 20);
            tsbPause.Text = "Pause";
            // 
            // tslJogador
            // 
            tslJogador.Name = "tslJogador";
            tslJogador.Size = new Size(61, 17);
            tslJogador.Text = "tslJogador";
            // 
            // timerJogo
            // 
            timerJogo.Tick += timerJogo_Tick;
            // 
            // Jogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 450);
            Controls.Add(statusStrip1);
            Name = "Jogo";
            Text = "Jogo da Cobra";
            Load += Jogo_Load;
            Paint += Jogo_Paint;
            KeyDown += Jogo_KeyDown;
            KeyPress += Jogo_KeyPress;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslNivel;
        private ToolStripStatusLabel tslPontos;
        private ToolStripDropDownButton tsbJogar;
        private ToolStripDropDownButton tsbSair;
        private ToolStripDropDownButton tsbPause;
        private System.Windows.Forms.Timer timerJogo;
        private ToolStripStatusLabel tslJogador;
    }
}