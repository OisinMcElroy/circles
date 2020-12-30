using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace circles
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            string path = "./gamerstats.txt";
            if (File.Exists(path))
            {
                highScoreDisplay.Text= "Highscore: "+File.ReadAllText(path);
            }

        }

        private void Start_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            DaGame theGame = new DaGame();
            theGame.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
