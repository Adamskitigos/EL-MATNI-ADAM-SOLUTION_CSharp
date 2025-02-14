using System;
using TP1;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Repertoire Rep1 = new Repertoire("c# project");
        Fichier Fichier1 = new Fichier("file1","pdf",20000);
        Fichier Fichier2 = new Fichier("file2", "png",30005);
        Fichier Fichier3 = new Fichier("file3", "pdf",20001);
        Fichier Fichier4 = new Fichier("file4", "pdf",900255);
        Rep1.Ajouter(Fichier1);
        Rep1.Ajouter(Fichier2);
        Rep1.Ajouter(Fichier3);
        Rep1.Ajouter(Fichier4);
        int indice = Rep1.Rechercher(Fichier4.Nom);
        Console.WriteLine(indice);
        List<Fichier> listFichier=Rep1.Rechercher();
        for(int i = 0; i < listFichier.Count; i++)
        {
            Console.WriteLine(listFichier[i].Nom);
        }

        Rep1.Renommer("file1", "file1(Copie)");
        Rep1.Modifier("file2", 21000);
        Rep1.Afficher();
        Console.WriteLine(Rep1.getTaille());
    }
}