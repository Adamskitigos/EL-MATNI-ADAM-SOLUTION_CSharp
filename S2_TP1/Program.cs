using System;
using gestion_employe;

public class Program
{
    public static void Main(string[] args)
    {
        Employee employee1 = new Employee("El Matni Adam",40000,"Software Architect");
        Employee employee2 = new Employee("El Harrak Mehdi", 30000, "Fullstack");
        Employee employee3 = new Employee("Kontar Riham", 50000, "Software Architect");

        Directeur directeur = Directeur.getDirecteur();
        directeur.ajouterEmployee(employee1);
        directeur.ajouterEmployee(employee2);
        directeur.ajouterEmployee(employee3);

        Console.WriteLine(directeur.calculeSalaireTotal());
        directeur.Afficher();


    }
}