using System;
using System.Collections.Generic;
using System.Linq;

namespace FruitOccurences
{
    class Program
    {
        int highestTotal = 0;
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
                int count = random.Next(1, 50);
                for (int j = 0; j < count; j++)
                {
                    fruitStrings.Add(fruits[i]);
                }
            }
            
            string responseString = "";

            List<string> mostFrequent = FindMostFrequentFruit(fruitStrings);

            responseString = mostFrequent.Count == 1 ? "The fruit that occured the most frequently was: " : "The fruits that occured the most frequently were: ";

            for (int i = 0; i < mostFrequent.Count; i++)
            {
                responseString += mostFrequent.Count > 1 && i < (mostFrequent.Count -1) ? mostFrequent[i] + ", " : mostFrequent[i];
            }
          
            Console.WriteLine(responseString);
        }
        static List<string> FindMostFrequentFruit(List<string> fruitStrings)
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
            List<string> returnStrings = new List<string>();
            string times = "";
            foreach (var item in fruitDictionary)
            {
                times = item.Value == 1 ? " time" : " times";
                Console.WriteLine(item.Key + " appeared " + item.Value + times);
                if (item.Value > highest)
                {
                    highest = item.Value;                 
                }
            }
            
            foreach (var item in fruitDictionary)
            {
                if (item.Value == highest)
                {
                    returnStrings.Add(item.Key);
                }
            }
            return returnStrings;
        }
    }
}
