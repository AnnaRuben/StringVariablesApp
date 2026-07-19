//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Conditionals
//{
//    internal class AdvencedIfStatements
//    {
//    }
//}

//Console.Write("What is your first name; ");
//string firstName = Console.ReadLine();

//Console.Write("What is your last name; ");
//string lastName = Console.ReadLine();

//if (firstName.ToLower() == "tim" &&
//    lastName.ToLower() == "corey")
//{
//    Console.WriteLine("Hello Professor Corey");
//}
//else if (firstName.ToLower() == "tim" ||
//         lastName.ToLower() == "corey")
//{
//    Console.WriteLine("You have a great part in your name.");
//}
//else
//{
//    Console.WriteLine("Hello Student.");
//}







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
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~







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
////~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



//int age = 73;

// ==, >, >=, <, <=, != (! =)->means not equal
//if (age != 43)
//{
//    Console.WriteLine("Sorry ,you aren't a great age.");
//}



//if ((age >= 40 && age < 50) ||
//    (age >= 70 && age < 80))
//{
//    Console.WriteLine("You are in your 40's or 70's");
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
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Example -> Common mistake without .ToLower:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//if (firstName = "tim")
//{
//    Console.WriteLine("You have a cool first name.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//visual studio gives us an Error saying :

//"Cannot implicitly convert type 'string' to 'bool'".

//that Error's hard to understand. 

//this Error's because we have one = here.

//one = is a problem because, it's assignment, means it put "tim" in to the variable firstName.   

//after that it evaluate the variable firstName ,to see if it's true or false, but it's a string, so it's says that it can't convert a string to bool.   

//notice, that technically works, but it'a a bad code :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//bool isComplete = false;

//if (isComplete = true)
//{
//    Console.WriteLine("You have a cool first name.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//because it's not a comparison, instead we put the value true in variable isComplete, after that evaluate isComplete. 

//if we run this code, it'll say:

//"You have a cool first name."

//because isComplete = true, because we assigned this value first and after that compare it.  

//notice:

//one =, is assignment .

//2 ==, is comparison.


//the correct code is :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//bool isComplete = false;

//if (isComplete == true)
//{
//    Console.WriteLine("You have a cool first name.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//other options :

// > (greater than)

//if it's 100:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 100;

//if (age > 100)
//{
//    Console.WriteLine("You are up there in years.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//no console writeline .

//if it's 101:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 101;

//if (age > 100)
//{
//    Console.WriteLine("You are up there in years.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we get Console WriteLine "You are up there in years."

//because it's > (greater than).

// >= (greater than or equals to)

//if it's 100:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 100;

//if (age >= 100)
//{
//    Console.WriteLine("You are up there in years.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we get Console WriteLine "You are up there in years."

//because it's >= (greater than or equals to).

// <= (less than or equals to)

//if it's 100:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 100;

//if (age <= 100)
//{
//    Console.WriteLine("You still have a ways to go.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we get Console WriteLine "You still have a ways to go."

//if it's 101:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 101;

//if (age <= 100)
//{
//    Console.WriteLine("You are up there in years.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//no console writeline .

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//ranges:

//if we are 101:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 101;

//if (age >= 40 && age < 50)
//{
//    Console.WriteLine("You are in your 40's");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//no console writeline .

//because we're out of that range .

//if we are 43:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 43;

//if (age >= 40 && age < 50)
//{
//    Console.WriteLine("You are in your 40's");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we get Console WriteLine "You are in your 40's"

//if we are 39:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 39;

//if (age >= 40 && age < 50)
//{
//    Console.WriteLine("You are in your 40's");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//no console writeline, out of range .

//if we are 49:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 49;

//if (age >= 40 && age < 50)
//{
//    Console.WriteLine("You are in your 40's");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we get Console WriteLine "You are in your 40's"

//if we are 40:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 40;

//if (age >= 40 && age < 50)
//{
//    Console.WriteLine("You are in your 40's");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we get Console WriteLine "You are in your 40's"

//if we are 50:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 50;

//if (age >= 40 && age < 50)
//{
//    Console.WriteLine("You are in your 40's");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//no console writeline, out of range .
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
// != (not equal ! =) 

//if we're 50:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 50;

// ==, >, >=, <, <=, != (! =)->means not equal
//if (age != 43)
//{
//    Console.WriteLine("Sorry ,you aren't a great age.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//Console WriteLine "Sorry ,you aren't a great age."

//because we're 50 and our if is not equal to 43.

