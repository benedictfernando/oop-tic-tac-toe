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
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            p1Turn = true;
            foreach (var cell in cells)
            {
                cell.Text = ""; cell.Enabled = true;
            }
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
            string result = null;

            // Initialize each cells to its corresponding text variable
            string l = cells[3].Text, m = cells[4].Text, r = cells[5].Text,
            tl = cells[0].Text, t = cells[1].Text, tr = cells[2].Text,
            bl = cells[6].Text, b = cells[7].Text, br = cells[8].Text;

            // For trios with 'middle' button as their common cell
            if ((tl == m && m == br || t == m && m == b || tr == m && m == bl 
                || r == m && m == l) && !cells[4].Enabled) result = m;

            // For trios with 'top-left' button as their common cell
            else if ((tl == t && t == tr || tl == l && l == bl)
                && !cells[0].Enabled) result = tl;

            // For trios with 'bottom-right' button as their common cell
            else if ((br == r && r == tr || br == b && b == bl)
                && !cells[8].Enabled) result = br;

            // For tie situation
            if (result == null)
            {
                // Check for any enabled cells
                bool tie = true;
                foreach (var cell in cells)
                {
                    if (cell.Enabled) { tie = !tie; break; }
                }
                if (tie) result = "Tie!";
            }

            // For results
            if (result != null)
            {
                addScore(result);
                if (result == "X") result = "Player 1 wins!";
                else if (result == "O") result = "Player 2 wins!";

                if (MessageBox.Show(result) == DialogResult.OK)
                    newGame.PerformClick();
            }
        }

        // Increment current player's score
        private void addScore(string value)
        {
            int score;
            if (value == "X")
            {
                score = int.Parse(p1Score.Text); score++;
                p1Score.Text = score.ToString("D2");
            }
            else if (value == "O")
            {
                score = int.Parse(p2Score.Text); score++;
                p2Score.Text = score.ToString("D2");
            }
        }

        // Change color in an alternate manner each move
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
