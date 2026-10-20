using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest
{
    internal class Monster
    {
        public required string monsterName { get; set; }
        public required Image monsterImage { get; set; }
        public int monsterHp { get; private set; }
        public int monsterMaxHp { get; private set; }
        public int monsterAttack { get; private set; }
        public int monsterSpecialAttack { get; private set; }
        public bool usedSpecialAttack { get; private set; }
        public bool haveProtection { get; set; }

        public Monster(string name, Image image, int hp, int attack, int specialAttack)
        {
            monsterName = name;
            monsterImage = image;
            monsterHp = hp;
            monsterMaxHp = hp;
            monsterAttack = attack;
            monsterSpecialAttack = specialAttack;
        }

        public void TakeDamage(int damage)
        {
            if(haveProtection)
            {
                damage = damage / 2;
                haveProtection = false;
            }

            monsterHp -= damage;
            if (monsterHp < 0)
            {
                monsterHp = 0;
            }
        }

        public void ActivateProtection()
        {
            haveProtection = true;
        }

        public bool IsAlive()
        {
            {
                return monsterHp > 0;
            }
        }

    }
}
