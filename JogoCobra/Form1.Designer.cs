namespace JogoCobra
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            TituloJogo = new Label();
            statusStrip1 = new StatusStrip();
            tslAutor = new ToolStripStatusLabel();
            tslData = new ToolStripStatusLabel();
            tslHora = new ToolStripStatusLabel();
            toolStripProgressBar1 = new ToolStripProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            botaoJogar = new Button();
            ImagemCobra = new PictureBox();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ImagemCobra).BeginInit();
            SuspendLayout();
            // 
            // TituloJogo
            // 
            TituloJogo.AutoSize = true;
            TituloJogo.Font = new Font("Bradley Hand ITC", 36F, FontStyle.Regular, GraphicsUnit.Point);
            TituloJogo.ForeColor = Color.FromArgb(64, 0, 64);
            TituloJogo.Location = new Point(328, 43);
            TituloJogo.Margin = new Padding(4, 0, 4, 0);
            TituloJogo.Name = "TituloJogo";
            TituloJogo.Size = new Size(293, 60);
            TituloJogo.TabIndex = 0;
            TituloJogo.Text = "Jogo da Cobra";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslAutor, tslData, tslHora, toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 406);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(975, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslAutor
            // 
            tslAutor.ForeColor = SystemColors.ActiveCaptionText;
            tslAutor.Name = "tslAutor";
            tslAutor.Size = new Size(118, 17);
            tslAutor.Text = "toolStripStatusLabel1";
            // 
            // tslData
            // 
            tslData.ForeColor = SystemColors.ActiveCaptionText;
            tslData.Name = "tslData";
            tslData.Size = new Size(118, 17);
            tslData.Text = "toolStripStatusLabel2";
            // 
            // tslHora
            // 
            tslHora.ForeColor = SystemColors.ActiveCaptionText;
            tslHora.Name = "tslHora";
            tslHora.Size = new Size(118, 17);
            tslHora.Text = "toolStripStatusLabel3";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(100, 16);
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // botaoJogar
            // 
            botaoJogar.FlatAppearance.BorderSize = 0;
            botaoJogar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            botaoJogar.FlatStyle = FlatStyle.Flat;
            botaoJogar.Font = new Font("Ravie", 21.75F, FontStyle.Italic, GraphicsUnit.Point);
            botaoJogar.ForeColor = Color.FromArgb(64, 0, 64);
            botaoJogar.Location = new Point(328, 306);
            botaoJogar.Name = "botaoJogar";
            botaoJogar.Size = new Size(249, 71);
            botaoJogar.TabIndex = 4;
            botaoJogar.Text = "Jogar";
            botaoJogar.UseVisualStyleBackColor = true;
            botaoJogar.Click += botaoJogar_Click;
            // 
            // ImagemCobra
            // 
            ImagemCobra.Image = (Image)resources.GetObject("ImagemCobra.Image");
            ImagemCobra.Location = new Point(328, 126);
            ImagemCobra.Name = "ImagemCobra";
            ImagemCobra.Size = new Size(249, 204);
            ImagemCobra.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagemCobra.TabIndex = 1;
            ImagemCobra.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(975, 428);
            Controls.Add(botaoJogar);
            Controls.Add(statusStrip1);
            Controls.Add(ImagemCobra);
            Controls.Add(TituloJogo);
            Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Green;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ImagemCobra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TituloJogo;
        private StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private Button botaoJogar;
        private ToolStripStatusLabel tslAutor;
        private ToolStripStatusLabel tslData;
        private ToolStripStatusLabel tslHora;
        private ToolStripProgressBar toolStripProgressBar1;
        private PictureBox ImagemCobra;
    }
}