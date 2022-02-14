using System;

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            var book1 = new Book
            {
                Title = "吾輩は猫である",
                Author = "夏目漱石",
                Pages = 610,
                Rating = 4
            };

            var book2 = new Book
            {
                Title = "人間失格",
                Author = "太宰治",
                Pages = 212,
                Rating = 5
            };

            var sale = new Sale
            {
                ProductName = "おにぎり",
                UnitPrice = 120,
                Quantity = 4
            };
            Console.WriteLine("Printメソッドを呼び出します");
            book1.Print();
            book2.Print();
            Console.WriteLine("Printメソッドの処理が終わりました");

            var amount = sale.GetAmount();
            Console.WriteLine($"合計金額：{amount}円");

            var bmicalc = new BmiCalculator();
            var bmi = bmicalc.GetBmi(158, 45);
            var type = bmicalc.GetBodyType(bmi);
            Console.WriteLine($"あなたは「{type}」です。");

            var date = new DateTime(2019, 4, 30);
            var date1 = date.AddDays(1);
            var date2 = date.AddMonths(6);
            Console.WriteLine(date1);
            Console.WriteLine(date2);
           
            //静的メソッド(new演算子が不要)
            var isLeapYear = DateTime.IsLeapYear(2021);
            if (isLeapYear)
            {
                Console.WriteLine("うるう年です");
            }
            else
            {
                Console.WriteLine("うるう年ではありません");
            }

            //インスタンス不要で使えるプロパティ→静的プロパティ
            var today = DateTime.Today;
            Console.WriteLine($"{today.Year}年{today.Month}月{today.Day}日");

            var book3 = new Book { Title2 = "伊豆の踊子", Author2 = "あいうえお" };
            book3.PrintTitle();
            var book4 = new Book { Title2 = "走れメロス", Author2 = "太宰治" };
            book4.PrintTitle();
            Book.ClearCount();
            Console.WriteLine(Book.Count);
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }

        //classの内側にメソッドを置く(外側には置けない)
        public void Print()
        {
            //thisは省略できる
            Console.WriteLine($"■{Title}");
            Console.WriteLine($"{Author} {Pages}ページ　評価：{Rating}");

        }

        //静的メソッドと静的プロパティの定義
        public static int Count { get; set; }
        public static void ClearCount()
        {
            Count = 0;
        }
        public string Title2 { get; set; }
        public string Author2 { get; set; }

        public void PrintTitle()
        {
            Console.WriteLine("書籍名：{0}", Title2);
            Count++;
            Console.WriteLine(Count);
        }
    }

    class Sale
    {
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int GetAmount()
        {
            return UnitPrice * Quantity;
        }
    }
  class  BmiCalculator
    {
        public double GetBmi(int height, int weight)
        {
            var metersTall = height / 100.0;
            var bmi = weight / (metersTall * metersTall);
            return bmi;
        }

        public string GetBodyType(double bmi)
        {
            var type = "";
            if (bmi < 18.5)
            {
                type = "やせ型";
            }
            else if (bmi < 25)
            {
                type = "普通体重";
            }
            else if (bmi < 30)
            {
                type = "肥満一度";
            }
            else if (bmi < 35)
            {
                type ="肥満2度";
            }
            else if(bmi < 40)
            {
                type = "肥満３度";
            }
            else
            {
                type = "肥満4度";
            }
            return type;
        }
    }

    
}