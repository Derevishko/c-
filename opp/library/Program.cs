namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Король лев", "я", 123, 5);
            Book book2 = new Book("Как приручить крысу", "Егор", 123, 2);
            Book book3 = new Book("Растрел как искуство", "Сталин", 123, 3);

            Library library1 = new Library("Номер 1", 7);

            library1.addBook(book1);
            library1.addBook(book2);
            library1.addBook(book3);


            object book4 = book1.Clone();
            Book book5 = (Book)book2.Clone();
            book5.print();

            library1.print();

        }
    }
}
