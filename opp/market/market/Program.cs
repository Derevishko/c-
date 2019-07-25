using System;
using MarketItems;

namespace market
{
    class Program
    {
        static void Main(string[] args)
        {
            Item item1 = new Item(4, "Beer");
            Item item2 = new Item(2, "Milk");
            Item item3 = new Item(1, "Salt");
            Item item4 = new Item(34000, "Renault Arkana");
            Item item5 = new Item(25000, "Lada Vesta Sport");
            Item item6 = new Item(60000, "Ranault New Caleos");
            Item item7 = new Item(18000, "Lada Granta");
            Item item8 = new Item(20000, "Lada XRay");

            Market market1 = new Market("Evroopt");
            Market market2 = new Market("Avtoprom");

            market1.addItem(item1);
            market1.addItem(item2);
            market1.addItem(item3);

            market2.addItem(item4);
            market2.addItem(item5);
            market2.addItem(item6);
            market2.addItem(item7);
            market2.addItem(item8);

            ShoppingBasket basket1 = new ShoppingBasket();
            
            basket1.addItem(market1.buy("Beer"));
            basket1.addItem(market1.buy("Beer"));
            basket1.addItem(market1.buy("Beer"));
            basket1.addItem(market1.buy("Salt"));
            basket1.addItem(market1.buy("sss"));
            basket1.addItem(market1.buy("Salt"));


            ShoppingBasket basket2 = new ShoppingBasket();
            basket2.addItem(market1.buy("Salt"));
            basket2.addItem(market1.buy("Salt"));
            basket2.addItem(market1.buy("Salt"));
            basket2.addItem(market2.buy("Renault Arkana"));
            basket2.addItem(market2.buy("Renault Arkana"));
            basket2.addItem(market2.buy("Renault Arkana"));
            basket2.addItem(market2.buy("Renault Arkana"));


            Console.WriteLine(basket1.check);

            Console.WriteLine(basket2.check);
        }
    }
}
