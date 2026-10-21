namespace CuteMonsterQuest
{
    partial class GameWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelPlayerMonster = new Label();
            labelPlayerMonsterHp = new Label();
            labelOpponentMonster = new Label();
            labelOpponentMonsterHp = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Location = new Point(271, 404);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 200);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Location = new Point(1002, 413);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(300, 200);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // labelPlayerMonster
            // 
            labelPlayerMonster.BackColor = Color.DarkSlateGray;
            labelPlayerMonster.Font = new Font("Arial Rounded MT Bold", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlayerMonster.ForeColor = Color.White;
            labelPlayerMonster.Location = new Point(28, 1013);
            labelPlayerMonster.Name = "labelPlayerMonster";
            labelPlayerMonster.Size = new Size(207, 55);
            labelPlayerMonster.TabIndex = 2;
            // 
            // labelPlayerMonsterHp
            // 
            labelPlayerMonsterHp.Font = new Font("Arial Rounded MT Bold", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlayerMonsterHp.ForeColor = Color.White;
            labelPlayerMonsterHp.Location = new Point(28, 1078);
            labelPlayerMonsterHp.Name = "labelPlayerMonsterHp";
            labelPlayerMonsterHp.Size = new Size(207, 52);
            labelPlayerMonsterHp.TabIndex = 3;
            // 
            // labelOpponentMonster
            // 
            labelOpponentMonster.Font = new Font("Arial Rounded MT Bold", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOpponentMonster.ForeColor = Color.White;
            labelOpponentMonster.Location = new Point(1210, 1013);
            labelOpponentMonster.Name = "labelOpponentMonster";
            labelOpponentMonster.Size = new Size(207, 55);
            labelOpponentMonster.TabIndex = 4;
            labelOpponentMonster.Click += label1_Click;
            // 
            // labelOpponentMonsterHp
            // 
            labelOpponentMonsterHp.Font = new Font("Arial Rounded MT Bold", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOpponentMonsterHp.ForeColor = Color.White;
            labelOpponentMonsterHp.Location = new Point(1210, 1078);
            labelOpponentMonsterHp.Name = "labelOpponentMonsterHp";
            labelOpponentMonsterHp.Size = new Size(207, 55);
            labelOpponentMonsterHp.TabIndex = 5;
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            BackgroundImage = Properties.Resources.backgroundGame1500;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1476, 1153);
            Controls.Add(labelOpponentMonsterHp);
            Controls.Add(labelOpponentMonster);
            Controls.Add(labelPlayerMonsterHp);
            Controls.Add(labelPlayerMonster);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "GameWindow";
            Text = "GameWindow - Cute Monster Quest";
            Load += GameWindow_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label labelPlayerMonster;
        private Label labelPlayerMonsterHp;
        private Label labelOpponentMonster;
        private Label labelOpponentMonsterHp;
    }
}