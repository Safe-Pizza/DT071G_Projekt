using CuteMonsterQuest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest.Actions
{
    public class Protect : IAction
    {
        public bool DoAction(Monster attacker, Monster target)
        {
            target.ActivateProtection();
            return true;
        }
    }
}
