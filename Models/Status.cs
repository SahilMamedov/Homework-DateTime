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
       
        public TimeSpan timer => DateTime.Now - ShareData;

        public Status(string title, string content)
        {
            Title = title;
            Content = content;
            ID++;
            Id = ID;
  
            ShareData = DateTime.Now;
           
        }
        public void GetStatusInfo()
        {
            Console.WriteLine($"ID: {Id} \n" +
                $"Title: {Title} \n" +
                $"Content: {Content} \n");
            Console.WriteLine("SharedSecound {0:hh\\:mm\\:ss}",timer);
            // Saniyeden millisecondu cixmaq uchun arashdirma    https://docs.microsoft.com/en-us/dotnet/standard/base-types/custom-timespan-format-strings?redirectedfrom=MSDN

        }


    }
}
