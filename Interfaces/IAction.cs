/**
 * Filnamn: IAction.cs
 * Författare: Hanna Lindkvist
 * Datum: 2026-10-23
 * Kurs: DT071G
 * 
 * Beskrivning: Interface för handlingar (actions) ett monster kan utföra
 * 
 * **/


using CuteMonsterQuest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest.Interfaces
{
    public interface IAction
    {
        string Name { get; }
        bool DoAction(Monster attacker, Monster target);
    }
}
