using System;

namespace library
{
    class Book : ICloneable, IComparable, IPrintable
    {
        static private int ID = 0;


        public readonly int id;
        public string name { get; private set; }
        public string author { get; private set; }
        public int created_at { get; private set; }
        private int Raiting;
        public int raiting
        {
            get
            {
                return this.Raiting;
            }
            private set
            {
                if (value > Config.MAX_RAITING)
                {
                    this.Raiting = Config.MAX_RAITING;
                }
                else if (value < Config.MIN_RAITING)
                {
                    this.Raiting = Config.MIN_RAITING;
                }
                else
                {
                    this.Raiting = value;
                }
            }
        }

        public Book(string name, string author, int created_at, int raiting)
        {
            this.id = Book.ID++;
            this.name = name;
            this.author = author;
            this.created_at = created_at;
            this.raiting = raiting;
        }

        public Book(string name, string author, int created_at) : this(name, author, created_at, 0) { }
        public Book(string name, string author) : this(name, author, 0) { }


        public void print()
        {
            Console.WriteLine("-----------------------------------------------------------------");
            Console.Write("ID:{0}\nНазвание: {1}\nАвтор: {2}\nДата написания: {3}\nРейтинг: {4}\n", this.id, this.name, this.author, this.created_at, this.raiting);
        }

        public void update(Book data)
        {
            this.name = data.name;
            this.author = data.author;
            this.created_at = data.created_at;
            this.raiting = data.raiting;
        }

        public object Clone()
        {
            return new Book(this.name, this.author, this.created_at, this.raiting);
        }

        public int CompareTo(object book)
        {
            return this.raiting >= ((Book)book).raiting ? -1 : 1;
        }
    }
}
