using System;
using System.Collections.Generic;

namespace SRP
{
    public class library
    {
        List<Book> libraryList = new List<Book>();
        public library(){
        }
        public void ShelveBook(String sector, String shelve,Book book)
        {
            book.LibrarySector = sector;
            book.LibraryShelve = shelve;
            libraryList.Add(book);
        }
    }
}
