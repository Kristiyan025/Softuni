namespace PlayersAndMonsters.Repositories
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Models.Players.Contracts;
    using Contracts;

    public class PlayerRepository : IPlayerRepository
    {
        private List<IPlayer> players;

        public PlayerRepository()
        {
            this.players = new List<IPlayer>();
        }

        public int Count { get => this.Players.Count; }

        public IReadOnlyCollection<IPlayer> Players { get => players; }

        public void Add(IPlayer player)
        {
            if (player is null)
            {
                throw new ArgumentException("Player cannot be null");
            }

            if (this.Players.Where(x => x.Username == player.Username).Count() != 0)
            {
                throw new ArgumentException($"Player {player.Username} already exists!");
            }

            this.players.Add(player);
        }

        public bool Remove(IPlayer player)
        {
            if (player is null)
            {
                throw new ArgumentException("Player cannot be null");
            }

            if (this.Players.Where(x => x.Username == player.Username).Count() == 0)
            {
                return false;
            }

            this.players.Remove(player);
            return true;
        }

        public IPlayer Find(string username)
        {
            var player = this.Players.FirstOrDefault(x => x.Username == username);
            if (player is null)
            {
                throw new ArgumentException("Player doesn't exist");
            }

            return player;
        }
    }
}
