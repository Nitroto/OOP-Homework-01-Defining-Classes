using System;
using System.Text;

/// Define a class Laptop that holds the following information about a laptop device: model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
///•	The model and price are mandatory.All other values are optional.
///•	Define two separate classes: a class Laptop holding an instance of class Battery.
///•	Define several constructors that take different sets of arguments(full laptop + battery information or only part of it). Use proper variable types.
///•	Add a method in the Laptop class that displays information about the given instance

class Laptop
{
    private string model;
    private decimal price;

    public Laptop(string model, decimal price)
    {
        this.Model = model;
        this.Price = price;
    }
    public Laptop(string model, decimal price, string manufacturer) : this(model, price)
    {
        this.Manufacturer = manufacturer;
    }
    public Laptop(string model, decimal price, string manufacturer, string processor) : this(model, price, manufacturer)
    {
        this.Processor = processor;
    }
    public Laptop(string model, decimal price, string manufacturer, string processor, int ram) : this(model, price, manufacturer, processor)
    {
        this.RAM = ram;
    }
    public Laptop(string model, decimal price, string manufacturer, string processor, int ram, string gpu) : this(model, price, manufacturer, processor, ram)
    {
        this.GraphicsCard = gpu;
    }
    public Laptop(string model, decimal price, string manufacturer, string processor, int ram, string gpu, string hdd) : this(model, price, manufacturer, processor, ram, gpu)
    {
        this.HDD = hdd;
    }
    public Laptop(string model, decimal price, string manufacturer, string processor, int ram, string gpu, string hdd, string screen) : this(model, price, manufacturer, processor, ram, gpu, hdd)
    {
        this.Screen = screen;
    }
    public Laptop(string model, decimal price, string manufacturer, string processor, int ram, string gpu, string hdd, string screen, Battery battery) : this(model, price, manufacturer, processor, ram, gpu, hdd, screen)
    {
        this.LaptopBattery = battery;
    }

    public string Model
    {
        get { return this.model; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                if (value == null)
                {
                    throw new ArgumentNullException("model", "Model can not be null!");
                }
                throw new ArgumentException("model", "Model can not be empty!");
            }
            this.model = value;
        }
    }
    public decimal Price
    {
        get { return this.price; }
        set
        {
            if (value < 0.0M)
            {
                throw new ArgumentOutOfRangeException("price", "Price can not be negative!");
            }
            this.price = value;
        }
    }
    public string Manufacturer { get; set; }
    public string Processor { get; set; }
    public int RAM { get; set; }
    public string GraphicsCard { get; set; }
    public string HDD { get; set; }
    public string Screen { get; set; }
    public Battery LaptopBattery { get; set; }
    public object StrinBuilder { get; private set; }

    public override string ToString()
    {
        StringBuilder output = new StringBuilder();
        output.Append(string.Format("{0}{1}", new string('-', 79), Environment.NewLine));
        output.Append(string.Format("|{0,-15}| {1,-60}|{2}", "Model", this.Model, Environment.NewLine));
        output.Append(string.Format("{0}{1}", new string('-', 79), Environment.NewLine));
        if (!string.IsNullOrWhiteSpace(this.Manufacturer))
        {
            output.Append(string.Format("|{0,-15}| {1,-60}|{2}", "Manufacturer", this.Manufacturer, Environment.NewLine));
            output.Append(string.Format("{0}{1}", new string('-', 79), Environment.NewLine));
        }
        if (!string.IsNullOrWhiteSpace(this.Processor))
        {
            output.Append(string.Format("|{0,-15}| {1,-60}|{2}", "Processor", this.Processor, Environment.NewLine));
            output.Append(string.Format("{0}{1}", new string('-', 79), Environment.NewLine));
        }
        if (this.RAM>0)
        {
            output.Append(string.Format("|{0,-15}| {1,-60}|{2}", "RAM", string.Format("{0} GB",this.RAM), Environment.NewLine));
            output.Append(string.Format("{0}{1}", new string('-', 79), Environment.NewLine));
        }
        if (!string.IsNullOrWhiteSpace(this.GraphicsCard))
        {
            output.Append(string.Format("|{0,-15}| {1,-60}|{2}", "Graphics Card", this.GraphicsCard, Environment.NewLine));
            output.Append(string.Format("{0}{1}", new string('-', 79), Environment.NewLine));
        }
        if (!string.IsNullOrWhiteSpace(this.HDD))
        {
            output.Append(string.Format("|{0,-15}| {1,-60}|{2}", "HDD", this.HDD, Environment.NewLine));
            output.Append(string.Format("{0}{1}", new string('-', 79), Environment.NewLine));
        }
        if (!string.IsNullOrWhiteSpace(this.Screen))
        {
            output.Append(string.Format("|{0,-15}| {1,-60}|{2}", "Screen", this.Screen, Environment.NewLine));
            output.Append(string.Format("{0}{1}", new string('-', 79), Environment.NewLine));
        }
        if (this.LaptopBattery != null)
        {
            output.Append(string.Format("|{0,-15}| {1,-60}|{2}", "Battery", this.LaptopBattery.BatteryInfo, Environment.NewLine));
            output.Append(string.Format("{0}{1}", new string('-', 79), Environment.NewLine));
            output.Append(string.Format("|{0,-15}| {1,-60}|{2}", "Battery life", string.Format("{0} hours", this.LaptopBattery.BatteryLife), Environment.NewLine));
            output.Append(string.Format("{0}{1}", new string('-', 79), Environment.NewLine));
        }
        output.Append(string.Format("|{0,-15}| {1,-60}|{2}", "Price", string.Format("{0:F2} lv.",this.Price), Environment.NewLine));
        output.Append(string.Format("{0}{1}", new string('-', 79), Environment.NewLine));


        return output.ToString();
    }

}
