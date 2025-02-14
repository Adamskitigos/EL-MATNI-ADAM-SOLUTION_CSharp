using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Consommation
    {
        private int no_semaine;
        private int id_pr;
        private int nb_tasses;

        public int No_semaine
        {
            get { return no_semaine; } 
            set { no_semaine = value; }
        } 
        public int Id_pr 
        { get { return id_pr; } 
            set { id_pr = value; }
        }
        public int Nb_tasses
        {
            get { return nb_tasses; }
            set { nb_tasses = value; }
        }

        public Consommation(int no_semaine,int id_pr,int nb_tasses)
        {
            No_semaine=no_semaine;
            Id_pr=id_pr;    
            Nb_tasses=nb_tasses;
        }

    }
}
