using Book.CRUD.Models;
using System;

namespace Book.CRUD.Service
{
    internal interface IBookService
    {
        
        Books GetBooks(int Id);
        Books[] ReadAllBooks();
        Books InsertBook(Books book);
        bool Update(int id, Books book);
         
    }
}
