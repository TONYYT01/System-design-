using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> Nums=new List<int>();

        Nums.Add(87);
        Nums.Add(10);
        Nums.Add(22);
        Nums.Add(78);
        // foreach (int nums in Nums)
        // {
        //     Console.WriteLine(nums);
        // }
        Nums.Sort();
        Console.WriteLine(Nums);
        foreach (int nums in Nums)
        {
            Console.WriteLine(nums);
        }
        Console.WriteLine(Nums.Count);

    }
}