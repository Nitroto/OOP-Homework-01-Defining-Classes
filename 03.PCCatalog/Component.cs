using System;

class Component : IComparable
{
    private string name;
    private decimal price;

    public Component(string name, decimal price)
    {
        this.Name = name;
        this.Price = price;
    }
    public Component(string name, decimal price, string details) : this(name, price)
    {
        this.Details = details;
    }


    public string Name
    {
        get { return this.name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("name", "Name can not be empty or null!");
            }
            this.name = value;
        }
    }

    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("price", "The price of component can not be negative!");
            }
            this.price = value;
        }
    }

    public string Details { get; set; }

    public int CompareTo(object obj)
    {
        Component otherComponent = (Component)obj;
        return this.Price.CompareTo(otherComponent.Price);
    }
}

