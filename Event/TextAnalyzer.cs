using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Event
{
    public class TextAnalyzer
    {
        public string Text { get; set; }
        public int Count { get; set; }
        public char Character { get; set; }
 
        public TextAnalyzer(out string text)
        {
            initText(out text);
            this.Text = text;
        }
        public SortedList<char, int> AnalizeText()
        {
            SortedList<char, int> list = new SortedList<char, int>();
          
            foreach (char ch in Text)
            {

                if (list.ContainsKey(ch))
                {
                    list[ch]++;
                }
                else
                {
                    list.Add(ch, 1);
                }
                
            }


            return list;

        }

        private void initText(out string text)
        {
            text = "";
            Random r = new Random();

            for (int i = 0; i < 50; i++)
            {
                text += (char)r.Next(97, 122);

            }

        }
        

    }
}
