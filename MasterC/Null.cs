//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CommonVariables
//{
//    internal class Null
//    {
//    }
//}

//Null - Lack of values.

//Haven't asked for the age yet
//int? age = null;
//bool? birthday = null;
//double? battingAverage = null;
//decimal? accountBalance = null;
//string? firstName = null;

//we have asked for the age now
//age = 0;






//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Examples and Explanations:

//Null - Lack of values.

//A Null value can be assigned to any variable type if we say it can .   

//think of this as a black hole of values.  

//and the reason we have Null is that indicate that there's nothing here.   

//for instance, we have an age variable, the default value for that is 0, what if we have'nt yet asked the person for their age ? should we have a 0 in that value ? probably not, because technically 0 is an age.           

//we may say ,no! 0 is not an age! 

//but when a new born is first born, what is their age in years ? because they hit their first birthday 365 days after they were born ,so what is their age in years up until that point ? well .... probably 0.           

//in the US we say things like "they're 1 week old", "they're 2 months old", yes but they're not yet 1 and we're using Integers here for years because that's how we talk.      

//we don't say "I'm 3.45 years old", in general we don't do that ,we don't say 3.5, we don't say "I'm 43.25 years old", we say 43 or we say 3, and so we use in our common parlance Integers to indicate our year, we don't call them Integers because we don't even know that's what an Integer is, we say whole numbers or just give a number.                       

//so if an age could be 0 and we have'nt yet asked the user for their age ,could this be confusing ? because right now, right here, we haven't asked for the age yet:        

//int age = 0;

//and if it's a baby and we have asked for the age now:

//age = 0;

//and the difference is nothing.  

//so how do we tell the system whether or not this is a valid age or a not yet an age we've asked for?      

//well that's where Null comes to the picture, because Null allows us to say "this lacks a value, it doesn't have a value yest".          

//normally we think to say: 

//int age = null;

//but an age is'nt Nullable.  

//meaning, it doesn't have the capacity to store a lack of value.   

//so we use this question mark at the end of the Int: 

//int? age = null;

//the question mark indicates is this type is Nullable, meaning it has the capacity to store Null.      

//so now age has not yet been set:  

//int? age = null;

//now age has been set and that is the value:   

//age = 0;

//so this is really useful for data, because in the database we often have the concept of Null.        

//if we don't have a value for a column, we don't put a value there ,we say Nullable and we say that column value doesn't have a value yet there for it's Null.         

//so when it comes to putting that data in to C#, we don't want to than convert that:     

//age = 0;

//to a default value that isn't Null, because then we say that data back'll now over write the Null value with a value that looks real.           

//so we want to be able to keep that Null going back and forth ,so we use Nullable characters.     

//the nice thing here is that we have this option:  

//int? age = null;

//because if we toke this question mark off, age can't be Null, Null isn't an option.       

//we can do this with all the types, like with int?, bool?, double?

//so ,this double? battingAverage = null; is Nullable average because we don't know yet what the average is, there for we aren't going to put a number here like 0 where the compiler'll say "wait ,your batting average is 0?, that isn't great!"      

//no! because 0 could be a valid number, we're going to say Null until you give us a valid number, which could be 0.     

//and this is true for all the types, we can put this question mark there that indicates that it's Nullable.   
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//String is a bit different. 

//it isn't Nullable. 

//that technically works:  

//string firstName = null;

//the compiler allows it because string is a different type, it's what actually called a Struct, but what that means for us is the fact that by default we can put Nulls in to Strings with out marking them as Nullable.           

//how ever, there's a new feature in C# that says we should probably do a check on that and may at least throw a massive jop saying that's not a great thing.            

//Because in this case we aren't saying that we're expecting a Null value here because it's a string ,it isn't Nullable string so even though it technically can store a Null, we aren't saying we're expecting a Null, there for Visual Studio says that it might be a bug, and we realize that it might and Visual Studio is right, and we realize that we're putting Null in to a value that we're saying that is required and there fo that's a problem ,and that could change our code, or we can put a question mark like this:                     

//string? firstName = null;

//and say to Visual Studio that we expect to be Null at some point or can be Null by using the question mark character and now Visual Studio won't yell us anymore.         

//so it isn't going to force us to make strings Nullable because they already are, but it's going to worn us if we try and use Null value, because of the fact that we didn't say that we expect a Null, so that's the one little kind of quirk on this but with this: string? , this allows us to have our code be a little more precise and it kind a helps us in Visual Studio by telling us that this might be a problem and if it is then we can say that we ether not make it Null or make this string Nullable.                                  

//so those option allow us to say what's going on Visual Studio then help us ensure that we follow our own desires.     

//so that warning isn't newer features of Visual Studio, that because we have a Nullable setting in our project, in "Edit project file" we have <Nullable>enable</Nullable>, we can delete it, and we won't get those warnings anymore but we should leave them to help us out .           
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~