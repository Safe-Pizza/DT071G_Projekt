using CuteMonsterQuest.Actions;
using CuteMonsterQuest.Interfaces;
using CuteMonsterQuest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest.GameLogic
{
    public class Battle
    {
        public Monster Player { get; }
        public Monster Opponent { get; }

        private List<IAction> opponentActions = new()
        {
            new Attack(),
            new Specialattack(),
            new Protect(),
            new Berry()
        };

        public Battle(Monster player, Monster opponent)
        {
            Player = player;
            Opponent = opponent;
        }

        public bool isBattleWon()
        {
            return Player.MonsterHp <= 0 || Opponent.MonsterHp <= 0;
        }
    }
}
