using LevelUp.CsharpJuniors.Hometasks.Lesson2.Models;
using static System.Formats.Asn1.AsnWriter;
using System.Security.Cryptography;

// Начало задания из презентации

Console.WriteLine("Let's play with C#");
Console.WriteLine("Enter user data");

string firstName, surname, hobby;
int age;

Console.WriteLine("Write your name:");

while (string.IsNullOrEmpty(firstName = Console.ReadLine() ?? string.Empty))
{
    Console.WriteLine("Incorrect input, please, try again!");
}

Console.WriteLine("Write your surname:");

while (string.IsNullOrEmpty(surname = Console.ReadLine() ?? string.Empty))
{
    Console.WriteLine("Incorrect input, please, try again!");
}

Console.WriteLine("Write your age:");

while (int.TryParse(Console.ReadLine() ?? string.Empty, out age) == false || age < 0 || age > 122)
{
    if (age > 122) Console.WriteLine("You are very old, you are not from this planet! Try again");
    else
    if (age < 0) Console.WriteLine("When you're born, come! Try again");
    else
        Console.WriteLine("Incorrect input, please, try again!");
}

Console.WriteLine("Write your hobby:");

while (string.IsNullOrEmpty(hobby = Console.ReadLine() ?? string.Empty))
{
    Console.WriteLine("Incorrect input, please, try again!");
}

var human = new Human(firstName, surname, age, hobby);

human.PrintParametrs();

//Начало 11 задания из репозитория

Console.WriteLine("\nEnter store data:");
Console.WriteLine("Enter the name of the store, then the address of the store");
var store = new Store(Console.ReadLine(), Console.ReadLine());
store.PrintInfo();

Console.ReadLine();