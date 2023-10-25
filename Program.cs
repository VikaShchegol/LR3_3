using System;

class Parent
{
    public string Name { get; set; }
    public int BirthYear { get; set; }

    public Parent()
    {
    }

    public Parent(string name, int birthYear)
    {
        Name = name;
        BirthYear = birthYear;
    }

    public void Print()
    {
        Console.WriteLine($"{Name}");
        Console.WriteLine($"Рiк народження: {BirthYear}");
    }

    public int CalculateAge(int currentYear)
    {
        return currentYear - BirthYear;
    }
}

class Child : Parent
{
    public int ExamScore { get; set; }

    public Child(string name, int birthYear, int examScore) : base(name, birthYear)
    {
        ExamScore = examScore;
    }

    public new void Print()
    {
        base.Print();
        Console.WriteLine($"Сума балiв на iспитi: {ExamScore}");
    }

    public void CheckAdmission(int passScore)
    {
        if (ExamScore >= passScore)
        {
            Console.WriteLine("Прохiдний бал 8.Абiтурiєнт поступив");
        }
        else
        {
            Console.WriteLine("Прохiдний бал 8.Абiтурiєнт не поступив");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введiть рiк народження: ");
        int birthYear = int.Parse(Console.ReadLine());

        int currentYear = DateTime.Now.Year;

        if (birthYear >= 2001 && birthYear <= 2007)
        {
            Console.Write("Набрав балiв: ");
            int examScore = int.Parse(Console.ReadLine());

            Child applicant = new Child("Абiтурiєнт", birthYear, examScore);
            applicant.Print();
            int age = applicant.CalculateAge(currentYear);
            Console.WriteLine($"Абiтурiєнту {age} рокiв");

            int passScore = 8;
            applicant.CheckAdmission(passScore);
        }
        else
        {
            Parent person = new Parent("Людина", birthYear);
            person.Print();
            int age = person.CalculateAge(currentYear);
            Console.WriteLine($"Людинi {age} рокiв");
        }

    }
}

