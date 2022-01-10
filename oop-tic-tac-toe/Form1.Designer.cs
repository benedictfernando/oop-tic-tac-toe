namespace oop_tic_tac_toe
{
    partial class tictactoe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tictactoe));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.newGame = new System.Windows.Forms.Button();
            this.resetScore = new System.Windows.Forms.Button();
            this.tl = new System.Windows.Forms.Button();
            this.t = new System.Windows.Forms.Button();
            this.tr = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Button();
            this.m = new System.Windows.Forms.Button();
            this.r = new System.Windows.Forms.Button();
            this.bl = new System.Windows.Forms.Button();
            this.b = new System.Windows.Forms.Button();
            this.br = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.p1 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.Label();
            this.p1Score = new System.Windows.Forms.Label();
            this.p2Score = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tl, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.t, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tr, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.l, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.m, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.r, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.bl, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.b, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.br, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 457);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel3, 5);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel3.Controls.Add(this.newGame, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.resetScore, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 402);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(474, 52);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // newGame
            // 
            this.newGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newGame.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.newGame.Location = new System.Drawing.Point(31, 3);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(202, 46);
            this.newGame.TabIndex = 0;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = true;
            // 
            // resetScore
            // 
            this.resetScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetScore.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.resetScore.Location = new System.Drawing.Point(239, 3);
            this.resetScore.Name = "resetScore";
            this.resetScore.Size = new System.Drawing.Size(202, 46);
            this.resetScore.TabIndex = 1;
            this.resetScore.Text = "Reset Score";
            this.resetScore.UseVisualStyleBackColor = true;
            // 
            // tl
            // 
            this.tl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tl.Location = new System.Drawing.Point(63, 60);
            this.tl.Name = "tl";
            this.tl.Size = new System.Drawing.Size(114, 108);
            this.tl.TabIndex = 0;
            this.tl.UseVisualStyleBackColor = true;
            this.tl.EnabledChanged += new System.EventHandler(this.labelChange);
            this.tl.Click += new System.EventHandler(this.cell_Click);
            // 
            // t
            // 
            this.t.Cursor = System.Windows.Forms.Cursors.Hand;
            this.t.Dock = System.Windows.Forms.DockStyle.Fill;
            this.t.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.t.Location = new System.Drawing.Point(183, 60);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(114, 108);
            this.t.TabIndex = 1;
            this.t.UseVisualStyleBackColor = true;
            this.t.EnabledChanged += new System.EventHandler(this.labelChange);
            this.t.Click += new System.EventHandler(this.cell_Click);
            // 
            // tr
            // 
            this.tr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tr.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tr.Location = new System.Drawing.Point(303, 60);
            this.tr.Name = "tr";
            this.tr.Size = new System.Drawing.Size(114, 108);
            this.tr.TabIndex = 2;
            this.tr.UseVisualStyleBackColor = true;
            this.tr.EnabledChanged += new System.EventHandler(this.labelChange);
            this.tr.Click += new System.EventHandler(this.cell_Click);
            // 
            // l
            // 
            this.l.Cursor = System.Windows.Forms.Cursors.Hand;
            this.l.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.l.Location = new System.Drawing.Point(63, 174);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(114, 108);
            this.l.TabIndex = 3;
            this.l.UseVisualStyleBackColor = true;
            this.l.EnabledChanged += new System.EventHandler(this.labelChange);
            this.l.Click += new System.EventHandler(this.cell_Click);
            // 
            // m
            // 
            this.m.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.m.Location = new System.Drawing.Point(183, 174);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(114, 108);
            this.m.TabIndex = 4;
            this.m.UseVisualStyleBackColor = true;
            this.m.EnabledChanged += new System.EventHandler(this.labelChange);
            this.m.Click += new System.EventHandler(this.cell_Click);
            // 
            // r
            // 
            this.r.Cursor = System.Windows.Forms.Cursors.Hand;
            this.r.Dock = System.Windows.Forms.DockStyle.Fill;
            this.r.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.r.Location = new System.Drawing.Point(303, 174);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(114, 108);
            this.r.TabIndex = 5;
            this.r.UseVisualStyleBackColor = true;
            this.r.EnabledChanged += new System.EventHandler(this.labelChange);
            this.r.Click += new System.EventHandler(this.cell_Click);
            // 
            // bl
            // 
            this.bl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bl.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bl.Location = new System.Drawing.Point(63, 288);
            this.bl.Name = "bl";
            this.bl.Size = new System.Drawing.Size(114, 108);
            this.bl.TabIndex = 6;
            this.bl.UseVisualStyleBackColor = true;
            this.bl.EnabledChanged += new System.EventHandler(this.labelChange);
            this.bl.Click += new System.EventHandler(this.cell_Click);
            // 
            // b
            // 
            this.b.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.b.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.b.Location = new System.Drawing.Point(183, 288);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(114, 108);
            this.b.TabIndex = 7;
            this.b.UseVisualStyleBackColor = true;
            this.b.EnabledChanged += new System.EventHandler(this.labelChange);
            this.b.Click += new System.EventHandler(this.cell_Click);
            // 
            // br
            // 
            this.br.Cursor = System.Windows.Forms.Cursors.Hand;
            this.br.Dock = System.Windows.Forms.DockStyle.Fill;
            this.br.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.br.Location = new System.Drawing.Point(303, 288);
            this.br.Name = "br";
            this.br.Size = new System.Drawing.Size(114, 108);
            this.br.TabIndex = 8;
            this.br.UseVisualStyleBackColor = true;
            this.br.EnabledChanged += new System.EventHandler(this.labelChange);
            this.br.Click += new System.EventHandler(this.cell_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 5);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel2.Controls.Add(this.p1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.p2, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.p1Score, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.p2Score, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(474, 51);
            this.tableLayoutPanel2.TabIndex = 9;
            // 
            // p1
            // 
            this.p1.AutoSize = true;
            this.p1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.p1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.p1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.p1.Location = new System.Drawing.Point(31, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(136, 51);
            this.p1.TabIndex = 0;
            this.p1.Text = "Player 1";
            this.p1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2
            // 
            this.p2.AutoSize = true;
            this.p2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.p2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.p2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.p2.Location = new System.Drawing.Point(305, 0);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(136, 51);
            this.p2.TabIndex = 1;
            this.p2.Text = "Player 2";
            this.p2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1Score
            // 
            this.p1Score.AutoSize = true;
            this.p1Score.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p1Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p1Score.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.p1Score.Location = new System.Drawing.Point(173, 0);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(60, 51);
            this.p1Score.TabIndex = 2;
            this.p1Score.Text = "00";
            this.p1Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2Score
            // 
            this.p2Score.AutoSize = true;
            this.p2Score.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.p2Score.Dock = System.Windows.Forms.DockStyle.Fill;
            this.p2Score.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.p2Score.Location = new System.Drawing.Point(239, 0);
            this.p2Score.Name = "p2Score";
            this.p2Score.Size = new System.Drawing.Size(60, 51);
            this.p2Score.TabIndex = 3;
            this.p2Score.Text = "00";
            this.p2Score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tictactoe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(480, 457);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "tictactoe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button tl;
        private System.Windows.Forms.Button t;
        private System.Windows.Forms.Button tr;
        private System.Windows.Forms.Button l;
        private System.Windows.Forms.Button m;
        private System.Windows.Forms.Button r;
        private System.Windows.Forms.Button bl;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.Button br;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Button resetScore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label p1;
        private System.Windows.Forms.Label p2;
        private System.Windows.Forms.Label p1Score;
        private System.Windows.Forms.Label p2Score;
    }
}
