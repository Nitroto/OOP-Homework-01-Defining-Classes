using System;
using System.Text;


class Student : Person
{
    private int studentNumber;
    private double averageGrade;

    public Student(string firstName, string lastName, int age, int studentNumber,double averageGrade):base(firstName,lastName,age)
    {
        this.StudentNumber = studentNumber;
        this.AverageGrade = averageGrade;
    }

    public int StudentNumber
    {
        get { return this.studentNumber; }
        set
        {
            if (value < 100000000 || value > 999999999)
            {
                throw new ArgumentOutOfRangeException("studentNumber", "Invalid student number! Student number should contain 9 digits.");
            }
            this.studentNumber = value;
        }
    }
    public double AverageGrade
    {
        get { return this.averageGrade; }
        set
        {
            if (value < 2.0 || value > 6.0)
            {
                throw new ArgumentOutOfRangeException("averageGrade", "Invalid average grade! It should be between 2.0 and 6.0");
            }
            this.averageGrade = value;
        }
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.Append(base.ToString());
        output.Append(string.Format("Student number: {0}{2}Average grade: {1}{2}", this.StudentNumber, this.AverageGrade, Environment.NewLine));
        return output.ToString();
    }

}
