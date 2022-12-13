using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr_09
{
    interface IDictionary
    {
        public void Add(Book key);
        public void Remove(Book key);
    }
    public class Book 
    {  
        public Book()
        { }
        
        public string Name { get; set; }
        public Book(string name) => Name = name;
    }

    public class CollectionList : IDictionary
    {
        List<Book> books = new List<Book>();
        public void Add(Book key)
        {
            books.Add(key);
        }

        public void Remove(Book key)
        {
            books.Remove(key);
        }

        public void Search(Book key)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (key == books[i])
                {
                    Console.WriteLine("Element: " + books[i]);
                    break;
                }
                else
                {
                    Console.WriteLine("No such object in list");
                    break;
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine(books[i]);
            }
        }
    }
}
