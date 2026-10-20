using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest
{
    public class Attack : IAction
    {
        public bool DoAction(Monster attacker, Monster target)
        {
            int damage = attacker.MonsterAttack;
            target.TakeDamage(damage);
            return true;
        }
    }
}
