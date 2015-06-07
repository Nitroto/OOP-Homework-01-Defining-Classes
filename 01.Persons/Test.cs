using System;

/// Define a class Person that has name, age and email. The name and age are mandatory. The email is optional. Define properties that accept 
/// non-empty name and age in the range [1 ... 100]. In case of invalid arguments, throw an exception. Define a property for the email that 
/// accepts either null or non-empty string containing '@'. Define two constructors. The first constructor should take name, age and email. 
/// The second constructor should take name and age only and call the first constructor. Implement the ToString() method to enable printing persons at the console.

class Test
{
    static void Main()
    {
        Person person1 = new Person("Ivan Petrov", 21, "ivan@petrov.bg");
        Console.WriteLine(person1);
        Person person2 = new Person("Petar Ivanov", 22);
        Console.WriteLine(person2);
        Person person3 = new Person("", 12, "blank@empty.com");
        Console.WriteLine(person3);
        //...
    }
}
