using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    // Employee class
    public class Employee
    {
        // Declare class variables
        public string Id;
        public string Name;
        public string Gender;
        public string Salary;

        // Assigns input to class' variables
        public Employee(string id, string name, string gender, string salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        // Overrides ToString method to provide custom string representation 
        public override string ToString()
        {
            return $"Id: {Id} | Name: {Name} | Gender: {Gender} | Salary: {Salary} |";
        }
    }
}
