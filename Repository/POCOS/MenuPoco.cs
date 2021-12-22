using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MenuPoco
    {
        public int combo { get; set; }
        public string mealName { get; set; }
        public string description { get; set; }
        public List<string> ingredients { get; set; }
        public double price { get; set; }
        public MenuPoco(int num, string nombre, string explain, List<string> recipie, double cost)
        {
            combo = num;
            mealName = nombre;
            description = explain;
            ingredients = recipie;
            price = cost;
        }
    }
}
