using System;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Home : Form
    {
        public static Form HomeForm = new Home();
        public Form vsPlayerForm = new vsPlayer();
        public Form vsCPUForm = new vsCPU();
        public Home()
        {
            InitializeComponent();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made with love by github.com/lorenzoverardo", "About");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void playerVsPlayerPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            vsPlayerForm.ShowDialog(this);
        }

        private void playerVsCpuPictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            vsCPUForm.ShowDialog(this);
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
