using CuteMonsterQuest.Interfaces;
using CuteMonsterQuest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest.Actions
{
    public class Berry : IAction
    {
        public string Name => "äter bär";
        public bool DoAction(Monster attacker, Monster target)
        {
            attacker.RestoreHp(10);
            return true;
        }
    }
}
