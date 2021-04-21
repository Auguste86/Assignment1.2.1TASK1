using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._1TASK1
{
    class Book:VLibraryContent
    {
        public Book()
        {
        }

        public Book(string title, DateTime addTime, string type)
        {
            Title = title;
            AddTime = addTime;
            Type = type;

        }




        public override void printAllContenet(List<VLibraryContent> contents)
        {
            Console.WriteLine("Book:");
            String itemStaus;
            foreach (VLibraryContent items in contents)
            {
                itemStaus = (items.IsBorrowed) ? "borrowed" : "available";
                if (items is Book)
                Console.WriteLine("Item title: " + items.Title + "\t" + "Items AddTime: " + items.AddTime + "\t" + "Items STATUS: " + itemStaus);
            }
        }
    }
}
