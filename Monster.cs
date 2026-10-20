using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest
{
    public class Monster(string name, Image image, int hp, int attack, int specialAttack)
    {
        public required string MonsterName { get; set; } = name;
        public required Image MonsterImage { get; set; } = image;
        public int MonsterHp { get; private set; } = hp;
        public int MonsterMaxHp { get; private set; } = hp;
        public int MonsterAttack { get; private set; } = attack;
        public int MonsterSpecialAttack { get; private set; } = specialAttack;
        public bool UsedSpecialAttack { get; private set; }
        public bool HaveProtection { get; set; }

        public void TakeDamage(int damage)
        {
            if(HaveProtection)
            {
                damage = damage / 2;
                HaveProtection = false;
            }

            MonsterHp -= damage;
            if (MonsterHp < 0)
            {
                MonsterHp = 0;
            }
        }

        public void restoreHp(int amount)
        {
            MonsterHp += amount;
            if (MonsterHp > MonsterMaxHp)
            {
                MonsterHp = MonsterMaxHp;
            }
        }

        public void ActivateProtection()
        {
            HaveProtection = true;
        }

        public bool IsAlive()
        {
            {
                return MonsterHp > 0;
            }
        }

    }
}
