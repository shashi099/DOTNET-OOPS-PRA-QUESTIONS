using System;
using System.Collections.Generic;

class Course
{
    private int courseId;
    private string courseName;
    private string courseAdmin;
    private int quiz;
    private int handson;

    // Parameterized Constructor
    public Course(int courseId, string courseName, string courseAdmin, int quiz, int handson)
    {
        this.courseId = courseId;
        this.courseName = courseName;
        this.courseAdmin = courseAdmin;
        this.quiz = quiz;
        this.handson = handson;
    }

    // Getters and Setters
    public int CourseId
    {
        get { return courseId; }
        set { courseId = value; }
    }

    public string CourseName
    {
        get { return courseName; }
        set { courseName = value; }
    }

    public string CourseAdmin
    {
        get { return courseAdmin; }
        set { courseAdmin = value; }
    }

    public int Quiz
    {
        get { return quiz; }
        set { quiz = value; }
    }

    public int Handson
    {
        get { return handson; }
        set { handson = value; }
    }
}
