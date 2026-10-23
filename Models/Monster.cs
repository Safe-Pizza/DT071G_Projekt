/**
 * Filnamn: Monster.cs
 * Författare: Hanna Lindkvist
 * Datum: 2026-10-23
 * Kurs: DT071G
 * 
 * Beskrivning: Representerar ett monster med egenskaperna Namn, bild, hp, attack, specialattack.
 * Hanterar även skada och läkning samt skydd
 * 
 * **/


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
        public bool UsedSpecialAttack { get; set; } = false;
        public bool HaveProtection { get; set; }

        public Monster(string name, Image image, int hp, int attack)
        {
            MonsterName = name;
            MonsterImage = image;
            MonsterHp = hp;
            MonsterMaxHp = hp;
            MonsterAttack = attack;
            MonsterSpecialAttack = attack * 2;
        }

        //Monster skadas
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

        //Monster läker
        public void RestoreHp(int amount)
        {
            MonsterHp += amount;
            if (MonsterHp > MonsterMaxHp)
            {
                MonsterHp = MonsterMaxHp;
            }
        }

        //Monster skyddar sid
        public void ActivateProtection()
        {
            HaveProtection = true;
        }

        //Är monster vid liv?
        public bool IsAlive()
        {
            {
                return MonsterHp > 0;
            }
        }

    }
}
