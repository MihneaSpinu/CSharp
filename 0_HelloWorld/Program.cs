//Console Start
#region 

//Change appearance of Console
Console.Title = "Not Skynet";
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WindowHeight = 40;

//Presentation

string TypeWriter(string input){
    if(input.Length > 0){
        string firstCharacter = input.Substring(0, 1);
        string restOfInput = input.Remove(0, 1);
        Console.Write(firstCharacter);
        Thread.Sleep(15);
        return TypeWriter(restOfInput);
    }else{
        return "";
            }
}
TypeWriter("Hello my user \nI am you personalized personal computer \nI do know your name, but do you? Let's see if you are right \n");

//Console.WriteLine("Hello my user \nI am you personalized personal computer");
//Console.WriteLine("I do know your name, but do you? Let's see if you are right");

//<Type> <Name> = <Value> ;
string myString = "This is how to define a string variable!";

#endregion

//The main program  (need to be uncommented to work)
#region 

myString = Console.ReadLine();

TypeWriter("Of course, your name is ");
Console.WriteLine(myString); 
TypeWriter("How are you? \n");

//Console.WriteLine("Of course, your name is " + myString + ", how are you?");
Console.ReadLine();

Thread.Sleep(950);
Console.WriteLine(myString + " would you like to do some math? (y/n)");

string answer = Console.ReadLine();

bool WantToDoMath = false;
if (answer == "y")
{
    WantToDoMath = true;
}

if (WantToDoMath == true)
{

    bool is_calculating = true;

while (is_calculating)
{
    Console.WriteLine("Would you like to add, subtract, multiply or divide?");
    string mathoperation = Console.ReadLine();

    switch (mathoperation)
    {
        case "add":
double addnum01;
double addnum02;

Console.WriteLine("Write a number");
addnum01 = Convert.ToDouble( Console.ReadLine() );

Console.WriteLine("Write a second number");
addnum02 = Convert.ToDouble( Console.ReadLine() );

double addresult = addnum01 + addnum02;
Console.WriteLine("The result is " + addresult);

            break;
        case "subtract":
double subnum01;
double subnum02;

Console.WriteLine("Write a number");
subnum01 = Convert.ToDouble( Console.ReadLine() );

Console.WriteLine("Write a second number");
subnum02 = Convert.ToDouble( Console.ReadLine() );

double subresult = subnum01 - subnum02;
Console.WriteLine("The result is " + subresult);
            break;

        case "multiply":
 double mulnum01;
double mulnum02;

Console.WriteLine("Write a number");
mulnum01 = Convert.ToDouble( Console.ReadLine() );

Console.WriteLine("Write a second number");
mulnum02 = Convert.ToDouble( Console.ReadLine() );

double mulresult = mulnum01 * mulnum02;
Console.WriteLine("The result is " + mulresult);
            break;

        case "divide":
double divnum01;
double divnum02;

Console.WriteLine("Write a number");
divnum01 = Convert.ToDouble( Console.ReadLine() );

Console.WriteLine("Write a second number");
divnum02 = Convert.ToDouble( Console.ReadLine() );

double divresult = divnum01 / divnum02;
Console.WriteLine("The result is " + divresult);
            break;
    }
    Console.WriteLine("Do you want to continue? (y/n)");
    string continue_string = Console.ReadLine();
    if (continue_string == "n")
    {
        is_calculating = false;
    }
}

}

Console.WriteLine("That was all i had, goodbye");
Console.ReadLine();



#endregion

//tests
#region 
/*

//Method
int Sum(){

    int firstNr = Convert.ToInt32(Console.ReadLine());
    int Secondnr = Convert.ToInt32(Console.ReadLine());

    return firstNr+Secondnr;
}

while(true){
    Console.WriteLine("Your choise");
    string answer = Console.ReadLine();

    if(answer == "add"){
        Sum();
        Console.WriteLine();
    }
}




//Array
string[] movies = new string[4];

Console.WriteLine("Write 4 movies: ");

for (int i = 0; i < movies.Length; i++)
{
    movies[i] = Console.ReadLine();
}

Console.WriteLine("\nHere they are alfabeticklly: ");

Array.Sort(movies);

for (int i = 0; i < movies.Length; i++)
{
    Console.WriteLine(movies[i]);
}




//Random number + while
Random numberGen = new Random();

int roll = 0;
int attempts = 0;

Console.WriteLine("Press enter to roll");

while(roll != 6) {
    Console.ReadLine();

    roll = numberGen.Next(1, 19);
    Console.WriteLine("You rolled:" + roll);
    attempts++;
}

Console.WriteLine("It took you " + attempts + " attempts to roll a six.");




//for loop
Console.ReadLine();
for (int i = 1; i <= 10; i++)
{
 Console.WriteLine(i);   
}

Console.ReadLine();
for (int i = 0; i < 10; i++)
{
    if( i == 5 )
        break;

    Console.WriteLine("Value of i: {0}", i);
}

*/
#endregion

//Notes
#region 

/*

// Dette er sådan man laver en switch med tal

    Console.Write("input a number between 1 and 5: ");

    int num = Convert.ToInt32(Console.ReadLine());

    switch (num) {
        case 1:
            Console.WriteLine("one");
            break;
        case 2:
            Console.WriteLine("two");
            break;
        case 3:
            Console.WriteLine("three");
            break;
        case 4:
            Console.WriteLine("four");
            break;
        case 5:
            Console.WriteLine("five");
            break;
     }

//  Dette er sådan man laver en lommeregner

    int num01;
    int num02;

    Console.WriteLine("Write a number");
    num01 = Convert.ToInt32( Console.ReadLine() );

    Console.WriteLine("Write a second number");
    num02 = Convert.ToInt32( Console.ReadLine() );

        int result = num01 + num02;
Console.WriteLine("The result is " + result);

 //== ecual to , != not ecual, && and, || or

// data / number types 

int:     	32-bit signed integer 	                        -2,147,483,648 to 2,147,483,647 
float: 	    32-bit Single-precision floating point type 	-3.402823e38 to 3.402823e38 
double: 	64-bit double-precision floating point type 	-1.79769313486232e308 to 1.79769313486232e308 

 */

#endregion

//Version 2.0    Date: 05/09/2022   Time: 12:50