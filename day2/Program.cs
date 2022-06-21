using System;
class Program
{
    static void Main()
    {
        int[] nums = { 100, 105, 103, 104, 105, 106, 103, 104, 105, 100, 106, 103};
        Array.Sort(nums);
        int count = 1;
        for (int i = 0; i < nums.Length; i++)
        {           
            if (i>0 && nums[i] == nums[i-1])
            {
                count++;
                if(i == nums.Length-1)
                {
                    Console.WriteLine("Couting " + nums[i].ToString() + " " + count);
                }
                else
                {
                    if (nums[i] != nums[i + 1])
                    {
                        Console.WriteLine("Couting " + nums[i].ToString() + " " + count);
                    }
                }
                          
            }
            else
            {
                count = 1;
            }            
        }              
        Console.ReadLine();
    }

}