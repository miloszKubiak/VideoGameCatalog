using System;
using System.Collections.Generic;
using System.Text;
using GamesCatalog;
using GamesCatalog.App.Common;
using GamesCatalog.Domain.Entity;

namespace GamesCatalog.App.Concrete
{
    public class MenuActionService : BaseService<MenuAction>
    {
        public MenuActionService()
        {
            Initialize();
        }

        public List<MenuAction> GetMenuActionsByMenuName(string menuName)
        {
            List<MenuAction> result = new List<MenuAction>();
            foreach (var menuAction in Games)
            {
                if (menuAction.MenuName==menuName)
                {
                    result.Add(menuAction);
                }
            }
            return result;
        }

        private void Initialize()
        {
            AddGame(new MenuAction(1, "Add game", "Main"));
            AddGame(new MenuAction(2, "Remove game", "Main"));
            AddGame(new MenuAction(3, "Show details", "Main"))  ;
            AddGame(new MenuAction(4, "List of games", "Main"));

            AddGame(new MenuAction(1, "Action", "AddNewGameMenu"));
            AddGame(new MenuAction(2, "Adventure", "AddNewGameMenu"));
            AddGame(new MenuAction(3, "FirstPersonShooter", "AddNewGameMenu"));
            AddGame(new MenuAction(4, "RolePlaying", "AddNewGameMenu"));
            AddGame(new MenuAction(5, "Simulation", "AddNewGameMenu"));
            AddGame(new MenuAction(6, "Strategy", "AddNewGameMenu"));
            AddGame(new MenuAction(7, "Sports", "AddNewGameMenu"));
        }
    }
}
