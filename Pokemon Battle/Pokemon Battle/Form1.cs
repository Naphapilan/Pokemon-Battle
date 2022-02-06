namespace Pokemon_Battle
{
    public partial class Form1 : Form
    {
        Pokemon mewtwo;

        //Array of pokemon
        Pokemon[] pokemondex;
        Pokemon[] enemydex;
        public Form1()
        {
            InitializeComponent();

            pokemondex = new Pokemon[6];
            enemydex = new Pokemon[6];

            mewtwo = new Mewtwo();

            pokemondex[0] = mewtwo;

            enemydex[0] = mewtwo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mewtwo mewtwo = new Mewtwo();
            this.labelPokemonName.Text = mewtwo.getName();
            this.pictureBox1.Image = Properties.Resources.ResourceManager.GetObject(mewtwo.get);

            Pikachu pikachu = new Pikachu();
            this.pictureBox7.Image = pikachu.getImage();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Image temp = this.pictureBox1.Image;
            this.pictureBox1.Image = this.pictureBox2.Image;
            this.pictureBox2.Image = temp;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image temp = this.pictureBox1.Image;
            this.pictureBox1.Image = this.pictureBox3.Image;
            this.pictureBox3.Image = temp;
        }
    }
}