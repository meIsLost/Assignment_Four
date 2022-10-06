using MyOwnFC;
using System.Runtime.CompilerServices;
using System;
using System.Xml.Linq;

namespace WebAppC.Manager
{
    public class FootballPlayersManager
    {
        private static int _nextID = 1;

        private static readonly List<FootballPlayer> _players = new List<FootballPlayer>
        {
            new FootballPlayer(_nextID++, "Rebecca", 17, 29),
            new FootballPlayer(_nextID++, "David", 19, 10),
            new FootballPlayer(_nextID++, "Lucy", 16, 97),
             new FootballPlayer(_nextID++, "Kiwi", 21, 23)
        };



        public List<FootballPlayer> GetAll()
        {
            List<FootballPlayer> result= new List<FootballPlayer>(_players);
            return result;
           
        }

        public FootballPlayer? GetById(int Id)
        {
            return _players.Find(player => player.Id == Id);
        }

        public FootballPlayer Add(FootballPlayer newPlayer)
        {
            newPlayer.Validate();
            newPlayer.Id = _nextID++;
            _players.Add(newPlayer);
            return newPlayer;
        }

        public FootballPlayer? Delete(int Id)
        {
            FootballPlayer? foundPlayer = GetById(Id);
            if (foundPlayer == null) return null;
            _players.Remove(foundPlayer);
            return foundPlayer;
        }

        public FootballPlayer? Update(int id, FootballPlayer updates)
        {
            updates.Validate();
            FootballPlayer? player= GetById(id);
            if (player == null) return null;
            player.Name = updates.Name;
            player.Age = updates.Age;
            player.ShirtNumber= updates.ShirtNumber;
            return player;
        }







    }
}
