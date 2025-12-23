using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Assignment01
{
    class Student
    {
        private string name;
        private bool gender;
        private int age;
        private int std;
        private char div;
        private double marks;
        public Student()
        {

        }
        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            this.name = name;
            this.gender = gender;
            this.age = age;
            this.std = std;
            this.div = div;
            this.marks = marks;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public bool Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public int Std
        {
            get { return this.std; }
            set { this.std = value; }
        }
        public char Div
        {
            get { return this.div; }
            set { this.div = value; }
        }
        public double Marks
        {
            get { return this.marks; }
            set { this.marks = value; }
        }
        public void AcceptDetails()
        {
            Console.WriteLine("Enter Name, gender, age, std, div, marks");
            this.name = Console.ReadLine();
            this.gender = bool.Parse(Console.ReadLine());
            string age1 = Console.ReadLine();
            this.age = int.Parse(age1);
            string std1 = Console.ReadLine();
            this.std = int.Parse(std1);
            this.div = char.Parse(Console.ReadLine());
            string marks1 = Console.ReadLine();
            this.marks = double.Parse(marks1);
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine($"Gender: {this.gender}");
            Console.WriteLine($"Age: {this.age}");
            Console.WriteLine($"Std: {this.std}");
            Console.WriteLine($"Div: {this.div}");
            Console.WriteLine($"Marks: {this.marks}");
        }
    }


    internal class Ques03
    {
        public static void Main(string[] args)
        {
            Student student = new Student();
            student.AcceptDetails();
            student.PrintDetails();
        }
    }
}
