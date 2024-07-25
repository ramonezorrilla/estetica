namespace estetica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnbloquear.Enabled = false;
            txtapellido.Enabled = false;
            txtnombre.Enabled = false;
            txtapellido.BackColor = Color.Aquamarine;
            txtnombre.BackColor = Color.Aquamarine;
        }

        private void btnhabilitar_Click(object sender, EventArgs e)
        {
            btnbloquear.Enabled = true;
            txtapellido.Enabled = true;
            txtnombre.Enabled = true;
            txtapellido.BackColor = Color.White;
            txtnombre.BackColor = Color.White;
        }

        private void btnbloquear_Click(object sender, EventArgs e)
        {
            btnhabilitar.Enabled = false;
            txtapellido.Enabled = false;
            txtnombre.Enabled = false;
            txtapellido.BackColor = Color.Aquamarine;
            txtnombre.BackColor = Color.Aquamarine;
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            probando probando = new probando();
            probando.Show();
        }
    }
}
