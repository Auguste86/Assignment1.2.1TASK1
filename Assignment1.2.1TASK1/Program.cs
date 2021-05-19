using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._1TASK1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<VLibraryContent> allItems = new List<VLibraryContent>();
            List<VLibraryContent> staffBorrow = new List<VLibraryContent>();
            List<VLibraryContent> studentBorrow = new List<VLibraryContent>();

            Book book = new Book();
            digitalMedia digital_Media = new digitalMedia();
            articles article = new articles();

            int person;
            bool loop = true;
            

            do
            {
                Console.WriteLine("\nMenu\n" +
                    "1)Add book\n" +
                    "2)Delete book\n" +
                    "3)Borrow book\n" +
                    "4)Return book\n" +
                    "5)Show Item\n" +
                    "6)Check Loans\n" +
                    "7)Close\n\n");
                Console.Write("Choose your option from menu :");

                int option = int.Parse(Console.ReadLine());

                if (option == 1)
                {
                    AddItem(allItems);
                }
                else if (option == 2)
                {
                    RemoveItem(allItems);
                }
                else if (option == 3)
                {
                    int choice;
                    Console.WriteLine("borrow or return?(1 for borrow,2 for return)");
                    choice = int.Parse(Console.ReadLine());
                    Console.WriteLine("Are you student or staff?(1 for student,2 for staff)");
                    person = int.Parse(Console.ReadLine());

                    if (person == 1)
                    {
                        Student.Borrow(allItems, studentBorrow);
                    }
                    if (person == 2)
                    {
                        Staff.Borrow(allItems, staffBorrow);
                    }
                }
                else if (option == 4)
                {
                    Console.WriteLine("Are you student or staff?(1 for student,2 for staff)");
                    person = int.Parse(Console.ReadLine());
                    if (person == 1)
                    {
                        Student.ReturnBook(allItems, studentBorrow);
                    }
                    if (person == 2)
                    {
                        Staff.ReturnBook(allItems, staffBorrow);
                    }

                }
                else if (option == 5)
                {
                    Console.WriteLine("All the item library have:");
                    book.printAllContenet(allItems);
                    digital_Media.printAllContenet(allItems);
                    article.printAllContenet(allItems);

                    Console.WriteLine("All the item student have borrowed:");
                    book.printAllContenet(studentBorrow);
                    digital_Media.printAllContenet(studentBorrow);
                    article.printAllContenet(studentBorrow);

                    Console.WriteLine("All the item staff have borrowed:");
                    book.printAllContenet(staffBorrow);
                    digital_Media.printAllContenet(staffBorrow);
                    article.printAllContenet(staffBorrow);
                }
                else if (option == 6)
                { 
                        Student.ReturnBook(allItems, studentBorrow);
                }
                else if (option == 7)
                {
                    Console.WriteLine("Thank you");
                    loop = false;
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option\nRetry !!!");
                }
                Console.ReadLine();
                Console.Clear();
            } while (loop == true);



        }
        public static void AddItem(List<VLibraryContent> allItems)
        {
            string Title;
            int selection;
            Book book = new Book();
            digitalMedia digital_Media = new digitalMedia();
            articles article = new articles();

            Console.WriteLine("What's the title for the item");
            Title = Console.ReadLine();
            Console.WriteLine("What's the type for the item(enter 1 for book, 2 for digitalMedia,3 for articles)");
            selection = int.Parse(Console.ReadLine());
            if (selection == 1)
            {
                allItems.Add(new Book(Title, DateTime.Now, "Book"));
                book.printAllContenet(allItems);
            }
            else if (selection == 2)
            {
                allItems.Add(new digitalMedia(Title, DateTime.Now, "digitalMedia"));
                digital_Media.printAllContenet(allItems);
            }
            else
            {
                allItems.Add(new articles(Title, DateTime.Now, "Articles"));
                article.printAllContenet(allItems);
            }
        }

        public static void RemoveItem(List<VLibraryContent> allItems)
        {
            string Title;
            Book book = new Book();
            digitalMedia digital_Media = new digitalMedia();
            articles article = new articles();

            Console.WriteLine("What's the title for the item");
            Title = Console.ReadLine();

            foreach (VLibraryContent items in allItems.ToList())
            {
                if (items.Title == Title)
                    allItems.Remove(items);
            }

            book.printAllContenet(allItems);
            digital_Media.printAllContenet(allItems);
            article.printAllContenet(allItems);
        }

        

    }
}
