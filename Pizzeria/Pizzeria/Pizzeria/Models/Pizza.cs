using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzeria.Models
{
    public class Pizza
    {
        public string Nom { get; set; }

        public decimal Prix { get; set; }

        public bool IsVegetarian { get; set; }

        public string Ingredients { get; set; }
    }
}
