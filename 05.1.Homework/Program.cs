namespace _05._1.Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book[] books = new Book[3];

            books[0] = new Book("Suç ve Ceza", "Dostoyevski", 687);
            books[1] = new Book("Sefiller", "Victor Hugo", 1200);
            books[2] = new Book("Kürk Mantolu Madonna", "Sabahattin Ali", 160);

            foreach (Book book in books)
            {
                Console.WriteLine(book.Info());
            }

            Book longestBook = books[0];

            foreach (Book book in books)
            {
                if (book.Pages > longestBook.Pages)
                {
                    longestBook = book;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Book with the most pages:");
            Console.WriteLine(longestBook.Info());
        }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        private int pages;

        public int Pages
        {
            get { return pages; }
            set
            {
                if (value > 0)
                {
                    pages = value;
                }
                else
                {
                    pages = 1;
                }
            }
        }

        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }

        public string Info()
        {
            return Title + " by " + Author + ", " + Pages + " pages";
        }
    }

}
