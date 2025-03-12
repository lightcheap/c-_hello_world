using System;

class Program3
{
    static void Main()
    {
        // ２つの整数が与えられる
        string[] input = Console.ReadLine().Trim().Split(' ');
        int M = int.Parse(input[0]);
        int N = int.Parse(input[1]);

        int count = 0;

        // 底辺の長さを1からM-1までループ
        for (int a = 1; a < M; a++)
        {
            // 高さの長さを1からN-1までループ
            for (int b = 1; b < N; b++)
            {
                // 斜辺の長さを計算
                double c = Math.Sqrt(a * a + b * b);

                // 斜辺が整数であるかをチェック
                if (c == (int)c)
                {
                    count++;
                }
            }
        }

        // 結果を出力
        Console.WriteLine(count);
    }
}
