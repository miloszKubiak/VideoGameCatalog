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
            Console.WriteLine("Please select game type: ");
            for (int i = 0; i < addNewGameMenu.Count; i++)
            {
                Console.WriteLine($"{addNewGameMenu[i].Id}. {addNewGameMenu[i].Name}");
            }
            var operation = Console.ReadKey();
            return operation;
        }
    }
}
