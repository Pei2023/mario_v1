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
            Player = new PictureBox();
            Base = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            Screen1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            SuspendLayout();
            // 
            // Screen1
            // 
            Screen1.BackColor = Color.FromArgb(192, 192, 255);
            Screen1.Controls.Add(Player);
            Screen1.Dock = DockStyle.Top;
            Screen1.Location = new Point(0, 0);
            Screen1.Margin = new Padding(0);
            Screen1.Name = "Screen1";
            Screen1.Size = new Size(663, 382);
            Screen1.TabIndex = 0;
            // 
            // Player
            // 
            Player.BackColor = Color.Transparent;
            Player.Image = Properties.Resources.marion_stand_21;
            Player.Location = new Point(288, 268);
            Player.Margin = new Padding(0);
            Player.Name = "Player";
            Player.Size = new Size(60, 80);
            Player.TabIndex = 0;
            Player.TabStop = false;
            // 
            // Base
            // 
            Base.BackColor = Color.FromArgb(128, 64, 0);
            Base.Dock = DockStyle.Bottom;
            Base.Location = new Point(0, 382);
            Base.Margin = new Padding(0);
            Base.Name = "Base";
            Base.Size = new Size(663, 57);
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
            ClientSize = new Size(663, 439);
            Controls.Add(Base);
            Controls.Add(Screen1);
            KeyPreview = true;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            Screen1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Screen1;
        private Panel Base;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Player;
    }
}