using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._2._1TASK1
{
    public abstract class VLibraryContent
    {
        private DateTime addTime;
        private Boolean isBorrowed = false;
        private string title;
        private string type;
        private Nullable<DateTime> borrowedTime = null;
        private Nullable<DateTime> dueTime = null;



        public bool IsBorrowed { get => isBorrowed; set => isBorrowed = value; }
        public string Title { get => title; set => title = value; }
        
        public DateTime AddTime { get => addTime; set => addTime = value; }
        public string Type { get => type; set => type = value; }
        public Nullable<DateTime> BorrowedTime { get => borrowedTime; set => borrowedTime = value; }
        public Nullable<DateTime> DueTime { get => dueTime; set => dueTime = value; }

        public virtual void RemoveContent(string title, List<VLibraryContent> contents)
        {
            foreach (VLibraryContent items in contents)
            {
                if (items.Title == title)
                    contents.Remove(items);
            }
        }


        
        public virtual void printAllContenet(List<VLibraryContent> contents)
        {
            Console.WriteLine("All item:");
            string itemStaus;
            foreach (VLibraryContent items in contents)
            {
                    itemStaus = (items.IsBorrowed == true) ? "borrowed" : "available";
                    Console.WriteLine("Item title: " + items.Title + "\t"+"Items AddTime: " + items.AddTime + "\t" + "Items Staus: " + itemStaus+ " Items borrowedTime:" + items.BorrowedTime);
            }
        }
        
    }
}
