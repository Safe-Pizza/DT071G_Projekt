using CuteMonsterQuest.Interfaces;
using CuteMonsterQuest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest.Actions
{
    public class Protect : IAction
    {
        public string Name => "aktiverar skydd";
        public bool DoAction(Monster attacker, Monster target)
        {
            attacker.ActivateProtection();
            return true;
        }
    }
}
