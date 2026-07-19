//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Conditionals
//{
//    internal class SwitchStatements
//    {
//    }
//}


string firstName = "Sue";
int age = 43;

switch (age)
{
	case >= 0 and < 18:
        Console.WriteLine("You are a child.");
		break
	default:
        Console.WriteLine("Age was not in an expected range.");
		break;
}



//switch (firstName.ToLower())
//{
//    //case "sue":
//	case "tim" or "sue":
//        Console.WriteLine("Hello Professor.");
//        break;
//    case "tom":
//        Console.WriteLine("Hello Tom");
//        break;
//    default:
//        Console.WriteLine("I don't know you.");
//        break;
//}









//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Examples and Explanations :

//a switch statements is like a Bunch of if else if together . 

//but it isn't something we use a lot .

//we might look at it and say well it looks like an if statement but it says switch instead:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//switch (firstName.ToLower())
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//but this,isn't evaluating to true or false :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//firstName.ToLower()
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//this is a value of some type.

//it doesn't have to be even one value type ,we can change it in the next switch to a different value type. 

//so for right now it's a string. 

//we could put an int here instead . 

//we do have Curly braces { }

//and inside of the Curly braces { }, we need to evaluate or compare to this value :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//firstName.ToLower()
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//this is an example for one complete case statement:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string firstName = "Tim";
//int age = 43;

//switch (firstName.ToLower())
//{
//    case "tim":
//        Console.WriteLine("Hello Professor.");
//        break;
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//case statement:

//this piece :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//"tim"
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//will be compared to value of this :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//firstName.ToLower()
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//and if those 2 things match, it'll run the code inside the case:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//case "tim":
//Console.WriteLine("Hello Professor.");
//break;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//unlike most things in C#, the case statement doesn't get Curly braces { } .    

//instead we have a Colon :, and every thing below that gets run, until we see the break, and it's done .  

//that's all that switch statement does ,it looks to the case ,finds the first one that matches, runs that code :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.WriteLine("Hello Professor.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//and it breaks for the entire switch statement . 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//there's one more case type ,a special one ,called  default:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string firstName = "Tim";
//int age = 43;

//switch (firstName.ToLower())
//{
//    case "tim":
//        Console.WriteLine("Hello Professor.");
//        break;
//    case "tom":
//        Console.WriteLine("Hello Tom");
//        break;
//    default:
//        Console.WriteLine("I don't know you.");
//        break;
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//for default, unlike the case , where we're comparing this value :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//"tom":
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//against this value inside the parentheses of the switch:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//firstName.ToLower()
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//instead we default, we say :"run this if you don't find a match any where up top".    

//we need to think of the default like the else statement on if else.   

//that's the difference, is that we can have this case statements, the compare like an if statement.    

//so if "tim" equals firstName.ToLower(), then run this code :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.WriteLine("Hello Professor.");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//if firstName.ToLower(), equals "tom", run this code :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.WriteLine("Hello Tom");
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//it's actually an else if statement because it won't run this case statement :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//case "tim":
//Console.WriteLine("Hello Professor.");
//break;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//and this case statement:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//case "tom":
//Console.WriteLine("Hello Tom");
//break;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//as soon as it finds the first case that matches, it's done and it's exits the switch statement.   

//and if it doesn't find any thing that match, the default gets run:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//default:
//        Console.WriteLine("I don't know you.");
//break;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we don't have to have a default but we probably should because of the fact that if we don't have a match it can cause a problem.  

//so if we run this code :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string firstName = "Tim";
//int age = 43;

//switch (firstName.ToLower())
//{
//    case "tim":
//        Console.WriteLine("Hello Professor.");
//        break;
//    case "tom":
//        Console.WriteLine("Hello Tom");
//        break;
//    default:
//        Console.WriteLine("I don't know you.");
//        break;
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//it's says "Hello Professor." 

//because of the fact that it matches "tim". 

//lets change it to "Tom" and run:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string firstName = "Tom";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//and now it says "Hello Tom" 

//lets change this to "Tina" and run:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string firstName = "Tina";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//now it says "I don't know you." 

//so we see 3 different switch cases, based up on this names.   
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//now we put the default out and run:


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string firstName = "Tina";
//int age = 43;

//switch (firstName.ToLower())
//{
//    case "tim":
//        Console.WriteLine("Hello Professor.");
//        break;
//    case "tom":
//        Console.WriteLine("Hello Tom");
//        break;
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we see that nothing is written on the console, because there was nothing matches so it exits of the switch.  

//so we need the default to clean things up. 

//that's the basics of the switch statement .

//but there's so much more that it can do .
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//for example ,we have 2 professors for this class ,"Tim" and "Sue". 

//how we say "Hello Professor" on "Tim" and "Sue"?

//we could create another copy of this and have it say "Sue":


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//case "tim":
//Console.WriteLine("Hello Professor.");
//break;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//that's one way.

//we could also do a special way of doing things :


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string firstName = "Tina";
//int age = 43;

//switch (firstName.ToLower())
//{
//    case "sue":
//    case "tim":
//        Console.WriteLine("Hello Professor.");
//        break;
//    case "tom":
//        Console.WriteLine("Hello Tom");
//        break;
//    default:
//        Console.WriteLine("I don't know you.");
//        break;
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//and that's it. 

//and because of the fact that there is no code bellow "sue", and it'll run the code for "tim" when "sue" matches:    


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string firstName = "Sue";
//int age = 43;

//switch (firstName.ToLower())
//{
//    case "sue":
//    case "tim":
//        Console.WriteLine("Hello Professor.");
//        break;
//    case "tom":
//        Console.WriteLine("Hello Tom");
//        break;
//    default:
//        Console.WriteLine("I don't know you.");
//        break;
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//and we see "Hello Professor.". 

//so that's will happen if we have that fall through. 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//another way is with OR statement . 

//it's just o-r, not with ||.

//unlike the if statement ,or statement says if it's "tim" or if it's "sue": 


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string firstName = "Sue";
//int age = 43;

//switch (firstName.ToLower())
//{
//    case "tim" or "sue":
//        Console.WriteLine("Hello Professor.");
//        break;
//    case "tom":
//        Console.WriteLine("Hello Tom");
//        break;
//    default:
//        Console.WriteLine("I don't know you.");
//        break;
//}
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//we see "Hello Professor.". 

//this way we can have more complex case statements .

//but with names, there's not a lot of complexity that we can do.   
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//example with age.

//the person is between 0 and 17 .








//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~













