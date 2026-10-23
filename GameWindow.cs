using CuteMonsterQuest.Actions;
using CuteMonsterQuest.GameLogic;
using CuteMonsterQuest.Interfaces;
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

            EnablePlayerButtons(false);

            bool success = game.CurrentBattle.ActionTurn(new Attack());

            if (!success)
            {
                if (game.CurrentBattle.IsBattleWon())
                {
                    await EndBattle();
                }
                else
                {
                    MessageBox.Show("Player turn attack went wrong");
                    return;
                }
            }
            else
            {
                await ShowBattleInfo($"{game.CurrentBattle.Player.MonsterName} attackerar");
                UpdateMonsterLabelHp();
            }

            await AutomaticExecuteOpponentTurn();

            EnablePlayerButtons(true);
        }

        private async void buttonAttackSpecial_Click(object sender, EventArgs e)
        {
            if (game.CurrentBattle is null)
                return;

            EnablePlayerButtons(false);

            bool success = game.CurrentBattle.ActionTurn(new Specialattack());

            if (!success)
            {
                if (!game.CurrentBattle.IsBattleWon())
                {
                    await ShowBattleInfo("Specialattack redan använd! Välj på nytt");
                }
                else if (game.CurrentBattle.IsBattleWon())
                {
                    await EndBattle();
                }
                else
                {
                    MessageBox.Show("Player turn specialattack went wrong");
                    return;
                }
            }
            else
            {
                await ShowBattleInfo($"{game.CurrentBattle.Player.MonsterName} använder specialattack");
                UpdateMonsterLabelHp();


                await AutomaticExecuteOpponentTurn();

                EnablePlayerButtons(true);
            }
        }

        private async void buttonProtect_Click(object sender, EventArgs e)
        {
            if (game.CurrentBattle is null)
                return;

            EnablePlayerButtons(false);

            bool success = game.CurrentBattle.ActionTurn(new Protect());

            if (!success)
            {
                if (game.CurrentBattle.IsBattleWon())
                {
                    await EndBattle();
                }
                else
                {
                    MessageBox.Show("Player turn protect went wrong");
                    return;
                }
            }
            else
            {
                await ShowBattleInfo($"{game.CurrentBattle.Player.MonsterName} aktiverar skydd");
                UpdateMonsterLabelHp();
            }

            await AutomaticExecuteOpponentTurn();

            EnablePlayerButtons(true);

        }

        private async void buttonBerry_Click(object sender, EventArgs e)
        {
            if (game.CurrentBattle is null)
                return;

            bool success = game.CurrentBattle.ActionTurn(new Berry());

            if (!success)
            {
                if (game.CurrentBattle.IsBattleWon())
                {
                    await EndBattle();
                }
                else
                {
                    MessageBox.Show("Player turn berry went wrong");
                    return;
                }
            }
            else
            {
                await ShowBattleInfo($"{game.CurrentBattle.Player.MonsterName} äter bär");
                UpdateMonsterLabelHp();
            }

            await AutomaticExecuteOpponentTurn();

            EnablePlayerButtons(true);
        }

        private async Task AutomaticExecuteOpponentTurn()
        {
            if (game.CurrentBattle is null)
                return;

            IAction? opponentAction = game.CurrentBattle.OpponentActionAutomatic();

            if (opponentAction == null)
            {
                if (game.CurrentBattle.IsBattleWon())
                {
                    await EndBattle();
                }
                else if (game.CurrentBattle.Opponent.UsedSpecialAttack)
                {
                    await AutomaticExecuteOpponentTurn();
                }
                else
                {
                    MessageBox.Show("Opponent turn went wrong");
                    return;
                }
            }
            else
            {
                await ShowBattleInfo($"{game.CurrentBattle.Opponent.MonsterName} {opponentAction.Name}", Color.Black);
                UpdateMonsterLabelHp();

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

        private void EnablePlayerButtons(bool enabled)
        {
            if (game.CurrentBattle is null)
                return;

            buttonAttack.Enabled = enabled;
            buttonAttackSpecial.Enabled = enabled && !game.CurrentBattle.Player.UsedSpecialAttack;
            buttonProtect.Enabled = enabled;
            buttonBerry.Enabled = enabled;

        }

        private void UpdateMonsterLabelHp()
        {
            if (game.CurrentBattle is null)
                return;

            labelPlayerMonsterHp.Text = $"HP: {game.CurrentBattle.Player.MonsterHp}";
            labelOpponentMonsterHp.Text = $"HP: {game.CurrentBattle.Opponent.MonsterHp}";
        }

        private async Task EndBattle()
        {
            Battle? battle = game.CurrentBattle;

            if (battle == null || !battle.IsBattleWon())
                return;

            if (battle.Player.IsAlive())
            {
                MessageBox.Show("Grattis! Du vann striden!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Du förlorade striden!");
                this.Close();
            }
        }
    }
}
