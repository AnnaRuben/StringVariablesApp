//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Conditionals
//{
//    internal class HomeWorkConditionalStatements
//    {
//    }
//}


Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

Console.Write("What is your last name: ");
string? lastName = Console.ReadLine();

if (firstName.ToLower() == "tim" &&
    lastName.ToLower() == "corey")
{
    Console.WriteLine("Hello Professor Corey");
}
else
{
    Console.WriteLine("Hello Student.");
}
