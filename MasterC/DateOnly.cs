//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace CommonVariables
//{
//    internal class DateOnly
//    {
//    }
//}

//using System.Globalization;

//DateTime today = DateTime.Now;

//DateOnly birthday = DateOnly.Parse("6/11/1998");

//Console.WriteLine(birthday.ToString("MMMM dd, yyyy", CultureInfo.InvariantCulture));

//Console.WriteLine($"Today full format: {today}");
//Console.WriteLine($"Today just date: {today.Date}");
//Console.WriteLine($"Birthday full format: {birthday}");






//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Examples and Explanations :
//DateOnly :

//used when we only wants the date. 

//it isn't about calendars. 

//so for example if our birthday was on Jun 11th, would we care about what time zone we're in when we say that ?    

//would we say it's Jun 11th but in Eastern time ?  

//no ,we wouldn't, because it's the date we're talking about.    

//when we talk about events that happen in history, we don't talk about the time necessarily, we talk about just the date tht it happened, so we just use a DateOnly.        

//but when we talk about things that happened maybe only reference the date but there's the time portion as well, we use the DateTime.         

//so that's the difference is when it's only a date, we use DateOnly :    

//DateOnly.Parse("6/11/1998")

//so birthday ,DateOnly. 
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~