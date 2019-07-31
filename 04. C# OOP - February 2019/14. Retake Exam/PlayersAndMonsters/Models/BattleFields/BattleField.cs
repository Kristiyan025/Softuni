namespace PlayersAndMonsters.Models.BattleFields
{
    using System;
    using Contracts;
    using Models.Players.Contracts;
    using Players;

    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            if (attackPlayer is Beginner)
            {
                attackPlayer.Health += 40;
                foreach (var card in attackPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }

            if (enemyPlayer is Beginner)
            {
                enemyPlayer.Health += 40;
                foreach (var card in enemyPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }

            foreach (var card in attackPlayer.CardRepository.Cards)
            {
                attackPlayer.Health += card.HealthPoints;
            }

            foreach (var card in enemyPlayer.CardRepository.Cards)
            {
                enemyPlayer.Health += card.HealthPoints;
            }

            while (true)
            {
                int damage = 0;
                foreach (var card in attackPlayer.CardRepository.Cards)
                {
                    damage += card.DamagePoints;
                }

                enemyPlayer.TakeDamage(damage);
                if (!enemyPlayer.IsDead)
                {
                    damage = 0;
                    foreach (var card in enemyPlayer.CardRepository.Cards)
                    {
                        damage += card.DamagePoints;
                    }

                    attackPlayer.TakeDamage(damage);
                    if (attackPlayer.IsDead) break;
                }                
                else break;
            }

        }
    }
}
