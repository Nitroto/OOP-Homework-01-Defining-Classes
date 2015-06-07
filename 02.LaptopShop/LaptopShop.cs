using System;
using System.Globalization;
using System.Threading;

/// Define a class Laptop that holds the following information about a laptop device: model, manufacturer, processor, RAM, graphics card, HDD, screen, battery, battery life in hours and price.
///•	The model and price are mandatory.All other values are optional.
///•	Define two separate classes: a class Laptop holding an instance of class Battery.
///•	Define several constructors that take different sets of arguments(full laptop + battery information or only part of it). Use proper variable types.
///•	Add a method in the Laptop class that displays information about the given instance
///o Tip: override the ToString() method
///•	Put validation in all property setters and constructors. String values cannot be empty, and numeric data cannot be negative.Throw exceptions when improper data is entered.

class LaptopShop
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Laptop sampleLaptop = new Laptop("HP 250 G2", 699M);
        Console.WriteLine(sampleLaptop);

        Laptop fullLaptop = new Laptop("Lenovo Yoga 2 Pro", 2259.00M, "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",8,
                                        "Intel HD Graphics 4400", "128GB SSD", "13.3\"(33.78 cm) – 3200 x 1800(QHD +), IPS sensor display", 
                                        new Battery("Li - Ion, 4 - cells, 2550 mAh", 4.5));
        Console.WriteLine(fullLaptop);
    }
}
