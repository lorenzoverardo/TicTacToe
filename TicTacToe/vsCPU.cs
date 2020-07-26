using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class vsCPU : Form
    {
        //PLAYER1 X, CPU O
        bool turn = false;
        public vsCPU()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- The game is played on a grid that's 3 squares by 3 squares.\n\n" +
                "- You are X, computer is O. Players take turns putting their marks in empty squares.\n\n" +
                "- The first player to get 3 of her marks in a row(up, down, across, or diagonally) is the winner.\n\n" +
                "- When all 9 squares are full, the game is over. If no player has 3 marks in a row, the game ends in a tie.", "Rules");
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void vsCPU_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (xPictureBox1.Visible || oPictureBox1.Visible || turn == true) return;

            xPictureBox1.Visible = true;

            if (!CheckWin())
                MakeAMove();
        }
        private void panel2_Click(object sender, EventArgs e)
        {
            if (xPictureBox2.Visible || oPictureBox2.Visible || turn == true) return;

            xPictureBox2.Visible = true;

            if (!CheckWin())
                MakeAMove();
        }
        private void panel3_Click(object sender, EventArgs e)
        {
            if (xPictureBox3.Visible || oPictureBox3.Visible || turn == true) return;

            xPictureBox3.Visible = true;

            if (!CheckWin())
                MakeAMove();
        }
        private void panel4_Click(object sender, EventArgs e)
        {
            if (xPictureBox4.Visible || oPictureBox4.Visible || turn == true) return;

            xPictureBox4.Visible = true;

            if (!CheckWin())
                MakeAMove();
        }
        private void panel5_Click(object sender, EventArgs e)
        {
            if (xPictureBox5.Visible || oPictureBox5.Visible || turn == true) return;

            xPictureBox5.Visible = true;

            if (!CheckWin())
                MakeAMove();
        }
        private void panel6_Click(object sender, EventArgs e)
        {
            if (xPictureBox6.Visible || oPictureBox6.Visible || turn == true) return;

            xPictureBox6.Visible = true;

            if (!CheckWin())
                MakeAMove();
        }
        private void panel7_Click(object sender, EventArgs e)
        {
            if (xPictureBox7.Visible || oPictureBox7.Visible || turn == true) return;

            xPictureBox7.Visible = true;

            if (!CheckWin())
                MakeAMove();
        }
        private void panel8_Click(object sender, EventArgs e)
        {
            if (xPictureBox9.Visible || oPictureBox9.Visible || turn == true) return;

            xPictureBox8.Visible = true;

            if (!CheckWin())
                MakeAMove();
        }
        private void panel9_Click(object sender, EventArgs e)
        {
            if (xPictureBox9.Visible || oPictureBox9.Visible || turn == true) return;
            xPictureBox9.Visible = true;

            if (!CheckWin())
                MakeAMove();
        }

        private void MakeAMove()
        {
            turn = true;
            turnLabel.ForeColor = Color.FromArgb(0, 114, 255);
            turnLabel.Text = "MY TURN";
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.AutoReset = false;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, EventArgs e)
        {
            // Pseudocode to always win/tie
            // 1. Win: If the player has two in a row, they can place a third to get three in a row.
            // 2. Block: If the opponent has two in a row, the player must play the third themselves to block the opponent.
            // 3. Fork: Create an opportunity where the player has two ways to win(two non - blocked lines of 2).
            // 4. Blocking an opponent's fork: If there is only one possible fork for the opponent, the player should block it. Otherwise, the player should block all forks in any way that simultaneously allows them to create two in a row. Otherwise, the player should create a two in a row to force the opponent into defending, as long as it doesn't result in them creating a fork. For example, if "X" has two opposite corners and "O" has the center, "O" must not play a corner move in order to win. (Playing a corner move in this scenario creates a fork for "X" to win.)
            // 5. Center: A player marks the center. (If it is the first move of the game, playing a corner move gives the second player more opportunities to make a mistake and may therefore be the better choice; however, it makes no difference between perfect players.)
            // 6. Opposite corner: If the opponent is in the corner, the player plays the opposite corner.
            // 7. Empty corner: The player plays in a corner square.
            // 8. Empty side: The player plays in a middle square on any of the 4 sides.
            // Note: 4-5 not implemented otherwise it's not worth playing against

            // https://stackoverflow.com/questions/142003/cross-thread-operation-not-valid-control-accessed-from-a-thread-other-than-the
            Invoke(new Action(() =>
            {
                if (oPictureBox1.Visible && oPictureBox2.Visible && !xPictureBox3.Visible && !oPictureBox3.Visible)
                {
                    oPictureBox3.Visible = true;
                }
                else if (oPictureBox2.Visible && oPictureBox3.Visible && !xPictureBox1.Visible && !oPictureBox1.Visible)
                {
                    oPictureBox1.Visible = true;
                }
                else if (oPictureBox4.Visible && oPictureBox5.Visible && !xPictureBox6.Visible && !oPictureBox6.Visible)
                {
                    oPictureBox6.Visible = true;
                }
                else if (oPictureBox5.Visible && oPictureBox6.Visible && !xPictureBox4.Visible && !oPictureBox4.Visible)
                {
                    oPictureBox4.Visible = true;
                }
                else if (oPictureBox7.Visible && oPictureBox8.Visible && !xPictureBox9.Visible && !oPictureBox9.Visible)
                {
                    oPictureBox9.Visible = true;
                }
                else if (oPictureBox8.Visible && oPictureBox9.Visible && !xPictureBox7.Visible && !oPictureBox7.Visible)
                {
                    oPictureBox7.Visible = true;
                }
                else if (oPictureBox1.Visible && oPictureBox4.Visible && !xPictureBox7.Visible && !oPictureBox7.Visible)
                {
                    oPictureBox7.Visible = true;
                }
                else if (oPictureBox2.Visible && oPictureBox5.Visible && !xPictureBox8.Visible && !oPictureBox8.Visible)
                {
                    oPictureBox8.Visible = true;
                }
                else if (oPictureBox3.Visible && oPictureBox6.Visible && !xPictureBox9.Visible && !oPictureBox9.Visible)
                {
                    oPictureBox9.Visible = true;
                }
                else if (oPictureBox4.Visible && oPictureBox7.Visible && !xPictureBox1.Visible && !oPictureBox1.Visible)
                {
                    oPictureBox1.Visible = true;
                }
                else if (oPictureBox5.Visible && oPictureBox8.Visible && !xPictureBox2.Visible && !oPictureBox2.Visible)
                {
                    oPictureBox2.Visible = true;
                }
                else if (oPictureBox6.Visible && oPictureBox9.Visible && !xPictureBox3.Visible && !oPictureBox3.Visible)
                {
                    oPictureBox3.Visible = true;
                }
                else if (oPictureBox1.Visible && oPictureBox5.Visible && !xPictureBox9.Visible && !oPictureBox9.Visible)
                {
                    oPictureBox9.Visible = true;
                }
                else if (oPictureBox5.Visible && oPictureBox9.Visible && !xPictureBox1.Visible && !oPictureBox1.Visible)
                {
                    oPictureBox1.Visible = true;
                }
                else if (oPictureBox3.Visible && oPictureBox5.Visible && !xPictureBox7.Visible && !oPictureBox7.Visible)
                {
                    oPictureBox7.Visible = true;
                }
                else if (oPictureBox5.Visible && oPictureBox7.Visible && !xPictureBox3.Visible && !oPictureBox3.Visible)
                {
                    oPictureBox3.Visible = true;
                }
                // end block 1
                else if (xPictureBox1.Visible && xPictureBox2.Visible && !xPictureBox3.Visible && !oPictureBox3.Visible)
                {
                    oPictureBox3.Visible = true;
                }
                else if (xPictureBox2.Visible && xPictureBox3.Visible && !xPictureBox1.Visible && !oPictureBox1.Visible)
                {
                    oPictureBox1.Visible = true;
                }
                else if (xPictureBox4.Visible && xPictureBox5.Visible && !xPictureBox6.Visible && !oPictureBox6.Visible)
                {
                    oPictureBox6.Visible = true;
                }
                else if (xPictureBox5.Visible && xPictureBox6.Visible && !xPictureBox4.Visible && !oPictureBox4.Visible)
                {
                    oPictureBox4.Visible = true;
                }
                else if (xPictureBox7.Visible && xPictureBox8.Visible && !xPictureBox9.Visible && !oPictureBox9.Visible)
                {
                    oPictureBox9.Visible = true;
                }
                else if (xPictureBox8.Visible && xPictureBox9.Visible && !xPictureBox7.Visible && !oPictureBox7.Visible)
                {
                    oPictureBox7.Visible = true;
                }
                else if (xPictureBox1.Visible && xPictureBox4.Visible && !xPictureBox7.Visible && !oPictureBox7.Visible)
                {
                    oPictureBox7.Visible = true;
                }
                else if (xPictureBox2.Visible && xPictureBox5.Visible && !xPictureBox8.Visible && !oPictureBox8.Visible)
                {
                    oPictureBox8.Visible = true;
                }
                else if (xPictureBox3.Visible && xPictureBox6.Visible && !xPictureBox9.Visible && !oPictureBox9.Visible)
                {
                    oPictureBox9.Visible = true;
                }
                else if (xPictureBox4.Visible && xPictureBox7.Visible && !xPictureBox1.Visible && !oPictureBox1.Visible)
                {
                    oPictureBox1.Visible = true;
                }
                else if (xPictureBox5.Visible && xPictureBox8.Visible && !xPictureBox2.Visible && !oPictureBox2.Visible)
                {
                    oPictureBox2.Visible = true;
                }
                else if (xPictureBox6.Visible && xPictureBox9.Visible && !xPictureBox3.Visible && !oPictureBox3.Visible)
                {
                    oPictureBox3.Visible = true;
                }
                else if (xPictureBox1.Visible && xPictureBox5.Visible && !xPictureBox9.Visible && !oPictureBox9.Visible)
                {
                    oPictureBox9.Visible = true;
                }
                else if (xPictureBox5.Visible && xPictureBox9.Visible && !xPictureBox1.Visible && !oPictureBox1.Visible)
                {
                    oPictureBox1.Visible = true;
                }
                else if (xPictureBox3.Visible && xPictureBox5.Visible && !xPictureBox7.Visible && !oPictureBox7.Visible)
                {
                    oPictureBox7.Visible = true;
                }
                else if (xPictureBox5.Visible && xPictureBox7.Visible && !xPictureBox3.Visible && !oPictureBox3.Visible)
                {
                    oPictureBox3.Visible = true;
                } 
                // end block 2
                else if (!xPictureBox5.Visible && !oPictureBox5.Visible)
                {
                    oPictureBox5.Visible = true;
                }
                // end block 5
                else if (xPictureBox1.Visible && !xPictureBox9.Visible && !oPictureBox9.Visible)
                {
                    oPictureBox9.Visible = true;
                }
                else if (xPictureBox3.Visible && !xPictureBox7.Visible && !oPictureBox7.Visible)
                {
                    oPictureBox7.Visible = true;
                }
                else if (xPictureBox7.Visible && !xPictureBox3.Visible && !oPictureBox3.Visible)
                {
                    oPictureBox3.Visible = true;
                }
                else if (xPictureBox9.Visible && !xPictureBox1.Visible && !oPictureBox1.Visible)
                {
                    oPictureBox1.Visible = true;
                }
                // end block 6
                else if (!xPictureBox1.Visible && !oPictureBox1.Visible)
                {
                    oPictureBox1.Visible = true;
                }
                else if (!xPictureBox3.Visible && !oPictureBox3.Visible)
                {
                    oPictureBox3.Visible = true;
                }
                else if (!xPictureBox7.Visible && !oPictureBox7.Visible)
                {
                    oPictureBox7.Visible = true;
                }
                else if (!xPictureBox9.Visible && !oPictureBox9.Visible)
                {
                    oPictureBox9.Visible = true;
                }
                // end block 7
                else if (!xPictureBox2.Visible && !oPictureBox2.Visible)
                {
                    oPictureBox2.Visible = true;
                }
                else if (!xPictureBox4.Visible && !oPictureBox4.Visible)
                {
                    oPictureBox4.Visible = true;
                }
                else if (!xPictureBox6.Visible && !oPictureBox6.Visible)
                {
                    oPictureBox6.Visible = true;
                }
                else if (!xPictureBox8.Visible && !oPictureBox8.Visible)
                {
                    oPictureBox8.Visible = true;
                }
                // end block 8

                if (oHasWon())
                {
                    turnLabel.ForeColor = Color.FromArgb(0, 114, 255);
                    turnLabel.Text = "CPU WIN";
                }
                else
                {
                    turnLabel.ForeColor = Color.Red;
                    turnLabel.Text = "YOUR TURN";
                }
            }));
            turn = false;
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

        private bool CheckWin()
        {
            if (xHasWon())
            {
                turnLabel.ForeColor = Color.Red;
                turnLabel.Text = "YOU WIN";
                return true;
            }

            if (oHasWon())
            {
                turnLabel.ForeColor = Color.FromArgb(0, 114, 255);
                turnLabel.Text = "CPU WIN";
                return true;
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
                ((xPictureBox9.Visible) || (oPictureBox9.Visible))
                )
            {
                turnLabel.ForeColor = Color.Black;
                turnLabel.Text = "TIE";
                return true;
            }
            return false;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
        }
    }
}
