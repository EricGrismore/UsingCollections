using System;
using System.Collections.Generic;

namespace QueueTCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Queue<string> food = new Queue<string>();

            food.Enqueue("Pizza");
            food.Enqueue("Krabby Patty");
           
            Console.WriteLine("Would you like to add food to the list?");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Member name: ");
                food.Enqueue(Console.ReadLine());
            }
            
            Console.WriteLine($"Here are your {food.Count()} members");
            
            foreach (var f in food)
            {
                Console.WriteLine(f);
            }
           
            string topFood = food.Peek();
            Console.WriteLine($"Would you like to get rid of {topFood} from your list (gross or love)?");
            string answer = Console.ReadLine();
            while (answer == "gross")
            {
                food.Dequeue(); 
                topFood = food.Peek();
                Console.WriteLine($"Would you like to get rid of {topFood} from your list (gross or love)?");
                answer = Console.ReadLine();
            }

            if (food.Peek() == null)
                Console.WriteLine("There is nothing in your list now.");
            else
                Console.WriteLine($"You have {food.Count} left in the queue");

        }
    }
}
