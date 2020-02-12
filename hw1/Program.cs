using System;
/*
Создайте программу в которой создайте обобщенный класс книга(Book). Класс Book должен содержать универсальный параметра типа T(Book<T>). 
В теле класса создайте два закрытых поля: Name – имя книги(private string Name) и Price – (обобщенныйтип) цена книги (private T Price). 
Также создайте свойства для доступа к выше описанным полям.После чего создайте метод Show() который будет вывод название книги и ее цену.
В методе Main() создайте экземпляр обобщенного типа, где Т это int и T это string. 
*/
namespace hw1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book<string> book_str = new Book<string>();
            book_str.name = "Book1";
            book_str.price = "50";
            book_str.Show();
            Console.WriteLine(book_str.price.GetType());
            Console.WriteLine("-----");
            Book<int> book_int = new Book<int>();
            book_int.name = "Book2";
            book_int.price = 50;
            book_int.Show();
            Console.WriteLine(book_int.price.GetType());
            Console.ReadKey();
        }
    }

    public class Book<T>
    {
        private string Name;
        private T Price;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public T price
        {
            get { return Price; }
            set { Price = value;}
        }

        public void Show()
        {
            Console.WriteLine("Название книги: {0}; цена книги: {1}", Name, Price);
        }
    }
}
