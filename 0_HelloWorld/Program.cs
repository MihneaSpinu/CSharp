//Change appearance of Console
Console.Title = "Not Skynet";
Console.BackgroundColor = ConsoleColor.White;
Console.ForegroundColor = ConsoleColor.Black;
Console.WindowHeight = 40;

//Presentation
Console.WriteLine("Hello Chosen One");
Console.WriteLine("What is your name?");

//<Type> <Name> = <Value> ;
string myString = "This is how to define a string variable!";

//Reading a string from the console
myString = Console.ReadLine();

Console.WriteLine("Hello " + myString + " How are you?");
Console.ReadLine();

Console.WriteLine(myString + " Wold you like to do some math");

string answer = Console.ReadLine();

bool WantToDoMath = false;
if (answer == "yes")
{
    WantToDoMath = true;
}

if (WantToDoMath == true)
{
    Console.WriteLine("Wold you like to add, subtract, multiply or divide?");
    string mathoperation = Console.ReadLine();

    switch (mathoperation)
    {
        case "add":
int addnum01;
int addnum02;

Console.WriteLine("Write a number");
addnum01 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("Write a second number");
addnum02 = Convert.ToInt32( Console.ReadLine() );

int addresult = addnum01 + addnum02;
Console.WriteLine("The result is " + addresult);

            break;
        case "subtract":
int subnum01;
int subnum02;

Console.WriteLine("Write a number");
subnum01 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("Write a second number");
subnum02 = Convert.ToInt32( Console.ReadLine() );

int subresult = subnum01 - subnum02;
Console.WriteLine("The result is " + subresult);
            break;

        case "multiply":
 int mulnum01;
int mulnum02;

Console.WriteLine("Write a number");
mulnum01 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("Write a second number");
mulnum02 = Convert.ToInt32( Console.ReadLine() );

int mulresult = mulnum01 * mulnum02;
Console.WriteLine("The result is " + mulresult);
            break;

        case "divide":
 int divnum01;
int divnum02;

Console.WriteLine("Write a number");
divnum01 = Convert.ToInt32( Console.ReadLine() );

Console.WriteLine("Write a second number");
divnum02 = Convert.ToInt32( Console.ReadLine() );

int divresult = divnum01 / divnum02;
Console.WriteLine("The result is " + divresult);
            break;
    }

}

Console.WriteLine("That was all i had, goodbye");
Console.ReadLine();



// Dette er sådan man laver en switch med tal

    //Console.Write("input a number between 1 and 5: ");

 //   int num = Convert.ToInt32(Console.ReadLine());

 //   switch (num) {
    //    case 1:
    //        Console.WriteLine("one");
    //        break;
    //    case 2:
    //        Console.WriteLine("two");
    //        break;
    //    case 3:
    //        Console.WriteLine("three");
    //        break;
    //    case 4:
    //        Console.WriteLine("four");
    //        break;
    //    case 5:
     //       Console.WriteLine("five");
   //         break;
  //  }

      //  Dette er sådan man laver en lommeregner

  //  int num01;
  //  int num02;

   // Console.WriteLine("Write a number");
   // num01 = Convert.ToInt32( Console.ReadLine() );

   // Console.WriteLine("Write a second number");
   // num02 = Convert.ToInt32( Console.ReadLine() );

   //     int result = num01 + num02;
//Console.WriteLine("The result is " + result);

 //== ecual to , != not ecual, && and, || or