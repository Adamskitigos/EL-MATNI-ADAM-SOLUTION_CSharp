using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_employe
{
    internal class GestionEmployes
    {
        private List<Employee> employeesList;

        public GestionEmployes() 
        {
            employeesList = new List<Employee>();
        }

        public bool AjouterEmployee(Employee employee)
        {
            if (!this.employeesList.Contains(employee))
            {
                this.employeesList.Add(employee);
                return true;
            }return false;
        }

        public bool SupprimerEmployee(Employee employee) 
        {
            if (this.employeesList.Contains(employee))
            {
                this.employeesList.Remove(employee);
                return true;
            }return false;
        }

        public double calculeSalaireTotal()
        {
            double salaireTotal = 0;
            for (int i = 0; i < employeesList.Count(); i++)
            {
                salaireTotal += employeesList[i].Salaire;
            }
            return salaireTotal;
        }

        public double salaireMoyen()
        {
            if (this.employeesList.Count() == 0)
            {
                Console.WriteLine("La liste des employes est vide");
                return 0;
            }
            return this.calculeSalaireTotal() / this.employeesList.Count();
        }

        public void Afficher()
        {
            for (int i = 0; i < this.employeesList.Count(); i++)
            {
                Console.WriteLine(employeesList[i].Nom);
            }
        }
    }
}
