using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    public class Article
    {
        private string productName;
        private string storeName;
        private decimal priceInUAH;

        public Article(string productName, string storeName, decimal priceInUAH)
        {
            this.productName = productName;
            this.storeName = storeName;
            this.priceInUAH = priceInUAH;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Назва товару: {productName}");
            Console.WriteLine($"Назва магазину: {storeName}");
            Console.WriteLine($"Вартість товару: {priceInUAH}");
        }

        public string GetProductName()
        {
            return productName;
        }
    }
    public class Store
    {
        private Article[] articles;

        public Store(Article[] articles)
        {
            this.articles = articles;
        }

        public void DisplayInfo(int index) //Вивод інфи по індексу
        {
            if (index >= 0 && index < articles.Length)
            {
                articles[index].DisplayInfo();
            }
            else
            {
                Console.WriteLine("Індекс виходить за межі масиву");
            }
        }

        public void FindAticleByName(string productName)
        {
            bool found = false;

            foreach (Article article in articles)
            {
                if (article.GetProductName().Equals(productName, StringComparison.OrdinalIgnoreCase))//порівнюємо рядки без урахування регістру
                {
                    article.DisplayInfo();
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine($"Товар з назвою '{productName}' не знайдено");
            }

        }
    }
}
