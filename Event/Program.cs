using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Event
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Problem 1

            //Concert ebi = new Concert("Ebi", "Koln", DateTime.Now.Date, DateTime.Now, 20);
            //Concert shakira = new Concert("Shakira", "Kiel", DateTime.Now.Date, DateTime.Now, 42);
            //Concert emenem = new Concert("Emenem", "Berlin", DateTime.Now.Date, DateTime.Now, 33);
            //Concert michel = new Concert("Michel", "Hamburg", DateTime.Now.Date, DateTime.Now, 12);
            //Concert alex = new Concert("Alex", "Paris", DateTime.Now.Date, DateTime.Now, 77);

            //Hashtable concerts = new Hashtable();
            //concerts.Add(ebi.Title, ebi);
            //concerts.Add(shakira.Title, shakira);
            //concerts.Add(emenem.Title, emenem);
            //concerts.Add(michel.Title, michel);
            //concerts.Add(alex.Title, alex);

            //if (ebi < shakira)
            //{
            //    Console.WriteLine(ebi.Title + " is cheaper than " + shakira.Title);
            //    Console.WriteLine(ebi.Price);
            //    ebi++;
            //    Console.WriteLine(ebi.Price);
            //}
            //else
            //{
            //    Console.WriteLine(ebi.Title + " is expensive than " + shakira.Title);
            //    Console.WriteLine(ebi.Price);
            //    ebi--;
            //    Console.WriteLine(ebi.Price);
            //}

            //if (emenem < michel)
            //{
            //    Console.WriteLine(emenem.Title + " is cheaper than " + michel.Title);
            //    Console.WriteLine(emenem.Price);
            //    emenem++;
            //    Console.WriteLine(emenem.Price);
            //}
            //else
            //{
            //    Console.WriteLine(emenem.Title + " is expensive than " + michel.Title);
            //    Console.WriteLine(emenem.Price);
            //    emenem--;
            //    Console.WriteLine(emenem.Price);
            //}


            //foreach (DictionaryEntry concert in concerts)
            //{
            //    Console.WriteLine(concert.Key + " - " + concert.Value);
            //}
            #endregion
            string text;

            TextAnalyzer textAnalyzer = new TextAnalyzer(out text);

            SortedList<char, int> charList = textAnalyzer.AnalizeText();

            foreach (KeyValuePair<char, int> pair in charList)
            {
                Console.WriteLine(pair.Key + " - " + pair.Value);
            }

            Console.ReadKey();

        }
    }
}
