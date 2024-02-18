using System;
using System.Collections.Generic;
using System.Text;

namespace App1.Singleton
{
    public static class Data
    {
        private static ConfigurationData _instance;
        

        public static ConfigurationData GetInstance()
        {
            if(_instance == null)
            {
                _instance = new ConfigurationData
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
