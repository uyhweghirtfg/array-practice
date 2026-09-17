using System;
namespace Task3
{


class Program
{
    static bool IsExists(int[] a, int b)
    {
        foreach(int e1 in a)
        if (e1==b) return true;
        return false;
    }
    static void Main()
    {
        int[] arr=new int[10];
        Random random=new Random();
        for(int i=0;i<arr.Length;i++)
        arr[i]=random.Next(1,6);
        System.Console.WriteLine(string.Join(", ", arr));
        int j=0;
        int[] t=new int [0];
        foreach(int e1 in arr)
        if (!IsExists(t,e1))
        {
            Array.Resize(ref t,j+1);
            t[j]=e1;
            j++;
        }
        System.Console.WriteLine(string.Join(", ", t));
    }
}
}

