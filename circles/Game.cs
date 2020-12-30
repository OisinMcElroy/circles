using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace circles
{
    public partial class DaGame : Form
    {
        int score = 0;
        int fallSpeed = 2;
        public DaGame()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void onClick(object sender, EventArgs e)
        {
            Random pos = new Random();
            if (theAimer.Bounds.IntersectsWith(theGoal.Bounds))
            {
                score++;
                daScore.Text = "Score: " + score;
                theAimer.Top = pos.Next(200);
            }
            else
            {
                endIt();
            }
            fallSpeed = 2 * ((score / 5)+1);
            keeperOfTime.Start();
        }

        private void endIt()
        {
            theAimer.Top = 200;
            keeperOfTime.Stop();
            fallSpeed = 2;
            string path = "./gamerstats.txt";
            string highScore = "";
            if (File.Exists(path))
            {
                highScore = File.ReadAllText(path);
            }
            else
            {
                File.WriteAllText(path, Convert.ToString(score, 10));
            }

            if (score > Int32.Parse(highScore))
            {
                File.WriteAllText(path, Convert.ToString(score, 10));
            }

            this.Hide();
            menu Menu = new menu();
            Menu.Closed += (s, args) => this.Close();
            Menu.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            theAimer.Top += fallSpeed;
            if (theAimer.Bottom >= 480) {
                endIt();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}