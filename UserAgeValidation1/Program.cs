// See https://aka.ms/new-console-template for more information
//asks age
//if age lower than 13 yo
//"Ur too young"
//else "Welcome"

Console.WriteLine("Enter age");

string userAge = Console.ReadLine();

int UserAgeNum = 0;
//bootlean-truezfalse

bool isAgeNumber = Int32.TryParse(userAge, out UserAgeNum);


//int userAge = Int32.Parse(Console.ReadLine()); // "13" - heap, 13-stack

Console.WriteLine($"Parse res {isAgeNumber}. User is {UserAgeNum} yo");

if (isAgeNumber == true)
{
    if(UserAgeNum >=13)
    {
        Console.WriteLine("Welcome");
}
    else
    {
        Console.WriteLine("Too young");
            }
}
else { Console.WriteLine("could not read ur age");
}



//if(userAge >= 13)
//{
//    Console.WriteLine("Welcome");
//}    
//else
//{
//    Console.WriteLine("Ur too young");
//}    