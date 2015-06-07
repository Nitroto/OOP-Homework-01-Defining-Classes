using System;
using System.Text;


class DropoutStudent:Student
{
    private string dropoutReason;

    public DropoutStudent(string firstName, string lastName, int age, int studentNumber, double averageGrade, string dropoutReason)
        :base(firstName,lastName,age,studentNumber,averageGrade)
    {
    }

    public string DropoutReason
    {
        get { return this.dropoutReason; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("dropoutReason", "Reason can not be empty or null!");
            }
            this.dropoutReason = value;
        }
    }

    public void Reapply()
    {
        Console.WriteLine(this);
    }
    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.Append(base.ToString());
        output.Append(string.Format("Dropout Reason: {0}{1}", this.DropoutReason, Environment.NewLine));
        return output.ToString();
    }
}

