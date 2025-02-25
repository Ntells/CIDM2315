using System;

public class Program
{
    // Method for Q1: Find the largest of two integers
    public static int largest(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }

    // Method for Q2: Find the largest of four integers
    public static int largest(int n1, int n2, int n3, int n4)
    {
        return largest(largest(n1, n2), largest(n3, n4));
    }

    // Main entry point for the combined program
    public static void Main(string[] args)
    {
        // Part 1: Find the largest of two integers (Q1)
        Console.WriteLine("Program 1: Find the largest of two numbers");
        Console.Write("Enter first integer: ");
        int first = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int second = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(first, second));

        // Add a line break for clarity between the two parts
        Console.WriteLine("\n---\n");

        // Part 2: Find the largest of four integers (Q2)
        Console.WriteLine("Program 2: Find the largest of four numbers");
        Console.Write("Enter first integer: ");
        int third = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second integer: ");
        int fourth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third integer: ");
        int fifth = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter fourth integer: ");
        int sixth = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The largest number is: " + largest(third, fourth, fifth, sixth));

        // Now calling the password account creation program
        Console.WriteLine("\n---\n");
        Console.WriteLine("Program 3: Create an Account");
        PasswordAccountProgram.CreateAccount();
    }
}

public class PasswordAccountProgram
{
    // Main method is not used in this class directly, it's called from Program class
    public static bool CheckAge(int birth_year)
    {
        // Calculate age
        int age = 2022 - birth_year;
        // If age is greater than or equal to 18, then return true
        if (age >= 18)
            return true;
        // Otherwise return false
        else
            return false;
    }

    // Method to create an account
    public static void CreateAccount()
    {
        // Declare String variables userName, password, and retypedPassword
        string userName, password, retypedPassword;
        // Declare integer variable birthYear
        int birthYear;

        // Prompt user to enter user name
        Console.WriteLine("Enter Your Username:");
        // Read userName
        userName = Console.ReadLine();

        // Prompt user to enter password
        Console.WriteLine("Enter Your Password:");
        // Read password
        password = Console.ReadLine();

        // Prompt user to enter password again
        Console.WriteLine("Enter Your Password Again:");
        // Read retypedPassword
        retypedPassword = Console.ReadLine();

        // Prompt user to enter birth year
        Console.WriteLine("Enter Your Birthyear:");
        // Read birthYear
        birthYear = Convert.ToInt32(Console.ReadLine());

        // If CheckAge() returns true, then
        if (CheckAge(birthYear))
        {
            // If password and retypedPassword are equal, then display
            // "Account is created successfully"
            if (password == retypedPassword)
                Console.WriteLine("Account is created successfully");
            // Otherwise display "Wrong password"
            else
                Console.WriteLine("Wrong password");
        }
        // Otherwise display "Could not create an account."
        else
            Console.WriteLine("Could not create an account.");
    }
}

