namespace JogoCobra
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            ImagemCobra2 = new PictureBox();
            TituloJogo = new Label();
            label1 = new Label();
            textBoxUser = new TextBox();
            textBoxPass = new TextBox();
            botaoConfirmar = new Button();
            botaoCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)ImagemCobra2).BeginInit();
            SuspendLayout();
            // 
            // ImagemCobra2
            // 
            ImagemCobra2.Image = (Image)resources.GetObject("ImagemCobra2.Image");
            ImagemCobra2.Location = new Point(540, 67);
            ImagemCobra2.Name = "ImagemCobra2";
            ImagemCobra2.Size = new Size(220, 213);
            ImagemCobra2.SizeMode = PictureBoxSizeMode.StretchImage;
            ImagemCobra2.TabIndex = 2;
            ImagemCobra2.TabStop = false;
            // 
            // TituloJogo
            // 
            TituloJogo.AutoSize = true;
            TituloJogo.Font = new Font("Bradley Hand ITC", 36F, FontStyle.Regular, GraphicsUnit.Point);
            TituloJogo.ForeColor = Color.Fuchsia;
            TituloJogo.Location = new Point(103, 32);
            TituloJogo.Margin = new Padding(4, 0, 4, 0);
            TituloJogo.Name = "TituloJogo";
            TituloJogo.Size = new Size(293, 60);
            TituloJogo.TabIndex = 3;
            TituloJogo.Text = "Jogo da Cobra";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 161);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 4;
            // 
            // textBoxUser
            // 
            textBoxUser.BackColor = SystemColors.Window;
            textBoxUser.BorderStyle = BorderStyle.FixedSingle;
            textBoxUser.CausesValidation = false;
            textBoxUser.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUser.ForeColor = SystemColors.WindowFrame;
            textBoxUser.Location = new Point(103, 133);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(358, 29);
            textBoxUser.TabIndex = 5;
            textBoxUser.Text = "username";
            textBoxUser.TextChanged += textBoxUser_TextChanged;
            // 
            // textBoxPass
            // 
            textBoxPass.BackColor = SystemColors.Window;
            textBoxPass.BorderStyle = BorderStyle.FixedSingle;
            textBoxPass.CausesValidation = false;
            textBoxPass.Font = new Font("Courier New", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPass.ForeColor = SystemColors.WindowFrame;
            textBoxPass.Location = new Point(103, 179);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(358, 29);
            textBoxPass.TabIndex = 6;
            textBoxPass.Text = "password";
            textBoxPass.UseSystemPasswordChar = true;
            // 
            // botaoConfirmar
            // 
            botaoConfirmar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            botaoConfirmar.FlatStyle = FlatStyle.Flat;
            botaoConfirmar.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            botaoConfirmar.Location = new Point(103, 214);
            botaoConfirmar.Name = "botaoConfirmar";
            botaoConfirmar.Size = new Size(176, 38);
            botaoConfirmar.TabIndex = 7;
            botaoConfirmar.Text = "Confirmar";
            botaoConfirmar.UseVisualStyleBackColor = true;
            botaoConfirmar.Click += botaoConfirmar_Click;
            // 
            // botaoCancelar
            // 
            botaoCancelar.FlatAppearance.MouseOverBackColor = Color.DarkGoldenrod;
            botaoCancelar.FlatStyle = FlatStyle.Flat;
            botaoCancelar.Font = new Font("Rockwell", 12F, FontStyle.Regular, GraphicsUnit.Point);
            botaoCancelar.Location = new Point(285, 214);
            botaoCancelar.Name = "botaoCancelar";
            botaoCancelar.Size = new Size(176, 38);
            botaoCancelar.TabIndex = 8;
            botaoCancelar.Text = "Cancelar";
            botaoCancelar.UseVisualStyleBackColor = true;
            botaoCancelar.Click += botaoCancelar_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(787, 292);
            Controls.Add(botaoCancelar);
            Controls.Add(botaoConfirmar);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxUser);
            Controls.Add(label1);
            Controls.Add(TituloJogo);
            Controls.Add(ImagemCobra2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)ImagemCobra2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox ImagemCobra2;
        private Label TituloJogo;
        private Label label1;
        private TextBox textBoxUser;
        private TextBox textBoxPass;
        private Button botaoConfirmar;
        private Button botaoCancelar;
    }
}