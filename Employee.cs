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
        // Declare class properties
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Gender { get; private set; }
        public string Salary { get; private set; }

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
