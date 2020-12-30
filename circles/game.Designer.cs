
namespace circles
{
    partial class DaGame
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
            this.components = new System.ComponentModel.Container();
            this.theGoal = new System.Windows.Forms.PictureBox();
            this.theAimer = new System.Windows.Forms.PictureBox();
            this.keeperOfTime = new System.Windows.Forms.Timer(this.components);
            this.daScore = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.theGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theAimer)).BeginInit();
            this.SuspendLayout();
            // 
            // theGoal
            // 
            this.theGoal.BackColor = System.Drawing.Color.DarkRed;
            this.theGoal.Location = new System.Drawing.Point(-2, 346);
            this.theGoal.Name = "theGoal";
            this.theGoal.Size = new System.Drawing.Size(488, 50);
            this.theGoal.TabIndex = 0;
            this.theGoal.TabStop = false;
            // 
            // theAimer
            // 
            this.theAimer.BackColor = System.Drawing.Color.Cyan;
            this.theAimer.Location = new System.Drawing.Point(-2, 141);
            this.theAimer.Name = "theAimer";
            this.theAimer.Size = new System.Drawing.Size(488, 15);
            this.theAimer.TabIndex = 1;
            this.theAimer.TabStop = false;
            // 
            // keeperOfTime
            // 
            this.keeperOfTime.Enabled = true;
            this.keeperOfTime.Interval = 10;
            this.keeperOfTime.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // daScore
            // 
            this.daScore.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.daScore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.daScore.Location = new System.Drawing.Point(12, 12);
            this.daScore.Name = "daScore";
            this.daScore.ReadOnly = true;
            this.daScore.Size = new System.Drawing.Size(100, 16);
            this.daScore.TabIndex = 2;
            this.daScore.Text = "Score: 0";
            this.daScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.daScore.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // DaGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.daScore);
            this.Controls.Add(this.theAimer);
            this.Controls.Add(this.theGoal);
            this.Name = "DaGame";
            this.Text = "haha funny drop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.onClick);
            ((System.ComponentModel.ISupportInitialize)(this.theGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theAimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox theAimer;
        private System.Windows.Forms.PictureBox theGoal;
        private System.Windows.Forms.Timer keeperOfTime;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox daScore;
    }
}

