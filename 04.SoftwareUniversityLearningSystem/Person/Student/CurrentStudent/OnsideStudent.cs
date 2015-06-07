using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OnsiteStudent : CurrentStudent
{
    private int numberOfVisits;
    public OnsiteStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string currentCourse, int numberOfVisits)
        :base(firstName,lastName,age,studentNumber,averageGrade,currentCourse)
    {
        this.NumberOfVisits = numberOfVisits;
    }

    public int NumberOfVisits
    {
        get { return this.numberOfVisits; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("numberOfVisits", "Number of visits can not be negative!");
            }
            this.numberOfVisits = value;
        }
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.Append(base.ToString());
        output.Append(string.Format("Number of visits: {0}{1}", this.NumberOfVisits, Environment.NewLine));
        return output.ToString();
    }
}
