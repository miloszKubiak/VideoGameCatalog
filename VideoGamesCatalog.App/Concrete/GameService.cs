using GamesCatalog.App.Common;
using GamesCatalog.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;


namespace GamesCatalog.App.Concrete
{
    public class GameService : BaseService<Game>
    {

        //public int GameTypeSelectionView()
        //{
        //    Console.WriteLine("\nPlease enter type id for game type you want to show: ");
        //    var gameId = Console.ReadKey();
        //    int id;
        //    Int32.TryParse(gameId.KeyChar.ToString(), out id);

        //    return id;
        //}

        //public void GamesByTypeIdView(int typeId)
        //{
        //    List<Game> toShow = new List<Game>();
        //    foreach (var game in Games)
        //    {
        //        if (game.TypeId == typeId)
        //        {
        //            toShow.Add(game);
        //        }
        //    }
        //    Console.WriteLine(toShow.ToStringTable(new[] { "Id", "Name" }, a => a.Id, a => a.Name));
        //}



        //public void GameDetailView(int detailId)
        //{
        //    Game gameToShow = new Game();
        //    foreach (var game in Games)
        //    {
        //        if (game.Id == detailId)
        //        {
        //            gameToShow = game;
        //            break;
        //        }
        //    }

        //    Console.WriteLine($"\nGame id: {gameToShow.Id}");
        //    Console.WriteLine($"\nGame name: {gameToShow.Name}");
        //    Console.WriteLine($"\nGame type id: {gameToShow.TypeId}");
        //}
        //public int GameDetailSelectionView()
        //{
        //    Console.WriteLine("\nPlease enter id for game you want to show: ");
        //    var gameId = Console.ReadKey();
        //    int id;
        //    Int32.TryParse(gameId.KeyChar.ToString(), out id);

        //    return id;
        //}


    }
}
