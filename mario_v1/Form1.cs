namespace mario_v1
{
    public partial class Form1 : Form
    {
        bool rightM, leftM, Jump;
        int Gravity = 30;
        int Force;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { rightM = true; }
            if (e.KeyCode == Keys.Left) { leftM = true; }
            if (e.KeyCode == Keys.Space)
            {
                Jump = true;
                Force = Gravity;
                Player.Image = Image.FromFile("marion_fly.png");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rightM == true) { Player.Left = Player.Left + 5; }
            if (leftM == true) { Player.Left = Player.Left - 5; }
            if (Jump == true)
            {
                // Falling ( if the player has jumped before)
                Player.Top = Player.Top - Force;
                Force = Force - 1;

            }

            if (Player.Top + Player.Height >= Screen1.Height)
            {
                Player.Top = Screen1.Height - Player.Height; // Stop falling at bottom
                Jump = false;
                Player.Image = Image.FromFile("marion_stand.png");
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { rightM = false; }
            if (e.KeyCode == Keys.Left) { leftM = false; }
            if (e.KeyCode == Keys.Escape) { this.Close(); } // Escape --> Exit
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player.Top = Screen1.Height - Player.Height;
        }
    }
}