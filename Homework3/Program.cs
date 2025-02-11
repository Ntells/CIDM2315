using System;
public class HelloWorld
{
    public static void Main(string[] args) {
        
        Console.WriteLine("Input an integer:");
        int n = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine(isPrime(n));
        
        
        Console.WriteLine("\nAssign an int value to N");
        n = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1; i <= n; i++){
            Console.WriteLine(new string('#',n));
        }
        
    
        Console.WriteLine("\nAssign an int value to N");
        n = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1; i <= n; i++){
            Console.WriteLine(new string('*',i));
        }
    }
    
    
    
    
    static bool isPrime(int n) {
        if(n == 1){
            Console.WriteLine("N is non-prime.");
            return false;
        }
        if(n == 2 || n == 3){
            Console.WriteLine("N is prime.");
            return true;
        }
        if(n % 2 == 0){
            Console.WriteLine("N is non-prime.");
            return false;
        }
        
        for(int i = 2; i < n; i++){
            if(n % i == 0){
                Console.WriteLine("N is non-prime.");
                return false;
            }
        }
        Console.WriteLine("N is prime.");
        return true;
    }
}