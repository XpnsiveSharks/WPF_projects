using System;
using System.Collections.Generic;


namespace WPF_projects.ScrambleWords.Commons
{
    public class InsertDataToCollections
    {
        public static List<CollectionAttributes> _easy = new List<CollectionAttributes>()
        {
            new CollectionAttributes {ID = 1, WORD = "adjust", HINT = "Make a change or alteration to something.", DIFFICULTY = "easy", SCORE = 1},
            new CollectionAttributes {ID = 2, WORD = "bead", HINT = "Small, often spherical, object typically strung together.", DIFFICULTY = "easy", SCORE = 1},
            new CollectionAttributes {ID = 3, WORD = "cheer", HINT = "A joyful expression or to express happiness.", DIFFICULTY = "easy", SCORE = 1},
            new CollectionAttributes {ID = 4, WORD = "cloud", HINT = "Fluffy masses in the sky, sometimes bring rain.", DIFFICULTY = "easy", SCORE = 1},
            new CollectionAttributes {ID = 5, WORD = "dirt", HINT = "Soil or earth, often found in gardens or on the ground.", DIFFICULTY = "easy", SCORE = 1},
            new CollectionAttributes {ID = 6, WORD = "east", HINT = "The direction where the sun rises.", DIFFICULTY = "easy", SCORE = 1},
            new CollectionAttributes {ID = 7, WORD = "erupt", HINT = "When a volcano blows its top.", DIFFICULTY = "easy", SCORE = 1},
            new CollectionAttributes {ID = 8, WORD = "infern", HINT = "A fiery place of punishment in some beliefs.", DIFFICULTY = "easy", SCORE = 1}
        };
        public static List<CollectionAttributes> _average = new List<CollectionAttributes>()
        {
            new CollectionAttributes {ID = 1, WORD = "acrobat", HINT = "A performer skilled in gymnastics and agility.", DIFFICULTY = "average", SCORE = 2},
            new CollectionAttributes {ID = 2, WORD = "algorithm", HINT = "A step-by-step procedure or formula for solving a problem.", DIFFICULTY = "average", SCORE = 2},
            new CollectionAttributes {ID = 3, WORD = "artificial", HINT = "Produced by human beings rather than occurring naturally.", DIFFICULTY = "average", SCORE = 2},
            new CollectionAttributes {ID = 4, WORD = "biometrics", HINT = "Using unique body characteristics for identification.", DIFFICULTY = "average", SCORE = 2},
            new CollectionAttributes {ID = 5, WORD = "browser", HINT = "Software for accessing the internet.", DIFFICULTY = "average", SCORE = 2},
            new CollectionAttributes {ID = 6, WORD = "confection", HINT = "Sweet, often sugary, food.", DIFFICULTY = "average", SCORE = 2},
            new CollectionAttributes {ID = 7, WORD = "encrypt", HINT = "Securely encode information.", DIFFICULTY = "average", SCORE = 2},
            new CollectionAttributes {ID = 8, WORD = "firewall", HINT = "A barrier to prevent unauthorized access in a network.", DIFFICULTY = "average", SCORE = 2}
        };
        public static string BrowseCollection(int randomNum, string attr)
        {
            Dictionary<int, CollectionAttributes> LookUp = new Dictionary<int, CollectionAttributes>();
            foreach (var info in _average)    
                LookUp.Add(info.ID, info);
            
            return LookUp[randomNum].WORD;
        }
    }
}
