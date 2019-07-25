using System;

namespace MarketItems {

    public class PriceException : Exception
    {
        public PriceException() : this("Not valid price") { }
        public PriceException(string message) : base(message) { }
    }

    public class Item
    {
        private int price = 0;
        public readonly string Name;
        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value > 0)
                {
                    this.price = value;
                }
                else
                {
                    throw new PriceException();
                }

            }
        }

        public Item() : this(0) { }
        public Item(int price) : this(price, "Not name") { }
        public Item(string name) : this(0, name) { }
        public Item(int price, string name)
        {
            this.Name = name;
            this.price = price;
        }
    }

    public class Market
    {

        private static Item defaultItem = new Item(0, "Nothing");

        public readonly string Name;
        private Item[] items = new Item[0];
        public string itemsList
        {
            get
            {
                string list = "";
                if (this.items.Length == 0) return "List is empty";
                for ( int index = 0; index < this.items.Length; index++ )
                {
                    list += $"{this.items[index].Name},";
                }
                return list;
            }
        }

	    public Market() : this("Market") { }
        public Market(string Name)
        {
            this.Name = Name;
        }

         public Item buy(string Name)
        {
            for (int index = 0; index < this.items.Length; index++)
            {
                if (this.items[index].Name == Name) return this.items[index];
            }
            return Market.defaultItem;
        }

        public void addItem(Item item)
        {
            Item[] items = new Item[this.items.Length + 1];
            for (int index = 0; index < this.items.Length; index++)
            {
                items[index] = this.items[index];
            }
            items[this.items.Length] = item;
            this.items = items;
        }
    }


    class ShoppingBasket
    {
        private Item[] items = new Item[0];
        private static string defaultCheck = "Nothing";
        public string check
        {
            get
            {
                int total = 0, count = 0;
                string check = "";
                for (int index = 0; index < this.items.Length; index++)
                {
                    if (this.items[index].Price == 0) continue;
                    count++;
                    check +=  $"{this.items[index].Name} - {this.items[index].Price}\n";
                    total += this.items[index].Price;
                }
                if (count == 0) return ShoppingBasket.defaultCheck;
                check += $"Total - {total}\n------------------------------------------";
                return check;
            }
        }

        public void addItem(Item item)
        {
            Item[] items = new Item[this.items.Length + 1];
            for (int index = 0; index < this.items.Length; index++)
            {
                items[index] = this.items[index];
            }
            items[this.items.Length] = item;
            this.items = items;
        }

        public void removeItem(string Name)
        {
            if (this.items.Length == 0) return;
            Item[] items = new Item[this.items.Length - 1];
            int count = 0;
            for (int index = 0; index < this.items.Length; index++)
            {
                if (this.items[index].Name == Name) continue;
                items[index] = this.items[index];
                count++;
            }
            if (count == this.items.Length) return;
            this.items = items;
        }

    }

}
