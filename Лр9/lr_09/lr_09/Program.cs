using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

namespace lr_09
{
    public class Programm
    {
        static void Main(string[] args)
        { 
            CollectionList list = new CollectionList();
            //CollectionList collectionList = new CollectionList();
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
            Console.WriteLine("--------------------------");

            list.AddToInt(11);
            list.AddToInt(13);
            list.AddToInt(15);
            list.AddToInt(17);
            list.AddToInt(19);
            list.AddToInt(23);
            list.PrintInt();
            Console.WriteLine("--------------------------");
            list.RemoveFromInt();
            list.PrintInt();

            Console.WriteLine("--------------------------");

            list.AddToSet(book1);
            list.AddToSet(book2);
            list.AddToSet(book3);
            list.SearchInSet(book3);
            list.PrintSet();
            Console.WriteLine("--------------------------");

            ObservableCollection<Book> strings = new ObservableCollection<Book>();
            strings.CollectionChanged += CollectionChange;
            strings.Add(book1);
            strings.Remove(book1);
            //book1.Change(book3);
        }
        private static void CollectionChange(object obj, NotifyCollectionChangedEventArgs args)
        {
            switch (args.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine($"New element was added");
                    break;

                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine($"Element was removed");
                    break;
            }
        }
    }
}