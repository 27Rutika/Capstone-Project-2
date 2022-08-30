using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Library_Management
{
    internal class Library
    {
        private ArrayList Bookinfo;        
        public string LibraryName { get; private set; }

        public Library(string name)
        {

            this.LibraryName = name;
            Bookinfo = new ArrayList();
        }

        public void AddBook()
        {
            Book B = new Book();

            Console.WriteLine();
            Console.WriteLine("Enter the details of the Book");
            Console.Write("Book Name : ");
            B.BookName = Console.ReadLine();
            Console.Write("Book Price: ");
            B.BookPrice = int.Parse(Console.ReadLine());
            Console.Write("Book Count: ");
            B.BookCount = (int)decimal.Parse(Console.ReadLine());

            Bookinfo.Add(B);
        }



        public void RemoveBook()
        {
            this.DisplayAllBook();
            Console.WriteLine("Enter the ID of the book to remove:");
            int id = int.Parse(Console.ReadLine());
            bool remove = false;
            for (int i = 0; i < Bookinfo.Count; i++)
            {
                Book B = this.Bookinfo[i] as Book;           
                if (B.BookId == id)
                {
                    this.Bookinfo.Remove(B);
                    remove = true;
                }
            }
            if (remove == false)
            {
                Console.WriteLine("ERROR!!! ID not found");
            }

        }

        public void DisplayAllBook()
        {
            Console.WriteLine();
            Console.WriteLine("---------------Books in the Library are -------------- ");
            Console.WriteLine("{0,5} {1,-20} {2,5} {3,15} {4, 15}", "BookID", "BookName", "BookPrice", "BookCount", "Cost");

            foreach (Book B in this.Bookinfo)
            {
                Console.WriteLine(B);
            }
        }

        public void SortBook()
        {
            this.DisplayAllBook();
            Console.WriteLine("After Sorting Books:");

            this.Bookinfo.Sort();

            foreach (Book p in this.Bookinfo)
            {
                Console.WriteLine(p.ToString());
            }

        }



        public void Searchbook()
        {
            Book book = new Book();
            Console.Write("Enter the ID of the Book to search :");
            int find = int.Parse(Console.ReadLine());
            bool found = false;

            foreach (Book searchId in Bookinfo)
            {
                if (searchId.BookId == find)
                {
                    Console.WriteLine("Book ID :{0}\t" +
                    "Book Name :{1}\t" +
                    "Book Price :{2}\t" +
                    "Book Count :{3}\t" + "Cost:{4}", searchId.BookId, searchId.BookName, searchId.BookPrice, searchId.BookCount, searchId.Cost);
                    Console.WriteLine("Book is Found");
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine("ERROR!!! ID not found");
            }


        }


        public void ReturnBook()
        {
            this.DisplayAllBook();

            Console.Write("\n\tEnter the ID of the Book to return: ");
            int id = int.Parse(Console.ReadLine());
            bool found = false;


            for (int i = 0; i < Bookinfo.Count; i++)
            {
                Book B = this.Bookinfo[i] as Book;
                if (B.BookId == id)
                {
                    
                    Console.Write("\tuser id : ");
                    B.userId = int.Parse(Console.ReadLine());
                    Console.Write("\tuser Name : ");
                    B.username = Console.ReadLine();
                    Console.Write("\tEnter the count of the Books you want to return: ");
                    B.BorrowCount = int.Parse(Console.ReadLine());
                    B.BookCount = B.BookCount + B.BorrowCount;
                    Console.WriteLine("Book ID: {0} \t" + "Book Name: {1} \t" + "Book Price: {2} \t" + "Book Count: {3} \t" + "Cost: {4} \t" + "User id: {5} \t" + "User name: {6} \t" ,
                    B.BookId, B.BookName, B.BookPrice, B.BookCount, B.Cost, B.userId, B.username);
                    DateTime dateTime = DateTime.Now;
                    Console.WriteLine("Return book Date and Time is: {0}", dateTime);
                    Console.WriteLine("Success");
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("ERROR!!! ID not found");
            }

        }

        public void IssueBook()
        {
            this.DisplayAllBook();
            
            Console.Write("\n\tEnter the Id of the Book to issue: ");
            int id = int.Parse(Console.ReadLine());
            bool found = false;


            for (int i = 0; i < Bookinfo.Count; i++)
            {
                Book B = this.Bookinfo[i] as Book;
                if (B.BookId == id)
                {
                    
                    Console.Write("\tuser id : ");
                    B.userId = int.Parse(Console.ReadLine());
                    Console.Write("\tuser Name : ");
                    B.username = Console.ReadLine();
                    Console.Write("\tEnter the count of the Books you want to issue: ");
                    B.BorrowCount = int.Parse(Console.ReadLine());
                    B.BookCount = B.BookCount - B.BorrowCount;
                    Console.WriteLine("Book ID:{0} \t" + "Book name: {1} \t" + "Book price: {2} \t" + "Book Count: {3} \t" + "Cost: {4} \t" + "User id: {5} \t" + "User name: {6} \t",
                    B.BookId, B.BookName, B.BookPrice, B.BookCount, B.Cost, B.userId, B.username);
                    DateTime dateTime = DateTime.Now;
                    Console.WriteLine("Issue Book Date and Time is: {0}", dateTime);
                    Console.WriteLine("-----Success------");
                    found = true;
                    break;
                }
            }
            if (found == false)
            {
                Console.WriteLine("ERROR!!! ID not found");
            }
        }
    }
}
