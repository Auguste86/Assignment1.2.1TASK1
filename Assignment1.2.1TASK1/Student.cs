using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._1TASK1
{
    class Student : IPerson
    {
        private float penalty;
        private int borrowedCount;
        private string name;
        public Student()
        {

        }

        public Student(float penalty, int borrowedCount)
        {
            Penalty = penalty;
            BorrowedCount = borrowedCount;
        }

        public float Penalty { get => penalty; set => penalty = value; }
        public int BorrowedCount { get => borrowedCount; set => borrowedCount = value; }
        public string Name { get => name; set => name = value; }

        public static int checkLoans(List<VLibraryContent> allItems, List<VLibraryContent> personBorrow)
        {
            DateTime currentTime = DateTime.Now;
            int penalty = 0;
            foreach (VLibraryContent items in allItems)
            {
                
                DateTime DueTime = (DateTime)items.DueTime;
                if (DateTime.Compare(currentTime, DueTime) >0)
                {
                    penalty+= 5*(currentTime- DueTime).Days;
                }
            }
            return penalty;
        }
        public static void Borrow(List<VLibraryContent> allItems, List<VLibraryContent> personBorrow)
        {
            string Title;
            Book book = new Book();
            digitalMedia digital_Media = new digitalMedia();
            articles article = new articles();

            Console.WriteLine();
            Console.WriteLine("Show all the contents in the Library");

            book.printAllContenet(allItems);
            digital_Media.printAllContenet(allItems);
            article.printAllContenet(allItems);

            Console.WriteLine();
            Console.WriteLine("What's the item you want to borrow?");
            Title = Console.ReadLine();
            bool borrow = false;
            if (personBorrow.Count <= 5)
            {

                int index = allItems.FindIndex(i => Title == i.Title);
                if (index == -1) { Console.WriteLine("Item not exist"); }
                else
                {
                    foreach (VLibraryContent items in allItems)
                    {

                        if (items.Title == Title && items.IsBorrowed == false)
                        {
                            items.BorrowedTime = DateTime.Now;
                            items.IsBorrowed = true;
                            items.DueTime = DateTime.Now.Date.AddDays(+14);
                            borrow = true;
                            personBorrow.Add(items);
                        }


                    }
                    if (borrow == false) { Console.WriteLine(" borrowed items are not available"); }
                }
            }
            else { Console.WriteLine("You can't borrow any items before you return it"); };
        }

        public static void ReturnBook(List<VLibraryContent> allItems, List<VLibraryContent> personBorrow)
        {
            string Title;
            Book book = new Book();
            digitalMedia digital_Media = new digitalMedia();
            articles article = new articles();

            Console.WriteLine("Show all the items you have borrow");
            book.printAllContenet(personBorrow);
            digital_Media.printAllContenet(personBorrow);
            article.printAllContenet(personBorrow);

            Console.WriteLine();
            Console.WriteLine("What's the item you want to return?");
            Title = Console.ReadLine();
            int index = allItems.FindIndex(i => Title == i.Title);
            if (index == -1) { Console.WriteLine("Item not exist"); }
            else
            {
                foreach (VLibraryContent items in personBorrow.ToList())
                {
                    if (items.Title == Title)
                    {
                        personBorrow.Remove(items);
                    }

                }
                foreach (VLibraryContent items in allItems.ToList())
                {
                    if (items.Title == Title && items.IsBorrowed == true)
                    {
                        items.BorrowedTime = null;
                        items.IsBorrowed = false;
                    }
                }
            }
        }
    }
}
