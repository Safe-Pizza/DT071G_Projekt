using CuteMonsterQuest.Actions;
using CuteMonsterQuest.Interfaces;
using CuteMonsterQuest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CuteMonsterQuest.GameLogic
{
    public class Battle
    {
        public Monster Player { get; }
        public Monster Opponent { get; }

        public bool PlayerTurn { get; private set; }

        private List<IAction> opponentActions = new()
        {
            new Attack(),
            new Specialattack(),
            new Protect(),
            new Berry()
        };

        public Battle(Monster player, Monster opponent)
        {
            Player = player;
            Opponent = opponent;
            PlayerTurn = true;
        }

        public bool ActionTurn(IAction action)
        {
            if(isBattleWon())
            {
                return false;
            }

            //Kontroll vems tur
            Monster attacker = PlayerTurn ? Player : Opponent;
            Monster target = PlayerTurn ? Opponent : Player;

            bool success = action.DoAction(attacker, target);

            if (success && !isBattleWon())
            {
                ChangeTurn();
            }

            return success;


        }

        public void ChangeTurn()
        {
            PlayerTurn = !PlayerTurn;
        }

        public bool isBattleWon()
        {
            return !Player.IsAlive() || !Opponent.IsAlive();
        }
    }
}
