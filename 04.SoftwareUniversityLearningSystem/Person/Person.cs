using System;

class Person
{
    private string firstName;
    private string lastName;
    private int age;

    public Person(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("firstName", "First name can not be null or empty!");
            }
            this.firstName = value;
        }
    }
    public string LastName
    {
        get { return this.lastName; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("lastName", "Last name can not be null or empty!");
            }
            this.lastName = value;
        }
    }
    public int Age
    {
        get { return this.age; }
        set
        {
            if (value<0)
            {
                throw new ArgumentOutOfRangeException("age", "Age can not be negative!");
            }
            this.age = value;
        }
    }

    public override string ToString()
    {
        string output = string.Format("First name: {0}{3}Last name: {1}{3}Age: {2}{3}", this.FirstName,this.LastName,this.Age,Environment.NewLine);
        return output;
    }

}
