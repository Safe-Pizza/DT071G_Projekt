using CuteMonsterQuest.Interfaces;
using CuteMonsterQuest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest.Actions
{
    public class Specialattack : IAction
    {
        public string Name => "använder specialattack";

        public bool DoAction(Monster attacker, Monster target)
        {
            if(attacker.UsedSpecialAttack)
            {
                return false;
            }
            else
            {
                target.TakeDamage(attacker.MonsterSpecialAttack);
                attacker.UsedSpecialAttack = true;
                return true;
            }
        }
    }
}
