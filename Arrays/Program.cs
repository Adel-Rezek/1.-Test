

//int[] arrayNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//int lengthOfNumbers = arrayNumbers.Length;


//for (int i = 1; i <= lengthOfNumbers; i++)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine(numbers[0]);

//foreach (int i in arrayNumbers)
//{
//    if (i == 5)
//    {
//        Console.WriteLine(i);
//    }
//    else
//    {
//        Console.WriteLine(lengthOfNumbers);
//    }


//}


int[,] bla =
    {
    {1,2,3 },
    {4,5,6 },
    {10,7,8 },
};


bla[0, 1] = 566;

Console.WriteLine(bla[2, 0]);


for (int i = 0; i < bla.GetLength(0); i++)
{
    for (int j = 0; j < bla.GetLength(1); j++)
    {
        if (bla[i, j] ==10)
        {
            Console.WriteLine($"Die 10 war in bla[{i},{j}]");
            Console.WriteLine();
        }
    }
}

