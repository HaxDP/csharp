using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static C__FUGAS.Block6;

namespace C__FUGAS
{
    class Block6
    {
        //task 1
        /*
        public class CommonFraction
        {
            public int numerator;
            public int denominator;
            public CommonFraction(int numerator, int denominator)
            {
                this.numerator = numerator;
                this.denominator = denominator;
            }
            public bool IsProper()
            {
                return Math.Abs(numerator) < Math.Abs(denominator);
            }
            public void Check()
            {
                if (IsProper())
                {
                    Console.WriteLine("This fraction is correct.");
                }
                else
                {
                    Console.WriteLine("This fraction is incorrect.");
                }
            }
        }
        static void Main()
        {
            Console.Write("Enter numerarararararararararator: ");
            int numerararator = int.Parse(Console.ReadLine());
            Console.Write("Enter denononononononononominator: ");
            int denononominator = int.Parse(Console.ReadLine());
            CommonFraction fraction = new CommonFraction(numerararator, denononominator);
            fraction.Check();
            Console.ReadLine();
        }
        */
        //task 2
        /*
        public class VectorBoi
        {
            public int xCoord;
            public int yCoord;
            public VectorBoi(int x, int y)
            {
                this.xCoord = x;
                this.yCoord = y;
            }
            public VectorBoi addThatBigAsFuckDick(VectorBoi otherBoi)
            {
                return new VectorBoi(this.xCoord + otherBoi.xCoord, this.yCoord + otherBoi.yCoord);
            }
            public VectorBoi subTractMyCock(VectorBoi otherBoi)
            {
                return new VectorBoi(this.xCoord - otherBoi.xCoord, this.yCoord - otherBoi.yCoord);
            }
            public void showMeUrDick()
            {
                Console.WriteLine($"Vector: [{xCoord}, {yCoord}]");
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter cock of first vector:");
            Console.Write("x: ");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y1 = int.Parse(Console.ReadLine());
            VectorBoi vector1 = new VectorBoi(x1, y1);
            Console.WriteLine("Enter cock of second vector:");
            Console.Write("x: ");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("y: ");
            int y2 = int.Parse(Console.ReadLine());
            VectorBoi vector2 = new VectorBoi(x2, y2);
            VectorBoi sumVector = vector1.addThatBigAsFuckDick(vector2);
            Console.WriteLine("Sum result is:");
            sumVector.showMeUrDick();
            VectorBoi diffVector = vector1.subTractMyCock(vector2);
            Console.WriteLine("Min result is:");
            diffVector.showMeUrDick();
            Console.ReadLine();
        }
        */
        //task 3
        /*
        public class Animal
        {
            public string species;
            public string name;
            public Animal(string species, string name)
            {
                this.species = species;
                this.name = name;
            }
            public void showUrBigDickAnimal()
            {
                Console.WriteLine($"Animal: {name}, breed: {species}");
            }
        }
        public class ZooBoi
        {
            public List<Animal> animalSquad;
            public ZooBoi()
            {
                animalSquad = new List<Animal>();
            }
            public void addDaAnimal(Animal newBoi)
            {
                animalSquad.Add(newBoi);
                Console.WriteLine($"Animal {newBoi.name} was added in zoo!");
            }
            public void releaseDaAnimal(string name)
            {
                Animal found = animalSquad.Find(boi => boi.name == name);

                if (found != null)
                {
                    animalSquad.Remove(found);
                    Console.WriteLine($"Animal {name} was delete in the pieces from zoo. Pishow nahui, shluha!");
                }
                else
                {
                    Console.WriteLine($"Animal with name {name} not found.");
                }
            }
            public void showAllDaAnimals()
            {
                if (animalSquad.Count == 0)
                {
                    Console.WriteLine("There is no animals in zoo yet. 🦄");
                }
                else
                {
                    Console.WriteLine("Zoo animals:");
                    foreach (var boi in animalSquad)
                    {
                        boi.showUrBigDickAnimal();
                    }
                }
            }
        }
        class Program
        {
            static void Main()
            {
                ZooBoi myZoo = new ZooBoi();
                myZoo.addDaAnimal(new Animal("Animal", "Prys"));
                myZoo.addDaAnimal(new Animal("Animal", "Sedlarov"));
                myZoo.addDaAnimal(new Animal("Animal", "Martunuk"));
                myZoo.showAllDaAnimals();
                myZoo.releaseDaAnimal("Prys");
                myZoo.showAllDaAnimals();
                Console.ReadLine();
            }
        }
        */
        //task 4
        /*
        public class coordinates
        {
            public double x;
            public double y;
            public coordinates(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public class line
        {
            public coordinates coord1;
            public coordinates coord2;
            public line(coordinates coord1, coordinates coord2)
            {
                this.coord1 = coord1;
                this.coord2 = coord2;
            }
            public double length()
            {
                double dx = coord1.x - coord1.x;
                double dy = coord2.y - coord1.y;
                return Math.Sqrt(dx * dx + dy * dy);
            }
        }
        public class Triangle
        {
            public line line1;
            public line line2;
            public line line3;
            public Triangle(line line1, line line2, line line3)
            {
                this.line1 = line1;
                this.line2 = line2;
                this.line3 = line3;
            }
            public double Perimeter()
            {
                return line1.length() + line2.length() + line3.length();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter coordinates of 3 points:");
                Console.Write("Point 1 (x, y): ");
                double x1 = double.Parse(Console.ReadLine());
                double y1 = double.Parse(Console.ReadLine());
                coordinates point1 = new coordinates(x1, y1);
                Console.Write("Point 2 (x, y): ");
                double x2 = double.Parse(Console.ReadLine());
                double y2 = double.Parse(Console.ReadLine());
                coordinates point2 = new coordinates(x2, y2);
                Console.Write("Point 3 (x, y): ");
                double x3 = double.Parse(Console.ReadLine());
                double y3 = double.Parse(Console.ReadLine());
                coordinates point3 = new coordinates(x3, y3);
                line line1 = new line(point1, point2);
                line line2 = new line(point2, point3);
                line line3 = new line(point3, point1);
                Triangle triangle = new Triangle(line1, line2, line3);
                double perimeter = triangle.Perimeter();
                Console.WriteLine($"Perimeter: {perimeter}");
                Console.ReadLine();
            }
        }
        */
        //task 5
        /*
        public class human
        {
            public string Name { get; private set; }
            public int Age { get; private set; }
            public human(string name, int age)
            {
                Name = name;
                Age = age;
            }
            public void ChangeName(string newName)
            {
                Name = newName;
                Console.WriteLine($"Name changed to: {newName}");
            }
            public virtual void ShowInfo()
            {
                Console.WriteLine($"Name: {Name}, age: {Age}");
            }
        }
        public class Student : human
        {
            public string place_of_study { get; private set; }
            public List<int> grades { get; private set; }
            public Student(string name, int age, string university)
                : base(name, age)
            {
                place_of_study = university;
                grades = new List<int>();
            }
            public void AddGrade(int grade)
            {
                grades.Add(grade);
                Console.WriteLine($"Mark {grade} added.");
            }
            public double CalculateAAAAAAverageGrade()
            {
                if (grades.Count == 0)
                    return 0;

                int sum = 0;
                foreach (int grade in grades)
                {
                    sum += grade;
                }
                return (double)sum / grades.Count;
            }
            public override void ShowInfo()
            {
                base.ShowInfo();
                Console.WriteLine($"Place of study: {place_of_study}");
                if (grades.Count > 0)
                {
                    Console.WriteLine($"Average mark: {CalculateAAAAAAverageGrade():F2}");
                }
                else
                {
                    Console.WriteLine("There is no marks.");
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                human human = new human("Cyborg Kiler", 993);
                human.ShowInfo();
                human.ChangeName("Nicola Tesla");
                human.ShowInfo();
                Student student = new Student("Megatron", 999, "Kibertron");
                student.ShowInfo();
                student.AddGrade(90);
                student.AddGrade(85);
                student.AddGrade(88);
                student.ShowInfo();
                Console.ReadLine();
            }
        }
        */
    }
}