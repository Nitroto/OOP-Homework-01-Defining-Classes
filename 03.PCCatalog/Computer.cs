using System;
using System.Collections.Generic;
using System.Text;

class Computer:IComparable
{
    private string name;
    private List<Component> components;

    public Computer(string name, List<Component> components)
    {
        this.Name = name;
        this.Components = components;
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
          get
        {
            return CalcConfigurationPrice(this);
        }
    }
    public List<Component> Components
    {
        get { return this.components; }
        set
        {
            if (value.Count == 0)
            {
                throw new ArgumentNullException("components", "The computer must contain at least one component!");
            }
            this.components = value;
        }

    }


    public static decimal CalcConfigurationPrice(Computer computer)
    {
        var components = computer.Components;

        decimal computerPrice = 0;

        foreach (var component in components)
        {
            computerPrice += component.Price;
        }

        return computerPrice;
    }

    public int CompareTo(object obj)
    {
        Computer otherComputer = (Computer)obj;
        return this.Price.CompareTo(otherComputer.Price);
    }

    public void AddComponent(Component component)
    {
        var newConfiguration = this.Components;
        newConfiguration.Add(component);
        this.Components = newConfiguration;
    }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.Append(string.Format("{0,-15}| {1}{2}", "Name:",this.Name,Environment.NewLine));
        foreach (var component in this.Components)
        {
            output.Append(string.Format("{0,-15}| {1,13:C2}{2}{3}", component.Name, component.Price, (string.IsNullOrWhiteSpace(component.Details)?"":" - " + component.Details), Environment.NewLine));
        }
        output.Append(string.Format("{0,-15}| {1,13:C2}{2}", "Price:", this.Price, Environment.NewLine));
        return output.ToString();
    }
}

