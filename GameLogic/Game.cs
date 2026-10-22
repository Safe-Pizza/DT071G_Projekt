using CuteMonsterQuest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest.GameLogic
{
    public class Game
    {
        public List<Monster> StartingMonsters { get; } = [];

        public List<Monster> OpponentMonsters { get; } = [];

        public Monster? SelectedMonster { get; private set; }
        public Monster? OpponentMonster { get; private set; }

        public Battle? CurrentBattle { get; private set; }

        public Game()
        {
            CreateMonsters();
        }

        private void CreateMonsters()
        {
            StartingMonsters.Add(new Monster(
                "Beige", Properties.Resources.beigeMonster, 120, 120, 40));

            StartingMonsters.Add(new Monster(
                "Green", Properties.Resources.greenMonster, 120, 20, 40));

            StartingMonsters.Add(new Monster(
                "Blue", Properties.Resources.blueMonster, 120, 20, 40));

            OpponentMonsters.Add(new Monster(
                "Navy", Properties.Resources.navyAngryMonster, 120, 20, 40));

            OpponentMonsters.Add(new Monster(
                "Red", Properties.Resources.redAngryMonster, 120, 20, 40));

            OpponentMonsters.Add(new Monster(
                "Purple", Properties.Resources.purpleAngryMonster, 120, 20, 40));
        }

        public void SelectMonster(Monster monster)
        {
            if (!StartingMonsters.Contains(monster))
                throw new ArgumentException("Ogiltigt monster.");

            SelectedMonster = monster;
        }

        private Monster RandomMonster(List<Monster> monsterList)
        {
            if (monsterList.Count == 0)
                throw new InvalidOperationException("Inga monster finns.");

            int index = Random.Shared.Next(monsterList.Count);

            return monsterList[index];
        }

        public void StartBattle()
        {
            if (SelectedMonster is null)
                throw new InvalidOperationException("Inget monster valt.");

            OpponentMonster = RandomMonster(OpponentMonsters);

            CurrentBattle = new Battle(SelectedMonster, OpponentMonster);
        }
    }
}
