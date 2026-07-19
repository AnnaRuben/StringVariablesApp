//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CommonVariables
//{
//    internal class Double
//    {
//    }
//}

//Doubles can have a Decimal point - 1.23, 43 

//double averageAge;

//averageAge = (43.0 + 22 + 62) / 3;

//averageAge = 2.3 / 3;

//Console.WriteLine(averageAge);


















//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Examples and Explanations:

//Double is a little bit different then Int because Double can have a Decimal point.     

//Like 1.23 and 43, we ask why 43 ,it doesn't have a Decimal point .

//the answer is : 

//Technically It can have a Decimal point - 43.0 .

//But ether way that's fine, it doesn't have to have a Decimal point, it doesn't lock in to a Decimal point, but we can have a Decimal point in our Double .      
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//The result of this code'll be in Int:

//averageAge = (43 + 21 + 62) / 3;

//but if we'll write this the same code like that :

//averageAge = (43.0 + 21 + 62) / 3;

//that's now a Double, the result of this code'll be a Double = 42.333333333333336 

//Ints are assumed if they're a whole number but if we add .0(43.0) which's still the same number, the compiler see it like a Double in type and the compiler'll see the rest of the numbers and the result of them as a Double ,so we need to give the compiler a hint if we want Double.         
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Notice that an Integer can go in to a Double no problem, because it's going from less specific to more specific, so 43 can feat an Integer with a whole number and 43 can feat in to a Double with out changing anything because 43 is 43 but if we had the opposite direction trying to put a Double in to an Integer, like this number 1.23 ,we would have to cut of the .23 from it and that wouldn't work because we'll loose data, there for we can't put Double in to an Integer even if that Double is just 43 because the system doesn't know that it's always be the case.                          

//The keys here are that Doubles have Decimal points in them, or can have Decimal points in them and if you add 3 numbers like 43 + 21 + 62 and divide by 3 so because they're all assumed as an Integers by the compiler, the result'll be in an Integer value which then does go in to a Double but that looses our Decimal point in that division because of using an Integers, but if we say that one of them is a Double, the rest of them'll follow and it'll become a Double operation and that'll keep our Decimal values .                          
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//The big deal with Double here're that they hold Decimal point, and because they do, this is the most used numeric type when it comes to math.     

//with Doubles we can add, subtract, multiplication, divide, square root, anything we want to do basically we can do with Doubles, so what ever comes to do in math ,we'll see Doubles.               
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Math in .Net:

//write : Math. and it'll open the library . 

//they all operate with Doubles, because that is the most common used type for holding Decimal point numbers.          

//It's also the cheapest, the reason is where it rounds the value, they're not ultra precise ,there's some rounding with our Double, there's some rounding with every type, it just how it works ,but this is a little bit more efficient than other types because it does have a little less significant digits, we can use this for almost every operation when it comes to Decimal point numbers ,the exception would be money ,we don't use Doubles to store money because we want to have more precision when it comes to money.                       

//averageAge = 2.3 / 3;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~