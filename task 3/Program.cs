



namespace task_3
{
    public class book
    {
       public string title;
       public string author;
       public  string isbn;
       public  bool availability;
  
        public book(string title, string author, string isbn, bool availability=true)
        {
            this.title = title;
            this.author = author;
            this.isbn = isbn;
            this.availability = availability =true;
        }
    }
    public class library
    {
        public List<book> books = new List<book>( );



        public string addBook(book book)

        {
            books.Add(book);
            return "book is added";
        }

        public string searchbook(string key )
        {

            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].title == key || books[i].author == key)

                {
                    return "is founded";
                }

            }
            return "book is not founded";
        }
        public string borrowbook(string key)
        {
            for (int i = 0; i < books.Count; i++)
            {

                if ((books[i].isbn == key || books[i].title == key || books[i].author == key) && books[i].availability)
                {
                    books[i].availability = false;
                    return "you can borrow the book";
                }


            }
            return "the book is not available";
        }

        public string returnbook(string key)
        {
            for (int i = 0; i < books.Count; i++)
            {

                if (books[i].isbn == key || books[i].title == key || books[i].author == key)
                {
                    books[i].availability = true;
                    return "the book is returned";
                }
            }
            return "can't find the book";

        }

    }
        
    internal class Program
    {
        static void Main(string[] args)
        {
            library lib = new library();

            
            Console.WriteLine(lib.addBook(new book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565")));
            Console.WriteLine(lib.addBook(new book("1984", "George Orwell", "9780451524935")));
            Console.WriteLine(lib.addBook(new book("To Kill a Mockingbird", "Harper Lee", "9780061120084")));

            Console.WriteLine(); 

            Console.WriteLine("Search for 'George Orwell': " + lib.searchbook("George Orwell"));
            Console.WriteLine("Search for 'J.K. Rowling': " + lib.searchbook("J.K. Rowling"));
            Console.WriteLine();

            Console.WriteLine("Borrowing book Gatsby: " + lib.borrowbook("Gatsby"));
            Console.WriteLine("Borrowing book (1984): " + lib.borrowbook("1984"));
            Console.WriteLine("Trying to borrow Harry Potter : " + lib.borrowbook("Harry Potter"));

            Console.WriteLine(); 

            
            Console.WriteLine("Returning book (1984): " + lib.returnbook("Gatsby"));
            Console.WriteLine("Returning non exist book: " + lib.returnbook("Harry Potter"));


            while (true)
            {

                Console.WriteLine("A - Add book");
                Console.WriteLine("S - Search book");
                Console.WriteLine("B - Borrow book");
                Console.WriteLine("R - Return book");
                Console.WriteLine("Q - quit");
                Console.Write("Enter your choice: ");
                string opration = Console.ReadLine();
                opration = opration.ToUpper();
                switch (opration)
                {

                    case "A":
                        Console.Write("Enter the book title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter the author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter the ISBN: ");
                        string isbn = Console.ReadLine();

                        lib.addBook(new book(title, author, isbn));
                        Console.WriteLine("the book is added");
                        break;
                    case "S":
                        Console.Write("Enter the book name to search: ");
                        string key = Console.ReadLine();
                        lib.searchbook(key);
                        break;
                    case "B":
                        Console.Write("Enter the name of the book you want to borrow: ");
                        string name = Console.ReadLine();
                        lib.borrowbook(name);
                        break;
                    case "R":
                        Console.Write("Enter the book title to return: ");
                        string keyword = Console.ReadLine();
                        lib.returnbook(keyword);
                        break;
                    case "Q":
                        Console.WriteLine("good bye");

                        return;
                        break;


                    default:
                        Console.WriteLine("invalid input");
                        break;
                }
            }





            }
        }
}
