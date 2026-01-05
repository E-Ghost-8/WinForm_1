using System;

//数値を管理するクラス
class Counter
{
    private int count = 99;
    
    //現在の値を取得
    public int GetValue()
    {
        return count;
    }
    //「1」増やす。上限は「100」までに設定。
    public void increment()
    {
        if(count < 100)
        {
            count++;
        }
    }
    //「1」減らす。下限は「0」までに設定。
    public void Decrement()
    {
    if(count > 0)
        count--;
    }
    public void Reset()
    {
        count = 0;
    }
}

//カウンターを1個作る
class Program
{
    static void Main()
    {
        Counter counter = new Counter();

        //終わるまで繰り返す
        while (true)
        {
            Console.WriteLine($"現在の値:{counter.GetValue()}");
            Console.WriteLine("「+」で増やす/「-」で減らす/「r」でリセット/「q」で終了");

            //キーボード入力を受け付ける
            string input = Console.ReadLine();

            if (input == "+")
            {
                counter.increment();
            }
            else if (input == "-")
            {
                counter.Decrement();
            }
            else if (input == "q")
            {
                break;
            }
            else if(input == "r")
            {
                counter.Reset();
            }
            else
            {
                Console.WriteLine("入力が違います");
            }
            Console.WriteLine();
        }
    }
}