using System;
using System.Collections.Generic;
using System.Text;

namespace GamesCatalog.App.Abstract
{
    public interface IService<T>
    {
        List<T> Games { get; set; }
        List<T> GetAllGames();
        int AddGame(T game);
        int UpdateGame(T game);
        void RemoveGame(T game);
    }
}
