namespace mario_v1
{
    public partial class Form1 : Form
    {
        bool rightM, leftM, Jump;
        int Force;
        int Gravity = 30;
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
                Player1.Image = Image.FromFile("mario_fly.png");
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { rightM = false; }
            if (e.KeyCode == Keys.Left) { leftM = false; }
            if (e.KeyCode == Keys.Escape) { this.Close(); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (rightM == true) { Player1.Left += 5; }
            if (leftM == true) { Player1.Left -= 5; }
            if (Jump == true)
            {
                // Jump and Fall
                Player1.Top -= Force;
                Force -= 1;
            }

            // Avoid Player1 From falling beneath Screen1
            if (Player1.Top + Player1.Height >= Screen1.Height)
            {
                Player1.Top = Screen1.Height - Player1.Height;
                Jump = false;
                Player1.Image = Image.FromFile("mario_stand.png");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player1.Top = Screen1.Height - Player1.Height;
        }
    }
}