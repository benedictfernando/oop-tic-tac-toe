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
        private bool p1Turn = true;
        private List<Button> cells = new List<Button>();

        public tictactoe()
        {
            InitializeComponent();
            
            // Add buttons to 'cells' global variable
            cells.Add(this.tl);
            cells.Add(this.t);
            cells.Add(this.tr);
            cells.Add(this.l);
            cells.Add(this.m);
            cells.Add(this.r);
            cells.Add(this.bl);
            cells.Add(this.b);
            cells.Add(this.br);

            // Start game
            // newGame.PerformClick()
        }

        private void cell_Click(object sender, EventArgs e)
        {
            var button = (sender as Button);
            if (button.Enabled)
            {
                if (p1Turn) button.Text = "X";
                else button.Text = "O";

                button.Enabled = false;
                p1Turn = !p1Turn;
                checkForWinner();
            }
        }

        private void checkForWinner()
        {
            bool tie = true;
            string result = null;

            // Check for any enabled cells
            foreach (var cell in cells)
            {
                if (cell.Enabled) { tie = false; break; }
            }

            if (tie) result = "Tie!";
            else    // if result is not 'tie'...
            {
                string l = cells[3].Text, m = cells[4].Text, r = cells[5].Text,
                tl = cells[0].Text, t = cells[1].Text, tr = cells[2].Text,
                bl = cells[6].Text, b = cells[7].Text, br = cells[8].Text;

                // for trios with 'middle' cell as their common one
                if ((tl == m && m == br || t == m && m == b || tr == m && m == bl 
                    || r == m && m == l) && !cells[4].Enabled) result = m;

                // for trios with 'top-left' cell as their common one
                else if ((tl == t && t == tr || tl == l && l == bl)
                    && !cells[0].Enabled) result = tl;

                // for trios with 'bottom-right' cell as their common one
                else if ((br == r && r == tr || br == b && b == bl)
                    && !cells[8].Enabled) result = br;
            }

            if (result != null)
            {
                if (result == "X")
                {
                    result = "Player 1 wins!"; // p1Score++;
                }
                else if (result == "O")
                {
                    result = "Player 2 wins!"; // p2Score++;
                }

                if (MessageBox.Show(result) == DialogResult.OK)
                {
                    // newGame.PerformClick()
                }
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
