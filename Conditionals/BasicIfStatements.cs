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

//Console.Write("What is your first name: ");
//string? firstName = Console.ReadLine();

//string lastName;

//if (firstName.ToLower() == "tim")
//{
//Console.WriteLine("Hello Mr. Corey.");
//lastName = "Corey";
//}
//else
//{
//    Console.WriteLine($"Helo {firstName}");
//    lastName = "Smith";
//}

//Console.WriteLine(lastName);
//Console.WriteLine("End of program.");






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


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//what if the user write tIM :


//~~~~~~~~~~~~~~~~
//Console.Write("What is your first name: ");
//string? firstName = Console.ReadLine();

//if (firstName == "Tim")
//{
//    Console.WriteLine("Hello Mr. Corey.");
//}
//else
//{
//    Console.WriteLine($"Helo {firstName}");
//}

//Console.WriteLine("End of program.");
//~~~~~~~~~~~~~~~~


//why did it not say when the value was Lower case t, Upper case IM :

//"Hello Mr. Corey."

//is because of the if statement:

//if (firstName == "Tim")

//this evaluates to false, so why this evaluates to false ?  

//because it's case sensitive, so Capital T, Lower case im is the only way that Tim'll match Tim.

//is that really what we want ?

//No, because that isn't really robust.

//there's a method of a string ,we can say:

//.ToLower()

//if (firstName.ToLower() == "tim")

//it converts the string of a first name to lower case.

//now it doesn't matter the casing.  

//just to point that out ,it doesn't modify the original variable.

//we're going to use:

//.ToLower()

//quite a bit probably when we're talking about strings if we're doing a string comparison like this :

//if (firstName.ToLower() == "tim")
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//note, we can have nested if statements.  


//~~~~~~~~~~~~~~~~
//Console.Write("What is your first name: ");
//string? firstName = Console.ReadLine();

//if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("Hello Mr. Corey.");
//}
//else
//{
//    Console.WriteLine($"Helo {firstName}");
//}

//Console.WriteLine("End of program.");
//~~~~~~~~~~~~~~~~


//we can put in this section another if statement :


//~~~~~~~~~~~~~~~~
//if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("Hello Mr. Corey.");
//}
//~~~~~~~~~~~~~~~~


//it's up to us if we want to do this, that's possible, we can put variables, if statements.

//for example ,we create a variable with hard code :


//~~~~~~~~~~~~~~~~
//Console.Write("What is your first name: ");
//string? firstName = Console.ReadLine();

//if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("Hello Mr. Corey.");
//    string lastName = "Corey";
//}
//else
//{
//    Console.WriteLine($"Helo {firstName}");
//}


//Console.WriteLine(lastName);
//Console.WriteLine("End of program.");
//~~~~~~~~~~~~~~~~


//notice ,it doesn't show us intellisense, and if we try and type it anyways, it says "The name 'lastName' does not exist in the current context".   

//that's because this variable was created inside of this scope:


//~~~~~~~~~~~~~~~~
//{
//    Console.WriteLine("Hello Mr. Corey.");
//    string lastName = "Corey";
//}
//~~~~~~~~~~~~~~~~


//which means it doesn't go out side of that scope.

//we can send things into a scope but not out.

//if we want to change this to be useable outside, we need to declare it at the top and then we can say:

//lastName = "Corey";

//looks like this :


//~~~~~~~~~~~~~~~~
//Console.Write("What is your first name: ");
//string? firstName = Console.ReadLine();

//string lastName;

//if (firstName.ToLower() == "tim")
//{
//    Console.WriteLine("Hello Mr. Corey.");
//    lastName = "Corey";
//}
//else
//{
//    Console.WriteLine($"Helo {firstName}");
//    lastName = "Smith";
//}

//Console.WriteLine(lastName);
//Console.WriteLine("End of program.");
//~~~~~~~~~~~~~~~~


//but now, we modified the variable inside the scope but because was created in the parent scope, then we can access it again in the parent scope.      
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


