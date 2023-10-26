using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace _06.StoreBoxes
{
    internal class Program
    {
        public class Item
        {
            public Item(string name,decimal price)
            { 
                ItemName=name;
                ItemPrice=price;
            }
            public string ItemName { get; set; }

            public decimal ItemPrice { get; set; }

        }
        public class Box
        {
            public Box(string serialNum, Item item, int quantity)
            {
                SerialNumber = serialNum;
                Item = item;
                ItemsQuantity = quantity;
            }
            public string SerialNumber { get; set; }
            public Item Item { get; set; }
            public int ItemsQuantity { get; set; }
            public  decimal PricePerBox { get { return Item.ItemPrice * ItemsQuantity; } }
            
        }
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string command = "";
            while ((command=Console.ReadLine()) != "end") 
            {
                string[] token = command.Split();
                string serialNumber = token[0];
                string itemName= token[1];
                int itemQuantity = int.Parse(token[2]);
                decimal itemPrice = decimal.Parse(token[3]);

                Item item = new Item(itemName,itemPrice);
                Box box = new Box(serialNumber, item,  itemQuantity);

              boxes.Add(box);
                
            }
            foreach (Box box in boxes.OrderByDescending(b=>b.PricePerBox)) 
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.ItemName} – ${box.Item.ItemPrice:f2}: {box.ItemsQuantity}");
                Console.WriteLine($"-- ${box.PricePerBox:f2}");
            }
            /*
19861519 Dove 15 2.50
86757035 Butter 7 3.20
39393891 Orbit 16 1.60
37741865 Samsung 10 1000
end
             */
        }
    }
}