using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest
{
    public interface IAction
    {
        bool DoAction(Monster attacker, Monster target);
    }
}
