using System;

class Program
{
    // Employee class definition with Id, FirstName, and LastName properties
    public class Employee
    {
        // Properties to hold the employee's Id, FirstName, and LastName
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to initialize an Employee object with given values
        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        // Overload the == operator to compare two Employee objects based on their Id
        public static bool operator ==(Employee e1, Employee e2)
        {
            // If both are null, they are equal. If one is null and the other isn't, they are not equal.
            if (ReferenceEquals(e1, null) && ReferenceEquals(e2, null))
                return true;
            if (ReferenceEquals(e1, null) || ReferenceEquals(e2, null))
                return false;

            // Compare their Ids for equality
            return e1.Id == e2.Id;
        }

        // Overload the != operator to negate the == operator's result
        public static bool operator !=(Employee e1, Employee e2)
        {
            // Simply return the negation of the == comparison
            return !(e1 == e2);
        }

        // Override Equals method for object comparison, comparing based on Id
        public override bool Equals(object obj)
        {
            // Check if the object is an Employee and compare their Ids
            if (obj is Employee other)
            {
                return this.Id == other.Id;
            }
            return false;
        }

        // Override GetHashCode, which is important when overriding Equals
        public override int GetHashCode()
        {
            // Use the Id property to calculate the hash code
            return Id.GetHashCode();
        }

        // ToString method to display Employee details in a readable format
        public override string ToString()
        {
            return $"Employee ID: {Id}, Name: {FirstName} {LastName}";
        }
    }

    static void Main()
    {
        // Creating two Employee objects with different IDs, names will differ too
        Employee emp1 = new Employee(101, "Mhd", "Imad");
        Employee emp2 = new Employee(102, "Imad", "AlDaker");

        // Display the details of the first and second employee objects
        Console.WriteLine("Employee 1: " + emp1.ToString());
        Console.WriteLine("Employee 2: " + emp2.ToString());

        // Using the overloaded == operator to compare employees by Id
        if (emp1 == emp2)
        {
            Console.WriteLine("The two employees are equal based on ID.");
        }
        else
        {
            Console.WriteLine("The two employees are NOT equal based on ID.");
        }

        // Using the overloaded != operator to check if employees are not equal
        if (emp1 != emp2)
        {
            Console.WriteLine("The two employees are NOT equal based on ID (using !=).");
        }
        else
        {
            Console.WriteLine("The two employees are equal based on ID (using !=).");
        }
    }
}
