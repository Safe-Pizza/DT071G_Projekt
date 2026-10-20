using CuteMonsterQuest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest.Actions
{
    public class Berry : IAction
    {
        public bool DoAction(Monster attacker, Monster target)
        {
            attacker.restoreHp(20);
            return true;
        }
    }
}
