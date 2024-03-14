namespace JogoCobra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void botaoJogar_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            tslAutor.Text = "© Guilherme Oliveira";
            tslData.Text = DateTime.Now.ToLongDateString() + "|";
            tslHora.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tslHora.Text = DateTime.Now.ToLongDateString();
        }


    }
}