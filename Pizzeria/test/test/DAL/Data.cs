using System;
using System.Collections.Generic;
using System.Text;
using test.Model;

namespace test.DAL
{
    class Data
    {
        private List<Voiture> voitures;

        private static Data _instance;

        public static Data GetInstance()
        {
            if(_instance == null)
            {
                _instance = new Data();
            }
            return _instance;
        }

        private Data()
        {
            voitures = new List<Voiture>
            {
                new Voiture(){marque="Peugeot", modele="5008", puissance=130},
                new Voiture(){marque="Renault", modele="Clio", puissance=80},
                new Voiture(){marque="Citroën", modele="Cactus", puissance=110}
            };
        }

        public List<Voiture> Voitures()
        {
            return voitures;
        }
    }
}
