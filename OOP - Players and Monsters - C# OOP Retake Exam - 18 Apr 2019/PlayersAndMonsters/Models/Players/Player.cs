
namespace PlayersAndMonsters.Models.Players
{
    using System;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;

    public abstract class Player : IPlayer
    {
        private string userName;
        private int health;

        protected Player(ICardRepository cardRepository, string username, int health) : base()
        {
            this.Username = userName;
            this.Health = health;
            this.CardRepository = cardRepository;
        }
        public ICardRepository CardRepository { get; }

        public string Username 
        { 
            get 
            {
                return this.userName;
            } 
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Player's username cannot be null or an empty string.");
                }
                else
                {
                    this.userName = value;
                }
            }
        }

        public int Health 
        { 
            get 
            {
                return this.health;
            } 
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Player's health bonus cannot be less than zero.");
                }

                this.health -= value;
            } 
        }

        public bool IsDead 
        { 
            get 
            {
                if (this.health <= 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } 
        }

        public void TakeDamage(int damagePoints)
        {
            if (damagePoints < 0)
            {
                throw new ArgumentException("Damage points cannot be less than zero.");
            }
            else if (damagePoints >= this.health)
            {
                this.Health = 0;
            }
            else
            {
                this.Health -= damagePoints;
            }
        }
    }
}
