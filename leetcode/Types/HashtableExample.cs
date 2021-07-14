using System;
using System.Collections;
using System.Collections.Generic;

namespace leetcode.Types
{
    // https://www.youtube.com/watch?v=KyUTuwz_b7Q
    class HashtableExample
    {
        public HashtableExample()
        {
            var cities = new Hashtable(){
                {"UK", "London- Manchester- Birmingham"},
                {"USA", "Chicago- New York- Washington"},
                {"India", "Mumbai- New Delhi- Pune"}
            };

            //The following throws run-time exception: key already added.
            //numberNames.Add(3, "Three"); 

            foreach (DictionaryEntry de in cities)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);

            string citiesOfUK = (string)cities["UK"]; //cast to string
            string citiesOfUSA = (string)cities["USA"]; //cast to string

            Console.WriteLine(citiesOfUK);
            Console.WriteLine(citiesOfUSA);

            cities["UK"] = "Liverpool- Bristol"; // update value of UK key
            cities["USA"] = "Los Angeles- Boston"; // update value of USA key

            if (!cities.ContainsKey("France"))
            {
                cities["France"] = "Paris";
            }

            if (cities.ContainsKey("France"))
            { // check key before removing it
                cities.Remove("France");
            }


            // Add Dictionary in Hashtable
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "one");
            dict.Add(2, "two");
            dict.Add(3, "three");
            Hashtable ht = new Hashtable(dict);


        }
    }
}
