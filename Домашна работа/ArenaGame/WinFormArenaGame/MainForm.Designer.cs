namespace WinFormArenaGame
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnNewGame = new Button();
            tbHeroA = new TextBox();
            tbHeroB = new TextBox();
            imgFight = new PictureBox();
            lbWinner = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbHero1Health = new TextBox();
            tbHero2Health = new TextBox();
            ((System.ComponentModel.ISupportInitialize)imgFight).BeginInit();
            SuspendLayout();
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(675, 63);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(94, 29);
            btnNewGame.TabIndex = 0;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // tbHeroA
            // 
            tbHeroA.Location = new Point(23, 35);
            tbHeroA.Multiline = true;
            tbHeroA.Name = "tbHeroA";
            tbHeroA.ReadOnly = true;
            tbHeroA.Size = new Size(560, 437);
            tbHeroA.TabIndex = 1;
            // 
            // tbHeroB
            // 
            tbHeroB.Location = new Point(879, 44);
            tbHeroB.Multiline = true;
            tbHeroB.Name = "tbHeroB";
            tbHeroB.ReadOnly = true;
            tbHeroB.Size = new Size(560, 437);
            tbHeroB.TabIndex = 2;
            // 
            // imgFight
            // 
            imgFight.Enabled = false;
            imgFight.Image = (Image)resources.GetObject("imgFight.Image");
            imgFight.Location = new Point(631, 252);
            imgFight.Name = "imgFight";
            imgFight.Size = new Size(206, 134);
            imgFight.TabIndex = 3;
            imgFight.TabStop = false;
            // 
            // lbWinner
            // 
            lbWinner.Location = new Point(631, 121);
            lbWinner.Name = "lbWinner";
            lbWinner.Size = new Size(206, 89);
            lbWinner.TabIndex = 4;
            lbWinner.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(879, 18);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 5;
            label1.Text = "Hero 2:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 9);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 6;
            label2.Text = "Hero 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 9);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 7;
            label3.Text = "Health:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(977, 18);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 8;
            label4.Text = "Health:";
            // 
            // tbHero1Health
            // 
            tbHero1Health.Location = new Point(189, 9);
            tbHero1Health.Multiline = true;
            tbHero1Health.Name = "tbHero1Health";
            tbHero1Health.ReadOnly = true;
            tbHero1Health.Size = new Size(49, 23);
            tbHero1Health.TabIndex = 9;
            tbHero1Health.TextChanged += tbHero1Health_TextChanged;
            // 
            // tbHero2Health
            // 
            tbHero2Health.Location = new Point(1039, 18);
            tbHero2Health.Multiline = true;
            tbHero2Health.Name = "tbHero2Health";
            tbHero2Health.ReadOnly = true;
            tbHero2Health.Size = new Size(49, 23);
            tbHero2Health.TabIndex = 10;
            tbHero2Health.TextChanged += tbHero2Health_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1464, 504);
            Controls.Add(tbHero2Health);
            Controls.Add(tbHero1Health);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbWinner);
            Controls.Add(imgFight);
            Controls.Add(tbHeroB);
            Controls.Add(tbHeroA);
            Controls.Add(btnNewGame);
            Name = "MainForm";
            Text = "Arena Game";
            ((System.ComponentModel.ISupportInitialize)imgFight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNewGame;
        private TextBox tbHeroA;
        private TextBox tbHeroB;
        private PictureBox imgFight;
        private Label lbWinner;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbHero1Health;
        private TextBox tbHero2Health;
    }
}