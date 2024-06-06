using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Who_Ate_the_Cake
    {
        static void Who_Ate_the_Cake_Main()
        {
            // スペース区切りの整数の入力
            string input_raw = Console.ReadLine();
            string[] input = input_raw.Split(" ");
            // 1~3
            string result = "123";
            foreach (string s in input)
            {
                result = result.Replace(s.Trim(), "");
            }
            if (result.Length > 1)
            {
                result = "-1";
            }

            Console.WriteLine(result);
        }
    }
}
