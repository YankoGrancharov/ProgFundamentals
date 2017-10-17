using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2ChangeList
{
    class Task2ChangeList
    {
        static void Main()
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> comand = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                

                if (comand[0]=="Delete")
                {
                    int numRemuv = int.Parse(comand[1]);
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] == numRemuv)
                        {
                            nums.Remove(nums[i]);
                            i--;
                        }
                    }
                }
                else if (comand[0] == "Insert")
                {
                    int element = int.Parse(comand[1]);
                    int posit = int.Parse(comand[2]);
                    nums.Insert(posit, element);
                }
                else if (comand[0] == "Even")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i]%2==0)
                        {
                            Console.Write($"{nums[i]} ");
                        }
                        
                    }
                    break;
                }
                else if (comand[0] == "Odd")
                {
                    for (int i = 0; i < nums.Count; i++)
                    {
                        if (nums[i] % 2 == 1)
                        {
                            Console.Write($"{nums[i]} ");
                        }

                    }
                    break;
                }

                comand = Console.ReadLine().Split(' ').ToList();

            }
                

        }
    }
}
