//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Conditionals
//{
//    internal class BasicIfStatements
//    {
//    }
//}

//bool isComplete = true; 

//if (isComplete)
//{
//    Console.WriteLine("The statement was true.");
//    Console.WriteLine("This line works in true.");
//}
//else
//{
//    Console.WriteLine("The statement was false.");
//    Console.WriteLine("This should also run");
//}

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Console.Write("What is your first name: ");
string? firstName = Console.ReadLine();

if (firstName == "Tim")
{
    Console.WriteLine("Hello Mr. Corey.");
}
else
{
    Console.WriteLine($"Helo {firstName}");
}

Console.WriteLine("End of program.");


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Examples and Explanations :

//If statements is very fundamental to how we work with C#.  

//a conditional allows us to have branching logic .
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//start with bool.

//initialize that to the initial value, by default - false    
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//first we have if. 

//then we have a set of (),

//and what ever's in the () is going to be evaluated to see if it's true.   


//~~~~~~~~~~
//if ()
//{

//}
//~~~~~~~~~~


//and we have open { ,and close } ,between them'll be the code running if what inside the () is true.   

//we have a bool, the bool's true or false. 

//if we say: 


//~~~~~~~~~~~~~~~~
//if (isComplete)
//{

//}
//~~~~~~~~~~~~~~~~ 


//that'll satisfy our if statement.

//because it's going to look at the bool, the bool is true or false.  

//we can say :


//~~~~~~~~~~~~~~~~
//if (isComplete)
//{
//    Console.WriteLine("The statement was true.");
//}
//~~~~~~~~~~~~~~~~ 


//at the very bottom we write :

//Console.WriteLine("End of program.");

//like this:


//~~~~~~~~~~~~~~~~
//if (isComplete)
//{
//    Console.WriteLine("The statement was true.");
//}


//Console.WriteLine("End of program.");
//~~~~~~~~~~~~~~~~ 


//and this's important because of the fact that right now (isComplete) is false.    

//which means we shouldn't run this code.

//is we'll set to true :

//bool isComplete = true;

//our code'll run, and we'll see our :

//Console.WriteLine("The statement was true.");


//~~~~~~~~~~~~~~~~
//bool isComplete = true;

//if (isComplete)
//{
//    Console.WriteLine("The statement was true.");
//}


//Console.WriteLine("End of program.");
//~~~~~~~~~~~~~~~~ 


//so based up on weather or not this expression/value is true or false :

//(isComplete)

//determine weather or not we're going to run this code :


//~~~~~~~~~~~~~~~~
//{
//    Console.WriteLine("The statement was true.");
//}
//~~~~~~~~~~~~~~~~
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//else statement 

//an else just says else ,

//and it has open { ,and close } 

//and we can say :

//Console.WriteLine("The statement was false.");

//just to show us what's running. 


//~~~~~~~~~~~~~~~~
//bool isComplete = true;

//if (isComplete)
//{
//    Console.WriteLine("The statement was true.");
//}
//else
//{
//    Console.WriteLine("The statement was false.");
//}


//Console.WriteLine("End of program.");
//~~~~~~~~~~~~~~~~


//so now we have if this's true : 

//if (isComplete)

//run this:

//{
//    Console.WriteLine("The statement was true.");
//}

//else/otherwise run this :

//{
//    Console.WriteLine("The statement was false.");
//}

//which mean ,we'll never have an occasion where both : 

//Console.WriteLine("The statement was true.");

//and this:

//Console.WriteLine("The statement was false.");

//run.

//it's one or the other .

//so if we change the bool to false :

//bool isComplete = false;

//it now says:

//"The statement was false."

//because it ran the else statement. 

//this's a basic if/else statement . 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//we didn't have to have the else statement.

//we can have just the if statement. 

//how ever ,we can't have just the else statement.

//because it has to have a relation ship to something, to know if it's true or false.  
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//this double equals == is a comparison right inside the () that'll return for us a boolean value, a true or a false  :   

//if (firstName == "Tim")

//it compares 2 values.

//so it's going to say :

//his first name equal to Tim.

//and it's going to return Boolean, Yes or No/True or false.

//we need to remember, those () evaluate a boolean value:

//(firstName == "Tim")







//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~






