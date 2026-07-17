//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Conditionals
//{
//    internal class AdvencedIfStatements
//    {
//    }
//}

Console.Write("What is your first name; ");
string firstName = Console.ReadLine();

Console.Write("What is your last name; ");
string lastName = Console.ReadLine();

//if (firstName.ToLower() == "tim" &&
//    lastName.ToLower() == "corey")
//{
//    Console.WriteLine("Hello Mr. Corey.");
//}
//else if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("Hello, you have a cool first name.");
//}
//else if (firstName.ToLower() == "corey")
//{
//    Console.WriteLine("You have a great last name.");
//}
//else
//{
//    Console.WriteLine("Sorry you don't have a cooler name!");
//}


//if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("You have a cool first name.");
//}

//if (lastName.ToLower() == "corey")
//{
//    Console.WriteLine("You have a great last name.");
//}
//else
//{
//    Console.WriteLine("Sorry your name isn't cooler.");
//}



//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Examples and Explanations :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.Write("What is your first name; ");
//string firstName = Console.ReadLine();

//Console.Write("What is your last name; ");
//string lastName = Console.ReadLine();

//if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("Hello Mr. Corey.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//&&

//Console.Write("What is your first name; ");
//string firstName = Console.ReadLine();

//Console.Write("What is your last name; ");
//string lastName = Console.ReadLine();

//if (firstName.ToLower() == "tim" && lastName.ToLower() == "corey")
//{
//    Console.WriteLine("Hello Mr. Corey.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//the first name and the last name have to be true, if that's the case ,say "Hello Mr. Corey."  

//notice, we can have a lot of these, but the line'll be very large, we can put a line break and C#'ll understand because it reads by the opening and closing of the parentheses ().     

//and it helps us logically because it's very easy to read a line after line this way: 


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.Write("What is your first name; ");
//string firstName = Console.ReadLine();

//Console.Write("What is your last name; ");
//string lastName = Console.ReadLine();

//if (firstName.ToLower() == "tim" &&
//    lastName.ToLower() == "corey")
//{
//    Console.WriteLine("Hello Mr. Corey.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//don't do this line break ,bad line break:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.Write("What is your first name; ");
//string firstName = Console.ReadLine();

//Console.Write("What is your last name; ");
//string lastName = Console.ReadLine();

//if (firstName.ToLower() == "tim" &&
//    lastName.ToLower() == "corey")
//{
//    Console.WriteLine(
//        "Hello Mr. Corey."
//        );
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//else if

//the else statement occurs if this first thing is false, meaning not "tim" and not "corey" : 


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//if (firstName.ToLower() == "tim" &&
//    lastName.ToLower() == "corey")
//{
//    Console.WriteLine("Hello Mr. Corey.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//so we can say else if:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.Write("What is your first name; ");
//string firstName = Console.ReadLine();

//Console.Write("What is your last name; ");
//string lastName = Console.ReadLine();

//if (firstName.ToLower() == "tim" &&
//    lastName.ToLower() == "corey")
//{
//    Console.WriteLine("Hello Mr. Corey.");
//}
//else if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("Hello, you have a cool first name.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//if we type "tim" "corey", this won't run:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//else if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("Hello, you have a cool first name.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//because "tim" "corey", both're true.

//this else if statement means if the above's false. 

//so it'll stop after this :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//if (firstName.ToLower() == "tim" &&
//    lastName.ToLower() == "corey")
//{
//    Console.WriteLine("Hello Mr. Corey.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//we can add another else if :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.Write("What is your first name; ");
//string firstName = Console.ReadLine();

//Console.Write("What is your last name; ");
//string lastName = Console.ReadLine();

//if (firstName.ToLower() == "tim" &&
//    lastName.ToLower() == "corey")
//{
//    Console.WriteLine("Hello Mr. Corey.");
//}
//else if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("Hello, you have a cool first name.");
//}
//else if (firstName.ToLower() == "corey")
//{
//    Console.WriteLine("You have a great last name.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//this'll run :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//else if (firstName.ToLower() == "corey")
//{
//    Console.WriteLine("You have a great last name.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//only if this's false :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//else if (firstName.ToLower() == "tim")
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//because if this's true :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//else if (firstName.ToLower() == "tim")
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//it'll run this code, and be done, it won't run nothing else :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//{
//    Console.WriteLine("Hello, you have a cool first name.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//notice ,we have a lot of else if statements 

//we can only have one else 

//we can only have one if, when they're chain together.  
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//example for not chain together :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("You have a cool first name.");
//}

//if (lastName.ToLower() == "corey")
//{
//    Console.WriteLine("You have a great last name.");
//}
//else
//{
//    Console.WriteLine("Sorry your name isn't cooler.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//if we run this code and say "Tim" "Corey", it'll say :

//"You have a cool first name." and "You have a great last name." 

//it says both because they aren't chained. 

//in order to chain ,we have to have the else if:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("You have a cool first name.");
//}
//else if (lastName.ToLower() == "corey")
//{
//    Console.WriteLine("You have a great last name.");
//}
//else
//{
//    Console.WriteLine("Sorry your name isn't cooler.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we run this code ,and it say "You have a cool first name." 

//but what about the last name ?

//because the section of the last name is in the else if statement ,means it run nle if the above's (first name) false. 

//but the above (first name) statement was true. 

//notice ,some time we need 2 separate if statements. 

//because we want to run 2 different bits of code ,if different things match,ad they're separate, like this :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("You have a cool first name.");
//}

//if (lastName.ToLower() == "corey")
//{
//    Console.WriteLine("You have a great last name.");
//}
//else
//{
//    Console.WriteLine("Sorry your name isn't cooler.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//if we need to check both first name and last name. 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//else.

//this else's a clean up.

//if non of the other things runs ,this else will run: 


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.Write("What is your first name; ");
//string firstName = Console.ReadLine();

//Console.Write("What is your last name; ");
//string lastName = Console.ReadLine();

//if (firstName.ToLower() == "tim" &&
//    lastName.ToLower() == "corey")
//{
//    Console.WriteLine("Hello Mr. Corey.");
//}
//else if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("Hello, you have a cool first name.");
//}
//else if (firstName.ToLower() == "corey")
//{
//    Console.WriteLine("You have a great last name.");
//}
//else
//{
//    Console.WriteLine("Sorry you don't have a cooler name!");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~





























































































































