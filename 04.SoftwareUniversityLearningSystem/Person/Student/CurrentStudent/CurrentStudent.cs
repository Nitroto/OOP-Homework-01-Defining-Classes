using System;
using System.Text;

class CurrentStudent:Student, IComparable
{
    private string currentCourse;

    public CurrentStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse)
        :base(firstName,lastName,age,studentNumber,averageGrade)
    {
        this.CurrentCourse = currentCourse;
    }

    public string CurrentCourse
    {
        get { return this.currentCourse; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("currentCourse", "Current course can not be empty or null!");
            }
            this.currentCourse = value;
        }
    }

    public int CompareTo(object obj)
    {
        CurrentStudent otherStudent = (CurrentStudent)obj;
        return this.AverageGrade.CompareTo(otherStudent.AverageGrade);
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.Append(base.ToString());
        output.Append(string.Format("Current Course: {0}{1}", this.CurrentCourse, Environment.NewLine));
        return output.ToString();
    }
}
