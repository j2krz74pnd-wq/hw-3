//Task1
// int n = Convert.ToInt32(Console.ReadLine());

// PrintFromNumberTo0n(n);

// void PrintFromNumberTo0n(int number)
// {
//     for(int i = number; i > 0; i--)
//     {
//         System.Console.Write($"{i} " );
//     }
// }


//task2
// int c = Summ(1,2,3,4); 
// Console.WriteLine(c); 
// int Summ(int a , int b , int c, int d)
// {
//     return a+b+c+d;
// }


//task3
// Console.WriteLine("ВВедите число: "); 
// string? n = Console.ReadLine();

// string reversedN = "";

// for(int i = n.Length; i > 0; i--)
// {
//     reversedN += n[i-1];
// };


// Console.WriteLine(reversedN); 


//task4
// int n = Convert.ToInt32(Console.ReadLine());
// PrintStars(n);

// void PrintStars(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }


//tash5
// int n = Convert.ToInt32(Console.ReadLine());
// PrintStars(n);

// int size = Convert.ToInt32(Console.ReadLine());
// PrintSquare(size);

// void PrintStars(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }
// void PrintSquare(int size)
// {
//     for (int i = 0; i < size; i++)
//     {
//         PrintStars(size);
//     }
// }



//task6
// PrintRectangle(17, 3);

// void PrintStars(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }
// void PrintRectangle(int width, int height)
// {
//     for (int i = 0; i < height; i++)
//     {
//         PrintStars(width);
//     }
// }


//task7
// int size = Convert.ToInt32(Console.ReadLine());
// PrintTriangle(size);

// void PrintStars(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }
// void PrintTriangle(int size)
// {
//     for (int i = 1; i <= size; i++)
//     {
//         PrintStars(i);
//     }
// }


//task8
// int size = Convert.ToInt32(Console.ReadLine());
// PrintRightTriangle(size);

// void PrintStars(int n)
// {
//     for (int i = 0; i < n; i++)
//     {
//         Console.Write("*");
//     }
//     Console.WriteLine();
// }
// void PrintSpaces(int number)
// {
//     for (int i = 0; i < number; i++)
//     {
//         Console.Write(" ");
//     }
// }
// void PrintRightTriangle(int size)
// {
//     for (int i = 1; i <= size; i++)
//     {
//         PrintSpaces(size - i);
//         PrintStars(i);
//     }
// }

//task10
int height = Convert.ToInt32(Console.ReadLine());
Tree(height);

void PrintStars(int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
void PrintSpaces(int number)
{
    for (int i = 0; i < number; i++)
    {
        Console.Write(" ");
    }
}
void Tree(int height)
{
    for (int i = 1; i <= height; i++)
    {
        PrintSpaces(height - i);
        PrintStars(2 * i - 1);
    }
    for (int i = 0; i < 2; i++)
    {
        PrintSpaces(height - 2);
        PrintStars(3);
    }
}