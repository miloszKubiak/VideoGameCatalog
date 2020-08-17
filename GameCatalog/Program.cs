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

            Console.WriteLine("Welcome to Video Games Catalog App!");
            Console.WriteLine("Please let me know what you want to do: ");
            var mainMenu = actionService.GetMenuActionsByMenuName("Main");
            for (int i = 0; i < mainMenu.Count; i++)
            {
                Console.WriteLine($"{mainMenu[i].Id}. {mainMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            switch (operation.KeyChar)
            {
                case '1':
                    break;
                case '2':
                    break;
                case '3':
                    break;
                case '4':
                    break;
                default:
                    Console.WriteLine("Action you entered does not exist.");
                    break;
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
