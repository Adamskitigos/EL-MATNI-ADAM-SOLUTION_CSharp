using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Programmeur
    {
        private int id;
        private string nom;
        private string prenom;
        private int bureau;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nom 
        {  
            get { return nom; } 
            set { nom = value; } 
        }
        public string Prenom 
        { 
            get {return prenom; } 
            set { prenom = value; }
        }
        public int Bureau 
        {  
            get { return bureau; } 
            set { bureau = value; } 
        }

        public Programmeur(int  id=0, string nom="", string prenom="",int bureau = 0)
        {
            Id= id;
            Nom = nom;
            Prenom = prenom;
            Bureau = bureau;
        }
    }
}
