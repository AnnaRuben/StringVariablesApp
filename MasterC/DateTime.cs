//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CommonVariables
//{
//    internal class DateTime
//    {
//    }
//}

using System.Globalization;

DateTime today = DateTime.UtcNow;

//DateTime birthday = DateTime.Parse("15/06/1998");

//DateTime birthday = DateTime.ParseExact("11/15/1998", "M/d/yyyy", CultureInfo.InvariantCulture);

//DateTime birthday = DateTime.ParseExact("06/11/1998", "d/M/yyyy", CultureInfo.InvariantCulture);

//Console.WriteLine(birthday.ToString());

Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz", CultureInfo.InvariantCulture));







//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Examples and Explanations :

//DateTime variable has been around since the beginning of C#.  

//there're newer parcel options.    

//the DateTime object is the most common way to store information about the date and time.    

//For example:

//DateTime today = DateTime.Now;

//that is going to be a date and time of right now and that'll put that in to the variable today .  

//that is local time, based up on where our computer is.  

//there's a lot of complexity around date and time.  

//the concept here is that date and time is complicated because it's potentially different for every person.    

//for instance , we're in central time, so our 01:30 pm is actually 02:30 pm in eastern time, at the same exact time .     

//so there's a complexity there with time zones.   

//there's also things like day light savings time where our area respects day light savings time, our area actually have day light savings time ,other areas even in the US don't respects day light savings time and so depending at what time of the year it is there'll be different times.             

//so there's a lot of complexity around date and time, there's also a leap here and all of the rest of the stuff that happens .    

//but the DateTime object stores a full date and time.  

//in the example we print this out:

//Console.WriteLine(today);

//and behind the scene it prints to string ,like this: 

//Console.WriteLine(today.ToString());

//but printing this out ,we have tones of options there, this ToString() have a lot of options, like:   

//put "" inside the (), and we could specify a format by opening a drop down list like:

//long date, full short date/time ,full long date/time ,general short date/time ,and so on .........

//for example we want just the date , the lower case d, but the variable sill holds the same information, this didn't change what information is in that variable, what it changed is what it displays, what it prints out.          

//and if we want just the time ,the lower case t,is with out the seconds, the capital T is with seconds and so on ..........  

//so we can use this different versions to print out just the portion that we want.     

//for a long time in C# was the only date or time object we had in C#, so if we want to represent our birthday, then we'll have a date time but we wouldn't worry about the time portion and traditionally what we do is put time to midnight so that's how we deal with just a date.          

//and if we had just a time, for example the time that the business opens is 08:00 am, well we would represent the date portion as January 1st, year 1 and a time as 08:00 am ,it's a little bit complicated using it but we can definitely do that.              

//we'll see this as the most common way dealing with dates, when we deal with just a part of the date, but we do have other options with date only and time only that're potential replacements if we doing just one portion, just the date or just the time          
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//for example birthday:

//DateTime birthday = DateTime.Parse("15/06/1998");

//Console.WriteLine(birthday.ToString());

//that is a valid date format, but that is a valid date format for Israel based date because my computer is Israel based and so our local says that day comes first and then month and then year but there's a lot of places in the world where the first spot is for the month and second spot is for the day, and so if we run this exact same code somewhere else and that computer's local say that month comes first in the day format, this would crush because there's no 15th month.                        

//so that is why date ans time can get very complicated, we have to know the local we're working with and if we just starting make an assumptions, we might introduce bugs and in potentially in bugs like this one where it doesn't crush the application, it just works but not as we expected.              
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//another way of doing this:

//DateTime birthday = DateTime.ParseExact();

//with a ParseExact we can be a little more exact with how we do things.  

//so the way is first we have to give it our date, "06/11/1998", we know that it's a valid date but then we give it a format, with some of the options from the format drop dow list we can specify a custom string, for instance d - day of the month (1-2 digits), 1-2 digits meaning if the month is February which is 2, we say 2 .            

//if we choose dd - day of the month (2 digits),meaning if the month is February which is 2, we say 02.  

//but if we choose DateTime birthday = DateTime.ParseExact("06/11/1998", "d/M/yyyy"); ,we choose the format of "d/M/yyyy", this format is more common in the world, not in the US, which is going to evaluate our date "06/11/1998" as the 6th day of November, 1998.          

//d is short date 

//capital M for month is month day  

//lower case yyyy is for year (4 digits)

//and we do have to specify the CultureInfo.InvariantCulture, by adding using System.Globalization;:    

//DateTime birthday = DateTime.ParseExact("06/11/1998", "d/M/yyyy", CultureInfo.InvariantCulture);

//meaning don't worry about what culture you're in ,what local you're in, and how they do formatting    
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Console.WriteLine(today.ToString("MMMM dd, yyyy hh:mm tt zzz", CultureInfo.InvariantCulture));

//MMMM:

//full month.

//dd:

//2 digits day.

//yyyy:

//4 digits year.

//hh:mm :

//12 hours clock(2 digits), minute(2 digits)

//2 tt AM/PM(full)

//3 zzz for the time zone utc hour and minute offset
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//DateTime today = DateTime.UtcNow;

//right now i'm saying Now which's the local time.  

//we have to think about where code's going to run, because often times people think that they can use Now because their code always going to run where they're at, well .... maybe.       

//because if we say that now it's time to go to the cloud and we run our application in the cloud, it may run in a different time zone because the server might be in a different tim zone than we're.         

//we may say that we'll always put the server at the same time zone we're, there for Now still works, well.... but what happens when the server goes down ....       

//we probably have a back up some where and usually that back up's in a different time zone.     

//so if we storing logs about when things happened and use:        

//DayTime.Now 

//with out specifying or saving that offset, that could be a problem.

//so there's another option and that's that we can use:   

//DateTime.UtcNow

//so that is Coordinated Universal Time (UTC), that's that Grinch meantime, that's the time that all of our time's based up on.       

//so that's the UTC time ,we could log every thing in UTC time because then it doesn't meter if it runs in the east cost or the west cost or Europe ,it'll always be the same time in relation ship to all other times.        

//how ever, we're loosing the ability to know what the offset is for what ever that was generated and we have to decide is that ok or not.          

//so there's UTC time and local time and we loosing information by just capturing UTC time but we're making easier to compare dates      
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~