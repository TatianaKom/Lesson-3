namespace Lesson3;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please, enter the first number: ");
        int firstnumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please, enter the second number: ");
        int secondnumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please, enter the operation: '+', '-', '*', '/' ");
        switch (Console.ReadLine())
        {
            case "+":
                Console.WriteLine(firstnumber + secondnumber);
                break;
            case "-":
                Console.WriteLine(firstnumber - secondnumber);
                break;
            case "*":
                Console.WriteLine(firstnumber * secondnumber);
                break ;
            case "/":
                if (secondnumber == 0)
                {
                    Console.WriteLine("Error, try again (div/0!)");
                }
                else
                {
                    Console.WriteLine(firstnumber / secondnumber);
                }

            break;
        }

    }
}