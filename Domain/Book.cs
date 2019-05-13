using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public class Book : IEquatable<Book>
    {
        public string Title
        {
            get;
            set;
        }

        public string Author
        {
            get;
            set;
        }

        public int Id
        {
            get;
            set;
        }

        public string Press
        {
            get;
            set;
        }

        public string Isbn
        {
            get;
            set;
        }

        public double Price
        {
            get;
            set;
        }
        public bool Equals(Book other)
        {
            if (other == null)
            {
                return false;
            }
            else
                return Id == other.Id;
        }
    }
}