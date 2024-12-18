using System;

class SimpleInterestCalculator
{
    static void Main()
    {
        // Step 1: Declare the variables
        double principal, rate, time, interest;

        // Step 2: Prompt the user to enter the principal amount
        Console.Write("Enter the principal amount (P): ");
        principal = Convert.ToDouble(Console.ReadLine());

        // Step 3: Prompt the user to enter the rate of interest
        Console.Write("Enter the rate of interest (R) in percentage: ");
        rate = Convert.ToDouble(Console.ReadLine());

        // Step 4: Prompt the user to enter the time period in years
        Console.Write("Enter the time (T) in years: ");
        time = Convert.ToDouble(Console.ReadLine());

        // Step 5: Calculate the simple interest using the formula
        interest = (principal * rate * time) / 100;

        // Step 6: Display the result
        Console.WriteLine($"The simple interest earned is: {interest:C}");
        
        // Optional: Display the total amount (Principal + Interest)
        double totalAmount = principal + interest;
        Console.WriteLine($"The total amount after {time} years will be: {totalAmount:C}");
    }
}

