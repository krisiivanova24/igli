using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace igli
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> list2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> output = new List<int>();
            int ch = 0;
            int chC = 0;
            for (int i = 0; i < list2.Count; i++)
            {
                Console.WriteLine(list2[i]);

                if (list2[i] <= list1[0])
                {

                   // Console.WriteLine(list2[i]+" *****");

                    output.Add(0);
                }
                for (int j = 0; j < list1.Count - 1; j++)
                {
                     //Console.WriteLine($"{list2[i]} <= {list1[j + 1]}) && {list2[i]} > {list1[j]}");
                    
                    if (list1[j] == 0)
                    {//Console.WriteLine("---------------------------");
                        ch = list1[j - 1];
                        if (list1[j + 1] != 0 && list2[i] >= ch && list2[i] <= list1[j + 1])
                        {
                            output.Add(j++);
                            //Console.Write(list1[j] + " ");
                            //Console.WriteLine(ch + " " + list1[j + 1]);
                            break;
                        }
                        else
                        {
                            
                            while (list1[j] == 0)
                            {

                                j++; chC++;
                            }


                            //Console.WriteLine("////////////////////");
                            //Console.WriteLine($"{list2[i]} >= {ch} && {list1[j + 1]} <= {list2[i]})");
                            //Console.WriteLine("////////////////////");
                            if (list2[i] >= ch && list2[i] <= list1[j+1])
                            {
                               // Console.WriteLine(j + 1 + " ++++++");
                                output.Add((j) - chC);
                                break;
                            }
                            chC = 0;

                        }
                    }
                    
                    if (list2[i] <= list1[j + 1] && list2[i] >= list1[j])
                    {
                        //Console.WriteLine(j + 1 + " ++++++");
                        output.Add(j + 1);
                        break;

                    }
                }
            }
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
