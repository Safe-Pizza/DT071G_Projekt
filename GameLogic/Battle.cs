/**
 * Filnamn: Battle.cs
 * Författare: Hanna Lindkvist
 * Datum: 2026-10-23
 * Kurs: DT071G
 * 
 * Beskrivning: Game hanterar skapandet av spelets monster och lagrar spelar och motståndarmonster (sparar spelarens monster val och slumpar motståndare)
 * Startar nytt objekt för strid med respektive monster av klassen Battle.
 * 
 * **/

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

        //Metod för en spelar tur
        public bool ActionTurn(IAction action)
        {
            if (IsBattleWon())
            {
                return false;
            }

            //Kontroll vems tur
            Monster attacker = PlayerTurn ? Player : Opponent;
            Monster target = PlayerTurn ? Opponent : Player;

            //Genomföra en action
            bool success = action.DoAction(attacker, target);

            if (success && !IsBattleWon())
            {
                //Byt tur mellan spelare, motståndare
                ChangeTurn();
            }

            return success;
        }

        //Metod för motståndare automatik, returnerar vilken action som utförts
        public IAction? OpponentActionAutomatic()

        {
            if (IsBattleWon() || PlayerTurn)
            {
                return null;
            }

            //Filtrering för att ta bort handlingar som motståndare inte kan använda
            List<IAction> availableActions = opponentActions
            .Where(action =>
            !(action is Specialattack && Opponent.UsedSpecialAttack) &&
            !(action is Protect && Opponent.HaveProtection))
            .ToList();

            //Hämta random action från filtrerad lista
            IAction action = RandomAction(availableActions);

            //Utför en speltur
            bool success = ActionTurn(action);

            return success ? action : null;
        }

        //Metod för att slumpa motståndarval utifrån lista
        private IAction RandomAction(List<IAction> opponentActions)
        {
            if (opponentActions.Count == 0)
                throw new InvalidOperationException("Inga actions finns.");

            int index = Random.Shared.Next(opponentActions.Count);

            return opponentActions[index];
        }

        //Metid för att byta speltur
        public void ChangeTurn()
        {
            PlayerTurn = !PlayerTurn;
        }

        //Metod för kontroll om någon spelare vunnit (om HP är noll)
        public bool IsBattleWon()
        {
            return !Player.IsAlive() || !Opponent.IsAlive();
        }
    }
}
