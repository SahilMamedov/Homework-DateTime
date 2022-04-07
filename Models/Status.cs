using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTime
{
    class Status
    {
        private static int ID { get; set; }
        public int Id { get;  }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime ShareData { get; set; }
        public int SharedSecond { get; set; }


        public Status(string title, string content)
        {
            Title = title;
            Content = content;
            ID++;
           Id = ID;
            
            
            DateTime dateTime = DateTime.Now;
            ShareData = dateTime;
           int  second = DateTime.Now.Second;
            SharedSecond = second;
            
        }
        public void GetStatusInfo()
        {
            Console.WriteLine($"ID: {Id} \n" +
                $"Title: {Title} \n" +
                $"Content: {Content} \n" +
                $"SahredSecond: {SharedSecond}");
            Console.WriteLine();
        }


    }
}
