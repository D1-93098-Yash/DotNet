namespace Assignment02
{
    class Person
    {
        String name;
        int age;
        public Person()
        {

        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public void accept()
        {
            Console.WriteLine("Enter Name and Age:");
            this.name = Console.ReadLine();
            this.age = Convert.ToInt32(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("Age: " + this.age);
        }
    }

    class Emp : Person
    {
        int id;
        double salary;
        public Emp() : base()
        {
            this.id = 0;
            this.salary = 0.0;
        }
        public Emp(string name, int age, int id, double salary) : base(name, age)
        {
            this.id = id;
            this.salary = salary;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public void acceptEmp()
        {
            base.accept();
            Console.WriteLine("Enter Employee Details id and salary:");
            this.id = Convert.ToInt32(Console.ReadLine());
            this.salary = Convert.ToDouble(Console.ReadLine());
        }
        public void displayEmp()
        {
            base.display();
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Salary: " + this.salary);
        }
        virtual public void calculateSalary()
        {
            // Default implementation (if any)
        }
    }
    class Labor : Emp
    {
        int hours;
        double rate;
        public Labor() : base()
        {
            this.hours = 0;
            this.rate = 0.0;
        }
        public Labor(string name, int age, int id, double salary, int hours, double rate) : base(name, age, id, salary)
        {
            this.hours = hours;
            this.rate = rate;
        }
        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }
        public double Rate
        {
            get { return rate; }
            set { rate = value; }
        }
        public void acceptLabor()
        {
            base.acceptEmp();
            Console.WriteLine("Enter Labor Details hours and rate:");
            this.hours = Convert.ToInt32(Console.ReadLine());
            this.rate = Convert.ToDouble(Console.ReadLine());
        }
        public void displayLabor()
        {
            base.displayEmp();
            Console.WriteLine("Hours: " + this.hours);
            Console.WriteLine("Rate: " + this.rate);
        }
        public override void calculateSalary()
        {
            this.Salary = this.hours * this.rate;
        }
    }
    class Manager : Emp
    {
        int bonus;
        public Manager() : base()
        {
            this.bonus = 0;
        }
        public Manager(string name, int age, int id, double salary, int bonus) : base(name, age, id, salary)
        {
            this.bonus = bonus;
        }
        public int Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        public void acceptManager()
        {
            base.acceptEmp();
            Console.WriteLine("Enter Manager Details bonus:");
            this.bonus = Convert.ToInt32(Console.ReadLine());
        }
        public void displayManager()
        {
            base.displayEmp();
            Console.WriteLine("Bonus: " + this.bonus);
        }
        public override void calculateSalary()
        {
            this.Salary = this.Salary + this.bonus;
        }
        class Salesman : Emp
        {
            double commission;
            public Salesman() : base()
            {
                this.commission = 0.0;
            }
            public Salesman(string name, int age, int id, double salary, double commission) : base(name, age, id, salary)
            {
                this.commission = commission;
            }
            public double Commission
            {
                get { return commission; }
                set { commission = value; }
            }
            public void acceptSalesman()
            {
                base.acceptEmp();
                Console.WriteLine("Enter Salesman Details commission:");
                this.commission = Convert.ToDouble(Console.ReadLine());
            }
            public void displaySalesman()
            {
                base.displayEmp();
                Console.WriteLine("Commission: " + this.commission);
            }
            public override void calculateSalary()
            {
                this.Salary = this.Salary + this.commission;
            }
        }
    }
    internal class Ques01
    {
        static void Main(string[] args)
        {
            Emp emp1 = new Labor();
            emp1.acceptEmp();
            emp1.calculateSalary();
            emp1.displayEmp();
            Emp emp2 = new Manager();
            emp2.acceptEmp();
            emp2.calculateSalary();
            emp2.displayEmp();
            Emp emp3 = new Manager();
            emp3.acceptEmp();
            emp3.calculateSalary();
            emp3.displayEmp();
        }
    }
}