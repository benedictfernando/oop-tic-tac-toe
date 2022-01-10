using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_tic_tac_toe
{
    public partial class tictactoe : Form
    {
        public tictactoe()
        {
            InitializeComponent();
        }

        private bool p1Turn = true;

        private void cell_Click(object sender, EventArgs e)
        {
            var button = (sender as Button);
            if (button.Enabled)
            {
                if (p1Turn) button.Text = "X";
                else button.Text = "O";

                button.Enabled = false;
                p1Turn = !p1Turn;
                // checkForWinner();
            }
        }

        private void labelChange(object sender, EventArgs e)
        {
            if (p1Turn)
            {
                p1.BackColor = SystemColors.ControlDarkDark;
                p2.BackColor = SystemColors.InactiveCaption;
            }
            else
            {
                p1.BackColor = SystemColors.InactiveCaption;
                p2.BackColor = SystemColors.ControlDarkDark;
            }
        }
    }
}
