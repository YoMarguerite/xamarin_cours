using Pizzeria.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Pizzeria.DAL
{
    public class Datas
    {
        #region Singleton

        private static Datas _instance { get; set; }
        public static Datas GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Datas();
            }
            return _instance;
        }

        #endregion

        private List<Pizza> _cartePizzas { get; set; }

        private Datas()
        {
            _cartePizzas = new List<Pizza>
            {
                new Pizza
                {
                    Nom = "Margarita",
                    Prix = 12.90m,
                    IsVegetarian = true,
                    Ingredients = "Tomates, Mozzarella, Basilic frais, Huile d'olive"
                },
                new Pizza
                {
                    Nom = "Calzone",
                    Prix = 12.5m,
                    IsVegetarian = true,
                    Ingredients = "Tomates, Mozzarella, Champignons, Huile d'olive"
                },
                new Pizza
                {
                    Nom = "Périgourdine",
                    Prix = 13.0m,
                    IsVegetarian = false,
                    Ingredients = "Tomates, Mozzarella, Magret de canard, pignons de pin, Huile d'olive"
                }
            };
        }

        public List<Pizza> GetCartePizzas()
        {
            return _cartePizzas;
        }
    }
}
