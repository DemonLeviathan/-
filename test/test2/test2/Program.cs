using System;

namespace test
{
    class SuperHashSet<T> where T : Computer
    {
        public HashSet<T> hset { get; set; }
        public int count = 0;
        public SuperHashSet()
        {
            hset = new HashSet<T>();
        }

        public bool Add(T item)
        {
            return this.hset.Add(item);
        }


        public void Show()
        {
            foreach (T element in this.hset)
            {
                Console.Write(element + "\n");
            }
            Console.WriteLine("\n");
        }

        public void Count()
        {
            int count = 0;
            foreach (T element in this.hset)
            {
                count++;
            }
            Console.WriteLine(count);
        }
    }
    class Computer
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public int Price { get; set; }

        public Computer(string Model, string Color, int Price)
        {
            this.Model = Model;
            this.Color = Color;
            this.Price = Price;
        }
        public override string ToString()
        {
            return $"{Model} {Color} {Price}";
        }

    }

    delegate void Message();
    class User
    {
        public event Message Click;

        public void ButtonClick()
        {
            Click?.Invoke();
        }
    }
    class Button
    {
        public Button(User user)
        {
            user.Click += Button1;
            user.Click += Button2;
        }
        private void Button1()
        {
            Console.WriteLine("Кнопка 1 нажата");
        }
        private void Button2()
        {
            Console.WriteLine("Кнопка 2 нажата");
        }
    }

    class Programm
    {
        static void Main(string[] args)
        {
            Computer computer1 = new Computer("MSI", "Red", 2700);
            Computer computer2 = new Computer("ASUS", "Purple", 2500);
            Computer computer3 = new Computer("Lenovo IdeaPad", "Blue", 2000);
            Computer computer4 = new Computer("qqq", "www", 3000);

            SuperHashSet<Computer> computers = new SuperHashSet<Computer>();
            computers.Add(computer1);
            computers.Add(computer2);
            computers.Add(computer3);
            computers.Add(computer4);
            computers.Show();
            computers.Count();

            Console.WriteLine("Количество элементов в коллекции равных заданному:");
            var count = computers.hset.Where(x => x.Price == 3000).Count();
            Console.WriteLine(count);
            Console.WriteLine("Найденный элемент:");
            var element = computers.hset.Where(x => x.Price == 3000).FirstOrDefault();
            foreach (var item in computers.hset)
            {
                if (item.Price == 2000)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("----------------------");

            User user = new User();
            Button button = new Button(user);
            user.ButtonClick();
        }
    }
}