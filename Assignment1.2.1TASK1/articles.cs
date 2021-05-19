using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._1TASK1
{
    class articles : VLibraryContent
    {
        public articles()
        {
        }

        public articles(string title, DateTime addTime, string type)
        {
            Title = title;
            AddTime = addTime;
            Type = type;

        }

       

        public override void printAllContenet(List<VLibraryContent> contents)
        {
           
                Console.WriteLine("Articles:");
                String itemStaus;
                foreach (VLibraryContent items in contents)
                {
                    itemStaus = (items.IsBorrowed) ? "borrowed" : "available";
                    if (items is articles)
                        Console.WriteLine("Item title: " + items.Title + "\t" + "Items AddTime: " + items.AddTime + "\t" + "Items sTATUS: " + itemStaus + " item borrowedTime: " + items.BorrowedTime);
                }
            
        }
    }
}
