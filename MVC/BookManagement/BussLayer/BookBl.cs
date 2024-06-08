using System.Collections.Generic;
using DAL;
using Entities;

namespace BussLayer
{
    public class BookBl
    {
        private Bookdal bDal = new Bookdal();

        public List<Book> GetAllBooks()
        {
            return bDal.GetAllBooks();
        }
    }
}
