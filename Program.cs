//Задача 1
/*
int [,] New2DArray ()
{
    Console.WriteLine("Enter count of rows: ");
    int userRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter count of collumns: ");
    int userColl = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter min passible value: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter max passible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] createArray = new int[userRows,userColl];
    for (int i = 0 ; i < userRows; i++)
    {
        for (int j = 0; j < userColl; j++)
        {
            createArray[i,j] = new Random().Next(minVal,maxValue + 1);
        }
    }
    return createArray;
}

void PrintArray (int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i++)
    {
        for (int j = 0; j < array2d.GetLength(1);j++ )
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int [,] outArray = New2DArray();
PrintArray(outArray);*/

// Задача 2 
/*
int [,] arr ={{1,2,3,4},{-5,-7,18,20},{9,6,-4,11}};
Console.WriteLine("Enter searching element: ");
int userEl = Convert.ToInt32(Console.ReadLine());
bool f = false;
for  (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (userEl == arr[i,j]) {f = true;};
        Console.Write("{0}\t", arr[i,j]);
    }
    Console.WriteLine();
}
Console.WriteLine();
if (f)
    Console.WriteLine($"Element {userEl} is found in array!");
else
    Console.WriteLine("Element not found in array!");  
Console.ReadKey();*/

// Задача 3
/*
Console.Write("Enter count of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter count of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int [m,n];
void mas(int m, int n)
{
    int i,j;
    Random rand = new Random();
    for (i = 0; i < m;i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i,j] = rand.Next(1,9);
            Console.Write($"{randomArray[i,j]}");
        }
        Console.WriteLine();
    }
}
void arif(int m, int n)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int i,j;
    Random rand = new Random();
    for ( j = 0; j < n; j++)
    {
        double sum = 0;
        for (i = 0; i < m; i++)
        {
            sum =  sum + randomArray[i,j];
        }
        Console.Write($"{sum/(i):F1};");
    }
}
mas(m,n);
arif(m,n);*/

