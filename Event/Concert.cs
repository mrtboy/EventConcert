using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class Concert
    {
        public string Title { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            string result = "The Concert " + this.Title + " in " + Location + " on " 
                + Date + "time " + Time + "and the price is " + Price;
            return result;
        }

        public Concert(string title, string location, DateTime date, DateTime time, decimal price)
        {
            Title = title;
            Location = location;
            Date = date;
            Time = time;
            Price = price;
        }

        public static bool operator <(Concert c1, Concert c2)
        {
            if (c1.Price < c2.Price)
            {
                return true;
            }
            return false;
        }
        public static bool operator >(Concert c1, Concert c2)
        {
            if (c1.Price > c2.Price)
            {
                return true;
            }
            return false;
        }

        public static Concert operator ++(Concert c1)
        {
            return new Concert(c1.Title, c1.Location, c1.Date, c1.Time, c1.Price += 5);
        }
        public static Concert operator --(Concert c1)
        {
            return new Concert(c1.Title, c1.Location, c1.Date, c1.Time, c1.Price -= 5);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Concert c = obj as Concert;
            if ((System.Object)c == null)
            {
                return false;
            }
            if (this.Title == c.Title && this.Location == c.Location && this.Price == c.Price &&
                this.Date == c.Date && this.Time == c.Time)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



    }
}
