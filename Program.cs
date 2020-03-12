using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interation7And8
{
    class MainClass
    {
        public static void Main()
        {
            string name, description;
            string[] select ={""};
            LookCommand MyLookCommand= new LookCommand();
            //Create a Console Application
            //Get input from user
            Console.WriteLine("Welcome to SwinAdventure");
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Please enter your description:");
            description = Console.ReadLine();
            Player MyPlayer = new Player(name, description);
            Console.WriteLine("You have arrived in {0}",MyPlayer.Currentlocation.Name);

            //Create 2 items, put 2 item in, and put 1 item into the default location
            Item CarItem = new Item(new string[] { "car", "moorbike" }, "an expensive car", "It has 7 seats");
            Item ShieldItem = new Item(new string[] { "shield", "hammer" }, "an unbreakable shield", "It belongs to Captain America");
            MyPlayer.Inventory.Put(CarItem);
            //MyPlayer.Inventory.Put(ShieldItem);
            MyPlayer.Currentlocation.Inventory.Put(CarItem);

            //Create a bag
            Bag TestBag1 = new Bag(new string[] { "ironman" }, "a hero", "he is a legend");
            MyPlayer.Inventory.Put(TestBag1);
            Item SuitItem = new Item(new string[] { "suit", "car" }, "an technology suit", "Its name is Javis");
            TestBag1.Inventory.Put(SuitItem);

            //Loop reading commands from the user:
            Console.WriteLine ("Command 'quit' to exist the game");
                        
            while (select[0] != "quit")
            {
                Console.WriteLine("Command -> ");
                select = Console.ReadLine().Split(' ');
                if (select[0] == "look")
                   Console.WriteLine( MyLookCommand.Execute(MyPlayer, select));
                else
                    Console.WriteLine("Wrong command");
            }
        }
    }
}
