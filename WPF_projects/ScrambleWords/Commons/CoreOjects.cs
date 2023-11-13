using System;
using System.Collections.Generic;
using System.Linq;

namespace WPF_projects.ScrambleWords.Commons
{
    public class CoreOjects
    {
        private static List <int> usedNumberEasy = new List <int> ();
        private static List<int> usedNumberAverage = new List<int>();
        private static List<int> usedNumberDifficult = new List<int>();
        
        
        public static string CheckUsedInteger()
        {
            int num = RandomNumberGenerator(usedNumberEasy); // pass the usedNumberEasy List in the method parameter RandomNumberGenerator then stored to variable num
            return InserDataCollections.PrintThis(num); // randomize num will pass in the PrintThis method from InserDataCollections
        }
        private static int RandomNumberGenerator(List <int> usedNumber)// Generates a random number and checks if the number generated has been used
        {
            Random random = new Random();
            var numberCollection = new List<int>();

            for (int i = 1; i <= 8; i++) // Alter if the dataset is finalized
                numberCollection.Add(i);

            int index = random.Next(numberCollection.Count);

            while (usedNumber.Contains(numberCollection[index])) // Check if the generated number is already used
                index = random.Next(numberCollection.Count); // Generate a new random number
            
            usedNumberEasy.Add(numberCollection[index]); // Add the generated number to the usedNumberEasy list
            return numberCollection[index]; // Return the generated number
        }
    }
}
