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

        private async void buttonAttack_Click(object sender, EventArgs e)
        {
            if (game.CurrentBattle is null)
                return;

            bool success = game.CurrentBattle.ActionTurn(new Attack());

            if (!success)
            {
                MessageBox.Show("Något blev fel, försök igen");
                return;
            }
            else
            {
                await ShowBattleInfo($"ATTACK!");
                labelOpponentMonsterHp.Text = $"HP: {game.CurrentBattle.Opponent.MonsterHp}";
            }

        }

        private async void buttonProtect_Click(object sender, EventArgs e)
        {
            if (game.CurrentBattle is null)
                return;

            bool success = game.CurrentBattle.ActionTurn(new Protect());

            if (!success)
            {
                MessageBox.Show("Något blev fel, försök igen");
                return;
            }
            else
            {
                await ShowBattleInfo($"SKYDD AKTIVT {game.CurrentBattle.Player.HaveProtection}");
            }

        }

        private async void buttonBerry_Click(object sender, EventArgs e)
        {
            if (game.CurrentBattle is null)
                return;

            bool success = game.CurrentBattle.ActionTurn(new Berry());

            if (!success)
            {
                MessageBox.Show("Något blev fel, försök igen");
                return;
            }
            else
            {
                await ShowBattleInfo($"MUMS! + 20 hp");
            }
        }

        private async Task ShowBattleInfo(string info, Color? backgroundColor = null)
        {
            labelBattleInfo.Text = info;
            labelBattleInfo.BackColor = backgroundColor ?? Color.DarkSlateGray;
            labelBattleInfo.Visible = true;

            await Task.Delay(2000);

            labelBattleInfo.Visible = false;
        }
    }
}
