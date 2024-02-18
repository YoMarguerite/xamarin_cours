using Eval.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eval.Data
{
    public static class Data
    {
        //compteur des choix
        private static Compteur compteur;

        private static List<Collaborateur> collabs;

        //récupérer la liste des collaborateurs
        public static List<Collaborateur> GetCollaborateurs()
        {
            if(collabs == null)
            {
                collabs = new List<Collaborateur>()
                {
                    new Collaborateur(){Nom="Harden", Prenom="James", Service="Informatique", Choix="Galaxy S10"},
                    new Collaborateur(){Nom="Wayne", Prenom="Bruce", Service="Technique", Choix="Galaxy S10"},
                    new Collaborateur(){Nom="Trump", Prenom="Donald", Service="Comptabilité", Choix="Iphone XS"},
                };
                GetCompteur();
                
            }
            return collabs;
        }

        //récupérer le compteur des choix
        public static Compteur GetCompteur()
        {
            if (compteur == null)
            {
                compteur = new Compteur() { NbGalaxy = 2, NbIphone = 1 };
            }
            return compteur;
        }

        private static void RefreshCompteur(string Choix)
        {
            if (Choix == "Galaxy S10")
            {
                GetCompteur().NbGalaxy++;
            }
            else
            if (Choix == "Iphone XS")
            {
                GetCompteur().NbIphone++;
            }
        }

        //méthode d'ajout d'un collaborateur
        public static void AjoutCollabs(string Nom, string Prenom, string Choix, string Service)
        {
            GetCollaborateurs().Add(new Collaborateur(){Nom=Nom, Prenom=Prenom, Choix=Choix, Service=Service });
            RefreshCompteur(Choix);
        }
    }
}
