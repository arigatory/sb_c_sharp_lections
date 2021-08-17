using System;

namespace Example_1443
{
    class People
    {
        public string Name { get; set; }

        public event Action<string> CatFood;
        Cat cat;

        public People(string Name, Cat ConcreteCat)
        {
            this.Name = Name;
            this.cat= ConcreteCat;
            ConcreteCat.MewEvent += a => Console.WriteLine($"{this.Name} пошёл кормить кота: {ConcreteCat.Nickname}");
        }

        public void FeedTheCat()
        {
            Console.WriteLine($"{cat.Nickname}, кис, кис, кис кушать кодано! ");
            CatFood?.Invoke("Вкусняшка");
        }



    }
}
