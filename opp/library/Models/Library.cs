using library.Exeptions;
using System;

namespace library
{
    class Library : IPrintable
    {
        static private int ID = 0;


        public readonly int id;
        public string name { get; private set; }

        private Book[] books = new Book[0];

        private int Raiting;

        public int length { get { return this.books.Length; } }
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

        public Library(string name, int raiting)
        {
            this.id = Library.ID++;
            this.name = name;
            this.raiting = raiting;
        }

        public void print()
        {
            int length = this.length;
            if (length == 0)
            {
                Console.WriteLine("Library is empty");
                return;
            }

            Console.WriteLine("Books in library #{0}:", this.id);
            for (int index = 0; index < length; index++)
            {
                this.books[index].print();
            }
        }
        public void addBook(Book book)
        {
            int length = this.books.Length;
            Book[] array = new Book[length + 1];
            for (int index = 0; index < length; index++)
            {
                array[index] = this.books[index];
            }
            array[length] = book;
            Array.Sort(array);
            this.books = array;
        }

        public void removeBook(int bookId)
        {
            int length = this.length;
            Book[] array = new Book[length - 1];
            try
            {
                for (int index = 0, newIndex = 0; index < length; index++)
                {
                    if (this.books[index].id != bookId)
                    {
                        array[newIndex++] = this.books[index];
                    }
                }
                this.books = array;
            }
            catch (IndexOutOfRangeException)
            {
                throw new NotBookException();
            }
        }

        public Book findBook(int id)
        {
            for (int index = 0; index < this.books.Length; index++)
            {
                if (this.books[index].id == id) return this.books[index];
            }
            throw new NotBookException();
        }
    }
}
