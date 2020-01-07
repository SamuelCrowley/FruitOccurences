using System;
using System.Collections.Generic;
using System.Linq;

namespace FruitOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = new string[10];
            List<string> fruitStrings = new List<string>();
            Random random = new Random();

            fruits[0] = "Apple";
            fruits[1] = "Banana";
            fruits[2] = "Kiwi";
            fruits[3] = "Apricot";
            fruits[4] = "Blueberry";
            fruits[5] = "Cherry";
            fruits[6] = "Grapefruit";
            fruits[7] = "Guava";
            fruits[8] = "Fig";
            fruits[9] = "Mango";

            for (int i = 0; i < fruits.Length; i++)
            {
                int count = random.Next(1, 30);
                for (int j = 0; j < count; j++)
                {
                    fruitStrings.Add(fruits[i]);
                }
            }

            Console.WriteLine("The fruit that occured the most frequently was " + FindMostFrequentFruit(fruitStrings));
        }

        static string FindMostFrequentFruit(List<string> fruitStrings)
        {
            Dictionary<string, int> fruitDictionary = new Dictionary<string, int>();

            foreach (var item in fruitStrings)
            {
                if (fruitDictionary.ContainsKey(item))
                {
                    fruitDictionary[item] += 1;
                }
                else
                {
                    fruitDictionary.Add(item, 1);
                }
            }

            int highest = 0;
            string returnString = "";
            string times = "";
            foreach (var item in fruitDictionary)
            {
                times = item.Value == 1 ? " time" : " times";
                Console.WriteLine(item.Key + " appeared " + item.Value + times);
                if (item.Value > highest)
                {
                    highest = item.Value;
                    returnString = item.Key;
                }
            }
            return returnString;
        }
    }
}
