using Book.CRUD.Broker.Logging;
using Book.CRUD.Models;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Book.CRUD.Service
{
    internal class BookService : BookServiceBase
    {
        private readonly LoggingBroker loggingBroker;
        private readonly IStoreageBroker storeageBroker;
        private object booksInfo;

        public BookService()

        {
            this.loggingBroker = new LoggingBroker();
            this.storeageBroker = new ArrayStoreageBroker();
        }
        public Books GetBooks(int id)
        {
            Books book = this.storeageBroker.RadBooks(id);
            return book;
        }
       
     
            

public Books ReadAllBook()
        {
            var books = this.storeageBroker.GetAllBook();
            if (booksInfo.Lingth is 0)
            {
                this.loggingBroker.LogError("Invalit not anailable.");
            }
            else
            {
               for (int itiration = 0; itiration < bookInfo.Lingth; itiration++)
                {
                    if (bookInfo.[itiration] is not null)
                    {
                        this.loggingBroker.LogInformation($"{bookInfo[itiration].Id}. {bookInfo[itiration].Name}");

                    }
                }

            }
            return books;
        }

        public bool Update(int id, Books books)
        {
           return this.storeageBroker.Update(id, book);

        }
    }
}






