using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_employe
{
    internal class Directeur
    {
        private static Directeur directeur=new Directeur();
        private GestionEmployes gestionEmployes;

        private Directeur() 
        {
            gestionEmployes = new GestionEmployes();
        }


        public static Directeur getDirecteur() 
        {
            return directeur;
        }

        public bool ajouterEmployee(Employee employee) 
        {
            return gestionEmployes.AjouterEmployee(employee);
        }

        public bool supprimerEmployee(Employee employee)
        {
            return gestionEmployes.SupprimerEmployee(employee);
        }

        public double calculeSalaireTotal()
        {
            return gestionEmployes.calculeSalaireTotal();
        }

        public double salaireMoyen()
        {
            return gestionEmployes.salaireMoyen();
        }

        public void Afficher()
        {
            gestionEmployes.Afficher();
        }
    }
}
