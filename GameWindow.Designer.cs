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
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            labelPlayerMonster = new Label();
            labelPlayerMonsterHp = new Label();
            labelOpponentMonster = new Label();
            labelOpponentMonsterHp = new Label();
            buttonAttack = new Button();
            buttonAttackSpecial = new Button();
            buttonProtect = new Button();
            buttonBerry = new Button();
            battleInfoTimer = new System.Windows.Forms.Timer(components);
            labelBattleInfo = new Label();
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
            labelPlayerMonster.Location = new Point(12, 1035);
            labelPlayerMonster.Name = "labelPlayerMonster";
            labelPlayerMonster.Size = new Size(207, 55);
            labelPlayerMonster.TabIndex = 2;
            // 
            // labelPlayerMonsterHp
            // 
            labelPlayerMonsterHp.Font = new Font("Arial Rounded MT Bold", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPlayerMonsterHp.ForeColor = Color.White;
            labelPlayerMonsterHp.Location = new Point(12, 1121);
            labelPlayerMonsterHp.Name = "labelPlayerMonsterHp";
            labelPlayerMonsterHp.Size = new Size(207, 52);
            labelPlayerMonsterHp.TabIndex = 3;
            // 
            // labelOpponentMonster
            // 
            labelOpponentMonster.Font = new Font("Arial Rounded MT Bold", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOpponentMonster.ForeColor = Color.White;
            labelOpponentMonster.Location = new Point(1238, 1035);
            labelOpponentMonster.Name = "labelOpponentMonster";
            labelOpponentMonster.Size = new Size(207, 55);
            labelOpponentMonster.TabIndex = 4;
            labelOpponentMonster.Click += label1_Click;
            // 
            // labelOpponentMonsterHp
            // 
            labelOpponentMonsterHp.Font = new Font("Arial Rounded MT Bold", 20.1428585F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelOpponentMonsterHp.ForeColor = Color.White;
            labelOpponentMonsterHp.Location = new Point(1238, 1121);
            labelOpponentMonsterHp.Name = "labelOpponentMonsterHp";
            labelOpponentMonsterHp.Size = new Size(207, 55);
            labelOpponentMonsterHp.TabIndex = 5;
            // 
            // buttonAttack
            // 
            buttonAttack.BackColor = Color.DarkSlateGray;
            buttonAttack.Cursor = Cursors.Hand;
            buttonAttack.Font = new Font("Arial Rounded MT Bold", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAttack.ForeColor = Color.White;
            buttonAttack.Image = Properties.Resources.swords;
            buttonAttack.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAttack.Location = new Point(284, 1052);
            buttonAttack.Name = "buttonAttack";
            buttonAttack.Padding = new Padding(10);
            buttonAttack.Size = new Size(210, 100);
            buttonAttack.TabIndex = 6;
            buttonAttack.Text = "ATTACK";
            buttonAttack.TextAlign = ContentAlignment.MiddleRight;
            buttonAttack.UseVisualStyleBackColor = false;
            buttonAttack.Click += buttonAttack_Click;
            // 
            // buttonAttackSpecial
            // 
            buttonAttackSpecial.BackColor = Color.DarkSlateGray;
            buttonAttackSpecial.Cursor = Cursors.Hand;
            buttonAttackSpecial.Font = new Font("Arial Rounded MT Bold", 9.857143F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonAttackSpecial.ForeColor = Color.White;
            buttonAttackSpecial.Image = Properties.Resources.swords;
            buttonAttackSpecial.ImageAlign = ContentAlignment.MiddleLeft;
            buttonAttackSpecial.Location = new Point(516, 1052);
            buttonAttackSpecial.Name = "buttonAttackSpecial";
            buttonAttackSpecial.Padding = new Padding(10);
            buttonAttackSpecial.Size = new Size(210, 100);
            buttonAttackSpecial.TabIndex = 7;
            buttonAttackSpecial.Text = "SPECIAL\r\nATTACK";
            buttonAttackSpecial.TextAlign = ContentAlignment.MiddleRight;
            buttonAttackSpecial.UseVisualStyleBackColor = false;
            buttonAttackSpecial.Click += buttonAttackSpecial_Click;
            // 
            // buttonProtect
            // 
            buttonProtect.BackColor = Color.DarkSlateGray;
            buttonProtect.Cursor = Cursors.Hand;
            buttonProtect.Font = new Font("Arial Rounded MT Bold", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonProtect.ForeColor = Color.White;
            buttonProtect.Image = Properties.Resources.swords;
            buttonProtect.ImageAlign = ContentAlignment.MiddleLeft;
            buttonProtect.Location = new Point(748, 1052);
            buttonProtect.Name = "buttonProtect";
            buttonProtect.Padding = new Padding(10);
            buttonProtect.Size = new Size(210, 100);
            buttonProtect.TabIndex = 8;
            buttonProtect.Text = "SKYDD";
            buttonProtect.TextAlign = ContentAlignment.MiddleRight;
            buttonProtect.UseVisualStyleBackColor = false;
            buttonProtect.Click += buttonProtect_Click;
            // 
            // buttonBerry
            // 
            buttonBerry.BackColor = Color.DarkSlateGray;
            buttonBerry.Cursor = Cursors.Hand;
            buttonBerry.Font = new Font("Arial Rounded MT Bold", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonBerry.ForeColor = Color.White;
            buttonBerry.Image = Properties.Resources.swords;
            buttonBerry.ImageAlign = ContentAlignment.MiddleLeft;
            buttonBerry.Location = new Point(980, 1052);
            buttonBerry.Name = "buttonBerry";
            buttonBerry.Padding = new Padding(10);
            buttonBerry.Size = new Size(210, 100);
            buttonBerry.TabIndex = 9;
            buttonBerry.Text = "ÄT BÄR";
            buttonBerry.TextAlign = ContentAlignment.MiddleRight;
            buttonBerry.UseVisualStyleBackColor = false;
            buttonBerry.Click += buttonBerry_Click;
            // 
            // battleInfoTimer
            // 
            battleInfoTimer.Interval = 2000;
            // 
            // labelBattleInfo
            // 
            labelBattleInfo.BackColor = Color.Transparent;
            labelBattleInfo.Font = new Font("Arial Rounded MT Bold", 14.1428576F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBattleInfo.ForeColor = Color.White;
            labelBattleInfo.Location = new Point(373, 135);
            labelBattleInfo.Name = "labelBattleInfo";
            labelBattleInfo.Size = new Size(791, 114);
            labelBattleInfo.TabIndex = 10;
            labelBattleInfo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // GameWindow
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateGray;
            BackgroundImage = Properties.Resources.backgroundGame1500;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1476, 1206);
            Controls.Add(labelBattleInfo);
            Controls.Add(buttonBerry);
            Controls.Add(buttonProtect);
            Controls.Add(buttonAttackSpecial);
            Controls.Add(buttonAttack);
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
        private Button buttonAttack;
        private Button buttonAttackSpecial;
        private Button buttonProtect;
        private Button buttonBerry;
        private System.Windows.Forms.Timer battleInfoTimer;
        private Label labelBattleInfo;
    }
}