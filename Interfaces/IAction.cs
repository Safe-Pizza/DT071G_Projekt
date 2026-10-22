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
