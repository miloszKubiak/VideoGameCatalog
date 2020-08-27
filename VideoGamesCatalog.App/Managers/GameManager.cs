using GamesCatalog.App.Concrete;
using GamesCatalog.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamesCatalog.App.Managers
{
    public class GameManager
    {
        private readonly MenuActionService _actionService;
        private GameService _gameService;
        public GameManager(MenuActionService actionService)
        {
            _gameService = new GameService();
            _actionService = actionService;
        }
        public int AddNewGame()
        {
            var addNewGameMenu = _actionService.GetMenuActionsByMenuName("AddNewGameMenu");
            Console.WriteLine("\nPlease select game type: ");
            for (int i = 0; i < addNewGameMenu.Count; i++)
            {
                Console.WriteLine($"{addNewGameMenu[i].Id}. {addNewGameMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            int typeId;
            Int32.TryParse(operation.KeyChar.ToString(), out typeId);
            Console.WriteLine("Please insert name for game:");
            var name = Console.ReadLine();
            var lastId = _gameService.GetLastId();
            Game game = new Game(lastId+1, name, typeId);
            _gameService.AddGame(game);
            return game.Id;

        }
    }
}
