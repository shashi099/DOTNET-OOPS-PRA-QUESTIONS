 
using System;

class Employee{
    private int employeeId;
    private string name;
    private string branch;
    private double rating;
    private bool transport;
    public Employee(int employeeId, string name, string branch, double rating, bool transport)
    {
        this.employeeId = employeeId;
        this.name = name;
        this.branch = branch;
        this.rating = rating;
        this.transport = transport;
    }

    // Getters and Setters
    public int EmployeeId
    {
        get{return employeeId;}
        set{employeeId = value;}
    }
    public string Name
    {
        get { return name;}
        set { name = value;}
    }    
    public string Branch
    {
        get { return branch;}
        set {branch = value;}
    }
    public double Rating
    {
        get{ return rating;}
        set{rating = value;}
    }
    public bool Transport
    {
        get{return transport;}
        set{transport = value;}
    }
}

class MyClass
{
    static void Main()
    {
        Employee[] emps = new Employee[4];
        for(int i=0; i<4; i++)
        {
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string branch = Console.ReadLine();
            double rat = double.Parse(Console.ReadLine());
            bool transp = bool.Parse(Console.ReadLine());

            emps[i] = new Employee(id, name, branch, rat, transp);
        }

        string findbranch = Console.ReadLine();
        int ans = findCountOfEmployeesUsingCompTransport(emps, findbranch);

        if(ans != 0)
        {
            Console.WriteLine(ans);
        }
        else
        {
            Console.WriteLine("No such Employees");
        }

        Employee ansE = findEmployeeWithSecondHighestRating(emps);
        if(ansE != null)
        {
            Console.WriteLine(ansE.EmployeeId + " -> " + ansE.Name);
        }
        else
        {
            Console.WriteLine("All Employees using company transport!");
        }

    }
    static int findCountOfEmployeesUsingCompTransport(Employee[] employees, string branch)
    {
        int countOfEmployee = 0;
        foreach (Employee item in employees)
        {
            if(employees != null && item.Branch.Equals(branch, StringComparison.OrdinalIgnoreCase))
            {
                countOfEmployee++;
            }
        }

        return countOfEmployee;
    }
    
    static Employee findEmployeeWithSecondHighestRating(Employee[] employees)
    {
        double highestRating = 0;
        double secondRating = 0;

        Employee search = null;

        foreach(Employee e in employees)
        {
            if(!e.Transport && highestRating < e.Rating)
            {
                secondRating = highestRating;
                highestRating = e.Rating;
            }else if(!e.Transport && secondRating < e.Rating)
            {
                secondRating = e.Rating;
            }
        }

        // Console.WriteLine(highestRating +" " + secondRating);

        foreach(Employee e in employees)
        {
            if(secondRating.Equals(e.Rating))
            {
                search = e;
            }
        }
        return search;
    }

}