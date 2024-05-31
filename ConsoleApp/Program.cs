using System;
class Program
{
    static void Main(string[] args)
    {
        // スペース区切りの整数の入力
        string input = Console.ReadLine();
        char[] splitStr = input.ToCharArray();
        int count = 0;
        for(int i = 0 ;i <= splitStr.Length-1;i++){
            if(splitStr[i] == '1'){
                count++;
            }
        }
        Console.WriteLine(count);
    }
}