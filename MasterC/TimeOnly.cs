//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CommonVariables
//{
//    internal class TimeOnly
//    {
//    }
//}

//TimeOnly openAt = TimeOnly.Parse("8:00 AM");

//TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);

//Console.WriteLine(openAt);
//Console.WriteLine(rightNow);












//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Examples and Explanation
//represents only the time portion of a value  

//it can be good for things like opening at .

//if we're a local business, we don't care about time zones, we open at 8 o'clock where we're and we close at 7 o'clock, where ever we want to say, that would be a time only thing, we aren't putting a date on it, we might say opens at 8 AM on Monday but we don't say a date, we aren't saying on November 5th i'm going to open at 8 AM, that would be kind'a silly, we don't want to have that much information stored some where we have to look every single day, usually we have a standard set of opening closing hours from Monday through Sunday and then we would have our exceptions like on this holyday we would close early and on that holyday we would close all day and so on .....                                  

//but this :

//openAt would give us that just one time:  

//"8:00 AM"

//so TimeOnly gives us the idea of 8 o'clock in the morning.    

//so that's our TimeOnly. 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//that'll give us the time right now:

//TimeOnly rightNow = TimeOnly.FromDateTime(DateTime.Now);
//Console.WriteLine(rightNow);

//so we have the time from the DateTime object. 

//just the time portion of it ,not the date and time  

//we can format that how ever we want, it only applies the time side of things, we can't say on this date or show me the month because that doesn't know what the month is, it just knows the time .        
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//so that's the TimeOnly option. 

//where we have just the time portion of a date and time   
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


































































