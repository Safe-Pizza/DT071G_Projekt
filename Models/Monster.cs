using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest.Models
{
    public class Monster
    {
        public string MonsterName { get; set; }
        public Image MonsterImage { get; set; }
        public int MonsterHp { get; private set; }
        public int MonsterMaxHp { get; private set; }
        public int MonsterAttack { get; private set; }
        public int MonsterSpecialAttack { get; private set; }
        public bool UsedSpecialAttack { get; private set; }
        public bool HaveProtection { get; set; }

        public Monster(string name, Image image, int hp, int attack, int specialAttack)
        {
            MonsterName = name;
            MonsterImage = image;
            MonsterHp = hp;
            MonsterMaxHp = hp;
            MonsterAttack = attack;
            MonsterSpecialAttack = specialAttack;
        }

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
