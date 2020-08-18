using System;
using System.Collections.Generic;
using System.Text;

namespace VideoGamesCatalog
{
    public class GameService
    {
        public List<Game> Games { get; set; }
        public GameService()
        {
            Games = new List<Game>();
        }

        public ConsoleKeyInfo AddNewGameView(MenuActionService actionService)
        {
            var addNewGameMenu = actionService.GetMenuActionsByMenuName("AddNewGameMenu");
            Console.WriteLine("\nPlease select game type: ");
            for (int i = 0; i < addNewGameMenu.Count; i++)
            {
                Console.WriteLine($"{addNewGameMenu[i].Id}. {addNewGameMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            return operation;
        }

        public int AddNewGame(char gameType)
        {
            int gameTypeId;
            Int32.TryParse(gameType.ToString(), out gameTypeId);
            Game game = new Game();
            game.TypeId = gameTypeId;
            Console.WriteLine("\nPlease enter id for new game: ");
            var id = Console.ReadLine();
            int gameId;
            Int32.TryParse(id, out gameId);
            Console.WriteLine("\nPlease enter name for new item: ");
            var name = Console.ReadLine();

            game.Id = gameId;
            game.Name = name;

            Games.Add(game);
            return gameId;
        }

        public int RemoveGameView()
        {
            Console.WriteLine("\nPlease enter id for game you want to remove: ");
            var gameId = Console.ReadKey();
            int id;
            Int32.TryParse(gameId.KeyChar.ToString(), out id);

            return id;
        }

        public int GameTypeSelectionView()
        {
            Console.WriteLine("\nPlease enter type id for game type you want to show: ");
            var gameId = Console.ReadKey();
            int id;
            Int32.TryParse(gameId.KeyChar.ToString(), out id);

            return id;
        }

        public void GamesByTypeIdView(int typeId)
        {
            List<Game> toShow = new List<Game>();
            foreach (var game in Games)
            {
                if (game.TypeId == typeId)
                {
                    toShow.Add(game);
                }
            }
            Console.WriteLine(toShow.ToStringTable(new[] { "Id", "Name" }, a => a.Id, a => a.Name));
        }

        public void RemoveGame(int removeId)
        {
            Game gameToRemove = new Game();
            foreach (var game in Games)
            {
                if (game.Id == removeId)
                {
                    gameToRemove = game;
                    break;
                }
            }
            Games.Remove(gameToRemove);
        }

        public void GameDetailView(int detailId)
        {
            Game gameToShow = new Game();
            foreach (var game in Games)
            {
                if (game.Id == detailId)
                {
                    gameToShow = game;
                    break;
                }
            }

            Console.WriteLine($"\nGame id: {gameToShow.Id}");
            Console.WriteLine($"\nGame name: {gameToShow.Name}");
            Console.WriteLine($"\nGame type id: {gameToShow.TypeId}");
        }
        public int GameDetailSelectionView()
        {
            Console.WriteLine("\nPlease enter id for game you want to show: ");
            var gameId = Console.ReadKey();
            int id;
            Int32.TryParse(gameId.KeyChar.ToString(), out id);

            return id;
        }


    }
}
