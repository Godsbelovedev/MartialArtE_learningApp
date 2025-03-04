Console.WriteLine("Enter your first number");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your first number");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter your first number");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine(SumThreeIntegers(num1,num2,num3));
static int SumThreeIntegers(int firstNumber, int secondNumber, int thirdNumber)
{
    return firstNumber+secondNumber+thirdNumber;
    // it returns the sum of the three integers
}