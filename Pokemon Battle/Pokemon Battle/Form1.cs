namespace Pokemon_Battle
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

        private void button1_Click(object sender, EventArgs e)
        {
            Image temp = this.pictureBox1.Image;
            this.pictureBox1.Image = this.pictureBox2.Image;
            this.pictureBox2.Image = temp;
        }
    }
}