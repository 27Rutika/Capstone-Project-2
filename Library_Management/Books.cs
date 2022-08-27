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

        public string bookName { get; set; }


        public int bookCount { get; set; }

        public decimal bookPrice { get; set; }

        public decimal Cost
        {
            get
            {
                return bookPrice * bookCount;
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
                return this.bookName.CompareTo(otherbook.bookName);

            }
        }
        public override string ToString()
        {
            return $"{BookId,5} {bookName,-20} {bookPrice,5} {bookCount,15} {Cost,20}";
        }
    }

}
