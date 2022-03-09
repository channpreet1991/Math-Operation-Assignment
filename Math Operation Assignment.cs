public class ConsoleApp
{
  public static void Main()
  {
    int num1;
     
    Console.Write("Input a number: ");
    num1 = Convert.ToInt32(Console.ReadLine());
    // Takes an input from the user, multiplies it by 50, and prints the result to the console.
    int result = num1 * 50;
    Console.WriteLine(num1 + " * 50 = " + result);
    
    // Takes an input from the user, adds 25 to it, and prints the result to the console.
    int result1 = num1 + 25;
    Console.WriteLine(num1 + " + 25 = " + result1);
    // Takes an input from the user, divides it by 12.5, and prints the result to the console.
    double result2 = num1 / 12.5;
    Console.WriteLine(num1 + " / 12.5 = " + result2);
    // Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.
    bool result3 = num1 > 50;
    Console.WriteLine(num1 + " > 50 = " + result3);
    // Takes an input from the user, divides it by 7, and prints the remainder to the console 
    double mod = num1 % 7;
    Console.WriteLine(num1 + " % 7 = "+ mod);

  }
}