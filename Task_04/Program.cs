using System;
using System.Text;
using Task_04;

public class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Article[] articles = new Article[]
        {
            new Article("Книга", "Книгарня", 250),
            new Article("Ноут", "ОЛХ", 15000),
            new Article("Смартфон", "Алло", 8000),
        };

        Store store = new Store(articles);

        Console.WriteLine("Інформація про товар за індексом 1:");
        store.DisplayInfo(1);

        Console.WriteLine("\nПошук товару за назвою 'Смартфон':");
        store.FindAticleByName("Смартфон");
    }
}
