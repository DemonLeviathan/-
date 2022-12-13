using System;

namespace lr_09
{
    public class Programm
    {
        static void Main(string[] args)
        { 
            CollectionList list = new CollectionList();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();


            list.Add(book1);
            list.Add(book2);
            list.Add(book3);
            //list.Print();
            list.Remove(book2);
            list.Search(book1);
            list.Search(book2);
            list.Print();
        }
    }
}