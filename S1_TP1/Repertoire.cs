using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    internal class Repertoire
    {
        private string nom;
        private int nbr_fichier;
        Fichier[] fichiers;

        public string Nom {  
            get { return nom; }
            set { nom = value; } 
        }

        public int Nbr_fichier
        {
            get { return nbr_fichier; }
            set { nbr_fichier = value; }
        }
        public Fichier[] Fichiers
        {
            get { return fichiers; }
        }

        public Repertoire(string nom="",int nbr_fichier=0)
        {
            this.nom = nom;
            this.nbr_fichier = nbr_fichier;
            this.fichiers = new Fichier[30];
        }

        public void Afficher()
        {
            if (nbr_fichier > 0)
            {
                Console.WriteLine($"Le nom des fichier est:");
                for (int i = 0; i < nbr_fichier; i++)
                {
                    Console.WriteLine(fichiers[i].Nom);
                }
            }
        }

        public int Rechercher(string nom)
        {
            for (int i = 0;i < fichiers.Length; i++)
            {
                if (fichiers[i].Nom.ToLower().Equals(nom.ToLower()))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Ajouter(Fichier fichier)
        {
            for(int i = 0; i<this.fichiers.Length; i++)
            {
                if (fichiers[i] == null)
                {
                    fichiers[i] = fichier;
                    this.nbr_fichier++;
                    return true;
                }
            }
            Console.WriteLine("Le repertoire est plein");
            return false;
        }

        public List<Fichier> Rechercher()
        {
            List<Fichier> listFichier=new List<Fichier>();
            for(int i=0; i < nbr_fichier; i++)
            {
                if (fichiers[i].Extension.ToLower() == "pdf")
                {
                    listFichier.Add(fichiers[i]);
                }
            }
            return listFichier;
        }

        public bool Renommer(string oldNom,string newNom)
        {
            int indice = Rechercher(oldNom);
            if (indice != -1)
            {
                fichiers[indice].Nom = newNom;
                return true;
            }
            return false;
        }

        public bool Modifier(string nom,float newTaille)
        {
            int indice = Rechercher(nom);
            if (indice != -1)
            {
                fichiers[indice].Taille = newTaille;
                return true;
            }
            return false;
        }

        public float getTaille()
        {
            float taille = 0;
            for(int i = 0; i < nbr_fichier; i++)
            {
                taille += fichiers[i].Taille;
            }
            return taille*1000;
        }
    }
}
