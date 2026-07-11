//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CommonVariables
//{
//    internal class TypeConversions
//    {
//    }
//}

Console.Write("What's your age: ");
string? ageText = Console.ReadLine();

//Console.ReadLine(ageText + 15);

//int age = int.Parse(ageText);

//int age;

bool isValidInt = int.TryParse(ageText, out int age);

Console.WriteLine($"This is valid: {isValidInt}. The number was {age}.");

Console.WriteLine(age + 15);

double testDouble = age;








//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Examples and Explanation
//the difference between:

//Console.Write

//and:

//Console.WriteLine

//is that it doesn't add a new line at the end.   
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//types of variables we might want to convert : 

//the most common one is the concept of converting from a strig to something else .   

//we often get our values from the console or from something else and we treat them as strings    

//for example:

//Console.WriteLine("What's your age: ");

//we expect the user to type them out .  

//we can do a:

//Console.ReadLine();

//to capture that information. 

//this'll capture what ever the user types until they hit Enter, and we had use this in the past, but we can also use this to capture what ever they types.     

//so we would capture this in to a nullable string.   

//we can say:

//string? ageText = Console.ReadLine();

//we can declare separately : 

//string? ageText

//and we can declare inline: 

//string? ageText = Console.ReadLine();

//either way's fine .

//we called it ageText, because it's coming as a string. 

//so if we want to fined out how old the person'll be in 15 years, we can't say :  

//Console.WriteLine(ageText + 15);

//although the compiler doesn't gives us a warning, but is we run this, the console'll ask the user for the age, he'll type 43, hit Enter, the compiler'll write he'll be 4315 in 15 years .  

//what happened here ,we can use the plus sign ,not just for adding numbers, but also for adding strings.    

//so what it did was it took this number and said that it's a string, there for when you say plus, you really mean to treat this:

//15

//as a string, and then we append this string:

//15

//on to our:

//ageText

//which is:

//4315           

//that's not what we're looking for, that won't work, that isn't a good code  

//so how we get a string age in to a numeric age ?   

//int age = int.Parse(ageText);

//int.Parse

//the type, we say:

//.Parse

//and pass in our:

//ageText

//so we do that and we should get a number:

//Console.WriteLine(age);

//we run this and say in the console:

//43 

//and the compiler say 43.

//but we need to know age in 15 years :

//Console.WriteLine(age + 15);

//it'll say 58.

//notice it isn't:

//4315 anymore 

//because it has done a parse, it means the parse takes in a string, checks is it just a number rapt in quotes ,and if it's, take the quotes of, put it in to the age and call it good.           

//and it does that .

//but what happens if we think that the user would give us a number ,but we should never trust the user, because invariably we'll put this in the production and the user'll type something that we didn't expect, so we need to make sure that we plan for the unexpected.          

//for instance:

//the user'll write the number (age) in words (string):

//Forty Three

//well we might say that isn't a number.

//why isn't it ?

//because if we would type it out in a document, and we were going to reference the number 43, we might print out this F-o-r-t-y T-h-r-e-e, because that's a representation of a number, but from our program perspective that isn't a number.             

//so that string right there, our program isn't going to be intelligent enough to go oh... you really meant Forty Three the number.     

//it can't do that. 

//so we'll get a crush of our application, called "Unhandled Exception". 

//it's not a bad exception here because it gave us bad information.  

//we shouldn't try to figure out how to force throw bad information.  

//because if we do, we might be putting other stuff in our application, stuff that just doesn't work and so we want to make sure we don't have default values here or something else to try and pretend like it worked.        

//we want to say stop the process ,don't continue, we're done.   

//so now we need to handle the Exception properly, because if the user passes in Forty Three, or something else crazy ,then we have to know what to do with that.        

//we'll use a different type :

//int.TryParse(ageText, out int age);

//with that we're going to try to make this work, properly parse and take the quotes of, and if it succeeds, we're going to put the value in to age.     

//but if it fails, notice that TryParse returns a Boolean, so we can say:    

//bool isValidInt = int.TryParse(ageText, out int age);

//now we know if this's a valid Integer.  

//so we can say :

//Console.WriteLine($"This is valid: {isValidInt}. The number was {age}.");

//it'll print out weather or not it's valid, so true or false, and if it's false ,we can know and ignore the number but what the age is we'll print it out either way.         

//so it'll print out the invalid age which's the default value or it'll print out the actual converted value if it was a valid number.     

//lets point out :

//here :

//bool isValidInt = int.TryParse(ageText, out int age);

//we declare int age right in line and started using it. 

//and the reason we declared int age right in line like this, is because of the fact that otherwise we're declaring something and then putting a value in to it and it's a two step process that doesn't have to be two step process.          

//how ever ,we can make it a two step process.  

//we can say :

//int age;

//bool isValidInt = int.TryParse(ageText, out age);

//so we call it :

//TryParse method  

//we're passing in :

//ageText our text 

//we're saying this :

//out age is an out variable

//which means that ,we're going to return a value of a boolean but we also return a value in this:

//age variable too, if this's valid  
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//lets run this :

//Console.Write("What's your age: ");
//string? ageText = Console.ReadLine();

//bool isValidInt = int.TryParse(ageText, out int age);

//Console.WriteLine($"This is valid: {isValidInt}. The number was {age}.");

//Console.WriteLine(age + 15);

//on the console: "What's your age: "

//we'll write the numeric form, 43 

//and it'll say on the console: "This is valid: True. The number was 43. 58"

//so that works, but what if we run it again and this time say :

//on the console: "What's your age: "

//Forty Three

//which isn't a valid age,the text representation of a number ,isn't the same thing.

//and it'll say on the console: "This is valid: False. The number was 0. 15"

//The number was 0, that's default value for age.

//notice that we see 15, this is where it gets in to a Gray area where we probably don't want to do this, where with out the if statement, that say if it's invalid, stop the process, we continue it on,and so we treated age as 0 because it's the default value for an Integer, and so we said the age plus 15 is 15 and that isn't right.               

//so that's where we're getting in to a treaky bit where some times parse is the right option because we want to stop everything and parse'll definitely do that if we give it wrong information.      

//so we need to notice that it:

//Console.WriteLine($"This is valid: {isValidInt}. The number was {age}.");

//continue to run our application regardless of weather or not this :   

//{isValidInt}

//was valid and that's where we need to be care full with.  
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//that's TryParse.

//we have TryParse on practically every variable type .

//Boolean, Double ,Decimal, Integer and so on .   

//so there's the idea that we have to parse to make sure the value's valid because some times it isn't going to be valid.        
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//there's another way to convert from one value to another:   

//double testDouble = age;

//that'll work, because we can put an Integer in to a Double, because we aren't loosing any information . 

//and if we say :

//decimal testDecimal = testDouble;

//that won't work, because of the fact that we're converting from double to decimal.

//we could do what's called a cast.

//and that cast's going to say ,this is actually a decimal :

//decimal testDecimal = (decimal)testDouble;

//it means that we're going to treat this as a decimal because of the fact that it's still a decimal point number ,it's just the precision're different, we're going to say that we don't care, we can put it in to a decimal type.       

//so we can convert one to another if we cast it. 

//we can't always cast things, so there're some things that we can't cast based up on a logic of how it works, but if we can, we can always do this :

//(decimal)

//and say we know, we're going to essentially do a conversion but that conversion's just saying, yes we want it to be another type.      
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~