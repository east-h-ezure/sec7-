using System;

namespace ClassSample
{
    class Program
    {
        static void Main()
        {
            var book = new Book();
            book.Title = "吾輩は猫である";
            book.Author = "夏目漱石";
            book.Pages = 610;
            book.Rating = 4;
            Console.WriteLine($"書籍名：{book.Title}");
            Console.WriteLine($"著者名：{book.Author}");
            Console.WriteLine($"ページ数：{book.Pages}");
            Console.WriteLine($"評価：{book.Rating}");
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }
    }
}