using AppConfiguration.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppConfiguration.Singleton
{
    public static class Datas
    {
        private static ConfigurationDatas _instance;
        
        public static ConfigurationDatas GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ConfigurationDatas
                {
                    CompteActif = true,
                    AutoriseLocation = false,
                    Email = string.Empty,
                    Telephone = string.Empty
                };
            }
            return _instance;
        }
    }
}
