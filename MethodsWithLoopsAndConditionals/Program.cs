

void Numbers()
{

    for (int i = 1000; i >= -1000; i--)
    {
        Console.WriteLine(i);
    }
}

Numbers();


void Numbers3()
{

    for (int i = 3; i <= 999; i += 3)
    {
        Console.WriteLine(i);
    }
}

Numbers3();

void AreEqual(int num1, int num2)
{
    Console.WriteLine("Are the two numbers equal:");





    if (num1 == num2)
    {
        Console.WriteLine("They are Equal");
    }
    else
    {
        Console.WriteLine("They are not equal");
    }


}

AreEqual(1, 2);

void EvenOrOdd(int y1)
{

    if (y1 % 2 == 0)
    {

        Console.WriteLine("Even");
    }
    else
    {
        Console.WriteLine("Odd");
    }
}

EvenOrOdd(2);


void PositiveOrNegative(int x1)
{



    if (x1 < 0)
    {
        Console.WriteLine("Negative");
    }
    else
    {
        Console.WriteLine("Positive");
    }
}
PositiveOrNegative(-1);

void VotingRight(int candidate)
{

    if (candidate >= 18)
    {
        Console.WriteLine("You can vote");
    }
    else
    {
        Console.WriteLine("Get outta here");
    }
}

VotingRight(18);

//HEATING UP SECTION

void RangeChecking()
{

//Note: In the instructions on TrueCoders portal under Heating Up Section
//  it is said "to check if an integer (from the user)"... Thats why I
// used int.Parse(Console.ReadLine()) and created new variable, so that
// the user can input the value.
//In above practices / examples I passed arguments to parameters because thats
//  how I understood following from Constraints:

//    "This project should work in a manner where if someone
// forks / clones this from GitHub, they can just press the play button and
//   have every method run in sequence, so all interface dialogue should
//   be in place already." Sorry for the long comment



    Console.WriteLine("Type the number below to check if its in range:");
Console.WriteLine();
int c = int.Parse(Console.ReadLine());

if (c == -10 || c <= 10)
{

    Console.WriteLine("In the range");
}
else

{

    Console.WriteLine("Not in the range");
}



}

RangeChecking();

void Multiplication(int s)
{

    //int s = 2;
    for (int i = 1; i <= 12; i++)
    {
        Console.WriteLine(s * i);
    }



}

Multiplication(2);



























