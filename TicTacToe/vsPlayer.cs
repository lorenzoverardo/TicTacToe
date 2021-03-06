﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class vsPlayer : Form
    {
        //PLAYER1 X, PLAYER2 O
        bool turn = false; // FALSE = PLAYER1, TRUE = PLAYER2

        public vsPlayer()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (xPictureBox1.Visible || oPictureBox1.Visible) return;

            if (turn == false)
            {
                xPictureBox1.Visible = true;
                turn = true;
                turnLabel.ForeColor = Color.FromArgb(0, 114, 255);
                turnLabel.Text = "PLAYER 2'S TURN";
            }
            else
            {
                oPictureBox1.Visible = true;
                turn = false;
                turnLabel.ForeColor = Color.Red;
                turnLabel.Text = "PLAYER 1'S TURN";
            }

            CheckWin();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            if (xPictureBox2.Visible || oPictureBox2.Visible) return;

            if (turn == false)
            {
                xPictureBox2.Visible = true;
                turn = true;
                turnLabel.ForeColor = Color.FromArgb(0, 114, 255);
                turnLabel.Text = "PLAYER 2'S TURN";
            }
            else
            {
                oPictureBox2.Visible = true;
                turn = false;
                turnLabel.ForeColor = Color.Red;
                turnLabel.Text = "PLAYER 1'S TURN";
            }

            CheckWin();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            if (xPictureBox3.Visible || oPictureBox3.Visible) return;

            if (turn == false)
            {
                xPictureBox3.Visible = true;
                turn = true;
                turnLabel.ForeColor = Color.FromArgb(0, 114, 255);
                turnLabel.Text = "PLAYER 2'S TURN";
            }
            else
            {
                oPictureBox3.Visible = true;
                turn = false;
                turnLabel.ForeColor = Color.Red;
                turnLabel.Text = "PLAYER 1'S TURN";
            }

            CheckWin();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            if (xPictureBox4.Visible || oPictureBox4.Visible) return;

            if (turn == false)
            {
                xPictureBox4.Visible = true;
                turn = true;
                turnLabel.ForeColor = Color.FromArgb(0, 114, 255);
                turnLabel.Text = "PLAYER 2'S TURN";
            }
            else
            {
                oPictureBox4.Visible = true;
                turn = false;
                turnLabel.ForeColor = Color.Red;
                turnLabel.Text = "PLAYER 1'S TURN";
            }

            CheckWin();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            if (xPictureBox5.Visible || oPictureBox5.Visible) return;

            if (turn == false)
            {
                xPictureBox5.Visible = true;
                turn = true;
                turnLabel.ForeColor = Color.FromArgb(0, 114, 255);
                turnLabel.Text = "PLAYER 2'S TURN";
            }
            else
            {
                oPictureBox5.Visible = true;
                turn = false;
                turnLabel.ForeColor = Color.Red;
                turnLabel.Text = "PLAYER 1'S TURN";
            }

            CheckWin();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            if (xPictureBox6.Visible || oPictureBox6.Visible) return;

            if (turn == false)
            {
                xPictureBox6.Visible = true;
                turn = true;
                turnLabel.ForeColor = Color.FromArgb(0, 114, 255);
                turnLabel.Text = "PLAYER 2'S TURN";
            }
            else
            {
                oPictureBox6.Visible = true;
                turn = false;
                turnLabel.ForeColor = Color.Red;
                turnLabel.Text = "PLAYER 1'S TURN";
            }

            CheckWin();
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            if (xPictureBox7.Visible || oPictureBox7.Visible) return;

            if (turn == false)
            {
                xPictureBox7.Visible = true;
                turn = true;
                turnLabel.ForeColor = Color.FromArgb(0, 114, 255);
                turnLabel.Text = "PLAYER 2'S TURN";
            }
            else
            {
                oPictureBox7.Visible = true;
                turn = false;
                turnLabel.ForeColor = Color.Red;
                turnLabel.Text = "PLAYER 1'S TURN";
            }

            CheckWin();
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            if (xPictureBox8.Visible || oPictureBox8.Visible) return;

            if (turn == false)
            {
                xPictureBox8.Visible = true;
                turn = true;
                turnLabel.ForeColor = Color.FromArgb(0, 114, 255);
                turnLabel.Text = "PLAYER 2'S TURN";
            }
            else
            {
                oPictureBox8.Visible = true;
                turn = false;
                turnLabel.ForeColor = Color.Red;
                turnLabel.Text = "PLAYER 1'S TURN";
            }

            CheckWin();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            if (xPictureBox9.Visible || oPictureBox9.Visible) return;

            if (turn == false)
            {
                xPictureBox9.Visible = true;
                turn = true;
                turnLabel.ForeColor = Color.FromArgb(0, 114, 255);
                turnLabel.Text = "PLAYER 2'S TURN";
            }
            else
            {
                oPictureBox9.Visible = true;
                turn = false;
                turnLabel.ForeColor = Color.Red;
                turnLabel.Text = "PLAYER 1'S TURN";
            }

            CheckWin();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            turn = false;
            xPictureBox1.Visible = false;
            xPictureBox2.Visible = false;
            xPictureBox3.Visible = false;
            xPictureBox4.Visible = false;
            xPictureBox5.Visible = false;
            xPictureBox6.Visible = false;
            xPictureBox7.Visible = false;
            xPictureBox8.Visible = false;
            xPictureBox9.Visible = false;
            oPictureBox1.Visible = false;
            oPictureBox2.Visible = false;
            oPictureBox3.Visible = false;
            oPictureBox4.Visible = false;
            oPictureBox5.Visible = false;
            oPictureBox6.Visible = false;
            oPictureBox7.Visible = false;
            oPictureBox8.Visible = false;
            oPictureBox9.Visible = false;
            panel1.Enabled = true;
            panel2.Enabled = true;
            panel3.Enabled = true;
            panel4.Enabled = true;
            panel5.Enabled = true;
            panel6.Enabled = true;
            panel7.Enabled = true;
            panel8.Enabled = true;
            panel9.Enabled = true;
            turnLabel.ForeColor = Color.Red;
            turnLabel.Text = "PLAYER 1'S TURN";
        }

        private bool xHasWon()
        {
            bool win = false;

            if ((xPictureBox1.Visible && xPictureBox2.Visible && xPictureBox3.Visible) ||
             (xPictureBox4.Visible && xPictureBox5.Visible && xPictureBox6.Visible) ||
             (xPictureBox7.Visible && xPictureBox8.Visible && xPictureBox9.Visible) ||
             (xPictureBox1.Visible && xPictureBox4.Visible && xPictureBox7.Visible) ||
             (xPictureBox2.Visible && xPictureBox5.Visible && xPictureBox8.Visible) ||
             (xPictureBox3.Visible && xPictureBox6.Visible && xPictureBox9.Visible) ||
             (xPictureBox1.Visible && xPictureBox5.Visible && xPictureBox9.Visible) ||
             (xPictureBox3.Visible && xPictureBox5.Visible && xPictureBox7.Visible))
                win = true;

            if (win)
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
                panel5.Enabled = false;
                panel6.Enabled = false;
                panel7.Enabled = false;
                panel8.Enabled = false;
                panel9.Enabled = false;
                return true;
            }
            return false;
        }

        private bool oHasWon()
        {
            bool win = false;

            if ((oPictureBox1.Visible && oPictureBox2.Visible && oPictureBox3.Visible) ||
             (oPictureBox4.Visible && oPictureBox5.Visible && oPictureBox6.Visible) ||
             (oPictureBox7.Visible && oPictureBox8.Visible && oPictureBox9.Visible) ||
             (oPictureBox1.Visible && oPictureBox4.Visible && oPictureBox7.Visible) ||
             (oPictureBox2.Visible && oPictureBox5.Visible && oPictureBox8.Visible) ||
             (oPictureBox3.Visible && oPictureBox6.Visible && oPictureBox9.Visible) ||
             (oPictureBox1.Visible && oPictureBox5.Visible && oPictureBox9.Visible) ||
             (oPictureBox3.Visible && oPictureBox5.Visible && oPictureBox7.Visible))
                win = true;

            if (win)
            {
                panel1.Enabled = false;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;
                panel5.Enabled = false;
                panel6.Enabled = false;
                panel7.Enabled = false;
                panel8.Enabled = false;
                panel9.Enabled = false;
                return true;
            }
            return false;
        }

        private void CheckWin()
        {
            if (xHasWon())
            {
                turnLabel.ForeColor = Color.Red;
                turnLabel.Text = "PLAYER 1 WINS";
            }

            if (oHasWon())
            {
                turnLabel.ForeColor = Color.FromArgb(0,114,255);
                turnLabel.Text = "PLAYER 2 WINS";
            }

            if (!xHasWon() && !oHasWon() && 
                ((xPictureBox1.Visible) || (oPictureBox1.Visible)) &&
                ((xPictureBox2.Visible) || (oPictureBox2.Visible)) &&
                ((xPictureBox3.Visible) || (oPictureBox3.Visible)) &&
                ((xPictureBox4.Visible) || (oPictureBox4.Visible)) &&
                ((xPictureBox5.Visible) || (oPictureBox5.Visible)) &&
                ((xPictureBox6.Visible) || (oPictureBox6.Visible)) &&
                ((xPictureBox7.Visible) || (oPictureBox7.Visible)) &&
                ((xPictureBox8.Visible) || (oPictureBox8.Visible)) &&
                ((xPictureBox9.Visible) || (oPictureBox9.Visible)))
            {
                turnLabel.ForeColor = Color.Black;
                turnLabel.Text = "TIE";
            }
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- The game is played on a grid that's 3 squares by 3 squares.\n\n" +
                "- You are X, your friend is O. Players take turns putting their marks in empty squares.\n\n" +
                "- The first player to get 3 of her marks in a row(up, down, across, or diagonally) is the winner.\n\n" +
                "- When all 9 squares are full, the game is over. If no player has 3 marks in a row, the game ends in a tie.", "Rules");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home.HomeForm.Show();
        }

        private void vsPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
