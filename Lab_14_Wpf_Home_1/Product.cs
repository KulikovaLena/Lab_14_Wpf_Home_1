using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_14_Wpf_Home_1
{
    public enum Сategories
    {
        Meal = 1,
        Appliances = 2,
        HouseholdСhemicals = 3
    }
    public class Product
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Picture { get; set; }
        public Сategories Сategory { get; set; }
        public override string ToString()
        {
            return ProductName;
        }
    }
}
