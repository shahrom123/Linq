

#region Task1
//int n;

//n = Convert.ToInt32(Console.ReadLine());

//int[] Numbers= new int[n];

//for (int i = 0;i < n; i++)
//{
//    Numbers[i]= Convert.ToInt32(Console.ReadLine());
//}
//Console.WriteLine("Asending Order: ");
//Array.Sort(Numbers);

//foreach (var Number in Numbers)
//{
//    Console.Write(" " + Number);
//}
//Console.WriteLine();
//Console.WriteLine("Desending Order: ");
//Array.Reverse(Numbers); 
//foreach(var Number in Numbers)
//{
//    Console.Write(" " + Number);
//}

#endregion

#region Task2

//int n, cnt=0;

//n = Convert.ToInt32(Console.ReadLine());
//int[] arr= new int[n];
//for (int i = 0; i < n; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//for (int i = 1;i < n; i++)
//{
//    if (arr[i] > arr[i-1])
//    {
//        cnt++;
//    }
//}
//Console.WriteLine(cnt);

#endregion

#region Task3

//int n, cnt = 0;

//n = Convert.ToInt32(Console.ReadLine());
//int[] arr = new int[n];
//for (int i = 0;i < n; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}
//foreach (int i in arr)
//{
//    cnt*=i;
//}
//Console.WriteLine(cnt);

#endregion

#region Task4
//int n;

//n = Convert.ToInt32(Console.ReadLine());

//int[]arr = new int[n];

//for (int i = 0;i < n; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//Array.Sort(arr);
//Console.Write("Smallest:");
//foreach (int i in arr.Take(3))
//{
//    Console.Write(" " + i);
//}

//Console.WriteLine();    
//Array.Reverse(arr);
//Console.Write("Biggest: ");
//foreach(int i in arr.Take(3))
//{
//    Console.Write(" " + i);
//}

#endregion

#region Task5

//double GetAverege(int[] arr, int size)
//{
//    int sum = 0;
//    for (int i = 0; i < size; i++)
//    {
//        sum += arr[i];
//    }
//    double averege = (double)sum / size;
//    return averege;
//}
//int n;

//n = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[n];
//for (int i = 0; i < n; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());

//}
//double averege = GetAverege(arr, arr.Length);

//Console.WriteLine("Averege: " + averege);

#endregion

#region Task6

//int n, x, cnt=0;

//n = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[n];
//for (int i = 0; i < n; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());

//}
//x =Convert.ToInt32(Console.ReadLine());

//foreach (int i in arr)
//{
//    if (i==x)
//    {
//        cnt++;
//    }
//}

//if(cnt>0)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}

#endregion

#region Task7
//int cnt = 0; 
// bool IsPrime(int n)
//{
//	for (int i = 1; i <=n; i++)
//	{
//		if(n%i==0)
//		{
//			cnt++;
//		}

//	}
//	if(cnt==2)
//	{
//		Console.WriteLine("Yes");
//        return true;
//    }
//	else
//	{
//		Console.WriteLine("No");
//        return false;
//    }
//}
//int n;
//n = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Number Is prime or No: ");
//bool prime = IsPrime(n);

//Console.WriteLine(prime);

#endregion

#region Task8

//int n;

//n = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[n];

//for (int i = 0;i < n; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//Console.Write("Even elements: ");

//foreach (int i in arr)
//{
//    if (i % 2 == 0)
//    {
//        Console.Write(i + " ");
//    }
//}

//Console.WriteLine();
//Console.Write("Odd elements: ");

//foreach (int i in arr)
//{
//    if(i % 2 != 0)
//    {
//        Console.Write(i + " ");
//    }
//}

#endregion

#region Task9

//int n, a, cnt=1;

//n = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[n];

//for (int i = 0; i < n; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}
//a = Convert.ToInt32(Console.ReadLine()); 
//foreach (int i in arr)
//{
//    if (i<=a)
//    {
//        cnt++;
//    }
//}
//Console.Write("line Abdulloh = " + cnt);

#endregion

#region Task10

//int n, cnt=0;

//n = Convert.ToInt32(Console.ReadLine());

//int[] arr = new int[n];

//for (int i = 0; i < n; i++)
//{
//    arr[i] = Convert.ToInt32(Console.ReadLine());
//}

//for(int i = 1; i < n; i++)
//{
//    if (arr[i] < arr[i-1] && arr[i] < arr[i+1])
//    {
//      cnt++;
        
//    }
//}
//if(cnt > 0)
//{
//    Console.WriteLine("Yes");
//}
//else
//{
//    Console.WriteLine("No");
//}

#endregion





