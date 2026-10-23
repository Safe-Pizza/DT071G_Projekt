/**
 * Filnamn: Protect.cs
 * Författare: Hanna Lindkvist
 * Datum: 2026-10-23
 * Kurs: DT071G
 * 
 * Beskrivning: Klass för skydd. Metod som vid val aktiverar skydd för den som valt.
 * Implementerar interface IAction
 * 
 * **/

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
