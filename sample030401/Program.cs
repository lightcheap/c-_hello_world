// $は、文字列内に変数や式を埋め込むことができます。
// 具体的には、$を使うと、文字列内の {} で囲まれた部分に変数や式の値が挿入されます。

string name = "山田太郎";
Console.WriteLine($"あなたの名前は、{name} ですね。");

char singleLetter = 'A';
Console.WriteLine($"データ型 charは、{singleLetter} のような単一の文字のみ入ります。");

// 一つの文字列内に複数の変数や式を埋め込むこともできます。
// {} で囲まれた部分には、変数や式の値が挿入されます。
Console.WriteLine($"今日は {DateTime.Now.ToString("yyyy年MM月dd日")} です。現在の時刻は {DateTime.Now.ToString("HH:mm:ss")} です。");

// C# でif文を書く
// C#では "==="は使用しない。"=="で型の比較を行う。
string name2 = "山田太郎";
if (name2 == "山田太郎")
{
    Console.WriteLine("あなたの名前は山田太郎ですね。");
}
else
{
    Console.WriteLine("あなたの名前は山田太郎ではありません。");
}

string age = "20";
if (age == "20")
{
    Console.WriteLine("あなたの年齢は20歳ですね。");
}
else
{
    Console.WriteLine("あなたの年齢は20歳ではありません。");
}

if (true) {

}
