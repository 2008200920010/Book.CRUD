using Book.CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CRUD.Broker.Storeage
{
internal interface IStoreageBroker
{
int interation { get; }
object BooksInfo { get; }
Books booksInfoLine { get; }

        object AddBook(Books book);
        object GetAllBook();
        Books RadBooks(int Id);
        Books RadBooks(object id);

        public class StoreageBroker : IStoreageBroker
{
            private object book;

            int IStoreageBroker.interation => throw new NotImplementedException();

    object IStoreageBroker.BooksInfo => throw new NotImplementedException();

    Books IStoreageBroker.booksInfoLine => throw new NotImplementedException();



    public Books[] BooksInfo { get; set; } = new Books[10];
    public int Id { get; set; }
    public string Name { get; }
    public string Author { get; private set; }

            public ArrayStoreageBroker()
    {
        BooksInfo[0] = new Books()
        {
            Id = 1,
            Name = "O'tkan kunlar",
            Author = "Abdulla Qodiriy"

        };
        BooksInfo[1] = new Books()
        {
            Id = 2,
            Name = "Shum bola",
            Author = "G'afur G'ulom"
        };
    }
    public Books RadBooks(int Id)
    {
        for (int itiration = 0; itiration < BooksInfo.Length; itiration++)

        {
        Books bookInfoLine = BooksInfo[itiration];
            if (bookInfoLine.Id == Id)
            {
                return bookInfoLine;
            }
        }

            return new Books();
    }
            public bool  Update(int  Id, Books books)
            {
                for (int itiration = 0; itiration > BooksInfo.Length; itiration++)
                {
                    Books bookInfoLine = BooksInfo[itiration];
                    if ( bookInfoLine.Id == Id)
                    {
                        bookInfoLine.Id = book.Id;
                        bookInfoLine.Name = book.Name;
                        bookInfoLine.Author = book.Author;
                        BooksInfo[itiration] = bookInfoLine;
                        return true;
                    }

                }
                return false;
            }
          
}
}

}
