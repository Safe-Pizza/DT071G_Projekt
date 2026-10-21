using CuteMonsterQuest.Actions;
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
    public partial class GameWindow : Form
    {
        private readonly Game game;

        public GameWindow(Game game)
        {
            InitializeComponent();

            this.game = game;

            ShowMonsters();
        }

        private void ShowMonsters()
        {
            if (game.CurrentBattle is null)
                return;

            Monster player = game.CurrentBattle.Player;
            Monster opponent = game.CurrentBattle.Opponent;

            pictureBox1.Image = player.MonsterImage;
            labelPlayerMonster.Text = player.MonsterName;
            labelPlayerMonsterHp.Text = $"HP: {player.MonsterHp}";

            pictureBox2.Image = opponent.MonsterImage;
            labelOpponentMonster.Text = opponent.MonsterName;
            labelOpponentMonsterHp.Text = $"HP: {opponent.MonsterHp}";
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAttack_Click(object sender, EventArgs e)
        {

        }

        private void labelOpponentMonsterHp_Click(object sender, EventArgs e)
        {

        }
    }
}
