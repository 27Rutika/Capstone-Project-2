using System;

namespace Library_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library L = new Library("\t *** WELCOME TO THE LIBRARY ***");
            int m = -1;
            while (m != 0)
            {
                int Choice = -1;
                Console.WriteLine("*******************************************************************************");
                Console.WriteLine(L.LibraryName);
                Console.WriteLine("*******************************************************************************");
                Console.WriteLine("Are You?");
                Console.WriteLine("\t<1> Librarian ");
                Console.WriteLine("\t<2> Borrower ");
                Console.WriteLine("\t<0> Exit ");
                Console.WriteLine("-------------------------------------------------------------------------------");
                Console.WriteLine("Enter your choice:");
                m = int.Parse(Console.ReadLine());

                switch (m)
                {
                    case 0:
                        Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-THANK YOU!!!HAVE A GREAT DAY!!!-+-+-+-+-+-+-+-+-+-+-+-+-+-");
                        break;
                    case 1:
                        while (Choice != 0)
                        {
                            Console.WriteLine("******************************************************************************");
                            Console.WriteLine("\t<0> Return to main menu");
                            Console.WriteLine("\t<1> Add Books");
                            Console.WriteLine("\t<2> Display All Books");
                            Console.WriteLine("\t<3> Remove the book");
                            Console.WriteLine("\t<4> Search the book");
                            Console.WriteLine("\t<5> Sort the Books");
                            Console.WriteLine("*******************************************************************************");
                            Console.WriteLine("What do you want to do?");
                            Choice = int.Parse(Console.ReadLine());

                            switch (Choice)
                            {

                                case 0:
                                    
                                    break;
                                case 1:                                    
                                    L.AddBook();
                                    break;
                                case 2:                                    
                                    L.DisplayAllBook();
                                    break;
                                case 3:                                    
                                    L.RemoveBook();
                                    break;
                                case 4:                                    
                                    L.Searchbook();
                                    break;
                                case 5:                                   
                                    L.SortBook();
                                    break;


                            }
                        }

                        break;
                    case 2:
                        int i = -1;
                        while (i != 0)
                        {
                            Console.WriteLine("*******************************************************************************");
                            Console.WriteLine("\t<0> Return to main menu");
                            Console.WriteLine("\t<1> Issue the book");
                            Console.WriteLine("\t<2> Return the book");
                            Console.WriteLine("*******************************************************************************");
                            Console.WriteLine("What do you want to do?");

                            i = int.Parse(Console.ReadLine());
                            switch (i)
                            {
                                case 0:                                    
                                    break;
                                case 1:                                    
                                    L.IssueBook();
                                    break;
                                case 2:                                  
                                    L.ReturnBook();
                                    break;
                            }
                        }
                        break;

                }
            }
        }


    }

}