//if we're 43:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 43;

// ==, >, >=, <, <=, != (! =)->means not equal
//if (age != 43)
//{
//    Console.WriteLine("Sorry ,you aren't a great age.");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//no console writeline .

//because we're 43.

//we'll get console writeline only when age not equal to 43.
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//|| (or)

//in || (or) statements in either side is true ,then the whole statement's true .  

//meaning ,either one of those can be true and the whole statement consider to be true:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//if (firstName.ToLower() == "tim" &&
//    lastName.ToLower() == "corey")
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//not like the && (and) statements, when both sides have to be true in order the statement to be true .


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.Write("What is your first name; ");
//string firstName = Console.ReadLine();

//Console.Write("What is your last name; ");
//string lastName = Console.ReadLine();

//if (firstName.ToLower() == "tim" &&
//    lastName.ToLower() == "corey")
//{
//    Console.WriteLine("Hello Professor Corey");
//}
//else if (firstName.ToLower() == "tim" ||
//         lastName.ToLower() == "corey")
//{
//    Console.WriteLine("You have a great part in your name.");
//}
//else
//{
//    Console.WriteLine("Hello Student.");
//}

//int age = 43;

//if (age >= 40 && age < 50)
//{
//    Console.WriteLine("You are in your 40's");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//lets say "Tim" "Corey"

//we get:

//Console.WriteLine "Hello Professor Corey" and "You are in your 40's" 

//lets say "Tim" "Smith"

//we get:

//Console.WriteLine "You have a great part in your name." and "You are in your 40's" 

//lets say "Sue" "Corey"

//we get:

//Console.WriteLine "You have a great part in your name." and "You are in your 40's"

//lets say "Sue" "Storm"

//we get:

//Console.WriteLine "Hello Student." and "You are in your 40's"
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//we can make these evaluations more complex ,but it's not a good idea.

//for example,we can say age greater than or equal to 40 and age less than 50 and age greater than or equal to 70 and age less than 80:    


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 43;

//if (age >= 40 && age < 50 && age >= 70 && age < 80)
//{
//    Console.WriteLine("You are in your 40's");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//not recommended ,because this statement'll never evaluates to true. 

//because if the age now's 43 :

//age >= 40 = true

//age < 50 = true

//age >= 70 = false 

//there for this whole thing's false .

//this is also ,age < 80 = true, but the evaluation'll fail.

//we might think that we nee to put || (or) here :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 43;

//if (age >= 40 && age < 50 || age >= 70 && age < 80)
//{
//    Console.WriteLine("You are in your 40's");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//it works because it checks:

//age >= 40 and age < 50

//or

//age >= 70 and age < 80 .

//and we get:

//Console WriteLine "You are in your 40's".

//if we put 73:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 73;

//if (age >= 40 && age < 50 || age >= 70 && age < 80)
//{
//    Console.WriteLine("You are in your 40's or 70's");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//it works, we get:

//Console WriteLine "You are in your 40's or 70's"

//but we leave it up to the compiler to figure it out what the ands and ors and how they work in order ,and may be we didn't mean that or to be the or.    

//so we use parentheses and say this's the order we want go in:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 73;

//if ((age >= 40 && age < 50) || (age >= 70 && age < 80))
//{
//    Console.WriteLine("You are in your 40's or 70's");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//now it'll evaluate this first:

//(age >= 40 && age < 50)

//and say or this second:

//(age >= 70 && age < 80)

//but if we want ,we can say :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 73;

//if (age >= 40 && (age < 50 || age >= 70) && age < 80)
//{
//    Console.WriteLine("You are in your 40's or 70's");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//now we say :

//this age >= 40 

//and of those (age < 50 || age >= 70), because of the || (or) 

//and this one age < 80

//we use the parentheses to change the evaluation set .

//so the best way, if we have multiple in, even just 3 things (unless they're all the same type, meaning all're going to be &&'s (and) or all're going to be ||'s (or)) , group them using parentheses:   


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 73;

//if ((age >= 40 && age < 50) || (age >= 70 && age < 80))
//{
//    Console.WriteLine("You are in your 40's or 70's");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//this way we're very clear ,not only with the compiler, also with who ever comes after us ,they don't have to guess what we meant.   

//also we can make it easy to read ,write like this :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//int age = 73;

//if ((age >= 40 && age < 50) ||
//    (age >= 70 && age < 80))
//{
//    Console.WriteLine("You are in your 40's or 70's");
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~