using Book.CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.CRUD.Broker.Storeage
{
    internal interface IStoreageBrokers
    {
        Books ReadBook(int id);
        Books[] GetAllBooks();
        Books GetBook(int id);
    bool Update(int id, Books book);
    }

}
    









