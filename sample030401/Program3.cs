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

        // --------------------------------
        //
        // --------------------------------
        // キーの耐久度を読み取る
        string[] durabilityInput = Console.ReadLine().Trim().Split(' ');
        int[] durability = Array.ConvertAll(durabilityInput, int.Parse);

        // 入力される文字列を読み取る
        string inputString = Console.ReadLine().Trim();

        // 結果を格納するための文字列
        string result = "";

        // 入力された文字列を1文字ずつ処理
        foreach (char c in inputString)
        {
            // ↑のchar c は　Unicode
            //
            //
            int index = c - 'a'; // 'a'のUnicodeコードポイントを引いてインデックスを計算

            // 耐久度が残っている場合のみ文字を追加
            if (durability[index] > 0)
            {
                result += c;
                durability[index]--; // 耐久度を減らす
            }
        }

        // 結果を出力
        Console.WriteLine(result);

        // --------------------------------
        //
        // --------------------------------
        char letterA = 'a';
        char letterC = 'c';

        System.Console.WriteLine(letterA);  // これはそのまま文字列の「a」が出る
        System.Console.WriteLine((int)letterA);  // これは 数値の97がでる

        System.Console.WriteLine(letterC);
        System.Console.WriteLine((int)letterC);

        int index = letterC - letterA;    // 格納する変数をintにすると、文字のUnicodeコードポイントの差が出る
        System.Console.WriteLine(index);  // これは数値の2が出る


    }
}
