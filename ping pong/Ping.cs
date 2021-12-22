using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
namespace ping_pong
{
    public partial class Ping : Form
    {
        public static int points=0;//sets points to 0
        public static int speed_left = 4;//sets speed to 4
        public static int speed_top = 4;
        public static bool leaderboard_entered = false;
        public static bool soundon = false;
        public Ping()
        {
            InitializeComponent();
            delay.Enabled = true;//activates timer
            this.TopMost = true; //makes this form the topmost
            this.Bounds = Screen.PrimaryScreen.Bounds; //sets the screen bounds to the screen
            playspace.Bounds = Screen.PrimaryScreen.Bounds;
            racket.Top = playspace.Bottom - (playspace.Bottom / 10); /// sets racket in accurate place
            DoubleBuffered = true;
            DialogResult d = MessageBox.Show("Would you like to enable sound?","Enable sound?",MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                soundon = true;
            }
            else
            {
                soundon = false;
            }
            Cursor.Hide(); //hides cursour in game
        }

        private void pingpong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)//closes when user presses esc
            {
                Application.Exit();
            }
            if (e.KeyCode== Keys.F2 && delay.Enabled == false)
            {
                if (Application.OpenForms["Entry.cs"] == null && leaderboard_entered==false)
                {
                    Cursor.Show();
                    Form enter = new entry();
                    enter.Show();
                    leaderboard_entered = true;
                }
                else if (leaderboard_entered == true)
                {
                    MessageBox.Show("You've already added your score!");
                }
            }
            if (e.KeyCode == Keys.F1)
            {
                Cursor.Hide();
                ball.Top = 50;
                ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                points = 0;
                score_lbl.Text = "Points: 0";
                gameover_lbl.Visible = false;
                leaderboard_entered = false;
                delay.Enabled = true;

            }
        }

        private void delay_Tick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width-2); //sets centre of racket
            ball.Left += speed_left;//moves the ball interms of x 
            ball.Top += speed_top;// moves the ball in terms of y
            if (racket.Bounds.IntersectsWith(ball.Bounds))//checks to award point
            {
                if (soundon == true)
                {
                    System.Media.SoundPlayer ping = new System.Media.SoundPlayer();//initialises system music player
                    ping.SoundLocation = Application.StartupPath + "\\ping.wav";//sets audio file target
                    ping.Play();//plays audio
                }
                Random colourselector = new Random();//initialises random
                this.BackColor = Color.FromArgb(colourselector.Next(0, 200), colourselector.Next(0, 200), colourselector.Next(0, 200));//sets backcolour randomly
                speed_top += 2;//incrases upwards speed of the ball
                speed_left += 2;//increases upwards speed of the ball
                speed_top = -speed_top;//inverses movement per hit
                points += 1;//increases points
                score_lbl.Text = "Points: " + points;//updates label for points
            }
            if (ball.Left >= playspace.Left) 
            {
                speed_left = -speed_left;
            }
            if (ball.Right <= playspace.Right)
            {
                speed_left = -speed_left;
            }
            if (ball.Top <= playspace.Top)
            {
                speed_top = -speed_top;
            }
            if (ball.Bottom >= playspace.Bottom)
            {
                delay.Enabled = false;
                gameover_lbl.Visible = true;
                Cursor.Show();
            }
        }


    }
}
