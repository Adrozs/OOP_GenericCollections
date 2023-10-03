// Adrian Rozsahegyi NET23

namespace GenericCollections
{
   
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create employees
            Employee employee1 = new Employee("626", "Stitch", "Alien", "23800");
            Employee employee2 = new Employee("404", "Notfo Und", "Male", "31337");
            Employee employee3 = new Employee("555", "Nova", "Female", "36500");
            Employee employee4 = new Employee("182", "Ava", "Female", "42000");
            Employee employee5 = new Employee("427", "Stanley", "Male", "22300");

            // Part 1 - Stack
            Stack <Employee> stack = new Stack<Employee>();

            // Push all employees to the stack
            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);

            Console.WriteLine("Part 1 - Stack: \n");

            Console.WriteLine("Plain printing");
           
            // Print out all elements in the stack with a foreach loop
            foreach (Employee emp in stack)
            {
                Console.WriteLine(emp);
                Console.WriteLine($"Items left in the stack: {stack.Count}.");
            }

            Console.WriteLine("------------------------");
            Console.WriteLine("Retrieving using pop()-method");
           
            // Print out all elements in the stack using the pop()-method
            while (stack.Count > 0)
            {
                Employee emp = stack.Pop();
                Console.WriteLine(emp);
                Console.WriteLine($"Items left in the stack: {stack.Count}.");
            }

            // Add back all the objects that were removed above with the pop() method
            stack.Push(employee1);
            stack.Push(employee2);
            stack.Push(employee3);
            stack.Push(employee4);
            stack.Push(employee5);

            Console.WriteLine("------------------------");
            Console.WriteLine("Retrieving using peek()-method");

            // Print out all elements in the stack using the peek()-method
            for (int i = 0; i < 2; i++)
            {
                Employee emp = stack.Peek();
                Console.WriteLine(emp);
                Console.WriteLine($"Items left in the stack: {stack.Count}.");
            }
            
            // Check if Employee 3 is in the stack or not and print out the result
            if (stack.Contains(employee3))
            {
                Console.WriteLine("Employee 3 is in the stack.");
            }
            else
            {
                Console.WriteLine("Employee 3 is not in the stack.");
            }

            // Part 2 - Lists
            Console.WriteLine("------------------------");
            Console.WriteLine("Part 2 - List: \n");

            // Create list
            List<Employee> list = new List<Employee>();

            // Add all employees to the list
            list.Add(employee1);
            list.Add(employee2);
            list.Add(employee3);
            list.Add(employee4);
            list.Add(employee5);

            // Check if list contains employee2 and print the result.
            if (list.Contains(employee2))
            {
                Console.WriteLine("Employee 2 is in the list.");
            }
            else
            {
                Console.WriteLine("Employee 2 is in not the list.");
            }

            // Prints out first male in list 
            Console.WriteLine($"\nFirst male in the list: \n{list.Find(employee => employee.Gender == "Male")}");

            // Creates a new list and assigns adds all Male employees to it as FindAll() returns a new list with the resluts
            List<Employee> maleEmployees = list.FindAll(employee => employee.Gender == "Male");

            // Prints out all male employees in the list
            Console.WriteLine("\nAll males in the list: ");
            foreach (Employee emp in maleEmployees)
            {
                Console.WriteLine(emp);
            }
            

        }
    }


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