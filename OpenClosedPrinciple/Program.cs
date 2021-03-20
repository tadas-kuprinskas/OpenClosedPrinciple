using OCPLibrary;
using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
            new PersonModel {FirstName = "John", LastName = "Johnson" },
            new ManagerModel {FirstName = "Sue", LastName = "Samson" },
            new ExecutiveModel {FirstName = "Willy", LastName = "Wilson" },
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress}, Is Manager: {emp.IsManager}, Is Executive: {emp.IsExecutive} ");
            }
        }
    }
}
