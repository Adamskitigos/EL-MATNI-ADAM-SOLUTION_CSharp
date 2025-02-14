using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_employe
{
    internal class Employee
    {
        private string nom;
        private double salaire;
        private string poste;
        private DateOnly date_embauche;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }
        public string Poste
        {
            get { return poste; }
            set { poste = value; }
        }
        public DateOnly Date_embauche
        {
            get { return date_embauche; }
            set {date_embauche = value;}
        }

        public Employee(string nom= "",double salaire= 0,string poste= "")
        {
            this.nom = nom;
            this.salaire = salaire; 
            this.poste = poste;
            this.date_embauche= DateOnly.FromDateTime(DateTime.Now);
        }


    }
}
