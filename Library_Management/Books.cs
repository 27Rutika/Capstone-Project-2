using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Management
{
    internal class Book : System.IComparable
    {

        private static int bookIdCounter;

        static Book()
        {
            Book.bookIdCounter = 0;
        }

        public Book()
        {
            this._BookId = ++Book.bookIdCounter;
        }

        private int _BookId;
        public int userId;
        public string username;
        internal int BorrowCount;

        public int BookId
        {
            get
            {
                return _BookId;
            }
        }

        public string BookName { get; set; }


        public int BookCount { get; set; }

        public decimal BookPrice { get; set; }

        public decimal Cost
        {
            get
            {
                return BookPrice * BookCount;
            }
        }

        public int CompareTo(object obj)
        {
            if (obj != null)
            {
                return 1;
            }
            else
            {
                Book otherbook = (Book)obj;
                return this.BookName.CompareTo(otherbook.BookName);

            }
        }
        public override string ToString()
        {
            return $"{BookId,5} {BookName,-20} {BookPrice,5} {BookCount,15} {Cost,20}";
        }
    }

}
