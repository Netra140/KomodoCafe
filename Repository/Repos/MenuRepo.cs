using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MenuRepo
    {
        public List<MenuPoco> _Menus = new List<MenuPoco>();
        public List<MenuPoco> GetList()
        {
            return _Menus;
        }
        public void AddMenu(MenuPoco Menu)
        {
            _Menus.Add(Menu);
        }
        public void Remove(int id)
        {
            _Menus.RemoveAt(id);
        }
    }
}
