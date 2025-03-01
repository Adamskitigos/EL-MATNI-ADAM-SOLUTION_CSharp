using TP3_GesrtionRH;
using TP3_GestionRH;

class Program
{
    static void Main()
    {
        Console.WriteLine("========== DEMARAGE DU SYSTEME DE GESTION RH ==========\n");

        RessourcesHumaines rh = new RessourcesHumaines();

        Etudiant et1 = new Etudiant("E001", "Ali", "Mohamed", "1ere annee", 12.5);
        Etudiant et2 = new Etudiant("E002", "Sara", "Amrani", "1ere annee", 14.0);
        Etudiant et3 = new Etudiant("E003", "Yassine", "Bennani", "2eme annee", 15.5);

        Console.WriteLine("Etudiants cree avec succes !\n");

        Groupe groupe1 = new Groupe("Groupe A");
        groupe1.Ajouter_etudiant(et1);
        groupe1.Ajouter_etudiant(et2);

        Groupe groupe2 = new Groupe("Groupe B");
        groupe2.Ajouter_etudiant(et3);

        Console.WriteLine("Groupes et etudiants ajoutes avec succes !\n");

        Enseignant enseignant1 = new Enseignant("ENS001", "Prof", "Ahmed", "Bureau 12", 15000, 1000);
        enseignant1.Grade = Grade.PA;

        groupe1.Ajouter_groupe(enseignant1);
        groupe2.Ajouter_groupe(enseignant1);

        Console.WriteLine("Enseignant cree et affecte aux groupes !\n");

        enseignant1.Afficher_ens();

        Directeur directeur1 = Directeur.getinstance("DIR001", "Karim", "El Amrani", "Bureau 101", 30000, 5000);

        Directeur directeur2 = Directeur.getinstance("DIR002", "Omar", "Ben Salah", "Bureau 102", 32000, 6000);

        Administratif admin1 = new Administratif("ADM001", "Leila", "Hamdi", "Bureau 22", 12000, 500);
        Console.WriteLine("Adminstratif ajoute !\n");

        rh.AjouterPersonne(enseignant1);
        rh.AjouterPersonne(directeur1);
        rh.AjouterPersonne(admin1);

        Console.WriteLine("\nLIST DES ENSEIGNATS ==========");
        rh.Afficher_Enseignants();

        Console.WriteLine("\n========== FIN DU PROGRAM ==========");
    }
}
