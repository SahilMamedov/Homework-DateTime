using System;

namespace DataTime
{
    class Program
    {
        static void Main(string[] args)
        {
            


            Console.WriteLine("UserName daxil edin");
            string username = Console.ReadLine();
            User user = new User(username);
            Console.WriteLine($"ID: {user._id}");
            while (true)
            {
                Console.WriteLine("    Menyu  \n" +
                    " \n" +
                    "1: Share Status \n" +
                    "2: Get all statuses \n" +
                    "3: Get status by id \n" +
                    "4: Filter status by date \n" +
                    "0: Quit \n");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine("Title elave edin");
                    string title = Console.ReadLine();
                    Console.WriteLine("Content elave edin");
                    string content = Console.ReadLine();
                    user.ShareStatus(new Status(title, content));
                }
                if (num == 2)
                {
                    user.GetAllStatuses();
                }
                if (num == 3)
                {
                    Console.WriteLine("Gormek istediyiniz statusun ID-sini daxil edin");
                    int id = Convert.ToInt32(Console.ReadLine());
                    user.GetStatusById(id);
                }
                if (num == 4)
                {
                    Console.WriteLine("Filtirlemek istediyiniz Userin ID-sini daxin edin");
                    int userid = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tarix yazin Excample: 02.02.2022 ");
                    
                    string name = Console.ReadLine();
                    DateTime data = DateTime.Parse(name);
                    user.FilterStatusByDate(userid, data);
                }
                if (num == 0)
                {
                    Console.WriteLine("Thanks");
                    break;
                }


            }













        }
    }
}

