using CuteMonsterQuest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest.Actions
{
    public class Specialattack : IAction
    {

        private readonly HashSet<Monster> MonsterUsedSpecialAttack = [];
        public bool DoAction(Monster attacker, Monster target)
        {
            if(MonsterUsedSpecialAttack.Contains(attacker))
            {
                return false;
            }
            else
            {
                target.TakeDamage(attacker.MonsterSpecialAttack);
                MonsterUsedSpecialAttack.Add(attacker);
                return true;
            }
        }
    }
}
