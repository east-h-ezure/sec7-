using System;
using System.IO;

namespace Chap09_03
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "C:\\ユーザー\\h-ezure.EAST\\source\\repos\\shogyoumuzyou.txt";
            CreateFile(path);
            // Q3-1
            var count = CountChars(path);
            Console.WriteLine($"{count}文字あります");

            // Q3-2
            SplitComma(path);
        }

        // Q3-1 文字数をカウントするメソッド
        static int CountChars(string path)
        {
            var lines = File.ReadAllLines(path);
            var count = 0;
            foreach (var line in lines)
            {
                count += line.Length;
            }
            return count;
        }

        // Q3-2 読点で分割するメソッド
        private static void SplitComma(string path)
        {
            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var phrases = line.Split('、');
                foreach (var phrase in phrases)
                {
                    Console.WriteLine(phrase);
                }
            }
        }

        // 祇園精舎.txt を作成するメソッド
        static void CreateFile(string path)
        {
            var lines = new string[]
            {
                    "祇園精舍の鐘の声、諸行無常の響きあり。",
                    "娑羅双樹の花の色、盛者必衰の理をあらはす。",
                    "奢れる人も久しからず、ただ春の夜の夢のごとし。",
                    "猛き者もつひにはほろびぬ、ひとへに風の前の塵に同じ。"
            };
            File.WriteAllLines(path, lines);
        }
    }
}
