//Q1 Grade Point//
Console.WriteLine("Please input a letter grade:");
string letter = Console.ReadLine();

    switch(letter){
        case "A":
        Console.WriteLine("GPA Point: 4");
        break;
        case "B":
        Console.WriteLine("GPA Point: 3");
        break;
        case "C":
        Console.WriteLine("GPA Point: 2");
        break;
        case "D":
        Console.WriteLine("GPA Point: 1");
        break;
        case "F":
        Console.WriteLine("GPA Point: 0");
        break;
        default:
        Console.WriteLine("Wrong Letter Grade");
        break;
    }
    //Q2 Smallest Value//
    Console.WriteLine("Please input first number");
    int x = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input second number");
    int y = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Please input third number");
    int z = Convert.ToInt16(Console.ReadLine());

    Console.WriteLine($"minimum number: {Math.Min(Math.Min(x,y),z)}");