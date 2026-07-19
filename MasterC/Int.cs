//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace StringVariables
//{
//    internal class Int
//    {
//    }
//}

//Yes: 2, 18, 2854, -9

//No: 1.2, -5.7

//int age = 0;

//age = 43;

//int ageInTenYears = age + 10;

//Two billion +/-
//signed Int32
//unsigned - 4 Billion 
//bit - 0 or 1 
//byte - 1 byte or 8 bits - 00000000
//1, 11, 111

//Console.WriteLine(age);
//Console.WriteLine(ageInTenYears);

//don't divide ints - Console.WriteLine(age / 2);


















//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Examples and Explanations:

//Holds whole numbers. 

//we can manipulate it. 

//add,subtract, multiply, are great with Integers . 


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Int type

//to declare a variable , we declare type.

//Int = Integer ,means a whole number, integers holds a whole numbers. 

//whole numbers are any numbers that don't have decimal point in them:   

//whole numbers: 2, 18, 2854, -9

//Not whole numbers: 1.2, -5.7

//Decimals won't work in Integers.

//the initial value of an Int if we don't assign to it is 0 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//We don't use "" around the number 43, because it isn't a String:

//age = 43;

//If we would put "" around the number: 

//age = "43";

//we would have an error because we can't put a String in to an Int, types don't cross.

//we can print it on the Console:

//Console.WriteLine(age);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Convert Int to a String:

//Console.WriteLine(age.ToString());

//It take the value in the Int called age and convert it to a String. 

//in this case ,Console.WriteLine(age.ToString()); takes the number 43 and put around it ""
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//How big is this Int can be :

//a little bit bigger than Two Billion +/- (meaning positive 2 billion and negative 2 billion) 

//technically behind the scenes it's called:  

//signed Int32

//signed means plus sign or minus sign (we don't show the plus sign just because we all know that if there's no sign it means positive), but essentially it has a plus or minus.         

//If there's signed, there's also unsigned, it means that it can hold 4 Billion.     

//Normally we use signed Int32 because it's stores 2 billion un a positive direction and 2 billion in a negative direction and that is all that we need     
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//There's also UInt32, it represents 32-bit unsigned integer
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//A bit is a 0 or 1 .

//It's what computers use, essentially it's a gate ,is the gate open or is the gate close, that's all it is, so we have our open and close values, open is 0 ,close is 1, this is binary and we don't necessary deal with binary in C# that often ,in fact practically never ,but it's based upon that binary system we're talking about our data and how it works so we'll see the concept of bits and bytes.                     

//a bit is a 0 or 1  

//a 1 byte is 8 bits ,also known as a 00000000(8-zeros), and any of this zeros can be 1's.     

//Counting in binary:   

//it's very important to understand this at his point and yet although it may seem a little bit theoretical but it absolutely not, new developers get this confused and make decisions based upon their confusion.             

//1 bit: 

//a 0 represents a 0 a 1 represents number 1.    

//2 bits: 

//00 ,represents 0.  

//01 represents 1.  

//10 represents 2 

//11 is 3 

//that's how binary counts. 

//11 can do 0, 1, 2, 3, that's 4 numbers.  

//1 - we can do 2 numbers, 0 or 1, 11 can do twice as many with just one more bit.     

//000 - can do 0 - 000, 1 - 001, 2 - 010, 3 - 011, 4 - 100, 5 - 101, 6 - 110, and 7 - 111, so we can do 0 to 7 or 8 numbers total, so 111 can do 8, 11 can do 4, 1 can do 2.               

//notice that we doubled every single time we added one more bit.      

//when we see 00000000(8 bits) it's a multiplication every time we add a 0.    

//when we say 16 bits, that isn't twice as large as 8 bits, that's the confusion that everybody stuck on.      

//9 bits is twice as large as 8 bits. 

//10 bits is 4 times as large as 8 bits, and it keeps going up in the multiplication.     

//when we see Int32(32 bits) that means there's 32 zeros, that's the number of places that we can store numbers in, it's a massive number.            

//if we want to go larger, the option is:

//Int64

//this is so large number that it's difficult to understand, we don't use it .  
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//We want to know our age in 10 years:

//int ageInTenYears = age + 10;
//Console.WriteLine(ageInTenYears);

//that's how we work with Integers ,we can add them ,subtract them, multiply them, divide them.        

//we don't modify the original number in this type of equation:   

//int ageInTenYears = age + 10;

//If we want to modify the original number in this type of equation:

//age = age + 10;

//that'll modify the original variable ,by taking the result value and putting it back to the original variable, that will change the age to 53.    

//we need to be careful with dividing because, if we write like this :

//Console.WriteLine(age / 2);

//the result will be incorrect ,the result will be a whole number because we use Int.

//add,subtract, multiply, are great with Integers .

//we need to be very careful with division because the results will be incorrect .
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~