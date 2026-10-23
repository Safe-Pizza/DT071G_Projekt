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
            if (IsBattleWon())
            {
                return false;
            }

            //Kontroll vems tur
            Monster attacker = PlayerTurn ? Player : Opponent;
            Monster target = PlayerTurn ? Opponent : Player;

            bool success = action.DoAction(attacker, target);

            if (success && !IsBattleWon())
            {
                ChangeTurn();
            }

            return success;
        }

        public IAction? OpponentActionAutomatic()

        {
            if (IsBattleWon() || PlayerTurn)
            {
                return null;
            }

            List<IAction> availableActions = opponentActions
            .Where(action =>
            !(action is Specialattack && Opponent.UsedSpecialAttack) &&
            !(action is Protect && Opponent.HaveProtection))
            .ToList();

            IAction action = RandomAction(availableActions);

            bool success = ActionTurn(action);

            return success ? action : null;
        }

        private IAction RandomAction(List<IAction> opponentActions)
        {
            if (opponentActions.Count == 0)
                throw new InvalidOperationException("Inga actions finns.");

            int index = Random.Shared.Next(opponentActions.Count);

            return opponentActions[index];
        }

        public void ChangeTurn()
        {
            PlayerTurn = !PlayerTurn;
        }

        public bool IsBattleWon()
        {
            return !Player.IsAlive() || !Opponent.IsAlive();
        }
    }
}
