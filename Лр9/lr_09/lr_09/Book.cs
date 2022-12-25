using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

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
        List<int> bookID = new List<int>();
        HashSet<Book> bookSet = new HashSet<Book>();
        public void Add(Book key)
        {
            books.Add(key);
        }

        public void AddToSet(Book key)
        {
            bookSet.Add(key);
        }

        public void AddToInt(int i)
        {
            bookID.Add(i);
        }

        public void Remove(Book key)
        {
            books.Remove(key);
        }

        public void RemoveFromInt()
        {
            bookID.RemoveRange(1, 3);
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

        public void SearchInSet(Book key)
        {
            bool found = false;
            for (int i = 0; i < bookSet.Count; i++)
            {
                found = bookSet.TryGetValue(key, out Book book);
            }
            Console.WriteLine("Is element in hashset? : {0}", found);
        }

        public void Print()
        {
            for (int i = 0; i < books.Count; i++)
            {
                Console.WriteLine(books[i]);
            }
        }

        public void PrintInt()
        {
            for (int i =0; i < bookID.Count; i++)
            {
                Console.WriteLine(bookID[i]);
            }
        }

        public void PrintSet()
        {
            Console.WriteLine(bookSet);
        }

    }

}
