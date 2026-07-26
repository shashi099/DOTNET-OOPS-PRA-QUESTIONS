class Program
{
    // Method 1
    public static int FindAvgOfQuizByAdmin(Course[] courses, string admin)
    {
        int sum = 0;
        int count = 0;

        foreach (Course c in courses)
        {
            if (c.CourseAdmin.Equals(admin, StringComparison.OrdinalIgnoreCase))
            {
                sum += c.Quiz;
                count++;
            }
        }

        if (count == 0)
            return 0;

        return sum / count;
    }

    // Method 2
    public static Course[] SortCourseByHandsOn(Course[] courses, int handson)
    {
        List<Course> list = new List<Course>();

        foreach (Course c in courses)
        {
            if (c.Handson < handson)
            {
                list.Add(c);
            }
        }

        if (list.Count == 0)
            return null;

        // Sorting (Ascending)
        list.Sort((a, b) => a.Handson.CompareTo(b.Handson));

        return list.ToArray();
    }

    static void Main(string[] args)
    {
        Course[] courses = new Course[4];

        for (int i = 0; i < 4; i++)
        {
            int id = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();
            string admin = Console.ReadLine();
            int quiz = Convert.ToInt32(Console.ReadLine());
            int handson = Convert.ToInt32(Console.ReadLine());

            courses[i] = new Course(id, name, admin, quiz, handson);
        }

        string adminName = Console.ReadLine();
        int handsonValue = Convert.ToInt32(Console.ReadLine());

        int avg = FindAvgOfQuizByAdmin(courses, adminName);

        if (avg != 0)
            Console.WriteLine(avg);
        else
            Console.WriteLine("No Course found");

        Course[] result = SortCourseByHandsOn(courses, handsonValue);

        if (result != null)
        {
            foreach (Course c in result)
            {
                Console.WriteLine(c.CourseName);
            }
        }
        else
        {
            Console.WriteLine("No Course found with mentioned attributes.");
        }
    }
}