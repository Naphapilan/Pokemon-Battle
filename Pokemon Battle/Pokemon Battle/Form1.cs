namespace Pokemon_Battle
{
    public partial class Form1 : Form
    {
        Pokemon mewtwo;
        Pokemon pikachu;
        Pokemon charizard;
        Pokemon pansear;
        Pokemon monferno;
        Pokemon moltres;
        Pokemon dragonite;

        //Array of pokemon
        Pokemon[] pokemondex;
        Pokemon[] enemydex;
        public Form1()
        {
            InitializeComponent();

            pokemondex = new Pokemon[6];
            enemydex = new Pokemon[6];

            mewtwo = new Mewtwo();
            pansear = new Pansear();
            monferno = new Monferno();
            dragonite = new Dragonite();
            moltres = new Moltres();
            charizard = new Charizard();

            pokemondex[0] = mewtwo;
            pokemondex[1] = pansear;
            pokemondex[2] = monferno;
            pokemondex[3] = dragonite;
            pokemondex[4] = moltres;
            pokemondex[5] = charizard;

            enemydex[0] = mewtwo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pokemon pk0 = pokemondex[0];
            this.pictureBox1.Image = pk0.getImage();
            this.labelPokemonName.Text = pk0.getName();

            this.pictureBox2.Image = pokemondex[1].getImage();
            this.pictureBox3.Image = pokemondex[2].getImage();
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

        private void button3_Click(object sender, EventArgs e)
        {
            Image temp = this.pictureBox1.Image;
            this.pictureBox1.Image = this.pictureBox4.Image;
            this.pictureBox4.Image = temp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Image temp = this.pictureBox1.Image;
            this.pictureBox1.Image = this.pictureBox5.Image;
            this.pictureBox5.Image = temp;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Image temp = this.pictureBox1.Image;
            this.pictureBox1.Image = this.pictureBox6.Image;
            this.pictureBox6.Image = temp;
        }
    }
}