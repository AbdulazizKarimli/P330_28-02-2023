#region Task
//class Program
//{
//    static void Main()
//    {
//        //Console.WriteLine(Pow(4));

//        //Console.WriteLine(Sum(11));
//    }
//    //static int Pow(int f)
//    //{
//    //    return f * f;
//    //}

//    //static int Area(int r)
//    //{
//    //    int pi = 3;

//    //    return pi * (r * r);
//    //}

//    //static int Area(int a, int b)
//    //{
//    //    return a * b;
//    //}

//    //static double Area(double a, double b, double c, double r)
//    //{
//    //    double p = (a + b + c) / 2;

//    //    return p * r;
//    //}

//    //static int Sum(int number)
//    //{
//    //    int result = 0;
//    //    for (int i = 0; i < number; i++)
//    //    {
//    //        if (i + result < number)
//    //        {
//    //            result += i;
//    //        }
//    //    }

//    //    return result;
//    //}
//}
#endregion

#region Value, Referance
//int a = 5;
//int b = a;
////b = 6;

//Console.WriteLine($"a={a}; b={b}");
//Console.WriteLine(a == b);

//int[] arr = { 1, 2, 3 };
//int[] arr1 = arr;
//arr1[0] = 5;

//int[] arr2 = { 1, 2, 3 };

//Console.WriteLine($"arr[0]={arr[0]}; arr1[0]={arr1[0]}");

//Console.WriteLine(arr1 == arr2);

//int? a = null;

//int number = 5;
//Console.WriteLine(number);
//Print(number);


//void Print(int a)
//{
//    a = 6;
//    Console.WriteLine(a);
//}

//int[] numbers = { 1, 2, 3 };
//Print(numbers);
//Console.WriteLine(numbers[0]);

//void Print(int[] arr)
//{
//    arr[0] = 5;
//    Console.WriteLine(arr[0]);
//}

//int number = 5;
//Print(out number);
//Console.WriteLine(number);


//void Print(out int a)
//{
//    a = 6;
//    Console.WriteLine(a);
//}
#endregion

#region Array


//Console.WriteLine(Array.IndexOf(numbers, 2));
//Array.Reverse(numbers);

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}

//Array.Sort(numbers);
//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}

//int[] arr = new int[numbers.Length];

//numbers.CopyTo(arr, 0);
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}

//arr[0] = 10;
//Console.WriteLine(arr[0]);
//Console.WriteLine(numbers[0]);

//int[] CopyTo(int[] array, int startIndex)
//{
//    int[] newArr = new int[array.Length];

//    for (int i = startIndex; i < array.Length; i++)
//    {
//        newArr[i] = array[i];
//    }

//    return newArr;
//}

//int[] arr1 = CopyTo(numbers, 0);

//foreach (var item in arr1)
//{
//    Console.WriteLine(item);
//}

//Array.Resize(ref numbers, numbers.Length + 1);

//foreach (var item in numbers)
//{
//    Console.WriteLine(item);
//}
//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 2, 6, -3 };
//        Console.WriteLine(IndexOf(numbers, 2));
//    }

//    static int IndexOf(int[] arr, int value)
//    {
//        for (int i = 0; i < arr.Length; i++)
//        {
//            if (arr[i] == value)
//                return i;
//        }

//        return -1;
//    }
//}
#endregion