namespace proj1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            faf.Text = ("this is a spades card");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            faf.Text = ("this is a diamond card");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            faf.Text = ("this is a card of worms");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            faf.Text = ("this is a card of the cross");
        }
    }
}
