namespace mario_v1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Screen1 = new Panel();
            Player1 = new PictureBox();
            Base = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            Screen1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Player1).BeginInit();
            SuspendLayout();
            // 
            // Screen1
            // 
            Screen1.BackColor = Color.FromArgb(192, 192, 255);
            Screen1.Controls.Add(Player1);
            Screen1.Location = new Point(0, 0);
            Screen1.Name = "Screen1";
            Screen1.Size = new Size(595, 442);
            Screen1.TabIndex = 0;
            // 
            // Player1
            // 
            Player1.BackColor = Color.Transparent;
            Player1.BackgroundImageLayout = ImageLayout.None;
            Player1.Image = Properties.Resources.mario_stand;
            Player1.Location = new Point(225, 253);
            Player1.Name = "Player1";
            Player1.Size = new Size(58, 87);
            Player1.TabIndex = 2;
            Player1.TabStop = false;
            // 
            // Base
            // 
            Base.BackColor = Color.FromArgb(128, 64, 0);
            Base.Location = new Point(0, 438);
            Base.Name = "Base";
            Base.Size = new Size(595, 47);
            Base.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 482);
            Controls.Add(Base);
            Controls.Add(Screen1);
            Name = "Form1";
            Text = "Scence1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            Screen1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Player1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Screen1;
        private PictureBox Player1;
        private Panel Base;
        private System.Windows.Forms.Timer timer1;
    }
}