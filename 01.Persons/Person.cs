using System;
using System.Text.RegularExpressions;


class Person
{
    private string name;
    private int age;
    private string email;
    public Person(string name, int age, string email)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
    }
    public Person(string name, int age) : this(name, age, null)
    {
    }
    public string Name
    {
        get { return this.name; }
        set
        {
            value.Trim();
            if (value == "" || value == null)
            {
                if (value == "")
                {
                    throw new ArgumentException("name", "Invalid name.\n\rName can not be blank!");
                }
                throw new ArgumentNullException("name", "Invalid name.\n\rName can not be null!");
            }
            this.name = value;
        }
    }
    public int Age
    {
        get { return this.age; }
        set
        {
            if (value < 0 || value >= 100)
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("age", "Age should  be positive number greater than 0!");
                }
                throw new ArgumentOutOfRangeException("age", "Age can not be greater than 100!");

            }
            this.age = value;
        }
    }
    public string Email
    {
        get { return this.email; }
        set
        {
            if (value != null && (Regex.Match(value, @"^@$").Success || value == ""))
            {
                if (value == "")
                {
                    throw new ArgumentException("email", "Invalid email.\n\rEmail can not be blank!");
                }
                throw new ArgumentException("email", "Invalid email.\n\rEmail can not be only \"@\"!");
            }
            this.email = value;
        }
    }
    public override string ToString()
    {
        return string.Format("Name: {0}\n\rAge: {1}\n\rE-mail: {2}", this.Name, this.Age, this.Email ?? "(no e-mail)");
    }
}

