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

        public Battle(Monster player, Monster opponent)
        {
            Player = player;
            Opponent = opponent;
        }
    }
}
