using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsoleApp
{
    class Program
    {
        public static LibraryEntities context = new LibraryEntities();
        static void Main(string[] args)
        {
            //foreach (var author in context.Authors)
            //{
            //    Console.WriteLine(author.FirstName +" " +  author.LastName);
            //}
            Menu();
            
        }
        static void Menu()
        {
            Console.WriteLine("Welcome to Book Storage App");
            Console.WriteLine("Possible things to do:\n1)insert a new book");
            Console.WriteLine("2)Insert a new author");
            Console.WriteLine("3)get all books in the library sorted by title");
            Console.WriteLine("4)get all books in the library sorted by author");
            Console.WriteLine("5)get all books sorted by gendre");
            Console.WriteLine("6)get all types of gendres a certain author has written");
            Console.WriteLine("7)get all books written by an author chosen by name");
            Console.WriteLine("8)get all the information about a book by its ISBN");
            Console.WriteLine("9)get complete information for a book by its title");
            Console.WriteLine("10)loan a book to a user");
            Console.WriteLine("11)return a loaned book");
            Console.WriteLine("exit to exit");
            Console.WriteLine("Input the number of the option you have chosen");
            string option = Console.ReadLine();
            if (option == "1")
            {
                InsertBook();
            }
            else if (option == "2")
            {
                InsertAuthor();
            }
            else if (option == "3")
            {
                GetAllBooksByTitle();
            }
            else if (option == "4")
            {
                GetAllBooksByAuthor();
            }
            else if (option == "5")
            {
                GetAllBooksByGendre();
            }
            else if (option == "6")
            {
                GetAllGenresByAnAuthor();
            }
            else if (option == "7")
            {
                GetAllBooksWrittenByAnAuthor();
            }
            else if (option == "8")
            {
                GetAllInforAboutABookByISBN();
            }
            else if (option == "9")
            {
                GetAllInfoByTitle();

            }
            else if (option == "10")
            {
                LoanABook();
            }
            else if (option == "11")
            {
                ReturnABook();
            }
            else if (option == "exit")
            {
                Console.WriteLine("exit to exit is exiting by the exit.");
            }
            else
            {
                Console.WriteLine("Invalid option please insert a correct number or \"exit\" to exit");
                Menu();
            }
        }
        static void InsertBook()
        {
            Books book = new Books();
            book.Quantity = true;
            Console.WriteLine("Input the new books title");
            book.Title = Console.ReadLine();
            Console.WriteLine("Input the new books publisher");
            book.Publisher = Console.ReadLine();
            Console.WriteLine("Input the year of the publishing (no books below 1800 are allowed)");
            string temp = Console.ReadLine();
            if (IntVerification(temp, 1800, 2016))
            {
                book.DatePublised = Int32.Parse(temp);
            }
            else
            {
                Console.WriteLine("Try again..make sure you input a year between 1800 and 2016..if you fail the default will be given - 1900");
                temp = Console.ReadLine();
                if (IntVerification(temp, 1800, 2016))
                {
                    book.DatePublised = Int32.Parse(temp);
                }
                else
                {
                    book.DatePublised = 1900;
                }
            }
            Console.WriteLine("Input the number of pages (makes sure its a reasonable number)");
            temp = Console.ReadLine();
            if (IntVerification(temp, 1, Int32.MaxValue))
            {
                book.DatePublised = Int32.Parse(temp);
            }
            else
            {
                Console.WriteLine("Try again..make sure you input a year between 1800 and 2016..if you fail the default will be given - 500");
                temp = Console.ReadLine();
                if (IntVerification(temp, 1, Int32.MaxValue))
                {
                    book.DatePublised = Int32.Parse(temp);
                }
                else
                {
                    book.DatePublised = 500;
                }
            }
            Console.WriteLine("Insert an ISBN code for the book (it must be unique for every book and is a 4 digit int)");
            bool check = true;
            temp = Console.ReadLine();
            while (check)
            {
                foreach (var bok in context.Books)
                {
                    if (bok.ISBN == temp)
                    {
                        Console.WriteLine("You must input a different ISBN, this one is being used");
                        temp = Console.ReadLine();
                    }
                }
                check = false;
                book.ISBN = temp;
            }
            context.Books.Add(book);
            context.SaveChanges();
        }


        static void InsertAuthor()
        {
            Authors author = new Authors();
            Console.WriteLine("Input the number of books this author has written(if you do not input a valid integer the deafult value 3 is given)");
            string temp = Console.ReadLine();
            if (IntVerification(temp, 0, 100))
            {
                author.BooksWritten = Int32.Parse(temp);
            }
            else
            {
                author.BooksWritten = 3;
            }
            Console.WriteLine("Input the authors first name:");
            author.FirstName = Console.ReadLine();
            Console.WriteLine("Input the author's last name");
            author.LastName = Console.ReadLine();
            Console.WriteLine("Input his/her birthyear(any birthday before year 1 or after 2006 is invalid and will be given a default value of 1976):");
            temp = Console.ReadLine();
            if (IntVerification(temp, 1, 2005))
            {
                author.YearBorn = Int32.Parse(temp);
            }
            else
            {
                author.YearBorn = 1976;
            }
            

            context.Authors.Add(author);
            context.SaveChanges();

        }

        static void GetAllBooksByTitle()
        {
            var x =
                from book in context.Books
                orderby book.Title
                select book;
            foreach (var b in x)
            {
                Console.WriteLine(b.Title);
            }

        }
        static void GetAllBooksByAuthor()
        {

            var booksByAuthor = from author in context.Authors
                        from book in author.Books
                        orderby author.AuthorID
                        select new {book.Title, authordID = author.AuthorID };

            foreach (var el in booksByAuthor)
            {
                Console.WriteLine(el);
            }

            

        }
        static void GetAllBooksByGendre()
        {
            var booksByGenre = from genre in context.Genres
                               from books in genre.Books
                               orderby genre.GenreID
                               select new{ books.Title,genre = genre.Name};

            foreach (var el in booksByGenre)
            {
                Console.WriteLine(el);
            }

        }
        static void GetAllGenresByAnAuthor()
        {
            Dictionary<int, ISet<string>> collection = new Dictionary<int, ISet<string>>();
            var books = context.Books;
            foreach (var book in books)
            {
                foreach (var author in book.Authors)
                {
                    foreach (var genre in book.Genres)
                    {
                        if (!(collection.ContainsKey(author.AuthorID)))
                        {
                            collection.Add(author.AuthorID, new HashSet<string>());
                        }
                        collection[author.AuthorID].Add(genre.Name);

                        
                    }
                }
            }
            foreach (KeyValuePair<int,ISet<string>> item in collection)
            {
                foreach (var genre in item.Value)
                {
                    Console.WriteLine("{0} - {1}", item.Key, genre);
                }
            }

        }
        static void GetAllBooksWrittenByAnAuthor()
        {
            Console.WriteLine("Input author name");
            string[] tempstr = AuthorNameInput();
            string firstName = tempstr[0];
            string lastName = tempstr[1];


            var author = from b in context.Books
                          from a in b.Authors
                          select a.AuthorID;

            var books = from authors in context.Authors
                        join bookAuthor in author on authors.AuthorID equals bookAuthor
                        join book in context.Books on bookAuthor equals book.BookID
                        where authors.FirstName == firstName && authors.LastName == lastName
                        select book.Title;

            foreach (var el in books)
            {
                Console.WriteLine(el);
            }


        }
        static void GetAllInforAboutABookByISBN()
        {
            var books = context.Books;
            var isbns = from book in books
                        select book.ISBN;

            Console.WriteLine("ISBN in this library is a 4 digit number usually between 1000 and 3000");
            Console.WriteLine("Input ISBN:");
            var temp = Console.ReadLine();
            if (isbns.Contains(temp))
            {
                foreach (var book in books)
                {
                    if (book.ISBN == temp)
                    {
                        Console.WriteLine("Title : {0},Publisher: {1},Pages: {2},Published on: {3}",book.Title,book.Publisher,book.Pages,book.DatePublised);
                    }
                }
                
            }
            else
            {
                Console.WriteLine("No book with this number..try again? Type yes or anything else to exit, (you can try a book with 1101 isbn for example)");
                temp = Console.ReadLine();
                if (temp == "yes")
                {
                    GetAllInforAboutABookByISBN();
                }
                else
                {
                    Console.WriteLine("ok,bye");
                }

            }



        }
        static void GetAllInfoByTitle()
        {
            Console.WriteLine("Input a title (Silmarilion for example)");
            string temp = Console.ReadLine();
            var books = context.Books;
            var titles = from book in books select book.Title;
            if (titles.Contains(temp))
            {
                foreach (var item in books)
                {
                    if (item.Title == temp)
                    {

                        Console.WriteLine("Title : {0},Publisher: {1},Pages: {2},Published on: {3},ISBN: {4}", item.Title, item.Publisher, item.Pages, item.DatePublised, item.ISBN);
                    }
                }

            }
            else
            {
                Console.WriteLine("Here a list of all the titles sorted by name:");
                GetAllBooksByTitle();
                Console.WriteLine("Try a new title:");
                GetAllInfoByTitle();


            }
        }
        static void LoanABook()
        {
            var users = context.Users;
            var books = context.Books;
            var titles = from book in books select book.Title;
            var userFirstNames = from user in users select user.FirstName;
            var userLastNames = from user in users select user.LastName;
            Console.WriteLine("Heres a list of all the users:");
            foreach (var user in users)
            {
                Console.WriteLine("{0} {1}", user.FirstName,user.LastName);
            }
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("Heres a list of all the books that can be given away:");
            foreach (var book in books)
            {
                if(book.Quantity)
                Console.WriteLine(book.Title);
            }

            Console.WriteLine("\n\n");
            Console.WriteLine("First input the book you want to loan..the program will check if there is any in store for giving away:");
            string temp = Console.ReadLine();
            int tempID = 0;
            if (titles.Contains(temp))
            {
                foreach (var item in books)
                {
                    if (item.Title == temp)
                    {
                        var checkIfLoanable = item.Quantity;
                        if (checkIfLoanable)
                        {
                            Console.WriteLine("The book can be loaned");
                            tempID = item.BookID;
                        }
                        else
                        {
                            Console.WriteLine("The book cannot be loaned,the title is reset");
                            temp = "";
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No such book in the Library");
            }

            Console.WriteLine("Now input the name of the user you want to loan a book to");
            var tempName = AuthorNameInput();
            if (userFirstNames.Contains(tempName[0])&& userLastNames.Contains(tempName[1]))
            {
                foreach (var person in users)
                {
                    if (person.FirstName == tempName[0] && person.LastName == tempName[1])
                    {
                        if (person.BookTaken == false)
                        {
                            Console.WriteLine("The book {0} will be loanded to {1} {2}", temp, person.FirstName, person.LastName);
                            person.BookTaken = true;
                            person.BookID = tempID;

                            foreach (var item in books)
                            {
                                if (item.Title == temp)
                                {
                                    item.Quantity = false;
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("This user already has the maximum amount of loaned books");
                        }
                    }
                }
            }
        context.SaveChanges();

        }
        static void ReturnABook()
        {
            var users = context.Users;
            var books = context.Books;
            var userFirstNames = from user in users select user.FirstName;
            var userLastNames = from user in users select user.LastName;
            int tempID = 0;
            Console.WriteLine("Heres all the users that have books loanded to them:");
            foreach (var user in users)
            {
                if (user.BookTaken)
                {
                    Console.WriteLine("{0} {1}",user.FirstName,user.LastName);
                }
            }
            Console.WriteLine("Input the name of the user that you want to return the book they have:");
            var tempName = AuthorNameInput();
            if (userFirstNames.Contains(tempName[0]) && userLastNames.Contains(tempName[1]))
            {
                foreach (var user in users)
                {
                    if (user.FirstName == tempName[0] && user.LastName == tempName[1])
                    {
                        tempID = (int)user.BookID;
                        user.BookID = null;
                        user.BookTaken = false;
                        foreach (var book in books)
                        {
                            if (book.BookID == tempID)
                            {
                                book.Quantity = true;
                            }
                        }

                        Console.WriteLine("The user {0} {1} has returned his/her book",user.FirstName,user.LastName);
                    }
                }
            }
            else
            {
                Console.WriteLine("Error: no such user in the library database");
            }

            context.SaveChanges();
            

        }


        static bool IntVerification(string el, int lowerBorder, int higherBorder)
        {
            int temp;
            if (Int32.TryParse(el, out temp))
            {
                if (temp >= lowerBorder && temp <= higherBorder)
                {
                    return true;
                }
            }
            return false;
        }

        static string[] AuthorNameInput()
        {
            string s = System.Console.ReadLine();
            string[] tempStr = s.Split(' ');
            if (tempStr.Length > 2)
            {
                Console.WriteLine("Only the first and last name  are enough");
                s = System.Console.ReadLine();
                tempStr = s.Split(' ');
            }
            return tempStr;
        }
    }
}
