using System;
using System.Collections.Generic;

namespace DataTime
{
    class User
    {
        private static int ID { get; set; }
        public string UserName { get; set; }
        public int _id { get; }
        public User(string username)
        {
            UserName = username;
            ID++;
            _id = ID;
        }

        List<Status> Statuses = new List<Status>();
        public void ShareStatus(Status status)
        {
            Statuses.Add(status);
            Console.WriteLine($"ID:{status.Id} status elave olundu ");
            Console.WriteLine();
        }
        public void GetStatusById(int? id)
        {
            
            Status status = Statuses.Find(item => item.Id == id);

           
             if (id == null)
            {
                throw new NullReferenceException("ID-ni bosh gondermisiz");
            }
           
            status.GetStatusInfo();
        }

        public void GetAllStatuses()
        {
            foreach (Status status in Statuses)
            {
                Console.WriteLine($"ID: {status.Id} \n" +
                    $"Title: {status.Title} \n" +
                    $"Content: {status.Content} \n" +
                    $"ShareData: {status.ShareData}");
                Console.WriteLine("***************");
            }
        }

        public void FilterStatusByDate(int? id, DateTime tarix)
        {

            if (_id == id)
            {
                foreach (Status status in Statuses)
                {
                    if (status.ShareData > tarix)
                    {
                        Console.WriteLine($"Filtirlenmish \n" +
                            $"ID: {status.Id} \n" +
                            $"Title: {status.Title} \n" +
                            $"Content: {status.Content} \n" +
                            $"ShareData: {status.ShareData}");
                        Console.WriteLine();
                        Console.WriteLine("****************");
                        Console.WriteLine();

                    }
                    else
                    {
                        throw new NotFoundException("Hecbir status tapilmadi");
                    }

                }


            }
            else if (id != _id)
            {
                Console.WriteLine("Bele ID-li user movcut deyil");
            }

            else if (id == null)
            {
                throw new NullReferenceException("ID-ni bosh gondermisiz");
            }




        }


    }
}
