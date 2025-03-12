using System;

class Program2
{
    static void Main()
    {
        // 入力を読み取る
        string[] firstLine = Console.ReadLine().Trim().Split(' ');
        int N = int.Parse(firstLine[0]);
        int M = int.Parse(firstLine[1]);

        string[] secondLine = Console.ReadLine().Trim().Split(' ');
        int[] a = Array.ConvertAll(secondLine, int.Parse);

        // 0がM回連続で出現するかをチェックする
        int consecutiveZeros = 0;
        bool isNG = false;

        for (int i = 0; i < N; i++)
        {
            if (a[i] == 0)
            {
                consecutiveZeros++;
                if (consecutiveZeros == M)
                {
                    isNG = true;
                    break;
                }
            }
            else
            {
                consecutiveZeros = 0;
            }
        }

        // 結果を出力する
        if (isNG)
        {
            Console.WriteLine("NG");
        }
        else
        {
            Console.WriteLine("OK");
        }
    }
}
