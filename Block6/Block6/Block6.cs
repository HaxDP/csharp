using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C__FUGAS
{
    class Block6
    {
        //task 1
        public class Fraction
        {
            public int Numerator { get; set; }
            public int Denominator { get; set; }

            public Fraction(int numerator, int denominator)
            {
                Numerator = numerator;
                Denominator = denominator;
            }

            public bool IsProper()
            {
                return Math.Abs(Numerator) < Math.Abs(Denominator);
            }

            public void CheckProperness()
            {
                if (IsProper())
                {
                    Console.WriteLine("This fraction is proper.");
                }
                else
                {
                    Console.WriteLine("This fraction is improper.");
                }
            }
        }

        static void Main()
        {
            Console.Write("Enter numerator: ");
            int numerator = int.Parse(Console.ReadLine());
            Console.Write("Enter denominator: ");
            int denominator = int.Parse(Console.ReadLine());
            Fraction fraction = new Fraction(numerator, denominator);
            fraction.CheckProperness();
            Console.ReadLine();
        }

        //task 2
        /*
        public class Vector
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Vector(int x, int y)
            {
                X = x;
                Y = y;
            }

            public Vector Add(Vector other)
            {
                return new Vector(X + other.X, Y + other.Y);
            }

            public Vector Subtract(Vector other)
            {
                return new Vector(X - other.X, Y - other.Y);
            }

            public void Display()
            {
                Console.WriteLine($"Vector: [{X}, {Y}]");
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter coordinates of the first vector:");
            Console.Write("x: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y1 = int.Parse(Console.ReadLine());
            Vector vector1 = new Vector(x1, y1);

            Console.WriteLine("Enter coordinates of the second vector:");
            Console.Write("x: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y2 = int.Parse(Console.ReadLine());
            Vector vector2 = new Vector(x2, y2);

            Vector sumVector = vector1.Add(vector2);
            Console.WriteLine("Sum result:");
            sumVector.Display();

            Vector diffVector = vector1.Subtract(vector2);
            Console.WriteLine("Difference result:");
            diffVector.Display();

            Console.ReadLine();
        }
        */

        //task 3
        /*
        public class Animal
        {
            public string Species { get; set; }
            public string Name { get; set; }

            public Animal(string species, string name)
            {
                Species = species;
                Name = name;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Animal: {Name}, Species: {Species}");
            }
        }

        public class Zoo
        {
            private List<Animal> animals;

            public Zoo()
            {
                animals = new List<Animal>();
            }

            public void AddAnimal(Animal animal)
            {
                animals.Add(animal);
                Console.WriteLine($"Animal {animal.Name} added to the zoo.");
            }

            public void RemoveAnimal(string name)
            {
                Animal animal = animals.Find(a => a.Name == name);

                if (animal != null)
                {
                    animals.Remove(animal);
                    Console.WriteLine($"Animal {name} removed from the zoo.");
                }
                else
                {
                    Console.WriteLine($"Animal with name {name} not found.");
                }
            }

            public void DisplayAllAnimals()
            {
                if (animals.Count == 0)
                {
                    Console.WriteLine("The zoo has no animals.");
                }
                else
                {
                    Console.WriteLine("Zoo Animals:");
                    foreach (var animal in animals)
                    {
                        animal.DisplayInfo();
                    }
                }
            }
        }

        static void Main()
        {
            Zoo zoo = new Zoo();
            zoo.AddAnimal(new Animal("Lion", "Simba"));
            zoo.AddAnimal(new Animal("Tiger", "Shera"));
            zoo.DisplayAllAnimals();
            zoo.RemoveAnimal("Simba");
            zoo.DisplayAllAnimals();
            Console.ReadLine();
        }
        */

        //task 4
        /*
        public class Coordinates
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Coordinates(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        public class Line
        {
            public Coordinates Start { get; set; }
            public Coordinates End { get; set; }

            public Line(Coordinates start, Coordinates end)
            {
                Start = start;
                End = end;
            }

            public double Length()
            {
                double dx = End.X - Start.X;
                double dy = End.Y - Start.Y;
                return Math.Sqrt(dx * dx + dy * dy);
            }
        }

        public class Triangle
        {
            public Line Line1 { get; set; }
            public Line Line2 { get; set; }
            public Line Line3 { get; set; }

            public Triangle(Line line1, Line line2, Line line3)
            {
                Line1 = line1;
                Line2 = line2;
                Line3 = line3;
            }

            public double Perimeter()
            {
                return Line1.Length() + Line2.Length() + Line3.Length();
            }
        }

        static void Main()
        {
            Console.WriteLine("Enter coordinates of 3 points:");
            Console.Write("Point 1 (x, y): ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            Coordinates point1 = new Coordinates(x1, y1);

            Console.Write("Point 2 (x, y): ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Coordinates point2 = new Coordinates(x2, y2);

            Console.Write("Point 3 (x, y): ");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            Coordinates point3 = new Coordinates(x3, y3);

            Line line1 = new Line(point1, point2);
            Line line2 = new Line(point2, point3);
            Line line3 = new Line(point3, point1);
            Triangle triangle = new Triangle(line1, line2, line3);

            double perimeter = triangle.Perimeter();
            Console.WriteLine($"Perimeter: {perimeter}");
            Console.ReadLine();
        }
        */

        //task 5
        /*
        public class Person
        {
            public string Name { get; private set; }
            public int Age { get; private set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public void ChangeName(string newName)
            {
                Name = newName;
                Console.WriteLine($"Name changed to: {newName}");
            }

            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}");
            }
        }

        public class Student : Person
        {
            public string University { get; private set; }
            public List<int> Grades { get; private set; }

            public Student(string name, int age, string university)
                : base(name, age)
            {
                University = university;
                Grades = new List<int>();
            }

            public void AddGrade(int grade)
            {
                Grades.Add(grade);
                Console.WriteLine($"Grade {grade} added.");
            }

            public double CalculateAverageGrade()
            {
                if (Grades.Count == 0)
                    return 0;

                return Grades.Average();
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"University: {University}");
                Console.WriteLine($"Average Grade: {CalculateAverageGrade():F2}");
            }
        }

        static void Main()
        {
            Person person = new Person("John Doe", 30);
            person.DisplayInfo();
            person.ChangeName("Jane Doe");
            person.DisplayInfo();

            Student student = new Student("Alice", 20, "Harvard");
            student.DisplayInfo();
            student.AddGrade(90);
            student.AddGrade(85);
            student.AddGrade(88);
            student.DisplayInfo();

            Console.ReadLine();
        }
        */
    }
}
