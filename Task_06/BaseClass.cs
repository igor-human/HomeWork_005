using System;

namespace Indexers
{
    class BaseClass
    {
        private string[] baseArray = null;

        // Конструктор.
        public BaseClass()
        {
            baseArray = new string[3];
            baseArray[0] = "Нуль";
            baseArray[1] = "Один";
            baseArray[2] = "Два";
        }

        // Віртуальний індексатор.
        public virtual string this[int index]
        {
            get { return baseArray[index]; }
        }
    }
}
