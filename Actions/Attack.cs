using CuteMonsterQuest.Interfaces;
using CuteMonsterQuest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest.Actions
{
    public class Attack : IAction
    {
        public string Name => "attackerade";
        public bool DoAction(Monster attacker, Monster target)
        {
            int damage = attacker.MonsterAttack;
            target.TakeDamage(damage);
            return true;
        }
    }
}
