using GamesCatalog.App.Abstract;
using GamesCatalog.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GamesCatalog.App.Common
{
    public class BaseService<T> : IService<T> where T: BaseEntity
    {
        public List<T> Games { get; set; }
        public BaseService()
        {
            Games = new List<T>();
        }

        public int GetLastId()
        {
            int lastId;
            if (Games.Any())
            {
                lastId = Games.OrderBy(p => p.Id).LastOrDefault().Id;
            }
            else
            {
                lastId = 0;
            }
            return lastId;
        }

        public int AddGame(T game)
        {
            Games.Add(game);
            return game.Id;
        }

        public List<T> GetAllGames()
        {
            return Games;
        }

        public void RemoveGame(T game)
        {
            Games.Remove(game);
        }

        public int UpdateGame(T game)
        {
            var entity = Games.FirstOrDefault(p => p.Id == game.Id);
            if (entity != null)
            {
                entity = game;
            }
            return entity.Id;
        }
    }
}
