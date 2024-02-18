using System;
using System.Collections.Generic;
using System.Text;

namespace AppPizza.Model
{
    public class Pizza
    {
        public string Nom;
        public bool Vegetarian;
        public string Ingredients;
        public double Prix;

        public Pizza(string _nom, bool _veg, string _ing, double _prix)
        {
            this.Nom = _nom;
            this.Vegetarian = _veg;
            this.Ingredients = _ing;
            this.Prix = _prix;
        }
        
    }
}
