using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoCobra
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoConfirmar_Click(object sender, EventArgs e)
        {
            if (textBoxUser.Text == "rui" && textBoxPass.Text == "silva")
            {
                Jogo frm = new Jogo();
                frm.ShowDialog();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxUser_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
