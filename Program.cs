

using Book.CRUD.Broker.Logging;
using Book.CRUD.Models;
using Book.CRUD.Service;
using System;

IBookService bookService = new BookService();

bool isContinue = true;
do
{
    Console.WriteLine("1. Get All");
    Console.WriteLine("2. Get Book");
    Console.WriteLine("3. Update one book");
    Console.WriteLine("Enter command: ");
    string command = Console.ReadLine();
    if (command.Contains("2") is true)
    {
        bookService.InsertBook(new Books() { Id = 3, Name = "Shaytanat", Author = "Tohir Malik" });
        {
            if (command.Contains("1") is true)
            {
                bookService.ReadAllBooks();
            }
            if (command.Contains("3") is true)
            {
                bookService.Update(2, new Books() { Id = 3, Name = "Saodat asri", Author = "Muhammad Yusuf" });
            }
            Console.WriteLine("Is Continue");
            string isCommand = Console.ReadLine();
            if (isCommand.ToLower().Contains("No") is true)
            {
                isContinue = false;
            }
        } while (isContinue is true);
    }
}
