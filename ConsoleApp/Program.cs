using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Program program = new Program();
        program.ABC087B();
    }

    private void ABC087B()
    {
        string input_A = Console.ReadLine();
        string input_B = Console.ReadLine();
        string input_C = Console.ReadLine();
        string input_X = Console.ReadLine();

        List<int> list = new List<int>();
        // Aは500円
        // Bは100円
        // Cは50円
        for (int a = 0; a <= int.Parse(input_A); a++)
        {
            for (int b = 0; b <= int.Parse(input_B); b++)
            {
                list.Add(a * 500 + b * 100);
            }
        }
        List<int> sumList = new List<int>();
        for (int c = 0; c <= int.Parse(input_C); c++)
        {
            foreach(int li in list)
            {
                sumList.Add(li + c * 50);
            }
        }
        int count = 0;
        foreach(int data in sumList)
        {
            if (data == int.Parse(input_X))
            {
                count++;
            }
        }
        Console.WriteLine(count);
    }
}