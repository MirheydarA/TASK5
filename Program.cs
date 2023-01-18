//task 1

//int[,] arr = new int[3, 3]
//  { { 3, 2, 6},
//    { 1, -4, 5 },
//    { -8, 9 , 4}
//};
//int sum = 0;    

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        if (i == j)
//        {
//            sum = sum + arr[i, j];
//        }
//    }

//}
//Console.WriteLine(sum);



//Task 2
int[,] arr = new int[3, 3]
  { { 3, 2, 3},
    { 1, -4, 5 },
    { -8, 9 , 4}
};

int[,] arr2 = new int[3, 3]
{ {1, 2, 3 },
  {4, 5, 6},
  { 8, 9, 4},
};

int sum = 0;

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        if (arr[i, j] == arr2[i, j])
        {
            sum += arr[i, j];
        }
    }
}
Console.WriteLine(sum);






//taks 3
//int[,] arr = { { 1, 2, 3, 4, 5},
//                {6, 7, 8, 9, 10},
//                {7, 8, 9, 1, 2},
//                {3, 4, 5, 6, 7},
//                {4, 5, 6, 7, 8}
//              };



//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {

//        if (i > 0 && j == 0 )
//        {
//            arr[i, j] = 0;
//        }
//        if (i > 1 && j == 1)
//        {
//            arr[i, j] = 0;
//        }
//        if (i > 2 && j == 2)
//        {
//            arr[i, j] = 0;
//        }
//        if (i > 3 && j == 3)
//        {
//            arr[i, j] = 0;
//        }


//Console.Write(arr[i, j] + " ");
//    }
//Console.WriteLine();
//}


