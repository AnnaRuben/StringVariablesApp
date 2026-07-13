//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CommonVariables
//{
//    internal class Decimal
//    {
//    }
//}


//Doubles - 4.12, 32, 1.234
//Decimal - 4.12, 32, 1.234

//Int32 - 00000000 00000000 00000000 00000001

//decimal bankAccountBalance;

//bankAccountBalance = 2.34M;

//Console.WriteLine(bankAccountBalance);













//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Examples and Explanations:

//We ask why do we have two different numbers, different variables that holds Decimal point numbers and why is that Double the preferred and yet it's stores Decimal point numbers and we have Decimal type, is Decimal not the perfect name for a number that holds a Decimal point ?          

//So yes we have two different types, but there's a difference:   

//Decimal is the more precise of the two (Double/Decimal). 

//so it stores numbers out to a rounding value about 28 positions, so we can have a Decimal point and a 28 numbers that aren't rounded until after that, so that's the precision that a Decimal can store, so why don't we use this for everything ?                

//just like with everything else in software development, it's a cost benefit analysis.       

//there'a an additional cost to an additional storage space that used for every single variable.         

//remember, variables have to be stored in memory just like everything else in our code.    

//so when we put a we reserve space in memory for a Decimal number ,we have to reserve a much larger spot.    

//like for example :

//we have Int32 - 00000000 00000000 00000000 00000000 

//so in memory, this is what's getting stored :

//00000000 00000000 00000000 00000000

//even if our number is one :

//00000000 00000000 00000000 00000001

//we're allocating all that space :

//00000000 00000000 00000000 00000001 , for 1

//we didn't know it's going to be 1,and we didn't know that's all it's going to be because if we did we could have stored it in a much smaller space in memory.   

//the same thing is true for Doubles and Decimals in a fact that we store based up on the size of the type.     

//Decimal is a much larger amount of storage in memory than a Double is.     

//so for most things we don't really care, we don't really care to have that ultra precision, so that's why for most operations we use Doubles, because not only are they cheaper to store but then we do things like multiply or add, it's cheaper to work with ,to calculate out the resulting value if it's a shorter number, there for we use Doubles.                    

//we use Decimals for really impractical terms, we use it for one thing and that is for money.      

//but for anything besides astronomical units and money we avoid Decimal.    
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//for example :

//bankAccountBalance = 2.34;

//the compiler is'nt allowing to write this way ,because that is a Double, but we say that this's a Decimal, no we can't.     

//we need to remember that we don't want to do conversions of types, there're times we can't do an implicit conversion like when we put an Int in to a Double but we're looking at this Double, we can't just put that in to a Decimal.              

//because we wouldn't cut anything off but this value has been technically rounded as the 15th to 16th place in it's number, it's all zeros so it doesn't matter but it's less precise than it would be if it was a Decimal, there for we're going to put a less precise value in to bankAccountBalance than it's expecting so that means there's a problem with that type conversion, we're going to be putting bad data essentially in to our Decimal, so we can't do that.                              

//but we may say that yeah but it's just a number so and it's just 2.34, we shell put that in to a Decimal.    

//well for constants like this , we have to say that this constant a Decimal by putting M in the end like this :  

//bankAccountBalance = 2.34M;

//the M is for the ease of use as the word "Money"  

//M is the indicator that has been chosen to identify that the number we see in front of it is a Decimal number.    

//in most times in code we aren't putting actual values in to a variable, we aren't hard coding, we ask the user for that information or we're getting it from the database, in those cases the information'll come in as a correct type.         

//but if we just typing it out and the compiler has to figure the type out, it'll think it's a Double and that isn't what we're looking for so we just need to put M in the end.     
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//most of the operations don't work.  

//so for example add ,subtract ,multiply ,divide, we don't typically think of these as returning Decimals, we think of them as returning Doubles.         

//because again, they're cheaper to do with Doubles, we can technically do it with Decimals but all of Microsoft built in Math Stuff works with Doubles and not Decimals.           

//if we use Decimal to store a number, it's most likely Dollars.    

//so how often we multiply our bank balance or divide our bank balance.... in general we don't do math operations of multiplications and division and square root on bank balance as a run money in general, instead we do things like add and subtract.               

//so that's why we don't see a lot of built in math stuff around Decimal, because Decimal primarily holds things like money and astronomical units, otherwise it's just too expensive to work with and so we use Doubles            
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~




















