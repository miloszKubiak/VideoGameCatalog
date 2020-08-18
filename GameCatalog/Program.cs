using System;
using System.ComponentModel.Design;
using VideoGamesCatalog;

namespace GameCatalog
{
    class Program
    {
        public const string FILE_NAME = @"C:\VideoGameCatalogFiles\ImportFile.xlsx";
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            actionService = Initialize(actionService);
            GameService gameService = new GameService();

            Console.WriteLine("Welcome to Video Games Catalog App!");
            while (true)
            {
                Console.WriteLine("\nPlease let me know what you want to do: ");
                var mainMenu = actionService.GetMenuActionsByMenuName("Main");
                for (int i = 0; i < mainMenu.Count; i++)
                {
                    Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
                }

                var operation = Console.ReadKey();
                
                switch (operation.KeyChar)
                {
                    case '1':
                        var keyInfo = gameService.AddNewGameView(actionService);
                        var id = gameService.AddNewGame(keyInfo.KeyChar);
                        break;
                    case '2':
                        var removeId = gameService.RemoveGameView();
                        gameService.RemoveGame(removeId); 
                        break;
                    case '3':
                        var detailId = gameService.GameDetailSelectionView();
                        gameService.GameDetailView(detailId);
                        break;
                    case '4':
                        var typeId = gameService.GameTypeSelectionView();
                        gameService.GamesByTypeIdView(typeId);
                        break;
                    default:
                        Console.WriteLine("\nAction you entered does not exist.");
                        break;
                }
            }
            
        }

        private static MenuActionService Initialize(MenuActionService actionService)
        {
            actionService.AddNewAction(1, "Add game", "Main");
            actionService.AddNewAction(2, "Remove game", "Main");
            actionService.AddNewAction(3, "Show details", "Main");
            actionService.AddNewAction(4, "List of games", "Main");

            actionService.AddNewAction(1, "Action", "AddNewGameMenu");
            actionService.AddNewAction(2, "Adventure", "AddNewGameMenu");
            actionService.AddNewAction(3, "FirstPersonShooter", "AddNewGameMenu");
            actionService.AddNewAction(4, "RolePlaying", "AddNewGameMenu");
            actionService.AddNewAction(5, "Simulation", "AddNewGameMenu");
            actionService.AddNewAction(6, "Strategy", "AddNewGameMenu");
            actionService.AddNewAction(7, "Sports", "AddNewGameMenu");
            return actionService;
        }
    }
}
