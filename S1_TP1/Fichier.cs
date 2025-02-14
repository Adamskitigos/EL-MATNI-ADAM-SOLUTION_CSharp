using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Fichier
    {
        private string nom;
        private string extension;
        private float taille;

        public string Nom{
            get { return nom; }
            set { nom = value; }
        }

        public string Extension { 
            get { return extension; } 
            set { extension = value; } 
        }

        public float Taille
        {
            get { return taille; }
            set { taille = value; }
        }

        public Fichier(string nom="",string extension="",float taille = 0) 
        {
            this.nom = nom;
            this.extension = extension;
            this.taille = taille;
        }
    }
}
