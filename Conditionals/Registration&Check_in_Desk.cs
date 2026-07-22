//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Conditionals
//{
//    internal class MiniProject
//    {
//    }
//}





using System.Globalization;

Console.Write("Hello user! What is your first name? ");
string? firstName = Console.ReadLine();

Console.Write($"Hello {firstName}! What is your last name? ");
string? lastName = Console.ReadLine();

Console.Write($"Hello {firstName} {lastName}! How old are you? ");
string? textAge = Console.ReadLine();
bool isValidAge = int.TryParse(textAge, out int age);

if (!isValidAge)
{
    age = 0;
}

decimal? walletBudget = 150.50M;

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

TimeOnly openingTime = TimeOnly.Parse("08:30");
DateOnly dateOfBirth = DateOnly.ParseExact("15/06/1998", "dd/MM/yyyy", CultureInfo.InvariantCulture);
Console.WriteLine($"Hello everybody, Check in starts at {openingTime} on {dateOfBirth}");

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



if (firstName.ToLower() == "tim" &&
    lastName.ToLower() == "cory")
{
    Console.WriteLine("Hello Professor Corey, VIP Access Granted!.");
}
else if (firstName.ToLower() == "bob" ||
         firstName.ToLower() == "sue")
{
    Console.WriteLine("Welcome back, Staff Member.");
}
else
{
    Console.WriteLine("Hello Student, welcome to the conference.");
}

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

switch (age)
{
    case >= 0 and < 18:
        Console.WriteLine($"You are a minor, you have {18 - age} years left. Please get a guardian's signature.");
        break;
    case >= 18 and < 65:
        Console.WriteLine("Full access granted to all tech talks.");
        break;
    case > 65:
        Console.WriteLine("Welcome! Ask about our senior developer lounge.");
        break;
    default:
        Console.WriteLine("Welcome! Ask about our senior developer lounge.");
        break;
}

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

string? filePath = @"C:\Conference\Tickets\2026";
Console.WriteLine($"My file path is {filePath}");

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~










