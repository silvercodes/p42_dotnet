
#region 1D arrays

//int[] arr1;                             // Array<int> arr1;

//int[] arr2 = new int[10];               // Array<int> arr2 = new Array<int>(10)

//int[] arr3 = new int[3] { 3, 4, 5 };

//int[] arr4 = new int[] { 3, 4, 5 };

//int[] arr5 = new[] { 3, 4, 5 };

//int[] arr6 = { 3, 4, 5 };

//// FROM C#12 !!!
//int[] arr7 = [3, 4, 5];     // :-)))

//int[] arr8 = [];





//string[] planets = ["Mercury", "Venus", "Earth", "Mars"];
//Console.WriteLine(planets[2]);
//planets[0] = "Moon";




//string[] planets = ["Mercury", "Venus", "Earth", "Mars"];
//Console.WriteLine(planets.Length);

//Console.WriteLine(planets[planets.Length - 1]);

//Console.WriteLine(planets[^1]);
//Console.WriteLine(planets[^2]);




//string[] planets = ["Mercury", "Venus", "Earth", "Mars"];

//foreach(string p in planets)
//    Console.WriteLine(p);
//Console.WriteLine("---------");

//for (int i = 0; i < planets.Length; i++)
//    Console.WriteLine(planets[i]);

#endregion


#region nD arrays

// ранг (rank) --> кол-во измерений

//int[] arr1 = [4, 5, 6, 7];
//int[,] arr2 = {
//    { 3, 4, 5 },
//    { 5, 6, 7 }
//};


//int[,] arr1;

//int[,] arr2 = new int[10, 12];

//int[,] arr3 = new int[2, 3] { {3, 4, 5 }, { 5, 6, 7 } };

//int[,] arr4 = new int[,] { { 3, 4, 5 }, { 5, 6, 7 } };

//int[,] arr5 = new[,] { { 3, 4, 5 }, { 5, 6, 7 } };

//int[,] arr6 = { { 3, 4, 5 }, { 5, 6, 7 } };




//int[,] arr = {
//    { 3, 4, 5 },
//    { 6, 7, 8 }
//};


////int rows = 2;
////int cols = 3;

//// int rows = arr.GetUpperBound(0) + 1;
//int rows = arr.GetLength(0);

//// int cols = arr.GetUpperBound(1) + 1;
//// int cols = arr.GetLength(1);
//int cols = arr.Length / rows;

//for (int i = 0; i < rows; ++i)
//{
//    for (int j = 0; j < cols; ++j)
//    {
//        Console.Write($"{arr[i, j]} ");
//    }
//    Console.WriteLine();
//}

#endregion


#region Зубчатый массив

int[][] arr = new int[3][];         // new Array<Array<int>>();
arr[0] = new int[2] { 3, 4 };
arr[1] = new int[4] { 5, 6, 7, 8 };
arr[2] = new int[3] { 3, 4, 5 };

foreach (int[] row in arr)
{
    foreach(int n in row)
    {
        Console.Write($"{n} ");
    }
    Console.WriteLine();
}

Console.WriteLine(arr[1][2]);

#endregion