namespace PlayersAndMonsters.Models.Players
{
    using System;
    using Contracts;
    using Repositories.Contracts;

    public abstract class Player : IPlayer
    {
        private string username;
        private int health;

        public Player(ICardRepository cardRepository, string username, int health)
        {
            this.Username = username;
            this.CardRepository = cardRepository;
            this.Health = health;
        }

        public string Username
        {
            get => this.username;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Player's username cannot be null or an empty string. ");
                }

                this.username = value;
            }
        }

        public int Health
        {
            get => this.health;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player's health bonus cannot be less than zero. ");
                }

                this.health = value;
            }
        }

        public ICardRepository CardRepository { get; }

        public bool IsDead { get => this.Health == 0; }

        public void TakeDamage(int damagePoints)
        {
            if (damagePoints < 0)
            {
                throw new ArgumentException("Damage points cannot be less than zero.");
            }

            if (this.Health <= damagePoints)
            {
                this.Health = 0;
            }
            else this.Health -= damagePoints;
        }
    }
}
