namespace PlayersAndMonsters.Core
{
    using System;
    using System.Linq;
    using System.Text;
    using Contracts;
    using Common;
    using Models.BattleFields;
    using Factories;
    using Factories.Contracts;
    using Repositories;

    public class ManagerController : IManagerController
    {
        private PlayerRepository players;
        private CardRepository cards;
        private BattleField battleField;
        private IPlayerFactory playerFactory;
        private ICardFactory cardFactory;

        public ManagerController()
        {
            this.players = new PlayerRepository();
            this.cards = new CardRepository();
            this.battleField = new BattleField();
            this.playerFactory = new PlayerFactory();
            this.cardFactory = new CardFactory();
        }

        public string AddPlayer(string type, string username)
        {
            var player = playerFactory.CreatePlayer(type, username);
            try
            {
                players.Add(player);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return ConstantMessages.SuccessfullyAddedPlayer
                .Replace("{0}", type)
                .Replace("{1}", username);
        }
            

        public string AddCard(string type, string name)
        {
            var card = cardFactory.CreateCard(type, name);
            try
            {
                cards.Add(card);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return ConstantMessages.SuccessfullyAddedCard
                .Replace("{0}", type)
                .Replace("{1}", name);
        }

        public string AddPlayerCard(string username, string cardName)
        {
            var player = this.players.Players.FirstOrDefault(x => x.Username == username);
            var card = this.cards.Cards.FirstOrDefault(x => x.Name == cardName);
            if (player is null)
            {
               return "Player cannot be null!";
            }

            if (card is null)
            {
                return "Card cannot be null!";
            }

            try
            {
                player.CardRepository.Add(card);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return e.Message;
            }
            return ConstantMessages.SuccessfullyAddedPlayerWithCards
                .Replace("{0}", cardName)
                .Replace("{1}", username);

        }

        public string Fight(string attackUser, string enemyUser)
        {
            var attacker = this.players.Players.FirstOrDefault(x => x.Username == attackUser);
            if (attacker is null)
            {
                return $"Player {attackUser} doesn't exist.";
            }

            var enemy = this.players.Players.FirstOrDefault(x => x.Username == enemyUser);
            if (enemy is null)
            {
                return $"Player {enemyUser} doesn't exist.";
            }

            try
            {
                battleField.Fight(attacker, enemy);
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return ConstantMessages.FightInfo
                .Replace("{0}", attacker.Health.ToString())
                .Replace("{1}", enemy.Health.ToString());
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < players.Count; i++)
            {
                sb.Append(ConstantMessages.PlayerReportInfo
                    .Replace("{0}", players.Players.ElementAt(i).Username)
                    .Replace("{1}", players.Players.ElementAt(i).Health.ToString())
                    .Replace("{2}", players.Players.ElementAt(i).CardRepository.Count.ToString()));
                sb.Append(Environment.NewLine);
                foreach (var card in players.Players.ElementAt(i).CardRepository.Cards)
                {
                    sb.Append(ConstantMessages.CardReportInfo
                        .Replace("{0}", card.Name)
                        .Replace("{1}", card.DamagePoints.ToString()));
                    sb.Append(Environment.NewLine);
                }

                sb.Append(ConstantMessages.DefaultReportSeparator);
                if(i != players.Count - 1)
                    sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }
    }
}
