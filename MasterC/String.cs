//string firstName = string.Empty;
//string lastName = string.Empty;
//string filePath = string.Empty;

//firstName = "Tim";
//lastName = "Corey";
////filePath = "C:\\Temp\\Demo";
//filePath = @"C:\Temp\Demo";
////firstName = "123";

////Console.WriteLine(firstName + " " + lastName);

//string testString = $@"The file for {firstName} is at C:\SampleFile";

////string interpolation 
//Console.WriteLine($"Hello {firstName} {lastName}");
//Console.WriteLine(filePath);
//Console.WriteLine(testString);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~










//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Examples and Explanation

//Variable:

//Holds any information we want ,as long as it's the correct type.
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Camel case, first letter of the first word is lower case and first letter of every word following will always be capitalized:   

//string firstName = string.Empty;

//or

//string myFirstName = string.Empty;

//if we have only one word ,it will be only lower case :

//string test = string.Empty;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Example of a real website that really mass this up:

//the name of the website is expertsExchange, and that's what the website was going for .

//in the URL of this website ,the name was expertsexchange, here we see a different potential name for this website:

//expert sex change

//that wasn't the name they're going for.

//and it got so bad that people weren't longer seen this word :  

//experts

//and this word:

//exchange

//they were seen 3 words 

//the website had to put - between :

//experts-exchange

//in the URL, just to be very clear about what was the website about and not be embarrassed all the time.       

//so casing really makes a big deal and that is why we're so strict about the style 

//if we would call like that :

//string a = string.Empty;
//string b = string.Empty;
//string c = string.Empty;

//that would still work, but the problem is that we don't know what a represents, and code was meant to be read.

//what if we change it like this :

//string b = string.Empty;
//string a = string.Empty;
//string c = string.Empty;

//how we supposed to understand that a is the first name or c is the last name or the opposite, that's why we don't use this short single letter variables,we want to name (regular variables, that we use often) very clear names that explains to every body what that variable is and does .           

//we won't give that kind of name:

//string firstNameForTheUserWhoIsUsingOurApplication = string.Empty;

//Acronyms :

//string fName = string.Empty;

//we don't usually read acronyms and associate them with a full word, and also not abbreviations   
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string firstName = string.Empty;

//the standard is:

//string.Empty;

//the meaning of it is that it's EMPTY and nothing is stored in it.

//it's a traditional way of saying that we have just started ,and we don't have nothing inside yet, it means that it's just a starting value.

//we can write :

//string firstName = string.Empty;

//or 

//we can reduce lines of code by writing the value at start inside the variable :

//string firstName = "Tim";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//this is a string with no content inside:

//string firstName = "";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//we put the value "Tim" inside the Variable firstName, now the Variable holds the information "Tim" :

//firstName = "Tim";

//after we put the value inside the Variable firstName, we can print it on the console, and our print will be "Tim" :

//Console.WriteLine(firstName);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//that's how we defined a Variable :

//string firstName = string.Empty;
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//that's how we assign a value :

//firstName = "Tim";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//that's how we use a variable:

//Console.WriteLine(firstName);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//we can also say :

//firstName = "123";

//we may think that this is a number ,but it's not, 123 is a number but if it raped with "" it becomes a string ,anything inside "" is a string .
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//if we'll run this code on the console :

//string firstName = string.Empty;

//firstName = "Tim";
//firstName = "123";

//Console.WriteLine(firstName);

//when we wrote this:

//firstName = "Tim";
// //firstName = "123";

//there is a spot in memory for "Tim" and for "123", we get read of a use of "Tim" but now we have to clean this up by the system, there is a Garbage collector(we don't hear about it, it just works).      

//we will see only 123,we won't see also "Tim" because we overwrote it with a new value.

//strings are expensive, when we put "Tim" inside firstName, we destroy the firstName that was before and creating new spot in memory and pointed "Tim" instead.      
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//here we're adding 3 strings together.

//" ": 

//this one called a string literal, we use it just for the space between:  

//Console.WriteLine(firstName + " " + lastName);
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//string Interpolation:

//meaning that we're going to put a $ infront , it means that we're going to mix a little bit of code with our string:

//Console.WriteLine($"Hello {firstName} {lastName}");

//this appending is actually making a new copy of this string :

//"Hello {firstName} {lastName}"

//it means what ever inside the {}, is a C# code and not as an actual string.

//every time that we work with a string ,manipulating it or changing it in some way, it makes a full copy of a string, that can get expensive over time    
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//our line of code is :

//filePath = "C:\\Temp\\Demo \n";

//under the \T and the \D, we have a red error line, it says :

//unrecognized escape sequence. 

//and we don't understand why we have this error because we put this string between "" so we did everything by the rules so why....

//the problem is that there are some characters that C# doesn't know what we want to do there, so there is an escape character, if we want line in return, we add \n , it means new line, we have escape character \ for new line n.

//if we want to use the actual escape character as just a regular character, we put \\ (2 escape characters),because we have an escape character that is a special character and we use an escape character again, it means that the special thing \ character does is put \ character in to the string.

//another option is to put @ symbol :

//it called string literal character, it says that treat everything in this string as a literal string, don't treat this as a special characters, we no longer can use our escape character.   
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//we can use {firstName} as a variable and \ as a literal because we have the ability to mix $@ together :

//string testString = $@"The file for {firstName} is at C:\SampleFile";
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~


//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
//Hungarian notation:

//string strFirstName = string.Empty;

//we don't do it and actively discourage it in the industry because it makes things hard to read, although it shows us the type of the variable.

//when we read code that written in Hungarian notation style, we don't break it mentally easy in our head in two ,str and FirstName ,we need to pause and take a minute to understand it, that slows down our mental process when it comes to reading, so this is why we don't use this style anymore.
//~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~