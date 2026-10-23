/**
 * Filnamn: MonsterSelectionForm.cs
 * Författare: Hanna Lindkvist
 * Datum: 2026-10-23
 * Kurs: DT071G
 * 
 * Beskrivning: Spelet sida för val av monster. Här väljer spelaren ett av tre tillgänliga monster.
 * 
 * **/


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

        //Visa grafik, namn, hp och attack för de tre valbara spelarmonstren
        private void ShowMonsters(List<Monster> monsterList)
        {
            if (monsterList == null)
            {
                throw new ArgumentException("Listan får inte vara tom");
            }

            pictureBox1.Image = monsterList[0].MonsterImage;
            pictureBox1.Tag = monsterList[0];
            pictureBox1.Click += ChooseMonster_Click;
            pb1MonsterName.Text = monsterList[0].MonsterName;
            pb1MonsterHp.Text = $"HP: {monsterList[0].MonsterHp.ToString()}";
            pb1MonsterAttack.Text = $"Skada: {monsterList[0].MonsterAttack.ToString()}";

            pictureBox2.Image = monsterList[1].MonsterImage;
            pictureBox2.Tag = monsterList[1];
            pictureBox2.Click += ChooseMonster_Click;
            pb2MonsterName.Text = monsterList[1].MonsterName;
            pb2MonsterHp.Text = $"HP: {monsterList[1].MonsterHp.ToString()}";
            pb2MonsterAttack.Text = $"Skada: {monsterList[1].MonsterAttack.ToString()}";

            pictureBox3.Image = monsterList[2].MonsterImage;
            pictureBox3.Tag = monsterList[2];
            pictureBox3.Click += ChooseMonster_Click;
            pb3MonsterName.Text = monsterList[2].MonsterName;
            pb3MonsterHp.Text = $"HP: {monsterList[2].MonsterHp.ToString()}";
            pb3MonsterAttack.Text = $"Skada: {monsterList[2].MonsterAttack.ToString()}";
        }

        //Klick-event för att välja monster
        private void ChooseMonster_Click(object? sender, EventArgs e)
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
