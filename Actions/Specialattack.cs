/**
 * Filnamn: Specialattack.cs
 * Författare: Hanna Lindkvist
 * Datum: 2026-10-23
 * Kurs: DT071G
 * 
 * Beskrivning: Klass för special attack med metod som minskar målets HP utifrån attackerande monsters specialattack. 
 * Endast en gång per spel, metod kontrollerar detta.  Implementerar interface IAction
 * 
 * **/

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
