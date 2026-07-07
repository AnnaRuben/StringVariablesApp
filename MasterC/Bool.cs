//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CommonVariables
//{
//    internal class Bool
//    {
//    }
//}

//true or false 

//bool isComplete = true;

//isComplete = !isComplete;

//Console.WriteLine(!isComplete);
//Console.WriteLine(isComplete);


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Examples and Explanations:

//A boolean is one of two values, it is ether true or false.    

//A Boolean can have two different states, one is true ,one is false, by default it's false.   

//true or false those are two key words that we can use.  
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Boolean used in an If statements, because in an If statements we say is this true ? or is this false ? that' what If statement is all about.  

//So there's a lot of times in C# we evaluate things to be ether true or false.     
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Although we said true:

//bool isComplete = true;

//by putting the not character ! before isComplete, we flipping the true statement to a false statement:  

//isComplete = !isComplete;

//so we can use the not character ! say the opposite of what ever the Boolean is and that can be useful, it's also a bit tricky because it's so easy to get lost in reading this word !isComplete, we might miss the fact that there's an Explanation point (!) in the beginning, but that's a pretty common thing to use that Explanation point (!) for, so this's how we flip a Boolean.                      
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//If we put in the Console.WriteLine an Explanation point (!):   

//bool isComplete = true;
//Console.WriteLine(!isComplete);

//that says it's not this, and so there for we're going to see that the value is false, so we can put it right in line.   

//to be clear, if we write like this and run in the Console :  

//bool isComplete = true;

//Console.WriteLine(!isComplete);
//Console.WriteLine(isComplete);

//we're going to get false and true, because we didn't actually modify isComplete in Console.WriteLine(!isComplete); we just modify the out put using isComplete, there for the actual variable still holds the same value so there for in Console.WriteLine(isComplete); becomes true again because it was always true, it's never been changed, it's just that we used a different value here by flipping the result.                        

//and Console.WriteLine(isComplete); will pint true  
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~