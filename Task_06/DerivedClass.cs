using System;

namespace Indexers
{
    class DerivedClass : BaseClass
    {
        private string[] derivedArray = null;
        private string[] ruArray = null;

        // Конструктор.
        public DerivedClass()
        {
            derivedArray = new string[3];
            derivedArray[0] = "Zero!";
            derivedArray[1] = "One!";
            derivedArray[2] = "Two!";
            ruArray = new string[3];
            ruArray[0] = "Ноль!";
            ruArray[1] = "Один!";
            ruArray[2] = "Два!";
        }

        // Перевизначений індексатор.
        public override string this[int index]
        {
            get { return base[index] + " - " + derivedArray[index] + " - " + ruArray[index]; }
        }

        public void Search(string name)
        {
            bool found = false;
            int index = 0;
            foreach (string item in ruArray)
            {          
                if (name == ruArray[index] || name == derivedArray[index] || name == base[index])//порівнюємо рядки
                {                  
                    Console.WriteLine("Знайдено слово: " + base[index] + " - " + derivedArray[index] + " - " + ruArray[index]);
                    found = true;
                    break;
                }
                index++;
            }
            if (!found)
            {
                Console.WriteLine($"Товар з назвою '{name}' не знайдено");
            }

        }

    }
}
