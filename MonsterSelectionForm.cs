using CuteMonsterQuest.GameLogic;
using CuteMonsterQuest.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CuteMonsterQuest
{
    public partial class MonsterSelectionForm : Form
    {
        private readonly Game game;

        public MonsterSelectionForm(Game game)
        {
            InitializeComponent();

            this.game = game;

            ShowMonsters(game.StartingMonsters);
        }

        private void ShowMonsters(List<Monster> monsterList)
        {
            pictureBox1.Image = monsterList[0].MonsterImage;
            pictureBox1.Tag = monsterList[0];
            pictureBox1.Click += ChooseMonster_Click;

            pictureBox2.Image = monsterList[1].MonsterImage;
            pictureBox2.Tag = monsterList[1];
            pictureBox2.Click += ChooseMonster_Click;

            pictureBox3.Image = monsterList[2].MonsterImage;
            pictureBox3.Tag = monsterList[2];
            pictureBox3.Click += ChooseMonster_Click;
        }

        private void ChooseMonster_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox &&
                pictureBox.Tag is Monster monster)
            {
                // Spara spelarens val i Game
                game.SelectMonster(monster);

                // Skapa striden och slumpa motståndare
                game.StartBattle();

                // Öppna spelfönstret
                this.Hide();

                GameWindow gameWindow = new GameWindow(game);

                gameWindow.StartPosition = FormStartPosition.Manual;

                gameWindow.Location = this.Location;

                gameWindow.ShowDialog();

                this.Close();
            }
        }
    }
}
