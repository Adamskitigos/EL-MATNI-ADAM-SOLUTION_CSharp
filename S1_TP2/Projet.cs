using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Projet
    {
        private int code;
        private string sujet;
        private float duree;
        private int nbr_prog;

        public int Code 
        {  
            get { return code; } 
            set { code = value; } 
        }
        public string Sujet
        {
            get { return sujet; }
            set { sujet = value; }
        }
        public float Duree
        {
            get { return duree; }
            set { duree = value; }
        }
        public int Nbr_prog
        {
            get { return nbr_prog; }
            set { nbr_prog = value; }
        }

        public Projet(int code=1,string sujet="",float duree=0,int nbr_prog = 0)
        {
            this.code = code;
            this.sujet = sujet;
            this.duree = duree;
            this.nbr_prog = nbr_prog;
        }

        public override string ToString() 
        {
            return $"Projet [Code: {code}, Sujet: {sujet}, Durée: {duree} heures, Nombre de programmeurs: {nbr_prog}]";
        }

        public bool AjouterProgrammeur()

    }
}
