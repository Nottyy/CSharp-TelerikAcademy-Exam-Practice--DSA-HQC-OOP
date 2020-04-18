namespace PlayersAndMonsters.Repositories
{
    using System.Linq;
    using PlayersAndMonsters.Models.Players.Contracts;
    using PlayersAndMonsters.Repositories.Contracts;
    using System.Collections.Generic;
    using System;
    using System.Collections;

    public class PlayerRepository : IPlayerRepository
    {
        private List<IPlayer> players;

        public PlayerRepository()
        {
            this.players = new List<IPlayer>();
        }
        public int Count { 
            get
            {
                return this.Players.Count();
            } 
        }

        public IReadOnlyCollection<IPlayer> Players 
        { 
            get
            {
                return this.players.AsReadOnly();
            }
        }

        public void Add(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException("Player cannot be null.");
            }

            bool ifPlayerExcists = this.players.Any(x => x.Username == player.Username);
            if (ifPlayerExcists)
            {
                throw new ArgumentException(string.Format("Player {0} already exists!", player.Username));
            }

            this.players.Add(player);
        }

        public IPlayer Find(string username)
        {
            return this.players.FirstOrDefault(x => x.Username == username);
        }

        public bool Remove(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException("Player cannot be null.");
            }

            bool isRemove = this.players.Remove(player);

            return isRemove;
        }
    }
}
