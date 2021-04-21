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
            
            List<VLibraryContent> personBorrow = new List<VLibraryContent>();
            Book book = new Book();
            digitalMedia digital_Media = new digitalMedia();
            articles article = new articles();
            
            int person;
            string loop;
            Console.WriteLine("Are you trying to add or remove book?(enter y to continue)");
            loop = Console.ReadLine();
            while (loop == "y") 
            {
                string Title;
                int selection;
                Console.WriteLine("1 for add item,2 for remove item");
                int addOrRemove;
                addOrRemove = int.Parse(Console.ReadLine());
                if (addOrRemove == 1)
                {
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
                else
                {
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
                Console.WriteLine("Are you trying to add or remove more book?(enter y to continue)");
                loop = Console.ReadLine();
                Console.Clear();
            } 
            Console.WriteLine("Are you student or staff?(1 for student,2 for staff)");
            person  = int.Parse(Console.ReadLine());

            if (person == 1) {
                Student student = new Student();
                int bb = student.BorrowedCount;
                string Title;
                Console.WriteLine();
                Console.WriteLine("Show all the contents in the Library");
                book.printAllContenet(allItems);
                digital_Media.printAllContenet(allItems);
                article.printAllContenet(allItems);
                Console.WriteLine();
                Console.WriteLine("What's the item you want to borrow?");
                Title = Console.ReadLine();
                if (personBorrow.Count < 5)
                {
                    foreach (VLibraryContent items in allItems)
                    {
                        if (items.Title == Title)
                            personBorrow.Add(items);
                        items.IsBorrowed = true;
                    }
                }
                else { Console.WriteLine("You can't borrow any book before you return it"); };
            }
            
        }
    }
}
