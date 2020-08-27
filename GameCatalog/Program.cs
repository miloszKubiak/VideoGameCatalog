using System;
using System.ComponentModel.Design;
using GamesCatalog;
using GamesCatalog.App.Abstract;
using GamesCatalog.App.Concrete;
using GamesCatalog.App.Managers;
using GamesCatalog.Domain.Entity;

namespace GameCatalog
{
    public class Program
    {
        public const string FILE_NAME = @"C:\VideoGameCatalogFiles\ImportFile.xlsx";
        static void Main(string[] args)
        {
            MenuActionService actionService = new MenuActionService();
            GameManager gameManager = new GameManager(actionService);

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
                        var newId = gameManager.AddNewGame();
                        break;
                    case '2':
                        var removeId = gameManager.
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
        
    }
}
