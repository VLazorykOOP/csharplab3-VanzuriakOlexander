class Triangle {
    private int a, b, c;
    private string color;

    public Triangle(int f, int s, int t) {
        a = f;
        b = s;
        c = t;
    }

    public Triangle(int f, int s, int t, string col) {
        a = f;
        b = s;
        c = t;
        color = col;
    }

    public void Print() {
        Console.WriteLine($"Triangle lines: a = {a}, b = {b}, c = {c}");
    }

    public int Perimeter() {
        return a + b + c;
    }

    public double Area() {
        float halfperimeter = (a + b + c) / 2;
        return Math.Sqrt(halfperimeter * (halfperimeter - a) * (halfperimeter - b) * (halfperimeter - c));
    }

    public int getFirst() {
        return a;
    }

    public int getSecond() {
        return b;
    }

    public int getThird() {
        return c;
    }

    public void setFirst(int newValue) {
        a = newValue;
    }

    public void setSecond(int newValue) {
        b = newValue;
    }

    public void setThird(int newValue) {
        c = newValue;
    }

    public string getColor() {
        return color;
    }
}

class Person
{
    public string name;
    public int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Show()
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
}

class Employee : Person
{
    public string position;

    public Employee(string name, int age, string position) : base(name, age)
    {
        this.position = position;
    }

    public new void Show()
    {
        base.Show();
        Console.WriteLine($"Position: {position}");
    }
}

class Worker : Person
{
    public double salary;

    public Worker(string name, int age, double salary) : base(name, age)
    {
        this.salary = salary;
    }

    public new void Show()
    {
        base.Show();
        Console.WriteLine($"Salary: {salary}");
    }
}

class Engineer : Person
{
    public string specialization;

    public Engineer(string name, int age, string specialization) : base(name, age)
    {
        this.specialization = specialization;
    }

    public new void Show()
    {
        base.Show();
        Console.WriteLine($"Specialization: {specialization}");
    }
}

class Task
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the task");
            string? str = Console.ReadLine();
            int n = 0; 
            if (str != null) n = int.Parse(str);
            if (n == 1) {
                Triangle triangle1 = new Triangle(3, 4, 5);
                triangle1.Print();
                Console.WriteLine($"Perimeter: {triangle1.Perimeter()}");
                Console.WriteLine($"Area of triangle: {triangle1.Area()}");
            } else {
                Person person1 = new Person("Olexander", 30);
                Employee employee1 = new Employee("Masha", 25, "Menager");
                Worker worker1 = new Worker("Petro", 35, 5000);
                Engineer engineer1 = new Engineer("Stepan", 28, "Electrical engineering");

                Person[] peopleArray = { person1, employee1, worker1, engineer1 };

                Array.Sort(peopleArray, (p1, p2) => p1.age.CompareTo(p2.age));

                foreach (var person in peopleArray)
                {
                    person.Show();
                }
            };
            
        }
    }
